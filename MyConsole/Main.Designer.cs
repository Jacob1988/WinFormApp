using System.IO.Ports;
namespace MyConsole
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.SerialPortBaud = new System.Windows.Forms.ComboBox();
            this.SerialPortDataBits = new System.Windows.Forms.ComboBox();
            this.SerialPortParity = new System.Windows.Forms.ComboBox();
            this.SerialPortStop = new System.Windows.Forms.ComboBox();
            this.SerialRead = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.SerialPortNum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mySerialPort
            // 
            this.mySerialPort.ReadTimeout = 100;
            this.mySerialPort.WriteTimeout = 100;
            this.mySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.mySerialPort_DataReceived);
            // 
            // SerialPortBaud
            // 
            this.SerialPortBaud.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SerialPortBaud.FormattingEnabled = true;
            this.SerialPortBaud.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "380400",
            "460800",
            "921600"});
            this.SerialPortBaud.Location = new System.Drawing.Point(12, 45);
            this.SerialPortBaud.Name = "SerialPortBaud";
            this.SerialPortBaud.Size = new System.Drawing.Size(100, 28);
            this.SerialPortBaud.TabIndex = 2;
            this.SerialPortBaud.TabStop = false;
            this.SerialPortBaud.Text = "9600";
            this.SerialPortBaud.SelectedIndexChanged += new System.EventHandler(this.SerialPortBaud_SelectedIndexChanged);
            // 
            // SerialPortDataBits
            // 
            this.SerialPortDataBits.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SerialPortDataBits.FormattingEnabled = true;
            this.SerialPortDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.SerialPortDataBits.Location = new System.Drawing.Point(12, 83);
            this.SerialPortDataBits.Name = "SerialPortDataBits";
            this.SerialPortDataBits.Size = new System.Drawing.Size(100, 28);
            this.SerialPortDataBits.TabIndex = 3;
            this.SerialPortDataBits.TabStop = false;
            this.SerialPortDataBits.Text = "8";
            this.SerialPortDataBits.SelectedIndexChanged += new System.EventHandler(this.SerialPortDataBits_SelectedIndexChanged);
            // 
            // SerialPortParity
            // 
            this.SerialPortParity.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SerialPortParity.FormattingEnabled = true;
            this.SerialPortParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.SerialPortParity.Location = new System.Drawing.Point(12, 161);
            this.SerialPortParity.Name = "SerialPortParity";
            this.SerialPortParity.Size = new System.Drawing.Size(100, 28);
            this.SerialPortParity.TabIndex = 4;
            this.SerialPortParity.TabStop = false;
            this.SerialPortParity.Text = "None";
            this.SerialPortParity.SelectedIndexChanged += new System.EventHandler(this.SerialPortParity_SelectedIndexChanged);
            // 
            // SerialPortStop
            // 
            this.SerialPortStop.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SerialPortStop.FormattingEnabled = true;
            this.SerialPortStop.Items.AddRange(new object[] {
            "0",
            "1",
            "1.5",
            "2"});
            this.SerialPortStop.Location = new System.Drawing.Point(12, 122);
            this.SerialPortStop.Name = "SerialPortStop";
            this.SerialPortStop.Size = new System.Drawing.Size(100, 28);
            this.SerialPortStop.TabIndex = 5;
            this.SerialPortStop.TabStop = false;
            this.SerialPortStop.Text = "1";
            this.SerialPortStop.SelectedIndexChanged += new System.EventHandler(this.SerialPortStop_SelectedIndexChanged);
            // 
            // SerialRead
            // 
            this.SerialRead.AcceptsReturn = true;
            this.SerialRead.BackColor = System.Drawing.Color.Black;
            this.SerialRead.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SerialRead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SerialRead.Location = new System.Drawing.Point(118, 6);
            this.SerialRead.Multiline = true;
            this.SerialRead.Name = "SerialRead";
            this.SerialRead.Size = new System.Drawing.Size(600, 500);
            this.SerialRead.TabIndex = 6;
            this.SerialRead.TabStop = false;
            this.SerialRead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SerialRead_KeyPress);
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnStart.Location = new System.Drawing.Point(12, 200);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(100, 33);
            this.BtnStart.TabIndex = 7;
            this.BtnStart.TabStop = false;
            this.BtnStart.Text = "连接";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnStop.Location = new System.Drawing.Point(12, 239);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(100, 33);
            this.BtnStop.TabIndex = 8;
            this.BtnStop.TabStop = false;
            this.BtnStop.Text = "断开";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // SerialPortNum
            // 
            this.SerialPortNum.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SerialPortNum.FormattingEnabled = true;
            this.SerialPortNum.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.SerialPortNum.Location = new System.Drawing.Point(12, 6);
            this.SerialPortNum.Name = "SerialPortNum";
            this.SerialPortNum.Size = new System.Drawing.Size(100, 28);
            this.SerialPortNum.TabIndex = 9;
            this.SerialPortNum.TabStop = false;
            this.SerialPortNum.Text = "COM1";
            this.SerialPortNum.SelectedIndexChanged += new System.EventHandler(this.SerialPortNum_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 518);
            this.Controls.Add(this.SerialPortNum);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.SerialRead);
            this.Controls.Add(this.SerialPortStop);
            this.Controls.Add(this.SerialPortParity);
            this.Controls.Add(this.SerialPortDataBits);
            this.Controls.Add(this.SerialPortBaud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口调试助手";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort mySerialPort;
        private System.Windows.Forms.ComboBox SerialPortBaud;
        private System.Windows.Forms.ComboBox SerialPortDataBits;
        private System.Windows.Forms.ComboBox SerialPortParity;
        private System.Windows.Forms.ComboBox SerialPortStop;
        private System.Windows.Forms.TextBox SerialRead;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.ComboBox SerialPortNum;
    }
}

