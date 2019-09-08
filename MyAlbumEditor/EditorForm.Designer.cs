namespace MyAlbumEditor
{
    partial class EditorForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAlbums = new System.Windows.Forms.GroupBox();
            this.tcPhotos = new System.Windows.Forms.TabControl();
            this.pagePhotos = new System.Windows.Forms.TabPage();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnPhotoProps = new System.Windows.Forms.Button();
            this.lstPhotos = new System.Windows.Forms.ListBox();
            this.pageDates = new System.Windows.Forms.TabPage();
            this.albumCalendar = new MyAlbumEditor.AlbumCalendar();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.comboAlbums = new System.Windows.Forms.ComboBox();
            this.btnAlbumProps = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pageImages = new System.Windows.Forms.TabPage();
            this.albumImages = new MyAlbumEditor.AlbumImage();
            this.grpAlbums.SuspendLayout();
            this.tcPhotos.SuspendLayout();
            this.pagePhotos.SuspendLayout();
            this.pageDates.SuspendLayout();
            this.pageImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAlbums
            // 
            this.grpAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAlbums.Controls.Add(this.tcPhotos);
            this.grpAlbums.Controls.Add(this.btnBrowse);
            this.grpAlbums.Controls.Add(this.comboAlbums);
            this.grpAlbums.Controls.Add(this.btnAlbumProps);
            this.grpAlbums.Location = new System.Drawing.Point(14, 14);
            this.grpAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAlbums.Name = "grpAlbums";
            this.grpAlbums.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAlbums.Size = new System.Drawing.Size(1107, 750);
            this.grpAlbums.TabIndex = 0;
            this.grpAlbums.TabStop = false;
            this.grpAlbums.Text = "&Albums";
            // 
            // tcPhotos
            // 
            this.tcPhotos.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcPhotos.Controls.Add(this.pagePhotos);
            this.tcPhotos.Controls.Add(this.pageDates);
            this.tcPhotos.Controls.Add(this.pageImages);
            this.tcPhotos.Location = new System.Drawing.Point(8, 68);
            this.tcPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcPhotos.Name = "tcPhotos";
            this.tcPhotos.SelectedIndex = 0;
            this.tcPhotos.Size = new System.Drawing.Size(1083, 654);
            this.tcPhotos.TabIndex = 4;
            this.tcPhotos.SelectedIndexChanged += new System.EventHandler(this.tcPhotos_SelectedIndexChanged);
            // 
            // pagePhotos
            // 
            this.pagePhotos.Controls.Add(this.btnMoveUp);
            this.pagePhotos.Controls.Add(this.btnRemove);
            this.pagePhotos.Controls.Add(this.btnMoveDown);
            this.pagePhotos.Controls.Add(this.btnPhotoProps);
            this.pagePhotos.Controls.Add(this.lstPhotos);
            this.pagePhotos.Location = new System.Drawing.Point(4, 31);
            this.pagePhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pagePhotos.Name = "pagePhotos";
            this.pagePhotos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pagePhotos.Size = new System.Drawing.Size(1075, 619);
            this.pagePhotos.TabIndex = 0;
            this.pagePhotos.Text = "Photos";
            this.pagePhotos.UseVisualStyleBackColor = true;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.Location = new System.Drawing.Point(844, 320);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(196, 46);
            this.btnMoveUp.TabIndex = 8;
            this.btnMoveUp.Text = "Move &Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.BtnMoveUp_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(844, 464);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(196, 46);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveDown.Location = new System.Drawing.Point(844, 388);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(196, 46);
            this.btnMoveDown.TabIndex = 6;
            this.btnMoveDown.Text = "Move &Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.BtnMoveDown_Click);
            // 
            // btnPhotoProps
            // 
            this.btnPhotoProps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhotoProps.Location = new System.Drawing.Point(844, 538);
            this.btnPhotoProps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhotoProps.Name = "btnPhotoProps";
            this.btnPhotoProps.Size = new System.Drawing.Size(196, 46);
            this.btnPhotoProps.TabIndex = 4;
            this.btnPhotoProps.Text = "Propertie&s";
            this.btnPhotoProps.UseVisualStyleBackColor = true;
            this.btnPhotoProps.Click += new System.EventHandler(this.BtnPhotoProps_Click);
            // 
            // lstPhotos
            // 
            this.lstPhotos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstPhotos.FormattingEnabled = true;
            this.lstPhotos.HorizontalScrollbar = true;
            this.lstPhotos.ItemHeight = 15;
            this.lstPhotos.Location = new System.Drawing.Point(10, 10);
            this.lstPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstPhotos.Name = "lstPhotos";
            this.lstPhotos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPhotos.Size = new System.Drawing.Size(804, 580);
            this.lstPhotos.TabIndex = 3;
            this.lstPhotos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LstPhotos_DrawItem);
            this.lstPhotos.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.LstPhotos_MeasureItem);
            // 
            // pageDates
            // 
            this.pageDates.Controls.Add(this.albumCalendar);
            this.pageDates.Location = new System.Drawing.Point(4, 31);
            this.pageDates.Margin = new System.Windows.Forms.Padding(4);
            this.pageDates.Name = "pageDates";
            this.pageDates.Size = new System.Drawing.Size(1075, 619);
            this.pageDates.TabIndex = 1;
            this.pageDates.Text = "Dates";
            this.pageDates.UseVisualStyleBackColor = true;
            // 
            // albumCalendar
            // 
            this.albumCalendar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.albumCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumCalendar.Location = new System.Drawing.Point(0, 0);
            this.albumCalendar.Manager = null;
            this.albumCalendar.Margin = new System.Windows.Forms.Padding(6);
            this.albumCalendar.Name = "albumCalendar";
            this.albumCalendar.Size = new System.Drawing.Size(1075, 619);
            this.albumCalendar.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(840, 30);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(116, 30);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // comboAlbums
            // 
            this.comboAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboAlbums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlbums.DropDownWidth = 400;
            this.comboAlbums.FormattingEnabled = true;
            this.comboAlbums.Location = new System.Drawing.Point(8, 32);
            this.comboAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.comboAlbums.Name = "comboAlbums";
            this.comboAlbums.Size = new System.Drawing.Size(820, 26);
            this.comboAlbums.TabIndex = 2;
            this.comboAlbums.SelectionChangeCommitted += new System.EventHandler(this.ComboAlbums_SelectionChangeCommitted);
            // 
            // btnAlbumProps
            // 
            this.btnAlbumProps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlbumProps.Enabled = false;
            this.btnAlbumProps.Location = new System.Drawing.Point(962, 32);
            this.btnAlbumProps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlbumProps.Name = "btnAlbumProps";
            this.btnAlbumProps.Size = new System.Drawing.Size(129, 30);
            this.btnAlbumProps.TabIndex = 1;
            this.btnAlbumProps.Text = "Propertie&s";
            this.btnAlbumProps.UseVisualStyleBackColor = true;
            this.btnAlbumProps.Click += new System.EventHandler(this.BtnAlbumProps_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(872, 796);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(196, 46);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pageImages
            // 
            this.pageImages.Controls.Add(this.albumImages);
            this.pageImages.Location = new System.Drawing.Point(4, 31);
            this.pageImages.Name = "pageImages";
            this.pageImages.Size = new System.Drawing.Size(1075, 619);
            this.pageImages.TabIndex = 2;
            this.pageImages.Text = "Images";
            this.pageImages.UseVisualStyleBackColor = true;
            // 
            // albumImages
            // 
            this.albumImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumImages.Location = new System.Drawing.Point(0, 0);
            this.albumImages.Name = "albumImages";
            this.albumImages.Padding = new System.Windows.Forms.Padding(5);
            this.albumImages.Size = new System.Drawing.Size(1613, 929);
            this.albumImages.TabIndex = 0;
            // 
            // EditorForm
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 876);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpAlbums);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditorForm";
            this.Text = "Form1";
            this.grpAlbums.ResumeLayout(false);
            this.tcPhotos.ResumeLayout(false);
            this.pagePhotos.ResumeLayout(false);
            this.pageDates.ResumeLayout(false);
            this.pageImages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAlbums;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAlbumProps;
        private System.Windows.Forms.ComboBox comboAlbums;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TabControl tcPhotos;
        private System.Windows.Forms.TabPage pagePhotos;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnPhotoProps;
        private System.Windows.Forms.ListBox lstPhotos;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.TabPage pageDates;
        private AlbumCalendar albumCalendar;
        private System.Windows.Forms.TabPage pageImages;
        private AlbumImage albumImages;
    }
}

