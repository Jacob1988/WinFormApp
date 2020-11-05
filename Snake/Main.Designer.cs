namespace Snake
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.Time = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameClock = new System.Windows.Forms.Timer(this.components);
            this.GameSpeed = new System.Windows.Forms.Label();
            this.SpeedDown = new System.Windows.Forms.PictureBox();
            this.SpeedUp = new System.Windows.Forms.PictureBox();
            this.GameBKground = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.PictureBox();
            this.GameKeyRight = new System.Windows.Forms.PictureBox();
            this.GameKeyLeft = new System.Windows.Forms.PictureBox();
            this.GameKeyDown = new System.Windows.Forms.PictureBox();
            this.GameKeyUp = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Begin = new System.Windows.Forms.PictureBox();
            this.Setting = new System.Windows.Forms.PictureBox();
            this.Renew = new System.Windows.Forms.PictureBox();
            this.Share = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBKground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.About)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameKeyRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameKeyLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameKeyDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameKeyUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Begin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Renew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Share)).BeginInit();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("微软雅黑", 26.25F);
            this.Time.ForeColor = System.Drawing.Color.Red;
            this.Time.Location = new System.Drawing.Point(180, 430);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(200, 50);
            this.Time.TabIndex = 15;
            this.Time.Text = "0:0";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("微软雅黑", 26.25F);
            this.Score.ForeColor = System.Drawing.Color.Red;
            this.Score.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Score.Location = new System.Drawing.Point(180, 486);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(200, 50);
            this.Score.TabIndex = 16;
            this.Score.Text = "0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // GameClock
            // 
            this.GameClock.Interval = 1000;
            this.GameClock.Tick += new System.EventHandler(this.GameClock_Tick);
            // 
            // GameSpeed
            // 
            this.GameSpeed.Font = new System.Drawing.Font("微软雅黑", 26.25F);
            this.GameSpeed.ForeColor = System.Drawing.Color.Red;
            this.GameSpeed.Location = new System.Drawing.Point(451, 430);
            this.GameSpeed.Name = "GameSpeed";
            this.GameSpeed.Size = new System.Drawing.Size(105, 50);
            this.GameSpeed.TabIndex = 22;
            this.GameSpeed.Text = "5";
            this.GameSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpeedDown
            // 
            this.SpeedDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpeedDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpeedDown.ErrorImage = global::Snake.Properties.Resources.减速;
            this.SpeedDown.Image = global::Snake.Properties.Resources.减速;
            this.SpeedDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SpeedDown.InitialImage = global::Snake.Properties.Resources.减速;
            this.SpeedDown.Location = new System.Drawing.Point(395, 430);
            this.SpeedDown.Name = "SpeedDown";
            this.SpeedDown.Size = new System.Drawing.Size(50, 50);
            this.SpeedDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpeedDown.TabIndex = 21;
            this.SpeedDown.TabStop = false;
            this.SpeedDown.WaitOnLoad = true;
            this.SpeedDown.Click += new System.EventHandler(this.SpeedDown_Click);
            this.SpeedDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpeedDown_MouseDown);
            this.SpeedDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SpeedDown_MouseUp);
            // 
            // SpeedUp
            // 
            this.SpeedUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpeedUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpeedUp.ErrorImage = global::Snake.Properties.Resources.加速;
            this.SpeedUp.Image = global::Snake.Properties.Resources.加速;
            this.SpeedUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SpeedUp.InitialImage = global::Snake.Properties.Resources.加速;
            this.SpeedUp.Location = new System.Drawing.Point(562, 430);
            this.SpeedUp.Name = "SpeedUp";
            this.SpeedUp.Size = new System.Drawing.Size(50, 50);
            this.SpeedUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpeedUp.TabIndex = 20;
            this.SpeedUp.TabStop = false;
            this.SpeedUp.WaitOnLoad = true;
            this.SpeedUp.Click += new System.EventHandler(this.SpeedUp_Click);
            this.SpeedUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpeedUp_MouseDown);
            this.SpeedUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SpeedUp_MouseUp);
            // 
            // GameBKground
            // 
            this.GameBKground.BackColor = System.Drawing.Color.Black;
            this.GameBKground.Location = new System.Drawing.Point(13, 13);
            this.GameBKground.Name = "GameBKground";
            this.GameBKground.Size = new System.Drawing.Size(600, 400);
            this.GameBKground.TabIndex = 17;
            this.GameBKground.TabStop = false;
            // 
            // About
            // 
            this.About.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About.ErrorImage = global::Snake.Properties.Resources.评论_回复;
            this.About.Image = global::Snake.Properties.Resources.评论_回复;
            this.About.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.About.InitialImage = global::Snake.Properties.Resources.评论_回复;
            this.About.Location = new System.Drawing.Point(395, 486);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(50, 50);
            this.About.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.About.TabIndex = 12;
            this.About.TabStop = false;
            this.About.WaitOnLoad = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            this.About.MouseDown += new System.Windows.Forms.MouseEventHandler(this.About_MouseDown);
            this.About.MouseUp += new System.Windows.Forms.MouseEventHandler(this.About_MouseUp);
            // 
            // GameKeyRight
            // 
            this.GameKeyRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameKeyRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameKeyRight.ErrorImage = global::Snake.Properties.Resources.右;
            this.GameKeyRight.Image = global::Snake.Properties.Resources.右;
            this.GameKeyRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GameKeyRight.InitialImage = global::Snake.Properties.Resources.右;
            this.GameKeyRight.Location = new System.Drawing.Point(124, 486);
            this.GameKeyRight.Name = "GameKeyRight";
            this.GameKeyRight.Size = new System.Drawing.Size(50, 50);
            this.GameKeyRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameKeyRight.TabIndex = 9;
            this.GameKeyRight.TabStop = false;
            this.GameKeyRight.WaitOnLoad = true;
            this.GameKeyRight.Click += new System.EventHandler(this.GameKeyRight_Click);
            this.GameKeyRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameKeyRight_MouseDown);
            this.GameKeyRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameKeyRight_MouseUp);
            // 
            // GameKeyLeft
            // 
            this.GameKeyLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameKeyLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameKeyLeft.ErrorImage = global::Snake.Properties.Resources.左;
            this.GameKeyLeft.Image = global::Snake.Properties.Resources.左;
            this.GameKeyLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GameKeyLeft.InitialImage = global::Snake.Properties.Resources.左;
            this.GameKeyLeft.Location = new System.Drawing.Point(12, 486);
            this.GameKeyLeft.Name = "GameKeyLeft";
            this.GameKeyLeft.Size = new System.Drawing.Size(50, 50);
            this.GameKeyLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameKeyLeft.TabIndex = 8;
            this.GameKeyLeft.TabStop = false;
            this.GameKeyLeft.WaitOnLoad = true;
            this.GameKeyLeft.Click += new System.EventHandler(this.GameKeyLeft_Click);
            this.GameKeyLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameKeyLeft_MouseDown);
            this.GameKeyLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameKeyLeft_MouseUp);
            // 
            // GameKeyDown
            // 
            this.GameKeyDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameKeyDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameKeyDown.ErrorImage = global::Snake.Properties.Resources.下;
            this.GameKeyDown.Image = global::Snake.Properties.Resources.下;
            this.GameKeyDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GameKeyDown.InitialImage = global::Snake.Properties.Resources.下;
            this.GameKeyDown.Location = new System.Drawing.Point(68, 486);
            this.GameKeyDown.Name = "GameKeyDown";
            this.GameKeyDown.Size = new System.Drawing.Size(50, 50);
            this.GameKeyDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameKeyDown.TabIndex = 7;
            this.GameKeyDown.TabStop = false;
            this.GameKeyDown.WaitOnLoad = true;
            this.GameKeyDown.Click += new System.EventHandler(this.GameKeyDown_Click);
            this.GameKeyDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameKeyDown_MouseDown);
            this.GameKeyDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameKeyDown_MouseUp);
            // 
            // GameKeyUp
            // 
            this.GameKeyUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameKeyUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameKeyUp.ErrorImage = global::Snake.Properties.Resources.上;
            this.GameKeyUp.Image = global::Snake.Properties.Resources.上;
            this.GameKeyUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GameKeyUp.InitialImage = global::Snake.Properties.Resources.上;
            this.GameKeyUp.Location = new System.Drawing.Point(68, 430);
            this.GameKeyUp.Name = "GameKeyUp";
            this.GameKeyUp.Size = new System.Drawing.Size(50, 50);
            this.GameKeyUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameKeyUp.TabIndex = 6;
            this.GameKeyUp.TabStop = false;
            this.GameKeyUp.WaitOnLoad = true;
            this.GameKeyUp.Click += new System.EventHandler(this.GameKeyUp_Click);
            this.GameKeyUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameKeyUp_MouseDown);
            this.GameKeyUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameKeyUp_MouseUp);
            // 
            // Exit
            // 
            this.Exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.ErrorImage = global::Snake.Properties.Resources.关闭_错误;
            this.Exit.Image = global::Snake.Properties.Resources.关闭_错误;
            this.Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit.InitialImage = global::Snake.Properties.Resources.关闭_错误;
            this.Exit.Location = new System.Drawing.Point(562, 486);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 50);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 5;
            this.Exit.TabStop = false;
            this.Exit.WaitOnLoad = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseDown);
            this.Exit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseUp);
            // 
            // Begin
            // 
            this.Begin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Begin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Begin.ErrorImage = global::Snake.Properties.Resources.播放;
            this.Begin.Image = global::Snake.Properties.Resources.播放;
            this.Begin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Begin.InitialImage = global::Snake.Properties.Resources.播放;
            this.Begin.Location = new System.Drawing.Point(12, 430);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(50, 50);
            this.Begin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Begin.TabIndex = 4;
            this.Begin.TabStop = false;
            this.Begin.WaitOnLoad = true;
            this.Begin.Click += new System.EventHandler(this.Begin_Click);
            this.Begin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Begin_MouseDown);
            this.Begin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Begin_MouseUp);
            // 
            // Setting
            // 
            this.Setting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Setting.ErrorImage = global::Snake.Properties.Resources.设置;
            this.Setting.Image = global::Snake.Properties.Resources.设置;
            this.Setting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Setting.InitialImage = global::Snake.Properties.Resources.设置;
            this.Setting.Location = new System.Drawing.Point(451, 486);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(50, 50);
            this.Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Setting.TabIndex = 3;
            this.Setting.TabStop = false;
            this.Setting.WaitOnLoad = true;
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            this.Setting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Setting_MouseDown);
            this.Setting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Setting_MouseUp);
            // 
            // Renew
            // 
            this.Renew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Renew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Renew.ErrorImage = global::Snake.Properties.Resources.刷新;
            this.Renew.Image = global::Snake.Properties.Resources.刷新;
            this.Renew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Renew.InitialImage = global::Snake.Properties.Resources.刷新;
            this.Renew.Location = new System.Drawing.Point(124, 430);
            this.Renew.Name = "Renew";
            this.Renew.Size = new System.Drawing.Size(50, 50);
            this.Renew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Renew.TabIndex = 1;
            this.Renew.TabStop = false;
            this.Renew.WaitOnLoad = true;
            this.Renew.Click += new System.EventHandler(this.Renew_Click);
            this.Renew.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Renew_MouseDown);
            this.Renew.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Renew_MouseUp);
            // 
            // Share
            // 
            this.Share.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Share.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Share.ErrorImage = global::Snake.Properties.Resources.分享;
            this.Share.Image = global::Snake.Properties.Resources.分享;
            this.Share.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Share.InitialImage = global::Snake.Properties.Resources.分享;
            this.Share.Location = new System.Drawing.Point(507, 486);
            this.Share.Name = "Share";
            this.Share.Size = new System.Drawing.Size(50, 50);
            this.Share.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Share.TabIndex = 0;
            this.Share.TabStop = false;
            this.Share.WaitOnLoad = true;
            this.Share.Click += new System.EventHandler(this.Share_Click);
            this.Share.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Share_MouseDown);
            this.Share.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Share_MouseUp);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 562);
            this.ControlBox = false;
            this.Controls.Add(this.GameSpeed);
            this.Controls.Add(this.SpeedDown);
            this.Controls.Add(this.SpeedUp);
            this.Controls.Add(this.GameBKground);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.About);
            this.Controls.Add(this.GameKeyRight);
            this.Controls.Add(this.GameKeyLeft);
            this.Controls.Add(this.GameKeyDown);
            this.Controls.Add(this.GameKeyUp);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Begin);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.Renew);
            this.Controls.Add(this.Share);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贪吃蛇";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBKground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.About)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameKeyRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameKeyLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameKeyDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameKeyUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Begin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Renew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Share)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Share;
        private System.Windows.Forms.PictureBox Renew;
        private System.Windows.Forms.PictureBox Setting;
        private System.Windows.Forms.PictureBox Begin;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox GameKeyUp;
        private System.Windows.Forms.PictureBox GameKeyDown;
        private System.Windows.Forms.PictureBox GameKeyLeft;
        private System.Windows.Forms.PictureBox GameKeyRight;
        private System.Windows.Forms.PictureBox About;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox GameBKground;
        private System.Windows.Forms.Timer GameClock;
        private System.Windows.Forms.PictureBox SpeedUp;
        private System.Windows.Forms.PictureBox SpeedDown;
        private System.Windows.Forms.Label GameSpeed;
    }
}

