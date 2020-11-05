namespace Snake
{
    partial class Setting
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
            this.SetColor = new System.Windows.Forms.Label();
            this.SetSize = new System.Windows.Forms.Label();
            this.SetWall = new System.Windows.Forms.Label();
            this.SetKing = new System.Windows.Forms.Label();
            this.ChoisecolorDialog = new System.Windows.Forms.ColorDialog();
            this.ChoiseColor = new System.Windows.Forms.Label();
            this.SetOk = new System.Windows.Forms.Button();
            this.ChoiseWall = new System.Windows.Forms.CheckBox();
            this.ChoiseKing = new System.Windows.Forms.CheckBox();
            this.ChoiseSize = new System.Windows.Forms.TextBox();
            this.ChoiseBDSize = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.ChoiseBDSize)).BeginInit();
            this.SuspendLayout();
            // 
            // SetColor
            // 
            this.SetColor.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetColor.ForeColor = System.Drawing.Color.Black;
            this.SetColor.Location = new System.Drawing.Point(14, 14);
            this.SetColor.Margin = new System.Windows.Forms.Padding(5);
            this.SetColor.Name = "SetColor";
            this.SetColor.Size = new System.Drawing.Size(60, 30);
            this.SetColor.TabIndex = 1;
            this.SetColor.Text = "颜色";
            this.SetColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SetSize
            // 
            this.SetSize.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetSize.ForeColor = System.Drawing.Color.Black;
            this.SetSize.Location = new System.Drawing.Point(14, 54);
            this.SetSize.Margin = new System.Windows.Forms.Padding(5);
            this.SetSize.Name = "SetSize";
            this.SetSize.Size = new System.Drawing.Size(60, 30);
            this.SetSize.TabIndex = 2;
            this.SetSize.Text = "大小";
            this.SetSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SetWall
            // 
            this.SetWall.Enabled = false;
            this.SetWall.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetWall.ForeColor = System.Drawing.Color.Black;
            this.SetWall.Location = new System.Drawing.Point(14, 94);
            this.SetWall.Margin = new System.Windows.Forms.Padding(5);
            this.SetWall.Name = "SetWall";
            this.SetWall.Size = new System.Drawing.Size(60, 30);
            this.SetWall.TabIndex = 3;
            this.SetWall.Text = "无界";
            this.SetWall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SetKing
            // 
            this.SetKing.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetKing.ForeColor = System.Drawing.Color.Black;
            this.SetKing.Location = new System.Drawing.Point(14, 134);
            this.SetKing.Margin = new System.Windows.Forms.Padding(5);
            this.SetKing.Name = "SetKing";
            this.SetKing.Size = new System.Drawing.Size(60, 30);
            this.SetKing.TabIndex = 4;
            this.SetKing.Text = "无敌";
            this.SetKing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChoiseColor
            // 
            this.ChoiseColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoiseColor.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChoiseColor.ForeColor = System.Drawing.Color.Blue;
            this.ChoiseColor.Location = new System.Drawing.Point(77, 14);
            this.ChoiseColor.Margin = new System.Windows.Forms.Padding(5);
            this.ChoiseColor.Name = "ChoiseColor";
            this.ChoiseColor.Size = new System.Drawing.Size(111, 30);
            this.ChoiseColor.TabIndex = 5;
            this.ChoiseColor.Text = "拾取颜色";
            this.ChoiseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChoiseColor.Click += new System.EventHandler(this.ChoiseColor_Click);
            // 
            // SetOk
            // 
            this.SetOk.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetOk.Location = new System.Drawing.Point(19, 207);
            this.SetOk.Margin = new System.Windows.Forms.Padding(5);
            this.SetOk.Name = "SetOk";
            this.SetOk.Size = new System.Drawing.Size(180, 40);
            this.SetOk.TabIndex = 6;
            this.SetOk.Text = "确定";
            this.SetOk.UseVisualStyleBackColor = true;
            this.SetOk.Click += new System.EventHandler(this.SetOk_Click);
            // 
            // ChoiseWall
            // 
            this.ChoiseWall.Enabled = false;
            this.ChoiseWall.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChoiseWall.ForeColor = System.Drawing.Color.Blue;
            this.ChoiseWall.Location = new System.Drawing.Point(82, 94);
            this.ChoiseWall.Name = "ChoiseWall";
            this.ChoiseWall.Size = new System.Drawing.Size(111, 36);
            this.ChoiseWall.TabIndex = 7;
            this.ChoiseWall.Text = "关闭";
            this.ChoiseWall.UseVisualStyleBackColor = true;
            this.ChoiseWall.CheckedChanged += new System.EventHandler(this.ChoiseWall_CheckedChanged);
            // 
            // ChoiseKing
            // 
            this.ChoiseKing.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChoiseKing.ForeColor = System.Drawing.Color.Blue;
            this.ChoiseKing.Location = new System.Drawing.Point(82, 134);
            this.ChoiseKing.Name = "ChoiseKing";
            this.ChoiseKing.Size = new System.Drawing.Size(111, 30);
            this.ChoiseKing.TabIndex = 8;
            this.ChoiseKing.Text = "关闭";
            this.ChoiseKing.UseVisualStyleBackColor = true;
            this.ChoiseKing.CheckedChanged += new System.EventHandler(this.ChoiseKing_CheckedChanged);
            // 
            // ChoiseSize
            // 
            this.ChoiseSize.Enabled = false;
            this.ChoiseSize.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChoiseSize.Location = new System.Drawing.Point(203, 54);
            this.ChoiseSize.MaxLength = 2;
            this.ChoiseSize.Multiline = true;
            this.ChoiseSize.Name = "ChoiseSize";
            this.ChoiseSize.Size = new System.Drawing.Size(111, 30);
            this.ChoiseSize.TabIndex = 10;
            this.ChoiseSize.Text = "30";
            this.ChoiseSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChoiseSize.Visible = false;
            this.ChoiseSize.WordWrap = false;
            this.ChoiseSize.TextChanged += new System.EventHandler(this.ChoiseSize_TextChanged);
            // 
            // ChoiseBDSize
            // 
            this.ChoiseBDSize.AutoSize = false;
            this.ChoiseBDSize.Location = new System.Drawing.Point(77, 54);
            this.ChoiseBDSize.Maximum = 50;
            this.ChoiseBDSize.Minimum = 1;
            this.ChoiseBDSize.Name = "ChoiseBDSize";
            this.ChoiseBDSize.Size = new System.Drawing.Size(111, 30);
            this.ChoiseBDSize.SmallChange = 5;
            this.ChoiseBDSize.TabIndex = 11;
            this.ChoiseBDSize.TabStop = false;
            this.ChoiseBDSize.TickFrequency = 5;
            this.ChoiseBDSize.Value = 1;
            this.ChoiseBDSize.Scroll += new System.EventHandler(this.ChoiseBDSize_Scroll);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 253);
            this.ControlBox = false;
            this.Controls.Add(this.ChoiseBDSize);
            this.Controls.Add(this.ChoiseSize);
            this.Controls.Add(this.ChoiseKing);
            this.Controls.Add(this.ChoiseWall);
            this.Controls.Add(this.SetOk);
            this.Controls.Add(this.ChoiseColor);
            this.Controls.Add(this.SetKing);
            this.Controls.Add(this.SetWall);
            this.Controls.Add(this.SetSize);
            this.Controls.Add(this.SetColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChoiseBDSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SetColor;
        private System.Windows.Forms.Label SetSize;
        private System.Windows.Forms.Label SetWall;
        private System.Windows.Forms.Label SetKing;
        private System.Windows.Forms.ColorDialog ChoisecolorDialog;
        private System.Windows.Forms.Label ChoiseColor;
        private System.Windows.Forms.Button SetOk;
        private System.Windows.Forms.CheckBox ChoiseWall;
        private System.Windows.Forms.CheckBox ChoiseKing;
        private System.Windows.Forms.TextBox ChoiseSize;
        private System.Windows.Forms.TrackBar ChoiseBDSize;

    }
}