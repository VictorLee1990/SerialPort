using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.IO.Ports;
using ResizeFormLibrary; 
namespace Luna2_ApplicationTool
{
    public interface IView
    {
        void SetController(IController controller);
        //Open serial port event
        void OpenComEvent(Object sender, SerialPortEventArgs e);
        //Close serial port event
        void CloseComEvent(Object sender, SerialPortEventArgs e);
        //Serial port receive data event
        void ComReceiveDataEvent(Object sender, SerialPortEventArgs e);
    }

    public partial class MainForm : CCWin.Skin_Mac, IView
    {
        private IController controller;
        private int sendBytesCount = 0;
        private int receiveBytesCount = 0;
        List<SensorValue> sensorValList = new List<SensorValue>();
        SensorValue result;
        SensorValue sensorValue;
       public struct SensorValue
        {
            public string Group;
            public string UDID;
            public string Temperature;
            public string Humi;
            public string textBox_device;
        }

        public MainForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            InitializeCOMCombox();
            this.statusTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.toolStripStatusTx.Text = "Sent: 0";
            this.toolStripStatusRx.Text = "Received: 0";
            //this.MaximizeBox = false; 
            //this.MinimizeBox = false;     
            IController controller = new IController(this);



        }

        /// <summary>
        /// Set controller
        /// </summary>
        /// <param name="controller"></param>
        public void SetController(IController controller)
        {
            this.controller = controller;
        }

        /// <summary>
        /// Initialize serial port information
        /// </summary>
        private void InitializeCOMCombox()
        {
            //BaudRate
            baudRateCbx.Items.Add(4800);
            baudRateCbx.Items.Add(9600);
            baudRateCbx.Items.Add(19200);
            baudRateCbx.Items.Add(38400);
            baudRateCbx.Items.Add(57600);
            baudRateCbx.Items.Add(115200);
            baudRateCbx.Items.ToString();
            //get 9600 print in text
            baudRateCbx.Text = baudRateCbx.Items[1].ToString();

            //Data bits
            dataBitsCbx.Items.Add(7);
            dataBitsCbx.Items.Add(8);
            //get the 8bit item print it in the text 
            dataBitsCbx.Text = dataBitsCbx.Items[1].ToString();

            //Stop bits
            stopBitsCbx.Items.Add("One");
            stopBitsCbx.Items.Add("OnePointFive");
            stopBitsCbx.Items.Add("Two");
            //get the One item print in the text
            stopBitsCbx.Text = stopBitsCbx.Items[0].ToString();

            //Parity
            parityCbx.Items.Add("None");
            parityCbx.Items.Add("Even");
            parityCbx.Items.Add("Mark");
            parityCbx.Items.Add("Odd");
            parityCbx.Items.Add("Space");
            //get the first item print in the text
            parityCbx.Text = parityCbx.Items[0].ToString();

            //Handshaking
            handshakingcbx.Items.Add("None");
            handshakingcbx.Items.Add("XOnXOff");
            handshakingcbx.Items.Add("RequestToSend");
            handshakingcbx.Items.Add("RequestToSendXOnXOff");
            handshakingcbx.Text = handshakingcbx.Items[0].ToString();

            //Com Ports
            string[] ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length == 0)
            {
                statuslabel.Text = "No COM found !";
                openCloseSpbtn.Enabled = false;
            }
            else
            {
                Array.Sort(ArrayComPortsNames);
                for (int i = 0; i < ArrayComPortsNames.Length; i++)
                {
                    comListCbx.Items.Add(ArrayComPortsNames[i]);
                }
                comListCbx.Text = ArrayComPortsNames[0];
                openCloseSpbtn.Enabled = true;
            }
        }

        /// <summary>
        /// update status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenComEvent(Object sender, SerialPortEventArgs e)
        {
            if (this.InvokeRequired)
            {
                Invoke(new Action<Object, SerialPortEventArgs>(OpenComEvent), sender, e);
                return;
            }

            if (e.isOpend)  //Open successfully
            {
                statuslabel.Text = comListCbx.Text + " Opend";
                openCloseSpbtn.Text = "Close";
                sendbtn.Enabled = true;
                autoSendcbx.Enabled = true;
                autoReplyCbx.Enabled = true;

                comListCbx.Enabled = false;
                baudRateCbx.Enabled = false;
                dataBitsCbx.Enabled = false;
                stopBitsCbx.Enabled = false;
                parityCbx.Enabled = false;
                handshakingcbx.Enabled = false;
                refreshbtn.Enabled = false;

                if (autoSendcbx.Checked)
                {
                    autoSendtimer.Start();
                    sendtbx.ReadOnly = true;
                }
            }
            else    //Open failed
            {
                statuslabel.Text = "Open failed !";
                sendbtn.Enabled = false;
                autoSendcbx.Enabled = false;
                autoReplyCbx.Enabled = false;
            }
        }

        /// <summary>
        /// update status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CloseComEvent(Object sender, SerialPortEventArgs e)
        {
            if (this.InvokeRequired)
            {
                Invoke(new Action<Object, SerialPortEventArgs>(CloseComEvent), sender, e);
                return;
            }

            if (!e.isOpend) //close successfully
            {
                statuslabel.Text = comListCbx.Text + " Closed";
                openCloseSpbtn.Text = "Open";

                sendbtn.Enabled = false;
                sendtbx.ReadOnly = false;
                autoSendcbx.Enabled = false;
                autoSendtimer.Stop();

                comListCbx.Enabled = true;
                baudRateCbx.Enabled = true;
                dataBitsCbx.Enabled = true;
                stopBitsCbx.Enabled = true;
                parityCbx.Enabled = true;
                handshakingcbx.Enabled = true;
                refreshbtn.Enabled = true;
            }
        }
        string _receiveStr;
        /// <summary>
        /// Display received data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ComReceiveDataEvent(Object sender, SerialPortEventArgs e)
        {
            if (this.InvokeRequired)
            {
                try
                {
                    Invoke(new Action<Object, SerialPortEventArgs>(ComReceiveDataEvent), sender, e);
                }
                catch (System.Exception)
                {
                    //disable form destroy exception
                }
                return;
            }

            if (recStrRadiobtn.Checked) //display as string
            {
                receivetbx.AppendText(Encoding.Default.GetString(e.receivedBytes));
                _receiveStr += Encoding.Default.GetString(e.receivedBytes);                     
                            
            }
            else //display as hex
            {
                if (receivetbx.Text.Length > 0)
                {
                    receivetbx.AppendText("-");
                }
                receivetbx.AppendText(IController.Bytes2Hex(e.receivedBytes));
            }
            //update status bar
            receiveBytesCount += e.receivedBytes.Length;
            toolStripStatusRx.Text = "Received: " + receiveBytesCount.ToString();

            //auto reply
            if (autoReplyCbx.Checked)
            {
                string receiverTemp = receivebtx.Text;
                if (CR_Cbx.Checked)
                {
                    receiverTemp += "\r";
                }
                if (LF_Cbx.Checked)
                {
                    receiverTemp += "\n";
                }
                if (_receiveStr == receiverTemp)
                {

                    sendbtn_Click(this, new EventArgs());
                }
            }
            _receiveStr = "";
        }


        /// <summary>
        /// Send data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendbtn_Click(object sender, EventArgs e)
        {
            String sendText = "\r\n";
            sendText += sendtbx.Text;
            bool flag = false;
            if (sendText == null)
            {
                return;
            }
            //set select index to the end
            sendtbx.SelectionStart = sendtbx.TextLength;

            if (sendHexRadiobtn.Checked)
            {
                //If hex radio checked
                //send bytes to serial port
                Byte[] bytes = IController.Hex2Bytes(sendText);
                sendbtn.Enabled = false;//wait return
                flag = controller.SendDataToCom(bytes);
                sendbtn.Enabled = true;
                sendBytesCount += bytes.Length;
            }
            else
            {
                //send String to serial port
                sendbtn.Enabled = false;//wait return
                flag = controller.SendDataToCom(sendText);
                sendbtn.Enabled = true;
                sendBytesCount += sendText.Length;
            }
            if (flag)
            {
                statuslabel.Text = "Send OK !";
            }
            else
            {
                statuslabel.Text = "Send failed !";
            }
            //update status bar
            toolStripStatusTx.Text = "Sent: " + sendBytesCount.ToString();
        }


        /// <summary>
        /// update time in status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statustimer_Tick(object sender, EventArgs e)
        {
            this.statusTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        /// <summary>
        /// open or close serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openCloseSpbtn_Click(object sender, EventArgs e)
        {
            if (openCloseSpbtn.Text == "Open")
            {

                controller.OpenSerialPort(comListCbx.Text, baudRateCbx.Text,
                    dataBitsCbx.Text, stopBitsCbx.Text, parityCbx.Text,
                    handshakingcbx.Text);
            }
            else
            {
                controller.CloseSerialPort();
            }
        }

        /// <summary>
        /// Refresh soft to find Serial port device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshbtn_Click(object sender, EventArgs e)
        {
            comListCbx.Items.Clear();
            //Com Ports
            string[] ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length == 0)
            {
                statuslabel.Text = "No COM found !";
                openCloseSpbtn.Enabled = false;
            }
            else
            {
                Array.Sort(ArrayComPortsNames);
                for (int i = 0; i < ArrayComPortsNames.Length; i++)
                {
                    comListCbx.Items.Add(ArrayComPortsNames[i]);
                }
                comListCbx.Text = ArrayComPortsNames[0];
                openCloseSpbtn.Enabled = true;
                statuslabel.Text = "OK !";
            }

        }

        


        #region 視窗放大縮小
        //        public void ResizeForm(ref double New_x, ref double New_y, double Initial_x, double Initial_y)
        //        {
        //            ResizeForm resizeform = new ResizeForm();

        //            double X_Zoom;
        //            double Y_Zoom;

        //            X_Zoom = (double)(this.Size.Width - 682.0)/2;
        //            Y_Zoom = (double)(this.Size.Height - 689.0);

        //            New_x = resizeform.X_RelativePosition(X_Zoom, Initial_x); 
        //            New_y = resizeform.Y_RelativePosition(Y_Zoom, Initial_y);

        //            resizeform = null;
        //        }

        //        public void ResizePictureBox(ref double New_width, ref double New_heigh, double Initial_Width, double Initial_Heigh)
        //        {
        //            ResizeForm resizeform = new ResizeForm();
        //            double Width_ZoomRatio;
        //            double High_ZoomRatio;

        //            Width_ZoomRatio = (double)(this.Size.Width / 682.0);
        //            High_ZoomRatio = (double)(this.Size.Height / 689.0);

        //            New_width = resizeform.X_SizeScaleZoom(Width_ZoomRatio, Initial_Width);
        //            New_heigh = resizeform.Y_SizeScaleZoom(High_ZoomRatio, Initial_Heigh);

        //            //if ((double)((double)this.Size.Width / (double)this.Size.Height) >= 1.333 && this.Size.Width > this.Size.Height)
        //            //{
        //            //    New_width = resizeform.X_SizeScaleZoom(Width_ZoomRatio, Initial_Width);
        //            //    High_ZoomRatio = New_width / 400;
        //            //    New_heigh = resizeform.Y_SizeScaleZoom(High_ZoomRatio, Initial_Heigh);

        //            //}

        //            //if ((double)((double)this.Size.Width / (double)this.Size.Height) >= 1.333 && this.Size.Height > this.Size.Width)
        //            //{
        //            //    New_heigh = resizeform.Y_SizeScaleZoom(High_ZoomRatio, Initial_Heigh);
        //            //    High_ZoomRatio = New_heigh / 300;
        //            //    New_width = resizeform.X_SizeScaleZoom(Width_ZoomRatio, Initial_Width);
        //            //}

        //            resizeform = null;
        //        }

        //        private void mainForm_Resize(object sender, EventArgs e)
        //        {

        //            double New_x;
        //            double New_y;
        //            double New_width;
        //            double New_heigh;
        //            double New_xLocation;
        //            double New_yLocation;


        //            New_x = this.treeView_device.Location.X;
        //            New_y = this.treeView_device.Location.Y;
        //            ResizeForm(ref New_x, ref New_y, 213, 161);
        //            this.treeView_device.Location = new System.Drawing.Point((int)New_x, (int)New_y);

        //            New_x = this.textBox_device.Location.X;
        //            New_y = this.textBox_device.Location.Y;
        //            ResizeForm(ref New_x, ref New_y, 320, 161);
        //            this.textBox_device.Location = new System.Drawing.Point((int)New_x, (int)New_y);

        //            //New_x = this.DIresetBtn.Location.X;
        //            //New_y = this.DIresetBtn.Location.Y;
        //            //ResizeForm(ref New_x, ref New_y, 705, 400);
        //            //this.DIresetBtn.Location = new System.Drawing.Point((int)New_x, (int)New_y);

        //            //New_width = this.PvPictureBox.Size.Width;
        //            //New_heigh = this.PvPictureBox.Size.Height;
        //            //ResizePictureBox(ref New_width, ref New_heigh, 400, 300);

        //            //this.PvPictureBox.Size = new System.Drawing.Size((int)New_width, (int)New_heigh);

        //            //New_xLocation = this.PvPictureBox.Size.Width + this.PvPictureBox.Location.X;
        //            //New_yLocation = this.PvPictureBox.Location.Y;
        //            //this.panel1.Location = new System.Drawing.Point((int)New_xLocation, (int)New_yLocation);
        //            //this.panel1.Size = new System.Drawing.Size((int)panel1.Size.Width, (int)PvPictureBox.Height);

        //            //New_xLocation = this.PvPictureBox.Size.Width + this.PvPictureBox.Location.X;
        //            //New_yLocation = this.PvPictureBox.Location.Y;
        //            //ResizeForm(ref New_xLocation, ref New_yLocation, 423, 69);
        //            //this.ProgramStatusTb.Location = new System.Drawing.Point((int)New_xLocation, (int)New_yLocation);

        //            //New_xLocation = this.PvPictureBox.Size.Width + this.PvPictureBox.Location.X;
        //            //New_yLocation = this.ProgramStatusTb.Location.Y + this.ProgramStatusTb.Size.Height;
        //            //New_heigh = this.PvPictureBox.Height - this.ProgramStatusTb.Size.Height - this.ResultLB.Height;
        //            //ResizeForm(ref New_x, ref New_y, 423, 105);
        //            //this.showProcessTimeTb.Location = new System.Drawing.Point((int)New_xLocation, (int)New_yLocation);
        //            //this.showProcessTimeTb.Size = new System.Drawing.Size((int)showProcessTimeTb.Size.Width, (int)New_heigh);

        //            //New_x = this.ResultLB.Location.X;
        //            //New_y = this.ResultLB.Location.Y;
        //            //ResizeForm(ref New_x, ref New_y, 493, 335);
        //            //this.ResultLB.Location = new System.Drawing.Point((int)New_x, (int)New_yLocation + (int)New_heigh);

        //            //New_x = this.ModStatusLabel.Location.X;
        //            //New_y = this.ModStatusLabel.Location.Y;
        //            //ResizeForm(ref New_x, ref New_y, 484, 107);
        //            //this.ModStatusLabel.Location = new System.Drawing.Point((int)New_x, (int)107);


        //        }
        #endregion

        /// <summary>
        /// clear receive text in receive area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearReceivebtn_Click(object sender, EventArgs e)
        {
            receivetbx.Text = "";
            toolStripStatusRx.Text = "Received: 0";
            receiveBytesCount = 0;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
