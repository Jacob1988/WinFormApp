namespace ImgeTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.labelLoaderAddr = new System.Windows.Forms.Label();
            this.labelSystemAddr = new System.Windows.Forms.Label();
            this.textBoxLoaderAddr = new System.Windows.Forms.TextBox();
            this.textBoxSystemAddr = new System.Windows.Forms.TextBox();
            this.labelImageSize = new System.Windows.Forms.Label();
            this.textBoxImageSize = new System.Windows.Forms.TextBox();
            this.textBoxBackupAddr = new System.Windows.Forms.TextBox();
            this.labelBackupAddr = new System.Windows.Forms.Label();
            this.checkBoxAllowBackup = new System.Windows.Forms.CheckBox();
            this.openFileDialogLoaderImage = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenLoaderImage = new System.Windows.Forms.Button();
            this.labelLoaderFilePath = new System.Windows.Forms.Label();
            this.labelSystemFilePath = new System.Windows.Forms.Label();
            this.buttonOpenSystemImage = new System.Windows.Forms.Button();
            this.labelBackupFilePath = new System.Windows.Forms.Label();
            this.buttonOpenBackupImage = new System.Windows.Forms.Button();
            this.openFileDialogSystemImage = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogBackupImage = new System.Windows.Forms.OpenFileDialog();
            this.saveImageFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveImageFile = new System.Windows.Forms.Button();
            this.labelSaveImageFilePath = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoaderAddr
            // 
            this.labelLoaderAddr.AutoSize = true;
            this.labelLoaderAddr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLoaderAddr.Location = new System.Drawing.Point(12, 34);
            this.labelLoaderAddr.Name = "labelLoaderAddr";
            this.labelLoaderAddr.Size = new System.Drawing.Size(233, 16);
            this.labelLoaderAddr.TabIndex = 0;
            this.labelLoaderAddr.Text = "Loader Partition Addr: 0x";
            // 
            // labelSystemAddr
            // 
            this.labelSystemAddr.AutoSize = true;
            this.labelSystemAddr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSystemAddr.Location = new System.Drawing.Point(12, 59);
            this.labelSystemAddr.Name = "labelSystemAddr";
            this.labelSystemAddr.Size = new System.Drawing.Size(233, 16);
            this.labelSystemAddr.TabIndex = 1;
            this.labelSystemAddr.Text = "System Partition Addr: 0x";
            // 
            // textBoxLoaderAddr
            // 
            this.textBoxLoaderAddr.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxLoaderAddr.Location = new System.Drawing.Point(241, 33);
            this.textBoxLoaderAddr.MaxLength = 20;
            this.textBoxLoaderAddr.Name = "textBoxLoaderAddr";
            this.textBoxLoaderAddr.Size = new System.Drawing.Size(147, 23);
            this.textBoxLoaderAddr.TabIndex = 2;
            this.textBoxLoaderAddr.Text = "0";
            this.textBoxLoaderAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLoaderAddr_KeyPress);
            // 
            // textBoxSystemAddr
            // 
            this.textBoxSystemAddr.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSystemAddr.Location = new System.Drawing.Point(241, 58);
            this.textBoxSystemAddr.MaxLength = 20;
            this.textBoxSystemAddr.Name = "textBoxSystemAddr";
            this.textBoxSystemAddr.Size = new System.Drawing.Size(147, 23);
            this.textBoxSystemAddr.TabIndex = 3;
            this.textBoxSystemAddr.Text = "200000";
            this.textBoxSystemAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSystemAddr_KeyPress);
            // 
            // labelImageSize
            // 
            this.labelImageSize.AutoSize = true;
            this.labelImageSize.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelImageSize.Location = new System.Drawing.Point(12, 9);
            this.labelImageSize.Name = "labelImageSize";
            this.labelImageSize.Size = new System.Drawing.Size(143, 16);
            this.labelImageSize.TabIndex = 4;
            this.labelImageSize.Text = "Image Size(Mb):";
            // 
            // textBoxImageSize
            // 
            this.textBoxImageSize.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxImageSize.Location = new System.Drawing.Point(241, 8);
            this.textBoxImageSize.MaxLength = 5;
            this.textBoxImageSize.Name = "textBoxImageSize";
            this.textBoxImageSize.Size = new System.Drawing.Size(147, 23);
            this.textBoxImageSize.TabIndex = 5;
            this.textBoxImageSize.Text = "16";
            this.textBoxImageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxImageSize_KeyPress);
            // 
            // textBoxBackupAddr
            // 
            this.textBoxBackupAddr.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBackupAddr.Location = new System.Drawing.Point(241, 83);
            this.textBoxBackupAddr.MaxLength = 20;
            this.textBoxBackupAddr.Name = "textBoxBackupAddr";
            this.textBoxBackupAddr.Size = new System.Drawing.Size(147, 23);
            this.textBoxBackupAddr.TabIndex = 7;
            this.textBoxBackupAddr.Text = "A00000";
            this.textBoxBackupAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBackupAddr_KeyPress);
            // 
            // labelBackupAddr
            // 
            this.labelBackupAddr.AutoSize = true;
            this.labelBackupAddr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBackupAddr.Location = new System.Drawing.Point(12, 84);
            this.labelBackupAddr.Name = "labelBackupAddr";
            this.labelBackupAddr.Size = new System.Drawing.Size(233, 16);
            this.labelBackupAddr.TabIndex = 6;
            this.labelBackupAddr.Text = "Backup Partition Addr: 0x";
            // 
            // checkBoxAllowBackup
            // 
            this.checkBoxAllowBackup.AutoSize = true;
            this.checkBoxAllowBackup.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxAllowBackup.Location = new System.Drawing.Point(394, 70);
            this.checkBoxAllowBackup.Name = "checkBoxAllowBackup";
            this.checkBoxAllowBackup.Size = new System.Drawing.Size(81, 36);
            this.checkBoxAllowBackup.TabIndex = 8;
            this.checkBoxAllowBackup.Text = "Allow\r\nBackup";
            this.checkBoxAllowBackup.UseVisualStyleBackColor = true;
            this.checkBoxAllowBackup.CheckedChanged += new System.EventHandler(this.checkBoxAllowBackup_CheckedChanged);
            // 
            // openFileDialogLoaderImage
            // 
            this.openFileDialogLoaderImage.FileName = "Bootloader.bin";
            this.openFileDialogLoaderImage.Filter = "所有文件|*.*|镜像文件|*.bin|镜像文件|*.bix";
            this.openFileDialogLoaderImage.Title = "Open Loader Image";
            // 
            // buttonOpenLoaderImage
            // 
            this.buttonOpenLoaderImage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOpenLoaderImage.Location = new System.Drawing.Point(12, 103);
            this.buttonOpenLoaderImage.Name = "buttonOpenLoaderImage";
            this.buttonOpenLoaderImage.Size = new System.Drawing.Size(142, 23);
            this.buttonOpenLoaderImage.TabIndex = 9;
            this.buttonOpenLoaderImage.Text = "Open Loader Image";
            this.buttonOpenLoaderImage.UseVisualStyleBackColor = true;
            this.buttonOpenLoaderImage.Click += new System.EventHandler(this.buttonOpenLoaderImage_Click);
            // 
            // labelLoaderFilePath
            // 
            this.labelLoaderFilePath.AutoSize = true;
            this.labelLoaderFilePath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLoaderFilePath.Location = new System.Drawing.Point(160, 106);
            this.labelLoaderFilePath.Name = "labelLoaderFilePath";
            this.labelLoaderFilePath.Size = new System.Drawing.Size(77, 14);
            this.labelLoaderFilePath.TabIndex = 10;
            this.labelLoaderFilePath.Text = "Loader.bin";
            // 
            // labelSystemFilePath
            // 
            this.labelSystemFilePath.AutoSize = true;
            this.labelSystemFilePath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSystemFilePath.Location = new System.Drawing.Point(160, 135);
            this.labelSystemFilePath.Name = "labelSystemFilePath";
            this.labelSystemFilePath.Size = new System.Drawing.Size(77, 14);
            this.labelSystemFilePath.TabIndex = 12;
            this.labelSystemFilePath.Text = "System.bin";
            // 
            // buttonOpenSystemImage
            // 
            this.buttonOpenSystemImage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOpenSystemImage.Location = new System.Drawing.Point(12, 132);
            this.buttonOpenSystemImage.Name = "buttonOpenSystemImage";
            this.buttonOpenSystemImage.Size = new System.Drawing.Size(142, 23);
            this.buttonOpenSystemImage.TabIndex = 11;
            this.buttonOpenSystemImage.Text = "Open System Image";
            this.buttonOpenSystemImage.UseVisualStyleBackColor = true;
            this.buttonOpenSystemImage.Click += new System.EventHandler(this.buttonOpenSystemImage_Click);
            // 
            // labelBackupFilePath
            // 
            this.labelBackupFilePath.AutoSize = true;
            this.labelBackupFilePath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBackupFilePath.Location = new System.Drawing.Point(160, 164);
            this.labelBackupFilePath.Name = "labelBackupFilePath";
            this.labelBackupFilePath.Size = new System.Drawing.Size(77, 14);
            this.labelBackupFilePath.TabIndex = 14;
            this.labelBackupFilePath.Text = "Backup.bin";
            // 
            // buttonOpenBackupImage
            // 
            this.buttonOpenBackupImage.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOpenBackupImage.Location = new System.Drawing.Point(12, 161);
            this.buttonOpenBackupImage.Name = "buttonOpenBackupImage";
            this.buttonOpenBackupImage.Size = new System.Drawing.Size(142, 23);
            this.buttonOpenBackupImage.TabIndex = 13;
            this.buttonOpenBackupImage.Text = "Open Backup Image";
            this.buttonOpenBackupImage.UseVisualStyleBackColor = true;
            this.buttonOpenBackupImage.Click += new System.EventHandler(this.buttonOpenBackupImage_Click);
            // 
            // openFileDialogSystemImage
            // 
            this.openFileDialogSystemImage.FileName = "System.bin";
            this.openFileDialogSystemImage.Filter = "所有文件|*.*|镜像文件|*.bin|镜像文件|*.bix";
            this.openFileDialogSystemImage.Title = "Open System Image";
            // 
            // openFileDialogBackupImage
            // 
            this.openFileDialogBackupImage.FileName = "Backup.bin";
            this.openFileDialogBackupImage.Filter = "所有文件|*.*|镜像文件|*.bin|镜像文件|*.bix";
            this.openFileDialogBackupImage.Title = "Open Backup Image";
            // 
            // saveImageFileDialog
            // 
            this.saveImageFileDialog.FileName = "Image.bin";
            this.saveImageFileDialog.Filter = "所有文件|*.*|镜像文件|*.bin|镜像文件|*.bix";
            this.saveImageFileDialog.Title = "Save Image File";
            // 
            // buttonSaveImageFile
            // 
            this.buttonSaveImageFile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSaveImageFile.Location = new System.Drawing.Point(12, 190);
            this.buttonSaveImageFile.Name = "buttonSaveImageFile";
            this.buttonSaveImageFile.Size = new System.Drawing.Size(142, 23);
            this.buttonSaveImageFile.TabIndex = 15;
            this.buttonSaveImageFile.Text = "SaveImageFile";
            this.buttonSaveImageFile.UseVisualStyleBackColor = true;
            this.buttonSaveImageFile.Click += new System.EventHandler(this.buttonSaveImageFile_Click);
            // 
            // labelSaveImageFilePath
            // 
            this.labelSaveImageFilePath.AutoSize = true;
            this.labelSaveImageFilePath.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSaveImageFilePath.Location = new System.Drawing.Point(160, 193);
            this.labelSaveImageFilePath.Name = "labelSaveImageFilePath";
            this.labelSaveImageFilePath.Size = new System.Drawing.Size(70, 14);
            this.labelSaveImageFilePath.TabIndex = 16;
            this.labelSaveImageFilePath.Text = "Image.bin";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(394, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 222);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSaveImageFilePath);
            this.Controls.Add(this.buttonSaveImageFile);
            this.Controls.Add(this.labelBackupFilePath);
            this.Controls.Add(this.buttonOpenBackupImage);
            this.Controls.Add(this.labelSystemFilePath);
            this.Controls.Add(this.buttonOpenSystemImage);
            this.Controls.Add(this.labelLoaderFilePath);
            this.Controls.Add(this.buttonOpenLoaderImage);
            this.Controls.Add(this.checkBoxAllowBackup);
            this.Controls.Add(this.textBoxBackupAddr);
            this.Controls.Add(this.labelBackupAddr);
            this.Controls.Add(this.textBoxImageSize);
            this.Controls.Add(this.labelImageSize);
            this.Controls.Add(this.textBoxSystemAddr);
            this.Controls.Add(this.textBoxLoaderAddr);
            this.Controls.Add(this.labelSystemAddr);
            this.Controls.Add(this.labelLoaderAddr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "烧片制作工具";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoaderAddr;
        private System.Windows.Forms.Label labelSystemAddr;
        private System.Windows.Forms.TextBox textBoxLoaderAddr;
        private System.Windows.Forms.TextBox textBoxSystemAddr;
        private System.Windows.Forms.Label labelImageSize;
        private System.Windows.Forms.TextBox textBoxImageSize;
        private System.Windows.Forms.TextBox textBoxBackupAddr;
        private System.Windows.Forms.Label labelBackupAddr;
        private System.Windows.Forms.CheckBox checkBoxAllowBackup;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoaderImage;
        private System.Windows.Forms.Button buttonOpenLoaderImage;
        private System.Windows.Forms.Label labelLoaderFilePath;
        private System.Windows.Forms.Label labelSystemFilePath;
        private System.Windows.Forms.Button buttonOpenSystemImage;
        private System.Windows.Forms.Label labelBackupFilePath;
        private System.Windows.Forms.Button buttonOpenBackupImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogSystemImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogBackupImage;
        private System.Windows.Forms.SaveFileDialog saveImageFileDialog;
        private System.Windows.Forms.Button buttonSaveImageFile;
        private System.Windows.Forms.Label labelSaveImageFilePath;
        private System.Windows.Forms.Button button1;
    }
}

