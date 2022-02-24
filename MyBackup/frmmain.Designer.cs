namespace MyBackup
{
    partial class frmmain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.lstSrc = new System.Windows.Forms.ListBox();
            this.lblSources = new System.Windows.Forms.Label();
            this.cmdAddFiles = new System.Windows.Forms.Button();
            this.ImgLst = new System.Windows.Forms.ImageList(this.components);
            this.cmdAddFolder = new System.Windows.Forms.Button();
            this.cmdRemoveItem = new System.Windows.Forms.Button();
            this.cmdClearList = new System.Windows.Forms.Button();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtBackupName = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblBackup = new System.Windows.Forms.Label();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.cmdRun = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TipInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSaveBackup = new System.Windows.Forms.Label();
            this.txtSaveTo = new System.Windows.Forms.TextBox();
            this.cmdSaveZip = new System.Windows.Forms.Button();
            this.cmdAbout = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSrc
            // 
            this.lstSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSrc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSrc.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lstSrc.FormattingEnabled = true;
            this.lstSrc.IntegralHeight = false;
            this.lstSrc.ItemHeight = 25;
            this.lstSrc.Location = new System.Drawing.Point(30, 162);
            this.lstSrc.Name = "lstSrc";
            this.lstSrc.Size = new System.Drawing.Size(643, 188);
            this.lstSrc.TabIndex = 5;
            this.lstSrc.SelectedIndexChanged += new System.EventHandler(this.lstSrc_SelectedIndexChanged);
            // 
            // lblSources
            // 
            this.lblSources.AutoSize = true;
            this.lblSources.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSources.ForeColor = System.Drawing.Color.Black;
            this.lblSources.Location = new System.Drawing.Point(30, 81);
            this.lblSources.Name = "lblSources";
            this.lblSources.Size = new System.Drawing.Size(181, 25);
            this.lblSources.TabIndex = 1;
            this.lblSources.Text = "Backup Files/Folders";
            // 
            // cmdAddFiles
            // 
            this.cmdAddFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAddFiles.FlatAppearance.BorderSize = 0;
            this.cmdAddFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.cmdAddFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAddFiles.ImageIndex = 0;
            this.cmdAddFiles.ImageList = this.ImgLst;
            this.cmdAddFiles.Location = new System.Drawing.Point(149, 116);
            this.cmdAddFiles.Name = "cmdAddFiles";
            this.cmdAddFiles.Size = new System.Drawing.Size(115, 40);
            this.cmdAddFiles.TabIndex = 1;
            this.cmdAddFiles.Text = "Add File";
            this.cmdAddFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAddFiles.UseVisualStyleBackColor = true;
            this.cmdAddFiles.Click += new System.EventHandler(this.cmdAddFiles_Click);
            // 
            // ImgLst
            // 
            this.ImgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLst.ImageStream")));
            this.ImgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLst.Images.SetKeyName(0, "add.png");
            this.ImgLst.Images.SetKeyName(1, "delete.png");
            this.ImgLst.Images.SetKeyName(2, "clear.png");
            this.ImgLst.Images.SetKeyName(3, "save.png");
            this.ImgLst.Images.SetKeyName(4, "load.png");
            this.ImgLst.Images.SetKeyName(5, "run.png");
            this.ImgLst.Images.SetKeyName(6, "about.png");
            // 
            // cmdAddFolder
            // 
            this.cmdAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAddFolder.FlatAppearance.BorderSize = 0;
            this.cmdAddFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.cmdAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAddFolder.ImageIndex = 0;
            this.cmdAddFolder.ImageList = this.ImgLst;
            this.cmdAddFolder.Location = new System.Drawing.Point(278, 116);
            this.cmdAddFolder.Name = "cmdAddFolder";
            this.cmdAddFolder.Size = new System.Drawing.Size(147, 40);
            this.cmdAddFolder.TabIndex = 2;
            this.cmdAddFolder.Text = " Add Folder";
            this.cmdAddFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAddFolder.UseVisualStyleBackColor = true;
            this.cmdAddFolder.Click += new System.EventHandler(this.cmdAddFolder_Click);
            // 
            // cmdRemoveItem
            // 
            this.cmdRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRemoveItem.Enabled = false;
            this.cmdRemoveItem.FlatAppearance.BorderSize = 0;
            this.cmdRemoveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.cmdRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemoveItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRemoveItem.ImageIndex = 1;
            this.cmdRemoveItem.ImageList = this.ImgLst;
            this.cmdRemoveItem.Location = new System.Drawing.Point(431, 116);
            this.cmdRemoveItem.Name = "cmdRemoveItem";
            this.cmdRemoveItem.Size = new System.Drawing.Size(121, 40);
            this.cmdRemoveItem.TabIndex = 3;
            this.cmdRemoveItem.Text = "Remove";
            this.cmdRemoveItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdRemoveItem.UseVisualStyleBackColor = true;
            this.cmdRemoveItem.Click += new System.EventHandler(this.cmdRemoveItem_Click);
            // 
            // cmdClearList
            // 
            this.cmdClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClearList.FlatAppearance.BorderSize = 0;
            this.cmdClearList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.cmdClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClearList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClearList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClearList.ImageIndex = 2;
            this.cmdClearList.ImageList = this.ImgLst;
            this.cmdClearList.Location = new System.Drawing.Point(577, 116);
            this.cmdClearList.Name = "cmdClearList";
            this.cmdClearList.Size = new System.Drawing.Size(96, 40);
            this.cmdClearList.TabIndex = 4;
            this.cmdClearList.Text = "Clear";
            this.cmdClearList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdClearList.UseVisualStyleBackColor = true;
            this.cmdClearList.Click += new System.EventHandler(this.cmdClearList_Click);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.ForeColor = System.Drawing.Color.DimGray;
            this.lblProject.Location = new System.Drawing.Point(30, 36);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(122, 25);
            this.lblProject.TabIndex = 6;
            this.lblProject.Text = "Project name";
            // 
            // txtBackupName
            // 
            this.txtBackupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupName.Location = new System.Drawing.Point(171, 33);
            this.txtBackupName.Name = "txtBackupName";
            this.txtBackupName.Size = new System.Drawing.Size(461, 26);
            this.txtBackupName.TabIndex = 0;
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSave.FlatAppearance.BorderSize = 0;
            this.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSave.ImageIndex = 3;
            this.cmdSave.ImageList = this.ImgLst;
            this.cmdSave.Location = new System.Drawing.Point(35, 467);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(108, 40);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblBackup
            // 
            this.lblBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBackup.AutoSize = true;
            this.lblBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackup.ForeColor = System.Drawing.Color.Black;
            this.lblBackup.Location = new System.Drawing.Point(30, 436);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(219, 25);
            this.lblBackup.TabIndex = 10;
            this.lblBackup.Text = "Save,Load or Run Project";
            // 
            // cmdLoad
            // 
            this.cmdLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdLoad.FlatAppearance.BorderSize = 0;
            this.cmdLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdLoad.ImageIndex = 4;
            this.cmdLoad.ImageList = this.ImgLst;
            this.cmdLoad.Location = new System.Drawing.Point(149, 467);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(115, 40);
            this.cmdLoad.TabIndex = 8;
            this.cmdLoad.Text = "Load";
            this.cmdLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // cmdRun
            // 
            this.cmdRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdRun.FlatAppearance.BorderSize = 0;
            this.cmdRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.cmdRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRun.ImageIndex = 5;
            this.cmdRun.ImageList = this.ImgLst;
            this.cmdRun.Location = new System.Drawing.Point(270, 467);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(86, 40);
            this.cmdRun.TabIndex = 9;
            this.cmdRun.Text = "Run";
            this.cmdRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdRun.UseVisualStyleBackColor = true;
            this.cmdRun.Click += new System.EventHandler(this.cmdRun_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TipInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 521);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(699, 30);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TipInfo
            // 
            this.TipInfo.Name = "TipInfo";
            this.TipInfo.Size = new System.Drawing.Size(94, 25);
            this.TipInfo.Text = "Status: Ide";
            // 
            // lblSaveBackup
            // 
            this.lblSaveBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaveBackup.AutoSize = true;
            this.lblSaveBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveBackup.ForeColor = System.Drawing.Color.Black;
            this.lblSaveBackup.Location = new System.Drawing.Point(30, 360);
            this.lblSaveBackup.Name = "lblSaveBackup";
            this.lblSaveBackup.Size = new System.Drawing.Size(143, 25);
            this.lblSaveBackup.TabIndex = 14;
            this.lblSaveBackup.Text = "Backup location";
            // 
            // txtSaveTo
            // 
            this.txtSaveTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaveTo.Location = new System.Drawing.Point(30, 389);
            this.txtSaveTo.Name = "txtSaveTo";
            this.txtSaveTo.Size = new System.Drawing.Size(563, 26);
            this.txtSaveTo.TabIndex = 6;
            this.txtSaveTo.WordWrap = false;
            // 
            // cmdSaveZip
            // 
            this.cmdSaveZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSaveZip.FlatAppearance.BorderSize = 0;
            this.cmdSaveZip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.cmdSaveZip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSaveZip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaveZip.Location = new System.Drawing.Point(605, 387);
            this.cmdSaveZip.Name = "cmdSaveZip";
            this.cmdSaveZip.Size = new System.Drawing.Size(57, 32);
            this.cmdSaveZip.TabIndex = 18;
            this.cmdSaveZip.Text = ". . .";
            this.cmdSaveZip.UseVisualStyleBackColor = true;
            this.cmdSaveZip.Click += new System.EventHandler(this.cmdSaveZip_Click);
            // 
            // cmdAbout
            // 
            this.cmdAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAbout.FlatAppearance.BorderSize = 0;
            this.cmdAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.cmdAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAbout.ImageIndex = 6;
            this.cmdAbout.ImageList = this.ImgLst;
            this.cmdAbout.Location = new System.Drawing.Point(571, 467);
            this.cmdAbout.Name = "cmdAbout";
            this.cmdAbout.Size = new System.Drawing.Size(102, 40);
            this.cmdAbout.TabIndex = 10;
            this.cmdAbout.Text = "About";
            this.cmdAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAbout.UseVisualStyleBackColor = true;
            this.cmdAbout.Click += new System.EventHandler(this.cmdAbout_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 551);
            this.Controls.Add(this.cmdAbout);
            this.Controls.Add(this.cmdSaveZip);
            this.Controls.Add(this.txtSaveTo);
            this.Controls.Add(this.lblSaveBackup);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdRun);
            this.Controls.Add(this.cmdLoad);
            this.Controls.Add(this.lblBackup);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.txtBackupName);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.cmdClearList);
            this.Controls.Add(this.cmdRemoveItem);
            this.Controls.Add(this.cmdAddFolder);
            this.Controls.Add(this.cmdAddFiles);
            this.Controls.Add(this.lblSources);
            this.Controls.Add(this.lstSrc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ben\'s First Backup";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSrc;
        private System.Windows.Forms.Label lblSources;
        private System.Windows.Forms.Button cmdAddFiles;
        private System.Windows.Forms.Button cmdAddFolder;
        private System.Windows.Forms.Button cmdRemoveItem;
        private System.Windows.Forms.Button cmdClearList;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtBackupName;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.Button cmdRun;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblSaveBackup;
        private System.Windows.Forms.TextBox txtSaveTo;
        private System.Windows.Forms.Button cmdSaveZip;
        private System.Windows.Forms.ToolStripStatusLabel TipInfo;
        private System.Windows.Forms.ImageList ImgLst;
        private System.Windows.Forms.Button cmdAbout;
    }
}

