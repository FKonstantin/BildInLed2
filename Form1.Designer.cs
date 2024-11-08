namespace BildInLed2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgLeds = new System.Windows.Forms.DataGridView();
            this.gbLeds = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.lbStopBit = new System.Windows.Forms.Label();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.lbParity = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.lbBaudrate = new System.Windows.Forms.Label();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnReScan = new System.Windows.Forms.Button();
            this.btnClearInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLeds)).BeginInit();
            this.gbLeds.SuspendLayout();
            this.gbPortSettings.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgLeds
            // 
            this.dgLeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLeds.Location = new System.Drawing.Point(6, 19);
            this.dgLeds.Name = "dgLeds";
            this.dgLeds.Size = new System.Drawing.Size(243, 197);
            this.dgLeds.TabIndex = 0;
            this.dgLeds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLeds_CellClick);
            // 
            // gbLeds
            // 
            this.gbLeds.Controls.Add(this.btnSend);
            this.gbLeds.Controls.Add(this.btnClear);
            this.gbLeds.Controls.Add(this.dgLeds);
            this.gbLeds.Location = new System.Drawing.Point(12, 12);
            this.gbLeds.Name = "gbLeds";
            this.gbLeds.Size = new System.Drawing.Size(255, 284);
            this.gbLeds.TabIndex = 1;
            this.gbLeds.TabStop = false;
            this.gbLeds.Text = "LEDs";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(7, 253);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(242, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send to MCU";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(7, 223);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(242, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbPortSettings
            // 
            this.gbPortSettings.Controls.Add(this.btnReScan);
            this.gbPortSettings.Controls.Add(this.btnClosePort);
            this.gbPortSettings.Controls.Add(this.btnOpenPort);
            this.gbPortSettings.Controls.Add(this.lbData);
            this.gbPortSettings.Controls.Add(this.cbData);
            this.gbPortSettings.Controls.Add(this.lbStopBit);
            this.gbPortSettings.Controls.Add(this.cbStopBit);
            this.gbPortSettings.Controls.Add(this.lbParity);
            this.gbPortSettings.Controls.Add(this.cbParity);
            this.gbPortSettings.Controls.Add(this.lbBaudrate);
            this.gbPortSettings.Controls.Add(this.cbBaudrate);
            this.gbPortSettings.Controls.Add(this.lbPort);
            this.gbPortSettings.Controls.Add(this.cbPort);
            this.gbPortSettings.Location = new System.Drawing.Point(273, 12);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Size = new System.Drawing.Size(174, 258);
            this.gbPortSettings.TabIndex = 2;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "Port Settings";
            // 
            // btnClosePort
            // 
            this.btnClosePort.Location = new System.Drawing.Point(6, 193);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(155, 23);
            this.btnClosePort.TabIndex = 11;
            this.btnClosePort.Text = "Close";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(7, 164);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(155, 23);
            this.btnOpenPort.TabIndex = 10;
            this.btnOpenPort.Text = "Open";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(7, 106);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 9;
            this.lbData.Text = "Data";
            // 
            // cbData
            // 
            this.cbData.FormattingEnabled = true;
            this.cbData.Location = new System.Drawing.Point(63, 103);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(99, 21);
            this.cbData.TabIndex = 8;
            // 
            // lbStopBit
            // 
            this.lbStopBit.AutoSize = true;
            this.lbStopBit.Location = new System.Drawing.Point(7, 133);
            this.lbStopBit.Name = "lbStopBit";
            this.lbStopBit.Size = new System.Drawing.Size(43, 13);
            this.lbStopBit.TabIndex = 7;
            this.lbStopBit.Text = "Stop bit";
            // 
            // cbStopBit
            // 
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Location = new System.Drawing.Point(63, 130);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(99, 21);
            this.cbStopBit.TabIndex = 6;
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Location = new System.Drawing.Point(7, 79);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(33, 13);
            this.lbParity.TabIndex = 5;
            this.lbParity.Text = "Parity";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(63, 76);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(99, 21);
            this.cbParity.TabIndex = 4;
            // 
            // lbBaudrate
            // 
            this.lbBaudrate.AutoSize = true;
            this.lbBaudrate.Location = new System.Drawing.Point(7, 52);
            this.lbBaudrate.Name = "lbBaudrate";
            this.lbBaudrate.Size = new System.Drawing.Size(50, 13);
            this.lbBaudrate.TabIndex = 3;
            this.lbBaudrate.Text = "Baudrate";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Location = new System.Drawing.Point(63, 49);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(99, 21);
            this.cbBaudrate.TabIndex = 2;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(7, 25);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(26, 13);
            this.lbPort.TabIndex = 1;
            this.lbPort.Text = "Port";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(63, 22);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(99, 21);
            this.cbPort.TabIndex = 0;
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(6, 19);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(423, 216);
            this.rtbInfo.TabIndex = 3;
            this.rtbInfo.Text = "";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.rtbInfo);
            this.gbInfo.Location = new System.Drawing.Point(12, 303);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(435, 241);
            this.gbInfo.TabIndex = 4;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // btnReScan
            // 
            this.btnReScan.Location = new System.Drawing.Point(6, 223);
            this.btnReScan.Name = "btnReScan";
            this.btnReScan.Size = new System.Drawing.Size(155, 23);
            this.btnReScan.TabIndex = 12;
            this.btnReScan.Text = "ReScan";
            this.btnReScan.UseVisualStyleBackColor = true;
            this.btnReScan.Click += new System.EventHandler(this.btnReScan_Click);
            // 
            // btnClearInfo
            // 
            this.btnClearInfo.Location = new System.Drawing.Point(273, 273);
            this.btnClearInfo.Name = "btnClearInfo";
            this.btnClearInfo.Size = new System.Drawing.Size(160, 23);
            this.btnClearInfo.TabIndex = 5;
            this.btnClearInfo.Text = "Clear Info";
            this.btnClearInfo.UseVisualStyleBackColor = true;
            this.btnClearInfo.Click += new System.EventHandler(this.btnClearInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 556);
            this.Controls.Add(this.btnClearInfo);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbPortSettings);
            this.Controls.Add(this.gbLeds);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ImageToLEDs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLeds)).EndInit();
            this.gbLeds.ResumeLayout(false);
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgLeds;
        private System.Windows.Forms.GroupBox gbLeds;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbPortSettings;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label lbBaudrate;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.Label lbStopBit;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnReScan;
        private System.Windows.Forms.Button btnClearInfo;
    }
}

