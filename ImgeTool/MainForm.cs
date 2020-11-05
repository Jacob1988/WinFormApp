using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImgeTool
{
    public partial class Main : Form
    {
        private bool allowBackup = false;
        //private string loaderFilePath = null;
        //private string systemFilePath = null;
        //private string backupFilePath = null;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            allowBackup = checkBoxAllowBackup.Checked;
            textBoxBackupAddr.Enabled = allowBackup;
            buttonOpenBackupImage.Enabled = allowBackup;
            labelLoaderFilePath.Text = "";
            labelSystemFilePath.Text = "";
            labelBackupFilePath.Text = "";
            //labelSaveImageFilePath.Text = null;
        }

        private void checkBoxAllowBackup_CheckedChanged(object sender, EventArgs e)
        {
            allowBackup = checkBoxAllowBackup.Checked;
            textBoxBackupAddr.Enabled = allowBackup;
            buttonOpenBackupImage.Enabled = allowBackup;
        }

        private void textBoxLoaderAddr_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允许输入十六进制数
            if (e.KeyChar != '\b')//允许退格
            {
                if (e.Handled = "0123456789ABCDEF".IndexOf(Char.ToUpper(e.KeyChar)) < 0)
                {
                    e.Handled = true;//消除不合适字符
                }
            }
        }

        private void textBoxSystemAddr_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允许输入十六进制数
            if (e.KeyChar != '\b')//允许退格
            {
                if (e.Handled = "0123456789ABCDEF".IndexOf(Char.ToUpper(e.KeyChar)) < 0)
                {
                    e.Handled = true;//消除不合适字符
                }
            }
        }

        private void textBoxImageSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允许输入数字
            if (e.KeyChar != '\b')
            {
                if (!Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxBackupAddr_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只允许输入十六进制数
            if (e.KeyChar != '\b')//允许退格
            {
                if (e.Handled = "0123456789ABCDEF".IndexOf(Char.ToUpper(e.KeyChar)) < 0)
                {
                    e.Handled = true;//消除不合适字符
                }
            }
        }

        private void buttonOpenLoaderImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogLoaderImage.ShowDialog() == DialogResult.OK)
            {
                labelLoaderFilePath.Text = openFileDialogLoaderImage.FileName;
            }
            else
            {
                labelLoaderFilePath.Text = "";
            }
        }

        private void buttonOpenSystemImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogSystemImage.ShowDialog() == DialogResult.OK)
            {
                labelSystemFilePath.Text = openFileDialogSystemImage.FileName;
            }
            else
            {
                labelSystemFilePath.Text = "";
            }
        }

        private void buttonOpenBackupImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogBackupImage.ShowDialog() == DialogResult.OK)
            {
                labelBackupFilePath.Text = openFileDialogBackupImage.FileName;
            }
            else
            {
                labelBackupFilePath.Text = "";
            }
        }

        private void buttonSaveImageFile_Click(object sender, EventArgs e)
        {
            int imageFileSize = 0;
            int loaderAddr = 0;
            int systemAddr = 0;
            int backupAddr = 0;

            FileStream loaderImageFile = null;
            FileStream systemImageFile = null;
            FileStream backupImageFile = null;
            FileStream imageFile = null;
            try
            {
                imageFileSize = Convert.ToInt32(textBoxImageSize.Text, 10);//10进制
                imageFileSize = imageFileSize * 1024 * 1024;//转换成字节单位
                loaderAddr = Convert.ToInt32(textBoxLoaderAddr.Text, 16);//16进制
                systemAddr = Convert.ToInt32(textBoxSystemAddr.Text, 16);//16进制
                if (allowBackup == true)
                {
                    backupAddr = Convert.ToInt32(textBoxBackupAddr.Text, 16);//16进制
                }
                else
                {
                    backupAddr = imageFileSize - 1;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("无效参数!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 参数检查
            if ((imageFileSize <= 0) ||
                (loaderAddr >= imageFileSize) ||
                (systemAddr >= imageFileSize) ||
                (backupAddr >= imageFileSize) ||
                (loaderAddr >= systemAddr) ||
                (systemAddr >= backupAddr))
            {
                MessageBox.Show("参数错误!"
                    + "\nimageFileSize\t:" + imageFileSize
                    + "\nloaderAddr\t:" + loaderAddr
                    + "\nsystemAddr\t:" + systemAddr
                    + "\nbackupAddr\t:" + backupAddr,
                    "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 打开loader镜像文件
            if (labelLoaderFilePath.Text == "")
            {
                MessageBox.Show("请打开Loader镜像文件!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    loaderImageFile = new FileStream(labelLoaderFilePath.Text, FileMode.Open);
                }
                catch (Exception)
                {

                    MessageBox.Show("打开Loader镜像文件出错!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if ((loaderImageFile.Length >= imageFileSize) || (loaderImageFile.Length >= (systemAddr - loaderAddr)))
                {
                    MessageBox.Show("Loader镜像文件太大!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (loaderImageFile != null)
                    {
                        loaderImageFile.Close();
                    }
                    return;
                }
            }

            // 打开system镜像文件
            if (labelSystemFilePath.Text == "")
            {
                MessageBox.Show("请打开System镜像文件!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    systemImageFile = new FileStream(labelSystemFilePath.Text, FileMode.Open);
                }
                catch (Exception)
                {
                    MessageBox.Show("打开System镜像文件出错!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if ((systemImageFile.Length >= imageFileSize) || (systemImageFile.Length >= (backupAddr - systemAddr)))
                {
                    MessageBox.Show("System镜像文件太大!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (systemImageFile != null)
                    {
                        systemImageFile.Close();
                    }
                    return;
                }
            }

            // 打开备份镜像文件
            if (allowBackup == true)
            {
                if (labelBackupFilePath.Text == "")
                {
                    MessageBox.Show("请打开Backup镜像文件!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    try
                    {
                        backupImageFile = new FileStream(labelBackupFilePath.Text, FileMode.Open);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("打开Backup镜像文件出错!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if ((backupImageFile.Length >= imageFileSize) || (backupImageFile.Length >= (imageFileSize - backupAddr)))
                    {
                        MessageBox.Show("Backup镜像文件太大!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (backupImageFile != null)
                        {
                            backupImageFile.Close();
                        }
                        return;
                    }
                }
            }

            // 生成烧片文件
            if (saveImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelSaveImageFilePath.Text = saveImageFileDialog.FileName;
                try
                {
                    imageFile = new FileStream(saveImageFileDialog.FileName, FileMode.Create);
                }
                catch (Exception)
                {
                    MessageBox.Show("打开烧片文件出错!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] saveImageFile = new byte[imageFileSize];
                //初始化烧片文件
                for (int i = 0; i < saveImageFile.Length; i++)
                {
                    saveImageFile[i] = 0xff;
                }

                try
                {
                    // 读入loader文件
                    loaderImageFile.Seek(0, SeekOrigin.Begin);
                    loaderImageFile.Read(saveImageFile, loaderAddr, (int)(loaderImageFile.Length));
                    loaderImageFile.Close();
                    loaderImageFile = null;
                    // 读入system文件
                    systemImageFile.Seek(0, SeekOrigin.Begin);
                    systemImageFile.Read(saveImageFile, systemAddr, (int)(systemImageFile.Length));
                    systemImageFile.Close();
                    systemImageFile = null;
                    //读入backup文件
                    if (allowBackup == true)
                    {
                        backupImageFile.Seek(0, SeekOrigin.Begin);
                        backupImageFile.Read(saveImageFile, backupAddr, (int)(backupImageFile.Length));
                        backupImageFile.Close();
                        backupImageFile = null;
                    }
                    //写烧片文件
                    imageFile.Seek(0, SeekOrigin.Begin);
                    imageFile.Write(saveImageFile, 0, saveImageFile.Length);
                    imageFile.Close();
                    imageFile = null;
                }
                catch (Exception)
                {
                    MessageBox.Show("文件读写出错!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //关闭文件
                    if (loaderImageFile != null)
                    {
                        loaderImageFile.Close();
                    }
                    if (systemImageFile != null)
                    {
                        systemImageFile.Close();
                    }
                    if (backupImageFile != null)
                    {
                        backupImageFile.Close();
                    }
                    if (imageFile != null)
                    {
                        imageFile.Close();
                    }
                    return;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("烧片制作工具\n"
                + "Image Size(Mb): 烧片文件大小(根据Flash型号选择),单位:兆字节\n"
                + "Loader Partition Addr: 引导分区起始地址\n"
                + "System Partition Addr: 系统分区起始地址\n"
                + "Backup Partition Addr: 备份分区起始地址(如果存在)\n"
                + "Open Loader Image: 打开引导镜像\n"
                + "Open System Image: 打开系统镜像\n"
                + "Open Backup Image: 打开备份镜像(如果存在)\n"
                + "SaveImageFile: 选择烧片文件保存位置，并生成烧片文件\n"
                +"by 胡椒小兄弟 - wnavy.com",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
