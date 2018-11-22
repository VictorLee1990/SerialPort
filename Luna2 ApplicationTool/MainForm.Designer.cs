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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.handshakingcbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.dataBitsCbx = new System.Windows.Forms.ComboBox();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statustimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.handshakingcbx);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.refreshbtn);
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
            this.groupBox2.Location = new System.Drawing.Point(7, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 364);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM";
            // 
            // handshakingcbx
            // 
            this.handshakingcbx.FormattingEnabled = true;
            this.handshakingcbx.Location = new System.Drawing.Point(14, 235);
            this.handshakingcbx.Name = "handshakingcbx";
            this.handshakingcbx.Size = new System.Drawing.Size(74, 20);
            this.handshakingcbx.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "HandShaking:";
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(14, 267);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(74, 32);
            this.refreshbtn.TabIndex = 22;
            this.refreshbtn.Text = "Refersh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            // 
            // dataBitsCbx
            // 
            this.dataBitsCbx.FormattingEnabled = true;
            this.dataBitsCbx.Location = new System.Drawing.Point(14, 115);
            this.dataBitsCbx.Name = "dataBitsCbx";
            this.dataBitsCbx.Size = new System.Drawing.Size(74, 20);
            this.dataBitsCbx.TabIndex = 11;
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
            this.openCloseSpbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openCloseSpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCloseSpbtn.Location = new System.Drawing.Point(14, 311);
            this.openCloseSpbtn.Name = "openCloseSpbtn";
            this.openCloseSpbtn.Size = new System.Drawing.Size(74, 36);
            this.openCloseSpbtn.TabIndex = 17;
            this.openCloseSpbtn.Text = "Open";
            this.openCloseSpbtn.UseVisualStyleBackColor = true;
            // 
            // baudRateCbx
            // 
            this.baudRateCbx.FormattingEnabled = true;
            this.baudRateCbx.Location = new System.Drawing.Point(14, 75);
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(4, 573);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(889, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(4, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 599);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox handshakingcbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.ComboBox dataBitsCbx;
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer statustimer;
        private System.Windows.Forms.Timer timer2;
    }
}

