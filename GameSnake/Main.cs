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
    public partial class GameWindow : Form
    {
        private int timeTickSec = 0;
        private int timeTickMin = 0;
        private int timeTickHour = 0;
        private bool beginBtnClk = false;

        private const int gameSpeedTmr = 1000;
        private int gameSpeed = 4;
        public bool GameKing = false;
        public GameSnake GameSnake;

        #region 设计器自动生成的代码
        public GameWindow()
        {
            InitializeComponent();
            #region 游戏初始化代码，放在窗体构造函数中
            //游戏速度相关设置的初始化代码
            GameSpeed.Text = (gameSpeed + 1).ToString();
            GameTimer.Interval = gameSpeedTmr - (gameSpeed * 100);
            //创建贪吃蛇游戏
            GameSnake = new GameSnake(GameBKground, Color.Red, 20);
            #endregion
        }
        #endregion

        #region 开始游戏和计时器
        private void Begin_Click(object sender, EventArgs e)
        {
            if (beginBtnClk == false)
            {
                beginBtnClk = true;
                GameTimer.Enabled = true;
                GameTimer.Start();

                GameClock.Enabled = true;
                GameClock.Start();

                Begin.Image = global::Snake.Properties.Resources.暂停;
                Begin.Refresh();
            }
            else
            {
                beginBtnClk = false;
                GameTimer.Enabled = false;
                GameTimer.Stop();

                GameClock.Enabled = false;
                GameClock.Stop();

                Begin.Image = global::Snake.Properties.Resources.播放;
                Begin.Refresh();
            }
        }
        #endregion

        #region 重新开始游戏和计时器

        private void Renew_Click(object sender, EventArgs e)
        {
            bool timerEn = false, clockEn = false;
            if (GameClock.Enabled == true)
            {
                clockEn = true;
                GameClock.Enabled = false;
                GameClock.Stop();
            }
            if (GameTimer.Enabled == true)
            {
                timerEn = true;
                GameTimer.Stop();
                GameTimer.Enabled = false;
            }

            timeTickSec = 0;
            timeTickMin = 0;
            timeTickHour = 0;
            Time.Text = timeTickMin.ToString() + ":" + timeTickSec.ToString();
            Score.Text = GameSnake.Score.ToString();
            GameSnake.SnakeGameRenew();//重新开始游戏


            if (clockEn == true)
            {
                GameClock.Enabled = true;
                GameClock.Start();
            }

            if (timerEn == true)
            {
                GameTimer.Enabled = true;
                GameTimer.Start();
            }
        }
        #endregion

        #region 游戏运行计时器
        private void GameTimer_Tick(object sender, EventArgs e)
        {//运行游戏
            GameSnake.SnakeGameRun();
            //Console.WriteLine("SnakeLife=" + life.ToString());
            if (GameKing == false)//无敌模式
            {
                switch (GameSnake.Life)
                {
                    case SnakeLife.Live:
                        break;
                    case SnakeLife.Die:
                        GameClock.Enabled = false;
                        GameClock.Stop();
                        GameTimer.Enabled = false;
                        GameTimer.Stop();
                        timeTickSec = 0;
                        timeTickMin = 0;
                        timeTickHour = 0;
                        Time.Text = timeTickMin.ToString() + ":" + timeTickSec.ToString();
                        Score.Text = GameSnake.Score.ToString();
                        GameSnake.SnakeGameRenew();//重新开始游戏
                        MessageBox.Show("好遗憾啊，你输了！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GameClock.Enabled = true;
                        GameClock.Start();
                        GameTimer.Enabled = true;
                        GameTimer.Start();
                        break;
                    case SnakeLife.Win:
                        GameClock.Enabled = false;
                        GameClock.Stop();
                        GameTimer.Enabled = false;
                        GameTimer.Stop();
                        timeTickSec = 0;
                        timeTickMin = 0;
                        timeTickHour = 0;
                        Time.Text = timeTickMin.ToString() + ":" + timeTickSec.ToString();
                        Score.Text = GameSnake.Score.ToString();
                        GameSnake.SnakeGameRenew();//重新开始游戏
                        MessageBox.Show("好厉害啊，你赢了！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GameClock.Enabled = true;
                        GameClock.Start();
                        GameTimer.Enabled = true;
                        GameTimer.Start();
                        break;
                    default:
                        break;
                }
            }
            Score.Text = GameSnake.Score.ToString();
        }
        #endregion

        #region 游戏时间计时器
        private void GameClock_Tick(object sender, EventArgs e)
        {
            timeTickSec++;//秒
            if (timeTickSec >= 60)//分钟
            {
                timeTickSec = 0;
                timeTickMin++;
            }
            if (timeTickMin >= 60)//小时 
            {
                timeTickMin = 0;
                timeTickHour++;
            }
            if (timeTickHour >= 24)//天
            {
                timeTickSec = 0;
                timeTickMin = 0;
                timeTickHour = 0;
            }

            if (timeTickHour > 0)//小时:分钟
            {
                Time.Text = timeTickHour.ToString() + ":" + timeTickMin.ToString();
            }
            else//分钟:秒
            {
                Time.Text = timeTickMin.ToString() + ":" + timeTickSec.ToString();
            }
        }
        #endregion

        #region 点击打开个人信息和网站
        private void Share_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.wnavy.com");
        }
        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("胡椒小兄弟\r\nwhjwnavy@163.com\r\n805400349@qq.com", "关于我", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region 终止所有进程并退出程序
        private void Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        #endregion

        #region 按钮按下并回弹动画
        public const int btnMove = 2;//回弹力度-像素
        private void Renew_MouseDown(object sender, MouseEventArgs e)
        {
            //Renew.Location = new Point(Renew.Location.X + 2, Renew.Location.Y + 2);
            Renew.Top += btnMove;
            Renew.Left += btnMove;
        }

        private void Renew_MouseUp(object sender, MouseEventArgs e)
        {
            //Renew.Location = new Point(Renew.Location.X - 2, Renew.Location.Y - 2);
            Renew.Top -= btnMove;
            Renew.Left -= btnMove;
        }

        private void Begin_MouseDown(object sender, MouseEventArgs e)
        {
            Begin.Top += btnMove;
            Begin.Left += btnMove;
        }

        private void Begin_MouseUp(object sender, MouseEventArgs e)
        {
            Begin.Top -= btnMove;
            Begin.Left -= btnMove;
        }

        private void GameKeyUp_MouseDown(object sender, MouseEventArgs e)
        {
            GameKeyUp.Top += btnMove;
            GameKeyUp.Left += btnMove;
        }

        private void GameKeyUp_MouseUp(object sender, MouseEventArgs e)
        {
            GameKeyUp.Top -= btnMove;
            GameKeyUp.Left -= btnMove;
        }

        private void GameKeyDown_MouseDown(object sender, MouseEventArgs e)
        {
            GameKeyDown.Top += btnMove;
            GameKeyDown.Left += btnMove;
        }

        private void GameKeyDown_MouseUp(object sender, MouseEventArgs e)
        {
            GameKeyDown.Top -= btnMove;
            GameKeyDown.Left -= btnMove;
        }

        private void GameKeyLeft_MouseDown(object sender, MouseEventArgs e)
        {
            GameKeyLeft.Top += btnMove;
            GameKeyLeft.Left += btnMove;
        }

        private void GameKeyLeft_MouseUp(object sender, MouseEventArgs e)
        {
            GameKeyLeft.Top -= btnMove;
            GameKeyLeft.Left -= btnMove;
        }

        private void GameKeyRight_MouseDown(object sender, MouseEventArgs e)
        {
            GameKeyRight.Top += btnMove;
            GameKeyRight.Left += btnMove;
        }

        private void GameKeyRight_MouseUp(object sender, MouseEventArgs e)
        {
            GameKeyRight.Top -= btnMove;
            GameKeyRight.Left -= btnMove;
        }

        private void About_MouseDown(object sender, MouseEventArgs e)
        {
            About.Top += btnMove;
            About.Left += btnMove;
        }

        private void About_MouseUp(object sender, MouseEventArgs e)
        {
            About.Top -= btnMove;
            About.Left -= btnMove;
        }

        private void Share_MouseDown(object sender, MouseEventArgs e)
        {
            Share.Top += btnMove;
            Share.Left += btnMove;
        }

        private void Share_MouseUp(object sender, MouseEventArgs e)
        {
            Share.Top -= btnMove;
            Share.Left -= btnMove;
        }

        private void Setting_MouseDown(object sender, MouseEventArgs e)
        {
            Setting.Top += btnMove;
            Setting.Left += btnMove;
        }

        private void Setting_MouseUp(object sender, MouseEventArgs e)
        {
            Setting.Top -= btnMove;
            Setting.Left -= btnMove;
        }

        private void Exit_MouseDown(object sender, MouseEventArgs e)
        {
            Exit.Top += btnMove;
            Exit.Left += btnMove;
        }

        private void Exit_MouseUp(object sender, MouseEventArgs e)
        {
            Exit.Top -= btnMove;
            Exit.Left -= btnMove;
        }

        private void SpeedDown_MouseDown(object sender, MouseEventArgs e)
        {
            SpeedDown.Top += btnMove;
            SpeedDown.Left += btnMove;
        }

        private void SpeedDown_MouseUp(object sender, MouseEventArgs e)
        {
            SpeedDown.Top -= btnMove;
            SpeedDown.Left -= btnMove;
        }

        private void SpeedUp_MouseDown(object sender, MouseEventArgs e)
        {
            SpeedUp.Top += btnMove;
            SpeedUp.Left += btnMove;
        }

        private void SpeedUp_MouseUp(object sender, MouseEventArgs e)
        {
            SpeedUp.Top -= btnMove;
            SpeedUp.Left -= btnMove;
        }
        #endregion

        #region 控制蛇移动方向
        private void GameKeyUp_Click(object sender, EventArgs e)
        {
            GameSnake.Direction = SnakeDirection.Up;
        }

        private void GameKeyDown_Click(object sender, EventArgs e)
        {
            GameSnake.Direction = SnakeDirection.Down;
        }

        private void GameKeyLeft_Click(object sender, EventArgs e)
        {
            GameSnake.Direction = SnakeDirection.Left;
        }

        private void GameKeyRight_Click(object sender, EventArgs e)
        {
            GameSnake.Direction = SnakeDirection.Right;
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    GameSnake.Direction = SnakeDirection.Up;
                    break;
                case Keys.S:
                case Keys.Down:
                    GameSnake.Direction = SnakeDirection.Down;
                    break;
                case Keys.A:
                case Keys.Left:
                    GameSnake.Direction = SnakeDirection.Left;
                    break;
                case Keys.D:
                case Keys.Right:
                    GameSnake.Direction = SnakeDirection.Right;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 改变游戏运行速度
        private void SpeedDown_Click(object sender, EventArgs e)
        {
            if (gameSpeed > 0)
            {
                gameSpeed--;
                GameTimer.Interval = gameSpeedTmr - (gameSpeed * 100);
                GameSpeed.Text = (gameSpeed + 1).ToString();
            }
        }

        private void SpeedUp_Click(object sender, EventArgs e)
        {
            if (gameSpeed < 9)
            {
                gameSpeed++;
                GameTimer.Interval = gameSpeedTmr - (gameSpeed * 100);
                GameSpeed.Text = (gameSpeed + 1).ToString();
            }
        }
        #endregion

        #region 游戏选项设置
        private void Setting_Click(object sender, EventArgs e)
        {
            Setting set = new Setting(GameSnake.SColor, GameSnake.BodySize, GameSnake.CrossWall, GameKing);
            set.ShowDialog(this);
            GameSnake.SColor = set.ColorSet;
            GameSnake.BodySize = set.BodySizeSet;
            GameSnake.CrossWall = set.WallSet;
            GameKing = set.KingSet;
        }
        #endregion

        #region 游戏窗体加载
        private void GameWindow_Load(object sender, EventArgs e)
        {
            GameSnake.SnakeGameRenew();
        }
        #endregion
    }
}
