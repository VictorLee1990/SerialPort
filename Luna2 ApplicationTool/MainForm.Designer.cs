namespace Luna2_ApplicationTool
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTx = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusRx = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statustimer = new System.Windows.Forms.Timer(this.components);
            this.autoSendtimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.receivebtx = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.sendHexRadiobtn = new System.Windows.Forms.RadioButton();
            this.autoReplyCbx = new System.Windows.Forms.CheckBox();
            this.sendStrRadiobtn = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.sendtbx = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.receivetbx = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clearReceivebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LF_Cbx = new System.Windows.Forms.CheckBox();
            this.CR_Cbx = new System.Windows.Forms.CheckBox();
            this.recHexRadiobtn = new System.Windows.Forms.RadioButton();
            this.recStrRadiobtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.handshakingcbx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.autoSendcbx = new System.Windows.Forms.CheckBox();
            this.addCRCcbx = new System.Windows.Forms.CheckBox();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataBitsCbx = new System.Windows.Forms.ComboBox();
            this.sendIntervalTimetbx = new System.Windows.Forms.TextBox();
            this.comListCbx = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openCloseSpbtn = new System.Windows.Forms.Button();
            this.baudRateCbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.parityCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stopBitsCbx = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel,
            this.toolStripStatusTx,
            this.toolStripStatusRx,
            this.toolStripStatusLabel1,
            this.statusTimeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(4, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(680, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslabel
            // 
            this.statuslabel.ActiveLinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(221, 17);
            this.statuslabel.Spring = true;
            this.statuslabel.Text = "Not Connected";
            this.statuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusTx
            // 
            this.toolStripStatusTx.Name = "toolStripStatusTx";
            this.toolStripStatusTx.Size = new System.Drawing.Size(221, 17);
            this.toolStripStatusTx.Spring = true;
            this.toolStripStatusTx.Text = "Sent:";
            this.toolStripStatusTx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusRx
            // 
            this.toolStripStatusRx.ActiveLinkColor = System.Drawing.SystemColors.Info;
            this.toolStripStatusRx.Name = "toolStripStatusRx";
            this.toolStripStatusRx.Size = new System.Drawing.Size(221, 17);
            this.toolStripStatusRx.Spring = true;
            this.toolStripStatusRx.Text = "Received:";
            this.toolStripStatusRx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusTimeLabel
            // 
            this.statusTimeLabel.Name = "statusTimeLabel";
            this.statusTimeLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(4, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statustimer
            // 
            this.statustimer.Enabled = true;
            this.statustimer.Interval = 1000;
            this.statustimer.Tick += new System.EventHandler(this.statustimer_Tick);
            // 
            // autoSendtimer
            // 
            this.autoSendtimer.Interval = 1000;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(128, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 380);
            this.panel2.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.receivebtx);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 536);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // receivebtx
            // 
            this.receivebtx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.receivebtx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receivebtx.ForeColor = System.Drawing.SystemColors.InfoText;
            this.receivebtx.Location = new System.Drawing.Point(5, 55);
            this.receivebtx.Name = "receivebtx";
            this.receivebtx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receivebtx.Size = new System.Drawing.Size(534, 21);
            this.receivebtx.TabIndex = 29;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.receivetbx, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(536, 292);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.2844F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.7156F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.sendStrRadiobtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.autoReplyCbx, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.sendHexRadiobtn, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 213);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(357, 32);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Send:";
            // 
            // sendHexRadiobtn
            // 
            this.sendHexRadiobtn.AutoSize = true;
            this.sendHexRadiobtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendHexRadiobtn.Location = new System.Drawing.Point(112, 3);
            this.sendHexRadiobtn.Name = "sendHexRadiobtn";
            this.sendHexRadiobtn.Size = new System.Drawing.Size(51, 26);
            this.sendHexRadiobtn.TabIndex = 17;
            this.sendHexRadiobtn.TabStop = true;
            this.sendHexRadiobtn.Text = "Hex";
            this.sendHexRadiobtn.UseVisualStyleBackColor = true;
            // 
            // autoReplyCbx
            // 
            this.autoReplyCbx.AutoSize = true;
            this.autoReplyCbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoReplyCbx.Location = new System.Drawing.Point(169, 3);
            this.autoReplyCbx.Name = "autoReplyCbx";
            this.autoReplyCbx.Size = new System.Drawing.Size(87, 26);
            this.autoReplyCbx.TabIndex = 25;
            this.autoReplyCbx.Text = "AutoReply";
            this.autoReplyCbx.UseVisualStyleBackColor = true;
            // 
            // sendStrRadiobtn
            // 
            this.sendStrRadiobtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sendStrRadiobtn.AutoSize = true;
            this.sendStrRadiobtn.Checked = true;
            this.sendStrRadiobtn.Location = new System.Drawing.Point(48, 6);
            this.sendStrRadiobtn.Name = "sendStrRadiobtn";
            this.sendStrRadiobtn.Size = new System.Drawing.Size(58, 19);
            this.sendStrRadiobtn.TabIndex = 16;
            this.sendStrRadiobtn.TabStop = true;
            this.sendStrRadiobtn.Text = "String";
            this.sendStrRadiobtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.75958F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.24042F));
            this.tableLayoutPanel4.Controls.Add(this.sendtbx, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.sendbtn, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 251);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(530, 38);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // sendtbx
            // 
            this.sendtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sendtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendtbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendtbx.ForeColor = System.Drawing.SystemColors.InfoText;
            this.sendtbx.Location = new System.Drawing.Point(3, 3);
            this.sendtbx.Name = "sendtbx";
            this.sendtbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendtbx.Size = new System.Drawing.Size(453, 21);
            this.sendtbx.TabIndex = 8;
            // 
            // sendbtn
            // 
            this.sendbtn.AutoSize = true;
            this.sendbtn.Enabled = false;
            this.sendbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.Location = new System.Drawing.Point(462, 3);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(54, 26);
            this.sendbtn.TabIndex = 7;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // receivetbx
            // 
            this.receivetbx.BackColor = System.Drawing.SystemColors.InfoText;
            this.receivetbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receivetbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receivetbx.ForeColor = System.Drawing.SystemColors.Info;
            this.receivetbx.Location = new System.Drawing.Point(3, 3);
            this.receivetbx.Multiline = true;
            this.receivetbx.Name = "receivetbx";
            this.receivetbx.ReadOnly = true;
            this.receivetbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receivetbx.Size = new System.Drawing.Size(530, 204);
            this.receivetbx.TabIndex = 9;
            this.receivetbx.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.39405F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.60595F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Controls.Add(this.clearReceivebtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 35);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // clearReceivebtn
            // 
            this.clearReceivebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearReceivebtn.AutoSize = true;
            this.clearReceivebtn.Location = new System.Drawing.Point(490, 3);
            this.clearReceivebtn.Name = "clearReceivebtn";
            this.clearReceivebtn.Size = new System.Drawing.Size(46, 25);
            this.clearReceivebtn.TabIndex = 11;
            this.clearReceivebtn.Text = "Clear";
            this.clearReceivebtn.UseVisualStyleBackColor = true;
            this.clearReceivebtn.Click += new System.EventHandler(this.clearReceivebtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LF_Cbx);
            this.panel1.Controls.Add(this.CR_Cbx);
            this.panel1.Controls.Add(this.recHexRadiobtn);
            this.panel1.Controls.Add(this.recStrRadiobtn);
            this.panel1.Location = new System.Drawing.Point(268, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 29);
            this.panel1.TabIndex = 20;
            // 
            // LF_Cbx
            // 
            this.LF_Cbx.AutoSize = true;
            this.LF_Cbx.Location = new System.Drawing.Point(165, 7);
            this.LF_Cbx.Name = "LF_Cbx";
            this.LF_Cbx.Size = new System.Drawing.Size(40, 19);
            this.LF_Cbx.TabIndex = 26;
            this.LF_Cbx.Text = "LF";
            this.LF_Cbx.UseVisualStyleBackColor = true;
            // 
            // CR_Cbx
            // 
            this.CR_Cbx.AutoSize = true;
            this.CR_Cbx.Location = new System.Drawing.Point(116, 7);
            this.CR_Cbx.Name = "CR_Cbx";
            this.CR_Cbx.Size = new System.Drawing.Size(43, 19);
            this.CR_Cbx.TabIndex = 25;
            this.CR_Cbx.Text = "CR";
            this.CR_Cbx.UseVisualStyleBackColor = true;
            // 
            // recHexRadiobtn
            // 
            this.recHexRadiobtn.AutoSize = true;
            this.recHexRadiobtn.Location = new System.Drawing.Point(63, 4);
            this.recHexRadiobtn.Name = "recHexRadiobtn";
            this.recHexRadiobtn.Size = new System.Drawing.Size(47, 19);
            this.recHexRadiobtn.TabIndex = 15;
            this.recHexRadiobtn.TabStop = true;
            this.recHexRadiobtn.Text = "Hex";
            this.recHexRadiobtn.UseVisualStyleBackColor = true;
            // 
            // recStrRadiobtn
            // 
            this.recStrRadiobtn.AutoSize = true;
            this.recStrRadiobtn.Checked = true;
            this.recStrRadiobtn.Location = new System.Drawing.Point(3, 4);
            this.recStrRadiobtn.Name = "recStrRadiobtn";
            this.recStrRadiobtn.Size = new System.Drawing.Size(57, 19);
            this.recStrRadiobtn.TabIndex = 14;
            this.recStrRadiobtn.TabStop = true;
            this.recStrRadiobtn.Text = "String";
            this.recStrRadiobtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Received:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.handshakingcbx);
            this.groupBox2.Controls.Add(this.autoSendcbx);
            this.groupBox2.Controls.Add(this.addCRCcbx);
            this.groupBox2.Controls.Add(this.refreshbtn);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dataBitsCbx);
            this.groupBox2.Controls.Add(this.comListCbx);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.openCloseSpbtn);
            this.groupBox2.Controls.Add(this.baudRateCbx);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.parityCbx);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.stopBitsCbx);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 380);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM";
            // 
            // handshakingcbx
            // 
            this.handshakingcbx.FormattingEnabled = true;
            this.handshakingcbx.Location = new System.Drawing.Point(24, 276);
            this.handshakingcbx.Name = "handshakingcbx";
            this.handshakingcbx.Size = new System.Drawing.Size(74, 20);
            this.handshakingcbx.TabIndex = 24;
            this.handshakingcbx.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "ms";
            // 
            // autoSendcbx
            // 
            this.autoSendcbx.AutoSize = true;
            this.autoSendcbx.Enabled = false;
            this.autoSendcbx.Location = new System.Drawing.Point(18, 411);
            this.autoSendcbx.Name = "autoSendcbx";
            this.autoSendcbx.Size = new System.Drawing.Size(70, 16);
            this.autoSendcbx.TabIndex = 21;
            this.autoSendcbx.Text = "AutoSend";
            this.autoSendcbx.UseVisualStyleBackColor = true;
            this.autoSendcbx.Visible = false;
            // 
            // addCRCcbx
            // 
            this.addCRCcbx.AutoSize = true;
            this.addCRCcbx.Enabled = false;
            this.addCRCcbx.Location = new System.Drawing.Point(17, 389);
            this.addCRCcbx.Name = "addCRCcbx";
            this.addCRCcbx.Size = new System.Drawing.Size(71, 16);
            this.addCRCcbx.TabIndex = 24;
            this.addCRCcbx.Text = "Add CRC";
            this.addCRCcbx.UseVisualStyleBackColor = true;
            this.addCRCcbx.Visible = false;
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(70, 10);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(28, 19);
            this.refreshbtn.TabIndex = 22;
            this.refreshbtn.Text = "Refersh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "HandShaking:";
            this.label9.Visible = false;
            // 
            // dataBitsCbx
            // 
            this.dataBitsCbx.FormattingEnabled = true;
            this.dataBitsCbx.Location = new System.Drawing.Point(14, 115);
            this.dataBitsCbx.Name = "dataBitsCbx";
            this.dataBitsCbx.Size = new System.Drawing.Size(74, 20);
            this.dataBitsCbx.TabIndex = 11;
            // 
            // sendIntervalTimetbx
            // 
            this.sendIntervalTimetbx.Location = new System.Drawing.Point(3, 3);
            this.sendIntervalTimetbx.MaxLength = 9;
            this.sendIntervalTimetbx.Name = "sendIntervalTimetbx";
            this.sendIntervalTimetbx.Size = new System.Drawing.Size(44, 21);
            this.sendIntervalTimetbx.TabIndex = 22;
            this.sendIntervalTimetbx.Text = "1000";
            // 
            // comListCbx
            // 
            this.comListCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comListCbx.FormattingEnabled = true;
            this.comListCbx.Location = new System.Drawing.Point(14, 35);
            this.comListCbx.Name = "comListCbx";
            this.comListCbx.Size = new System.Drawing.Size(74, 20);
            this.comListCbx.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port Name:";
            // 
            // openCloseSpbtn
            // 
            this.openCloseSpbtn.Enabled = false;
            this.openCloseSpbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.openCloseSpbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openCloseSpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCloseSpbtn.Location = new System.Drawing.Point(14, 222);
            this.openCloseSpbtn.Name = "openCloseSpbtn";
            this.openCloseSpbtn.Size = new System.Drawing.Size(74, 36);
            this.openCloseSpbtn.TabIndex = 17;
            this.openCloseSpbtn.Text = "Open";
            this.openCloseSpbtn.UseVisualStyleBackColor = true;
            this.openCloseSpbtn.Click += new System.EventHandler(this.openCloseSpbtn_Click);
            // 
            // baudRateCbx
            // 
            this.baudRateCbx.FormattingEnabled = true;
            this.baudRateCbx.Location = new System.Drawing.Point(14, 74);
            this.baudRateCbx.Name = "baudRateCbx";
            this.baudRateCbx.Size = new System.Drawing.Size(74, 20);
            this.baudRateCbx.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "Parity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Baud Rate:";
            // 
            // parityCbx
            // 
            this.parityCbx.FormattingEnabled = true;
            this.parityCbx.Location = new System.Drawing.Point(14, 195);
            this.parityCbx.Name = "parityCbx";
            this.parityCbx.Size = new System.Drawing.Size(74, 20);
            this.parityCbx.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Bits:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stop Bits:";
            // 
            // stopBitsCbx
            // 
            this.stopBitsCbx.FormattingEnabled = true;
            this.stopBitsCbx.Location = new System.Drawing.Point(14, 155);
            this.stopBitsCbx.Name = "stopBitsCbx";
            this.stopBitsCbx.Size = new System.Drawing.Size(74, 20);
            this.stopBitsCbx.TabIndex = 13;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 56);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(680, 386);
            this.tableLayoutPanel5.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sendIntervalTimetbx);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(262, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 26);
            this.panel3.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(688, 468);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowSystemMenu = true;
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer statustimer;
        private System.Windows.Forms.Timer autoSendtimer;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTx;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusRx;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusTimeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton sendHexRadiobtn;
        private System.Windows.Forms.RadioButton sendStrRadiobtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox sendtbx;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.TextBox receivetbx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button clearReceivebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton recHexRadiobtn;
        private System.Windows.Forms.RadioButton recStrRadiobtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox handshakingcbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox autoReplyCbx;
        private System.Windows.Forms.CheckBox autoSendcbx;
        private System.Windows.Forms.CheckBox addCRCcbx;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox dataBitsCbx;
        private System.Windows.Forms.TextBox sendIntervalTimetbx;
        private System.Windows.Forms.ComboBox comListCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openCloseSpbtn;
        private System.Windows.Forms.ComboBox baudRateCbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox parityCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox stopBitsCbx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox receivebtx;
        private System.Windows.Forms.CheckBox LF_Cbx;
        private System.Windows.Forms.CheckBox CR_Cbx;
        private System.Windows.Forms.Panel panel3;
    }
}

