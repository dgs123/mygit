﻿namespace MyPhotos
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;   //私有components字段

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
        private void InitializeComponent()                            //窗体初始化代码
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.ctxMenuPhoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageScale = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageStretch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageActual = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageAutoSize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNext = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLast = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPixelData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhotoProps = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlbumProps = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilePrintView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAlbumPos = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBorder = new System.Windows.Forms.ToolStripDropDownButton();
            this.boderSunkenInner = new System.Windows.Forms.ToolStripMenuItem();
            this.borderSunken = new System.Windows.Forms.ToolStripMenuItem();
            this.borderRaisedOuter = new System.Windows.Forms.ToolStripMenuItem();
            this.borderRaisedInner = new System.Windows.Forms.ToolStripMenuItem();
            this.borderRaised = new System.Windows.Forms.ToolStripMenuItem();
            this.borderFlat = new System.Windows.Forms.ToolStripMenuItem();
            this.borderEtched = new System.Windows.Forms.ToolStripMenuItem();
            this.borderBump = new System.Windows.Forms.ToolStripMenuItem();
            this.borderAdjust = new System.Windows.Forms.ToolStripMenuItem();
            this.flybyTextProvider = new Manning.MyPhotoControls.FlybyTextProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.ctxMenuPhoto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPhoto.ContextMenuStrip = this.ctxMenuPhoto;
            this.pbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxPhoto.Location = new System.Drawing.Point(0, 24);
            this.pbxPhoto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(505, 496);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 1;
            this.pbxPhoto.TabStop = false;
            this.pbxPhoto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbxPhoto_MouseMove);
            // 
            // ctxMenuPhoto
            // 
            this.ctxMenuPhoto.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImage,
            this.menuNext,
            this.menuPrevious,
            this.toolStripSeparator1,
            this.menuFirst,
            this.menuLast,
            this.toolStripMenuItem1,
            this.menuPixelData,
            this.menuPhotoProps,
            this.menuAlbumProps});
            this.ctxMenuPhoto.Name = "ctxMenuPhoto";
            this.ctxMenuPhoto.OwnerItem = this.menuView;
            this.ctxMenuPhoto.Size = new System.Drawing.Size(204, 192);
            this.ctxMenuPhoto.Opening += new System.ComponentModel.CancelEventHandler(this.CtxMenuPhoto_Opening);
            // 
            // menuImage
            // 
            this.menuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImageScale,
            this.menuImageStretch,
            this.menuImageActual,
            this.menuImageCenter,
            this.menuImageAutoSize});
            this.flybyTextProvider.SetFlybyText(this.menuImage, null);
            this.menuImage.Name = "menuImage";
            this.menuImage.Size = new System.Drawing.Size(203, 22);
            this.menuImage.Text = "&Image";
            this.menuImage.DropDownOpening += new System.EventHandler(this.MenuImage_DropDownOpening);
            this.menuImage.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuImage_DropDownItemClicked);
            // 
            // menuImageScale
            // 
            this.menuImageScale.Checked = true;
            this.menuImageScale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flybyTextProvider.SetFlybyText(this.menuImageScale, null);
            this.menuImageScale.Name = "menuImageScale";
            this.menuImageScale.Size = new System.Drawing.Size(155, 22);
            this.menuImageScale.Tag = "Zoom";
            this.menuImageScale.Text = "&Scale to Fit";
            // 
            // menuImageStretch
            // 
            this.flybyTextProvider.SetFlybyText(this.menuImageStretch, null);
            this.menuImageStretch.Name = "menuImageStretch";
            this.menuImageStretch.Size = new System.Drawing.Size(155, 22);
            this.menuImageStretch.Tag = "StretchImage";
            this.menuImageStretch.Text = "S&tretch to Fit";
            // 
            // menuImageActual
            // 
            this.flybyTextProvider.SetFlybyText(this.menuImageActual, null);
            this.menuImageActual.Name = "menuImageActual";
            this.menuImageActual.Size = new System.Drawing.Size(155, 22);
            this.menuImageActual.Tag = "Normal";
            this.menuImageActual.Text = "&Actual Size";
            // 
            // menuImageCenter
            // 
            this.flybyTextProvider.SetFlybyText(this.menuImageCenter, null);
            this.menuImageCenter.Name = "menuImageCenter";
            this.menuImageCenter.Size = new System.Drawing.Size(155, 22);
            this.menuImageCenter.Tag = "CenterImage";
            this.menuImageCenter.Text = "&Center Image";
            // 
            // menuImageAutoSize
            // 
            this.flybyTextProvider.SetFlybyText(this.menuImageAutoSize, null);
            this.menuImageAutoSize.Name = "menuImageAutoSize";
            this.menuImageAutoSize.Size = new System.Drawing.Size(155, 22);
            this.menuImageAutoSize.Tag = "AutoSize";
            this.menuImageAutoSize.Text = "A&uto Size";
            // 
            // menuNext
            // 
            this.flybyTextProvider.SetFlybyText(this.menuNext, null);
            this.menuNext.Name = "menuNext";
            this.menuNext.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.menuNext.Size = new System.Drawing.Size(203, 22);
            this.menuNext.Text = "&Next";
            this.menuNext.Click += new System.EventHandler(this.MenuNext_Click);
            // 
            // menuPrevious
            // 
            this.flybyTextProvider.SetFlybyText(this.menuPrevious, null);
            this.menuPrevious.Name = "menuPrevious";
            this.menuPrevious.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.menuPrevious.Size = new System.Drawing.Size(203, 22);
            this.menuPrevious.Text = "&Previous";
            this.menuPrevious.Click += new System.EventHandler(this.MenuPrevious_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // menuFirst
            // 
            this.flybyTextProvider.SetFlybyText(this.menuFirst, null);
            this.menuFirst.Name = "menuFirst";
            this.menuFirst.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.menuFirst.Size = new System.Drawing.Size(203, 22);
            this.menuFirst.Text = "&First";
            this.menuFirst.Click += new System.EventHandler(this.MenuFirst_Click);
            // 
            // menuLast
            // 
            this.flybyTextProvider.SetFlybyText(this.menuLast, null);
            this.menuLast.Name = "menuLast";
            this.menuLast.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.menuLast.Size = new System.Drawing.Size(203, 22);
            this.menuLast.Text = "&Last";
            this.menuLast.Click += new System.EventHandler(this.MenuLast_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(200, 6);
            // 
            // menuPixelData
            // 
            this.flybyTextProvider.SetFlybyText(this.menuPixelData, null);
            this.menuPixelData.Name = "menuPixelData";
            this.menuPixelData.Size = new System.Drawing.Size(203, 22);
            this.menuPixelData.Text = "Pi&xel Data";
            this.menuPixelData.Click += new System.EventHandler(this.MenuPixelData_Click);
            // 
            // menuPhotoProps
            // 
            this.flybyTextProvider.SetFlybyText(this.menuPhotoProps, null);
            this.menuPhotoProps.Name = "menuPhotoProps";
            this.menuPhotoProps.Size = new System.Drawing.Size(203, 22);
            this.menuPhotoProps.Text = "Phot&o Properties";
            this.menuPhotoProps.Click += new System.EventHandler(this.MenuPhotoProps_Click);
            // 
            // menuAlbumProps
            // 
            this.flybyTextProvider.SetFlybyText(this.menuAlbumProps, null);
            this.menuAlbumProps.Name = "menuAlbumProps";
            this.menuAlbumProps.Size = new System.Drawing.Size(203, 22);
            this.menuAlbumProps.Text = "Albu&m Properties";
            this.menuAlbumProps.Click += new System.EventHandler(this.MenuAlbumProps_Click);
            // 
            // menuView
            // 
            this.menuView.DropDown = this.ctxMenuPhoto;
            this.flybyTextProvider.SetFlybyText(this.menuView, null);
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(60, 22);
            this.menuView.Text = "视图(&V)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.toolStripSeparator,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripSeparator2,
            this.menuFilePrint,
            this.menuFilePrintView,
            this.toolStripSeparator3,
            this.menuFileExit});
            this.flybyTextProvider.SetFlybyText(this.menuFile, "The File Menu");
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(58, 22);
            this.menuFile.Text = "文件(&F)";
            // 
            // menuFileNew
            // 
            this.flybyTextProvider.SetFlybyText(this.menuFileNew, null);
            this.menuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("menuFileNew.Image")));
            this.menuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(165, 22);
            this.menuFileNew.Text = "新建(&N)";
            this.menuFileNew.Click += new System.EventHandler(this.MenuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.flybyTextProvider.SetFlybyText(this.menuFileOpen, null);
            this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
            this.menuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(165, 22);
            this.menuFileOpen.Text = "打开(&O)";
            this.menuFileOpen.Click += new System.EventHandler(this.MenuFileOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(162, 6);
            // 
            // menuFileSave
            // 
            this.flybyTextProvider.SetFlybyText(this.menuFileSave, null);
            this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
            this.menuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(165, 22);
            this.menuFileSave.Text = "保存(&S)";
            this.menuFileSave.Click += new System.EventHandler(this.MenuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.flybyTextProvider.SetFlybyText(this.menuFileSaveAs, null);
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(165, 22);
            this.menuFileSaveAs.Text = "另存为(&A)";
            this.menuFileSaveAs.Click += new System.EventHandler(this.MenuFileSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
            // 
            // menuFilePrint
            // 
            this.flybyTextProvider.SetFlybyText(this.menuFilePrint, null);
            this.menuFilePrint.Image = ((System.Drawing.Image)(resources.GetObject("menuFilePrint.Image")));
            this.menuFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFilePrint.Name = "menuFilePrint";
            this.menuFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuFilePrint.Size = new System.Drawing.Size(165, 22);
            this.menuFilePrint.Text = "打印(&P)";
            // 
            // menuFilePrintView
            // 
            this.flybyTextProvider.SetFlybyText(this.menuFilePrintView, null);
            this.menuFilePrintView.Image = ((System.Drawing.Image)(resources.GetObject("menuFilePrintView.Image")));
            this.menuFilePrintView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFilePrintView.Name = "menuFilePrintView";
            this.menuFilePrintView.Size = new System.Drawing.Size(165, 22);
            this.menuFilePrintView.Text = "打印预览(&V)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
            // 
            // menuFileExit
            // 
            this.flybyTextProvider.SetFlybyText(this.menuFileExit, null);
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(165, 22);
            this.menuFileExit.Text = "退出(&X)";
            this.menuFileExit.Click += new System.EventHandler(this.MenuFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.menuEditCut,
            this.menuEditCopy,
            this.menuEditPaste,
            this.toolStripSeparator5,
            this.menuEditAdd,
            this.menuEditRemove});
            this.flybyTextProvider.SetFlybyText(this.menuEdit, null);
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(59, 22);
            this.menuEdit.Text = "编辑(&E)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // menuEditCut
            // 
            this.flybyTextProvider.SetFlybyText(this.menuEditCut, null);
            this.menuEditCut.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCut.Image")));
            this.menuEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCut.Name = "menuEditCut";
            this.menuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuEditCut.Size = new System.Drawing.Size(195, 22);
            this.menuEditCut.Text = "剪切(&T)";
            this.menuEditCut.Click += new System.EventHandler(this.menu_NotImplementd);
            // 
            // menuEditCopy
            // 
            this.flybyTextProvider.SetFlybyText(this.menuEditCopy, null);
            this.menuEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCopy.Image")));
            this.menuEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditCopy.Name = "menuEditCopy";
            this.menuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuEditCopy.Size = new System.Drawing.Size(195, 22);
            this.menuEditCopy.Text = "复制(&C)";
            this.menuEditCopy.Click += new System.EventHandler(this.menu_NotImplementd);
            // 
            // menuEditPaste
            // 
            this.flybyTextProvider.SetFlybyText(this.menuEditPaste, null);
            this.menuEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("menuEditPaste.Image")));
            this.menuEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditPaste.Name = "menuEditPaste";
            this.menuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuEditPaste.Size = new System.Drawing.Size(195, 22);
            this.menuEditPaste.Text = "粘贴(&P)";
            this.menuEditPaste.Click += new System.EventHandler(this.menu_NotImplementd);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(192, 6);
            // 
            // menuEditAdd
            // 
            this.flybyTextProvider.SetFlybyText(this.menuEditAdd, null);
            this.menuEditAdd.Name = "menuEditAdd";
            this.menuEditAdd.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.menuEditAdd.Size = new System.Drawing.Size(195, 22);
            this.menuEditAdd.Text = "添加(&d)";
            this.menuEditAdd.Click += new System.EventHandler(this.MenuEditAdd_Click);
            // 
            // menuEditRemove
            // 
            this.flybyTextProvider.SetFlybyText(this.menuEditRemove, null);
            this.menuEditRemove.Name = "menuEditRemove";
            this.menuEditRemove.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.menuEditRemove.Size = new System.Drawing.Size(195, 22);
            this.menuEditRemove.Text = "移除(&v)";
            this.menuEditRemove.Click += new System.EventHandler(this.MenuEditRemove_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.flybyTextProvider.SetFlybyText(this.menuHelp, null);
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(61, 22);
            this.menuHelp.Text = "帮助(&H)";
            // 
            // menuHelpAbout
            // 
            this.flybyTextProvider.SetFlybyText(this.menuHelpAbout, null);
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(125, 22);
            this.menuHelpAbout.Text = "关于(&A)...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusInfo,
            this.statusImageSize,
            this.statusAlbumPos,
            this.statusBorder});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(505, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusInfo
            // 
            this.statusInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(36, 21);
            this.statusInfo.Text = "Desc";
            this.statusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusImageSize
            // 
            this.statusImageSize.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusImageSize.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.statusImageSize.Name = "statusImageSize";
            this.statusImageSize.Size = new System.Drawing.Size(47, 21);
            this.statusImageSize.Text = "W x H";
            // 
            // statusAlbumPos
            // 
            this.statusAlbumPos.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusAlbumPos.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.statusAlbumPos.Name = "statusAlbumPos";
            this.statusAlbumPos.Size = new System.Drawing.Size(31, 21);
            this.statusAlbumPos.Text = "1/1";
            // 
            // statusBorder
            // 
            this.statusBorder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boderSunkenInner,
            this.borderSunken,
            this.borderRaisedOuter,
            this.borderRaisedInner,
            this.borderRaised,
            this.borderFlat,
            this.borderEtched,
            this.borderBump,
            this.borderAdjust});
            this.statusBorder.Image = ((System.Drawing.Image)(resources.GetObject("statusBorder.Image")));
            this.statusBorder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.statusBorder.Name = "statusBorder";
            this.statusBorder.Size = new System.Drawing.Size(109, 24);
            this.statusBorder.Text = "Size Border";
            this.statusBorder.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusBorder_DropDownItemClicked);
            // 
            // boderSunkenInner
            // 
            this.flybyTextProvider.SetFlybyText(this.boderSunkenInner, null);
            this.boderSunkenInner.Name = "boderSunkenInner";
            this.boderSunkenInner.Size = new System.Drawing.Size(148, 22);
            this.boderSunkenInner.Tag = "SunkenInner";
            this.boderSunkenInner.Text = "Su&nkenInner";
            // 
            // borderSunken
            // 
            this.flybyTextProvider.SetFlybyText(this.borderSunken, null);
            this.borderSunken.Name = "borderSunken";
            this.borderSunken.Size = new System.Drawing.Size(148, 22);
            this.borderSunken.Tag = "Sunken";
            this.borderSunken.Text = "S&unken";
            // 
            // borderRaisedOuter
            // 
            this.flybyTextProvider.SetFlybyText(this.borderRaisedOuter, null);
            this.borderRaisedOuter.Name = "borderRaisedOuter";
            this.borderRaisedOuter.Size = new System.Drawing.Size(148, 22);
            this.borderRaisedOuter.Tag = "RaiseOuter";
            this.borderRaisedOuter.Text = "Rai&sedOuter";
            // 
            // borderRaisedInner
            // 
            this.flybyTextProvider.SetFlybyText(this.borderRaisedInner, null);
            this.borderRaisedInner.Name = "borderRaisedInner";
            this.borderRaisedInner.Size = new System.Drawing.Size(148, 22);
            this.borderRaisedInner.Tag = "RaisedInner";
            this.borderRaisedInner.Text = "Ra&isedInner";
            // 
            // borderRaised
            // 
            this.flybyTextProvider.SetFlybyText(this.borderRaised, null);
            this.borderRaised.Name = "borderRaised";
            this.borderRaised.Size = new System.Drawing.Size(148, 22);
            this.borderRaised.Tag = "Raised";
            this.borderRaised.Text = "&Raised";
            // 
            // borderFlat
            // 
            this.flybyTextProvider.SetFlybyText(this.borderFlat, null);
            this.borderFlat.Name = "borderFlat";
            this.borderFlat.Size = new System.Drawing.Size(148, 22);
            this.borderFlat.Tag = "Flat";
            this.borderFlat.Text = "&Flat";
            // 
            // borderEtched
            // 
            this.flybyTextProvider.SetFlybyText(this.borderEtched, null);
            this.borderEtched.Name = "borderEtched";
            this.borderEtched.Size = new System.Drawing.Size(148, 22);
            this.borderEtched.Tag = "Etched";
            this.borderEtched.Text = "&Etched";
            // 
            // borderBump
            // 
            this.flybyTextProvider.SetFlybyText(this.borderBump, null);
            this.borderBump.Name = "borderBump";
            this.borderBump.Size = new System.Drawing.Size(148, 22);
            this.borderBump.Tag = "Bump";
            this.borderBump.Text = "&Bump";
            // 
            // borderAdjust
            // 
            this.flybyTextProvider.SetFlybyText(this.borderAdjust, null);
            this.borderAdjust.Name = "borderAdjust";
            this.borderAdjust.Size = new System.Drawing.Size(148, 22);
            this.borderAdjust.Tag = "Adjust";
            this.borderAdjust.Text = "&Adjust";
            // 
            // flybyTextProvider
            // 
            this.flybyTextProvider.StatusLabel = this.statusInfo;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 520);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "MyPhotos";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ctxMenuPhoto.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxPhoto;   //定义图片框控件变量
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip ctxMenuPhoto;
        private System.Windows.Forms.ToolStripMenuItem menuImage;
        private System.Windows.Forms.ToolStripMenuItem menuImageScale;
        private System.Windows.Forms.ToolStripMenuItem menuImageStretch;
        private System.Windows.Forms.ToolStripMenuItem menuImageActual;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuImageCenter;
        private System.Windows.Forms.ToolStripMenuItem menuImageAutoSize;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusInfo;
        private System.Windows.Forms.ToolStripStatusLabel statusImageSize;
        private System.Windows.Forms.ToolStripStatusLabel statusAlbumPos;
        private System.Windows.Forms.ToolStripDropDownButton statusBorder;
        private System.Windows.Forms.ToolStripMenuItem boderSunkenInner;
        private System.Windows.Forms.ToolStripMenuItem borderSunken;
        private System.Windows.Forms.ToolStripMenuItem borderRaisedOuter;
        private System.Windows.Forms.ToolStripMenuItem borderRaisedInner;
        private System.Windows.Forms.ToolStripMenuItem borderRaised;
        private System.Windows.Forms.ToolStripMenuItem borderFlat;
        private System.Windows.Forms.ToolStripMenuItem borderEtched;
        private System.Windows.Forms.ToolStripMenuItem borderBump;
        private System.Windows.Forms.ToolStripMenuItem borderAdjust;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem menuFilePrintView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuEditCut;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem menuEditPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem menuEditAdd;
        private System.Windows.Forms.ToolStripMenuItem menuEditRemove;
        private System.Windows.Forms.ToolStripMenuItem menuNext;
        private System.Windows.Forms.ToolStripMenuItem menuPrevious;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFirst;
        private System.Windows.Forms.ToolStripMenuItem menuLast;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuPixelData;
        private System.Windows.Forms.ToolStripMenuItem menuPhotoProps;
        private System.Windows.Forms.ToolStripMenuItem menuAlbumProps;
        private Manning.MyPhotoControls.FlybyTextProvider flybyTextProvider;
    }
}

