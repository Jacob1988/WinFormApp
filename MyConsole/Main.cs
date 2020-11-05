using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyConsole
{
    public partial class Main : Form
    {
        public delegate void SDataRcvEntHnd(char recv);
        public bool portOpen = false;
        public string portName = "COM1";//端口号
        public int portBaudRate = 9600;//波特率
        public int portDataBits = 8;//数据位
        public Parity portParity;//奇偶校验位
        public StopBits portStopBits;//停止位

        public string sendBuff;

        #region 工具类方法
        /// <summary>
        /// 选项ID转波特率
        /// </summary>
        /// <param name="s">选项ID</param>
        /// <param name="b">波特率</param>
        private void _SelectIdToBaudRate(int s, out int b)
        {
            switch (s)
            {
                case 0:
                    b = 110;
                    break;
                case 1:
                    b = 300;
                    break;
                case 2:
                    b = 600;
                    break;
                case 3:
                    b = 1200;
                    break;
                case 4:
                    b = 2400;
                    break;
                case 5:
                    b = 4800;
                    break;
                case 6:
                    b = 9600;
                    break;
                case 7:
                    b = 14400;
                    break;
                case 8:
                    b = 19200;
                    break;
                case 9:
                    b = 38400;
                    break;
                case 10:
                    b = 57600;
                    break;
                case 11:
                    b = 115200;
                    break;
                case 12:
                    b = 230400;
                    break;
                case 13:
                    b = 380400;
                    break;
                case 14:
                    b = 460800;
                    break;
                case 15:
                    b = 921600;
                    break;
                default:
                    b = 9600;
                    break;
            }
        }

        /// <summary>
        /// 选项ID转数据位
        /// </summary>
        /// <param name="s">选项ID</param>
        /// <param name="b">数据位</param>
        private void _SelectIdToDataBits(int s, out int d)
        {
            switch (s)
            {
                case 0/*"5"*/:
                    d = 5;
                    break;
                case 1/*"6"*/:
                    d = 6;
                    break;
                case 2/*"7"*/:
                    d = 7;
                    break;
                case 3/*"8"*/:
                    d = 8;
                    break;
                default:
                    d = 8;
                    break;
            }
        }

        /// <summary>
        /// 选项ID转奇偶校验
        /// </summary>
        /// <param name="s">选项ID</param>
        /// <param name="p">奇偶校验</param>
        private void _SelectIdToParity(int s, out Parity p)
        {
            switch (s)
            {
                case 0/*"None"*/:
                    p = Parity.None;
                    break;
                case 1/*"Odd"*/:
                    p = Parity.Odd;
                    break;
                case 2/*"Even"*/:
                    p = Parity.Even;
                    break;
                case 3/*"Mark"*/:
                    p = Parity.Mark;
                    break;
                case 4/*"Space"*/:
                    p = Parity.Space;
                    break;
                default:
                    p = Parity.None;
                    break;
            }
        }

        /// <summary>
        /// 选项ID转停止位
        /// </summary>
        /// <param name="s">选项ID</param>
        /// <param name="st">停止位</param>
        private void _SelectIdToStopBits(int s, out StopBits st)
        {
            switch (s)
            {
                case 0/*"0"*/:
                    st = StopBits.None;
                    break;
                case 1/*"1"*/:
                    st = StopBits.One;
                    break;
                case 2/*"1.5"*/:
                    st = StopBits.OnePointFive;
                    break;
                case 3/*"2"*/:
                    st = StopBits.Two;
                    break;
                default:
                    st = StopBits.One;
                    break;
            }
        }

        #endregion

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (portOpen == false)
            {
                BtnStart.Enabled = true;
                BtnStop.Enabled = false;
            }
            portName = SerialPortNum.Text;
            _SelectIdToBaudRate(SerialPortBaud.SelectedIndex, out portBaudRate);
            _SelectIdToDataBits(SerialPortDataBits.SelectedIndex, out portDataBits);
            _SelectIdToParity(SerialPortParity.SelectedIndex, out portParity);
            _SelectIdToStopBits(SerialPortStop.SelectedIndex, out portStopBits);
        }

        #region 打开或关闭串口
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (portOpen == false)//防止重复打开
            {
                try
                {
                    mySerialPort.BaudRate = portBaudRate;
                    mySerialPort.DataBits = portDataBits;
                    mySerialPort.Parity = portParity;
                    mySerialPort.PortName = portName;
                    mySerialPort.StopBits = portStopBits;

                    mySerialPort.Open();

                    portOpen = true;
                    BtnStart.Enabled = false;
                    BtnStop.Enabled = true;

                }
                catch (Exception)
                {
                    MessageBox.Show(this, "未能打开端口: " + portName + "\n可能是该端口不存在或已被占用!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (portOpen == true)
            {
                try
                {
                    mySerialPort.Close();
                    portOpen = false;
                    BtnStart.Enabled = true;
                    BtnStop.Enabled = false;
                }
                catch (Exception)
                {
                    {
                        MessageBox.Show(this, "未能关闭端口: " + portName, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

        #region 设置串口参数
        private void SerialPortNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            portName = SerialPortNum.Text;
        }

        private void SerialPortBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectIdToBaudRate(SerialPortBaud.SelectedIndex, out portBaudRate);
            Console.WriteLine("SerialPortBaud: {0}-{1}", SerialPortBaud.SelectedIndex, portBaudRate);
        }

        private void SerialPortDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectIdToDataBits(SerialPortDataBits.SelectedIndex, out portDataBits);
            Console.WriteLine("SerialPortDataBits: {0}-{1}", SerialPortDataBits.SelectedIndex, portDataBits);
        }

        private void SerialPortStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectIdToStopBits(SerialPortStop.SelectedIndex, out portStopBits);
            Console.WriteLine("SerialPortStop: {0}-{1}", SerialPortStop.SelectedIndex, portStopBits.ToString());
        }

        private void SerialPortParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectIdToParity(SerialPortParity.SelectedIndex, out portParity);
            Console.WriteLine("SerialPortParity: {0}-{1}", SerialPortParity.SelectedIndex, portParity.ToString());
        }
        #endregion

        private void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (mySerialPort.IsOpen)
            {
                try
                {
                    //byte[] buffer = new byte[mySerialPort.BytesToRead];
                    //mySerialPort.Read(buffer, 0, mySerialPort.BytesToRead);
                    //string recvString = Encoding.ASCII.GetString(buffer);//byte[] to string
                    //SerialReadChange(recvString);

                    for (int i = 0; i < mySerialPort.BytesToRead; i++)
                    {
                        SerialReadChange((char)mySerialPort.ReadChar());
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "接收出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SerialReadChange(char recv)
        {
            if (SerialRead.InvokeRequired)
            {
                SDataRcvEntHnd s = new SDataRcvEntHnd(SerialReadChange);
                SerialRead.Invoke(s, new object[] { recv });
            }
            else
            {
                SerialRead.Text += recv;
                //SerialRead.AppendText((string)recv);
                //SerialRead.Text += "\r\n";
                SerialRead.SelectionStart = SerialRead.TextLength;//光标在最后
                SerialRead.ScrollToCaret();
            }
        }

        private void SerialRead_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mySerialPort.IsOpen)
            {
                try
                {
                    byte[] buffer = new byte[2];
                    //if ((e.KeyChar == '\r') || (e.KeyChar == '\n'))
                    //{
                    //    buffer[0] = Convert.ToByte('\r');
                    //    buffer[1] = Convert.ToByte('\n');
                    //    mySerialPort.Write(buffer, 0, 2);
                    //    Console.WriteLine("WriteBuffer" + buffer[0] + ", " + buffer[1]);
                    //}
                    //else
                    {
                        buffer[0] = Convert.ToByte(e.KeyChar);
                        mySerialPort.Write(buffer, 0, 1);
                        Console.WriteLine("WriteBuffer" + buffer[0]);
                    }
                    //SerialRead.SelectionStart = SerialRead.TextLength;//光标在最后
                    SerialRead.ScrollToCaret();
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "发送出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
