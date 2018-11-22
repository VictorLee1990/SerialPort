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

    public partial class MainForm : CCWin.Skin_Mac,IView
    {
        private IController controller;    

        private int sendBytesCount = 0;
        private int receiveBytesCount = 0;

        public MainForm()
        {
            InitializeComponent();
            InitializeCOMCombox();
            this.statusTimeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.toolStripStatusTx.Text = "Sent: 0";
            this.toolStripStatusRx.Text = "Received: 0";
            this.MaximizeBox = false; 
            this.MinimizeBox = false;
        }

    
    }
}
