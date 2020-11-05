using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Setting : Form
    {
        #region 字段和属性
        private Color _ColorSet;
        private int _BodySizeSet;
        private bool _WallSet;
        private bool _KingSet;

        public Color ColorSet
        {
            get { return _ColorSet; }
            set { _ColorSet = value; }
        }

        public int BodySizeSet
        {
            get { return _BodySizeSet; }
            set { _BodySizeSet = value; }
        }

        public bool WallSet
        {
            get { return _WallSet; }
            set { _WallSet = value; }
        }

        public bool KingSet
        {
            get { return _KingSet; }
            set { _KingSet = value; }
        }
        #endregion

        public Setting(Color col, int bdsz, bool wall, bool king)
        {
            InitializeComponent();
            _ColorSet = col;
            _BodySizeSet = bdsz;
            _WallSet = wall;
            _KingSet = king;
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            ChoiseColor.BackColor = _ColorSet;
            ChoiseSize.Text = _BodySizeSet.ToString();
            ChoiseBDSize.Value = _BodySizeSet;
            //ChoiseWall.Checked = _WallSet;
            //if (_WallSet == true)
            //{
            //    ChoiseWall.Text = "打开";
            //}
            //else
            //{
            //    ChoiseWall.Text = "关闭";
            //}
            ChoiseKing.Checked = _KingSet;
            if (_KingSet == true)
            {
                ChoiseKing.Text = "打开";
            }
            else
            {
                ChoiseKing.Text = "关闭";
            }
        }

        private void ChoiseColor_Click(object sender, EventArgs e)
        {
            if (ChoisecolorDialog.ShowDialog() == DialogResult.OK)
            {
                _ColorSet = ChoisecolorDialog.Color;
                ChoiseColor.BackColor = _ColorSet;
            }
        }

        private void ChoiseWall_CheckedChanged(object sender, EventArgs e)
        {
            //_WallSet = ChoiseWall.Checked;
            //if (_WallSet == true)
            //{
            //    ChoiseWall.Text = "打开";
            //}
            //else
            //{
            //    ChoiseWall.Text = "关闭";
            //}
        }

        private void ChoiseKing_CheckedChanged(object sender, EventArgs e)
        {
            _KingSet = ChoiseKing.Checked;
            //_WallSet = ChoiseWall.Checked;
            if (_KingSet == true)
            {
                ChoiseKing.Text = "打开";

                _WallSet = true;//如果打开了无敌模式，默认也将打开无界模式
                //ChoiseWall.Checked = _WallSet;
                //ChoiseWall.Text = "打开";
            }
            else
            {
                ChoiseKing.Text = "关闭";
                _WallSet = false;
            }
        }

        private void SetOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChoiseSize_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    _BodySizeSet = Convert.ToInt32(ChoiseSize.Text);
            //    //if (_BodySizeSet <= 5) _BodySizeSet = 5;
            //    //if (_BodySizeSet >= 50) _BodySizeSet = 50;
            //    //ChoiseSize.Text = _BodySizeSet.ToString();
            //}
            //catch (Exception)
            //{
            //    BodySizeSet = 20;
            //}
        }

        private void ChoiseBDSize_Scroll(object sender, EventArgs e)
        {
            _BodySizeSet = ChoiseBDSize.Value;
        }
    }
}
