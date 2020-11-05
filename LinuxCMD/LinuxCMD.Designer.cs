namespace LinuxCMD
{
    partial class LinuxCmd
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmdBrowser = new System.Windows.Forms.WebBrowser();
            this.cmdSearchStr = new System.Windows.Forms.TextBox();
            this.cmdGroupList = new System.Windows.Forms.ComboBox();
            this.cmdGroupItem = new System.Windows.Forms.ListBox();
            this.btnSearchLoc = new System.Windows.Forms.Button();
            this.btnSearchNet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdBrowser
            // 
            this.cmdBrowser.IsWebBrowserContextMenuEnabled = false;
            this.cmdBrowser.Location = new System.Drawing.Point(183, 2);
            this.cmdBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdBrowser.MinimumSize = new System.Drawing.Size(27, 31);
            this.cmdBrowser.Name = "cmdBrowser";
            this.cmdBrowser.Size = new System.Drawing.Size(600, 560);
            this.cmdBrowser.TabIndex = 0;
            // 
            // cmdSearchStr
            // 
            this.cmdSearchStr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdSearchStr.Location = new System.Drawing.Point(3, 2);
            this.cmdSearchStr.Name = "cmdSearchStr";
            this.cmdSearchStr.Size = new System.Drawing.Size(173, 29);
            this.cmdSearchStr.TabIndex = 1;
            this.cmdSearchStr.Text = "搜索......";
            this.cmdSearchStr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdSearchStr_MouseDown);
            // 
            // cmdGroupList
            // 
            this.cmdGroupList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdGroupList.FormattingEnabled = true;
            this.cmdGroupList.Location = new System.Drawing.Point(3, 79);
            this.cmdGroupList.Name = "cmdGroupList";
            this.cmdGroupList.Size = new System.Drawing.Size(173, 29);
            this.cmdGroupList.TabIndex = 2;
            // 
            // cmdGroupItem
            // 
            this.cmdGroupItem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmdGroupItem.FormattingEnabled = true;
            this.cmdGroupItem.ItemHeight = 21;
            this.cmdGroupItem.Location = new System.Drawing.Point(3, 114);
            this.cmdGroupItem.Name = "cmdGroupItem";
            this.cmdGroupItem.Size = new System.Drawing.Size(173, 445);
            this.cmdGroupItem.TabIndex = 3;
            // 
            // btnSearchLoc
            // 
            this.btnSearchLoc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearchLoc.Location = new System.Drawing.Point(3, 37);
            this.btnSearchLoc.Name = "btnSearchLoc";
            this.btnSearchLoc.Size = new System.Drawing.Size(80, 30);
            this.btnSearchLoc.TabIndex = 4;
            this.btnSearchLoc.Text = "本地";
            this.btnSearchLoc.UseVisualStyleBackColor = true;
            // 
            // btnSearchNet
            // 
            this.btnSearchNet.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearchNet.Location = new System.Drawing.Point(95, 37);
            this.btnSearchNet.Name = "btnSearchNet";
            this.btnSearchNet.Size = new System.Drawing.Size(80, 30);
            this.btnSearchNet.TabIndex = 5;
            this.btnSearchNet.Text = "百度";
            this.btnSearchNet.UseVisualStyleBackColor = true;
            // 
            // LinuxCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnSearchNet);
            this.Controls.Add(this.btnSearchLoc);
            this.Controls.Add(this.cmdGroupItem);
            this.Controls.Add(this.cmdGroupList);
            this.Controls.Add(this.cmdSearchStr);
            this.Controls.Add(this.cmdBrowser);
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::LinuxCMD.Properties.Resources.iconfont_linux;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LinuxCmd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linux命令速查";
            this.Load += new System.EventHandler(this.LinuxCmd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.WebBrowser cmdBrowser;
        private System.Windows.Forms.TextBox cmdSearchStr;
        private System.Windows.Forms.ComboBox cmdGroupList;
        private System.Windows.Forms.ListBox cmdGroupItem;
        private System.Windows.Forms.Button btnSearchLoc;
        private System.Windows.Forms.Button btnSearchNet;
    }
}

