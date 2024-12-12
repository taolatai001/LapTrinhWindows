namespace Lab3_02
{
    partial class frmSoanVanBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoanVanBan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewText = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbVanBan = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.cbxFont = new System.Windows.Forms.ToolStripComboBox();
            this.cbxSize = new System.Windows.Forms.ToolStripComboBox();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItaly = new System.Windows.Forms.ToolStripButton();
            this.btnGachChan = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệToolStripMenuItem,
            this.địnhDạngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệToolStripMenuItem
            // 
            this.hệToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewText,
            this.OpenFile,
            this.saveFile,
            this.thoátToolStripMenuItem});
            this.hệToolStripMenuItem.Name = "hệToolStripMenuItem";
            this.hệToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệToolStripMenuItem.Text = "Hệ thống";
            // 
            // btnNewText
            // 
            this.btnNewText.Image = global::Lab3_02.Properties.Resources.file;
            this.btnNewText.Name = "btnNewText";
            this.btnNewText.Size = new System.Drawing.Size(190, 22);
            this.btnNewText.Text = "Tạo văn bản mới";
            this.btnNewText.Click += new System.EventHandler(this.btnNewText_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Image = global::Lab3_02.Properties.Resources.open_folder;
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(190, 22);
            this.OpenFile.Text = "Mở tập tin";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Image = global::Lab3_02.Properties.Resources.diskette;
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(190, 22);
            this.saveFile.Text = "Lưu nội dung văn bản";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::Lab3_02.Properties.Resources.logout;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // địnhDạngToolStripMenuItem
            // 
            this.địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            this.địnhDạngToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.địnhDạngToolStripMenuItem.Text = "Định dạng";
            this.địnhDạngToolStripMenuItem.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
            // 
            // rtbVanBan
            // 
            this.rtbVanBan.Location = new System.Drawing.Point(0, 138);
            this.rtbVanBan.Name = "rtbVanBan";
            this.rtbVanBan.Size = new System.Drawing.Size(800, 327);
            this.rtbVanBan.TabIndex = 1;
            this.rtbVanBan.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.cbxFont,
            this.cbxSize,
            this.btnBold,
            this.btnItaly,
            this.btnGachChan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // cbxFont
            // 
            this.cbxFont.Name = "cbxFont";
            this.cbxFont.Size = new System.Drawing.Size(121, 25);
            this.cbxFont.SelectedIndexChanged += new System.EventHandler(this.cbxFont_SelectedIndexChanged);
            // 
            // cbxSize
            // 
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(121, 25);
            this.cbxSize.SelectedIndexChanged += new System.EventHandler(this.cbxSize_SelectedIndexChanged);
            this.cbxSize.Click += new System.EventHandler(this.cbxSize_Click);
            // 
            // btnBold
            // 
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(23, 22);
            this.btnBold.Text = "toolStripButton3";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItaly
            // 
            this.btnItaly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItaly.Image = ((System.Drawing.Image)(resources.GetObject("btnItaly.Image")));
            this.btnItaly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItaly.Name = "btnItaly";
            this.btnItaly.Size = new System.Drawing.Size(23, 22);
            this.btnItaly.Text = "toolStripButton4";
            this.btnItaly.Click += new System.EventHandler(this.btnItaly_Click);
            // 
            // btnGachChan
            // 
            this.btnGachChan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGachChan.Image = ((System.Drawing.Image)(resources.GetObject("btnGachChan.Image")));
            this.btnGachChan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGachChan.Name = "btnGachChan";
            this.btnGachChan.Size = new System.Drawing.Size(23, 22);
            this.btnGachChan.Text = "toolStripButton5";
            this.btnGachChan.Click += new System.EventHandler(this.btnGachChan_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // frmSoanVanBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rtbVanBan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSoanVanBan";
            this.Text = "Soạn thảo văn bản";
            this.Load += new System.EventHandler(this.frmSoanVanBan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhDạngToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbVanBan;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem btnNewText;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbxFont;
        private System.Windows.Forms.ToolStripComboBox cbxSize;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItaly;
        private System.Windows.Forms.ToolStripButton btnGachChan;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

