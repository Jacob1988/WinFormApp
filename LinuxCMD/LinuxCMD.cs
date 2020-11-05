using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LinuxCMD
{
    public partial class LinuxCmd : Form
    {
        SQLiteConnection DBConnect;
        
        string DBPath = "Data Source=" + Environment.CurrentDirectory + "\\linuxcmd.db;" + "Version=3;";
        public LinuxCmd()
        {
            InitializeComponent();
        }

        private void LinuxCmd_Load(object sender, EventArgs e)
        {
            DBConnect = new SQLiteConnection(DBPath);
            DBConnect.Open();
            string sql = "select * from cmdlist where title='ls'";
            SQLiteCommand DBCommand = new SQLiteCommand(sql, DBConnect);
            SQLiteDataReader DBreader = DBCommand.ExecuteReader();
            DBreader.Read();
            cmdBrowser.DocumentText = DBreader.GetString(3);
        }

        private void cmdSearchStr_MouseDown(object sender, MouseEventArgs e)
        {
            cmdSearchStr.Text = String.Empty;
        }
    }
}
