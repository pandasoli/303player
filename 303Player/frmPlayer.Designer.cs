namespace _303Player
{
    partial class frmPlayer
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayer));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMaximize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbTitleIcon = new System.Windows.Forms.PictureBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblTitleHome = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbIconHome = new System.Windows.Forms.PictureBox();
            this.tsTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnMute = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRandom = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRepeat = new Bunifu.Framework.UI.BunifuImageButton();
            this.tcbVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btnMore = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnOpenFile = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.tcbTemp = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnPlayControls = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNextControls = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBackControls = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMore = new System.Windows.Forms.Panel();
            this.guna2VSeparator3 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnFullScreen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLoad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlPlaylist = new System.Windows.Forms.Panel();
            this.lsbPlaylist = new System.Windows.Forms.ListBox();
            this.cxmsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.pnlwmpPause = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wmpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblNotfication2 = new System.Windows.Forms.Label();
            this.lblNotficationLink = new System.Windows.Forms.LinkLabel();
            this.lblNotfication1 = new System.Windows.Forms.Label();
            this.pnlNotfications = new System.Windows.Forms.Panel();
            this.btnClosePnlUpdate = new Bunifu.Framework.UI.BunifuImageButton();
            this.lsMenu = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlaylist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlayer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tmTimer = new System.Windows.Forms.Timer(this.components);
            this.ToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.sfdSavePlaylist = new System.Windows.Forms.SaveFileDialog();
            this.FormShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitleIcon)).BeginInit();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconHome)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNextControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackControls)).BeginInit();
            this.pnlMore.SuspendLayout();
            this.pnlPlaylist.SuspendLayout();
            this.cxmsMenuStrip.SuspendLayout();
            this.pnlPlayer.SuspendLayout();
            this.pnlwmpPause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).BeginInit();
            this.pnlNotfications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePnlUpdate)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.guna2Separator1);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.btnMaximize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.pbTitleIcon);
            this.tsTransition.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(767, 26);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.DoubleClick += new System.EventHandler(this.btnMaximize_Click);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // guna2Separator1
            // 
            this.tsTransition.SetDecoration(this.guna2Separator1, BunifuAnimatorNS.DecorationType.None);
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 24);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(767, 2);
            this.guna2Separator1.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.tsTransition.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(361, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Player";
            this.lblTitle.DoubleClick += new System.EventHandler(this.btnMaximize_Click);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnMaximize.ImageActive")));
            this.btnMaximize.Location = new System.Drawing.Point(49, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(18, 18);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximize.TabIndex = 0;
            this.btnMaximize.TabStop = false;
            this.ToolTip.SetToolTip(this.btnMaximize, "Zoom");
            this.btnMaximize.Zoom = 0;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageActive")));
            this.btnClose.Location = new System.Drawing.Point(5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.ToolTip.SetToolTip(this.btnClose, "Close");
            this.btnClose.Zoom = 0;
            this.btnClose.Click += new System.EventHandler(this.btnsTop_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.btnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnMinimize.ImageActive")));
            this.btnMinimize.Location = new System.Drawing.Point(27, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(18, 18);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.ToolTip.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.Zoom = 0;
            this.btnMinimize.Click += new System.EventHandler(this.btnsTop_Click);
            // 
            // pbTitleIcon
            // 
            this.pbTitleIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tsTransition.SetDecoration(this.pbTitleIcon, BunifuAnimatorNS.DecorationType.None);
            this.pbTitleIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbTitleIcon.Image")));
            this.pbTitleIcon.Location = new System.Drawing.Point(330, 3);
            this.pbTitleIcon.Name = "pbTitleIcon";
            this.pbTitleIcon.Size = new System.Drawing.Size(30, 22);
            this.pbTitleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTitleIcon.TabIndex = 3;
            this.pbTitleIcon.TabStop = false;
            this.pbTitleIcon.DoubleClick += new System.EventHandler(this.btnMaximize_Click);
            this.pbTitleIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.pbTitleIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // pnlHome
            // 
            this.pnlHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHome.BackColor = System.Drawing.Color.Transparent;
            this.pnlHome.Controls.Add(this.lblTitleHome);
            this.pnlHome.Controls.Add(this.lblVersion);
            this.pnlHome.Controls.Add(this.label1);
            this.pnlHome.Controls.Add(this.pbIconHome);
            this.tsTransition.SetDecoration(this.pnlHome, BunifuAnimatorNS.DecorationType.None);
            this.pnlHome.Location = new System.Drawing.Point(153, 26);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(614, 444);
            this.pnlHome.TabIndex = 3;
            // 
            // lblTitleHome
            // 
            this.lblTitleHome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTitleHome.AutoSize = true;
            this.tsTransition.SetDecoration(this.lblTitleHome, BunifuAnimatorNS.DecorationType.None);
            this.lblTitleHome.Font = new System.Drawing.Font("Segoe Script", 27.75F);
            this.lblTitleHome.ForeColor = System.Drawing.Color.White;
            this.lblTitleHome.Location = new System.Drawing.Point(229, 245);
            this.lblTitleHome.Name = "lblTitleHome";
            this.lblTitleHome.Size = new System.Drawing.Size(156, 58);
            this.lblTitleHome.TabIndex = 1;
            this.lblTitleHome.Text = "Player";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.tsTransition.SetDecoration(this.lblVersion, BunifuAnimatorNS.DecorationType.None);
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.DimGray;
            this.lblVersion.Location = new System.Drawing.Point(6, 410);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(61, 17);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "Version : ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.tsTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(6, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Created by : Anonymous 303";
            // 
            // pbIconHome
            // 
            this.pbIconHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsTransition.SetDecoration(this.pbIconHome, BunifuAnimatorNS.DecorationType.None);
            this.pbIconHome.Location = new System.Drawing.Point(103, 56);
            this.pbIconHome.Name = "pbIconHome";
            this.pbIconHome.Size = new System.Drawing.Size(394, 260);
            this.pbIconHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconHome.TabIndex = 0;
            this.pbIconHome.TabStop = false;
            // 
            // tsTransition
            // 
            this.tsTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.tsTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.tsTransition.DefaultAnimation = animation2;
            // 
            // pnlControls
            // 
            this.pnlControls.AllowDrop = true;
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.Controls.Add(this.btnMute);
            this.pnlControls.Controls.Add(this.btnRandom);
            this.pnlControls.Controls.Add(this.btnRepeat);
            this.pnlControls.Controls.Add(this.tcbVolume);
            this.pnlControls.Controls.Add(this.btnMore);
            this.pnlControls.Controls.Add(this.btnOpenFile);
            this.pnlControls.Controls.Add(this.lblTemp);
            this.pnlControls.Controls.Add(this.lblVolume);
            this.pnlControls.Controls.Add(this.lblMaxTemp);
            this.pnlControls.Controls.Add(this.tcbTemp);
            this.pnlControls.Controls.Add(this.guna2Separator2);
            this.pnlControls.Controls.Add(this.btnPlayControls);
            this.pnlControls.Controls.Add(this.btnNextControls);
            this.pnlControls.Controls.Add(this.btnBackControls);
            this.tsTransition.SetDecoration(this.pnlControls, BunifuAnimatorNS.DecorationType.None);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.Location = new System.Drawing.Point(153, 382);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(614, 88);
            this.pnlControls.TabIndex = 4;
            this.pnlControls.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlControls_DragDrop);
            this.pnlControls.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlControls_DragEnter);
            // 
            // btnMute
            // 
            this.btnMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMute.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.btnMute, BunifuAnimatorNS.DecorationType.None);
            this.btnMute.Image = ((System.Drawing.Image)(resources.GetObject("btnMute.Image")));
            this.btnMute.ImageActive = null;
            this.btnMute.Location = new System.Drawing.Point(441, 54);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(31, 24);
            this.btnMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMute.TabIndex = 6;
            this.btnMute.TabStop = false;
            this.ToolTip.SetToolTip(this.btnMute, "Mute");
            this.btnMute.Zoom = 0;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRandom.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.btnRandom, BunifuAnimatorNS.DecorationType.None);
            this.btnRandom.Image = global::_303Player.Properties.Resources.Random;
            this.btnRandom.ImageActive = null;
            this.btnRandom.Location = new System.Drawing.Point(87, 37);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(32, 24);
            this.btnRandom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRandom.TabIndex = 6;
            this.btnRandom.TabStop = false;
            this.ToolTip.SetToolTip(this.btnRandom, "Random");
            this.btnRandom.Zoom = 0;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRepeat.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.btnRepeat, BunifuAnimatorNS.DecorationType.None);
            this.btnRepeat.Image = ((System.Drawing.Image)(resources.GetObject("btnRepeat.Image")));
            this.btnRepeat.ImageActive = null;
            this.btnRepeat.Location = new System.Drawing.Point(87, 59);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(32, 25);
            this.btnRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRepeat.TabIndex = 6;
            this.btnRepeat.TabStop = false;
            this.ToolTip.SetToolTip(this.btnRepeat, "Repeat");
            this.btnRepeat.Zoom = 0;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // tcbVolume
            // 
            this.tcbVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsTransition.SetDecoration(this.tcbVolume, BunifuAnimatorNS.DecorationType.None);
            this.tcbVolume.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.tcbVolume.HoverState.Parent = this.tcbVolume;
            this.tcbVolume.IndicateFocus = false;
            this.tcbVolume.Location = new System.Drawing.Point(472, 60);
            this.tcbVolume.Name = "tcbVolume";
            this.tcbVolume.Size = new System.Drawing.Size(116, 14);
            this.tcbVolume.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.tcbVolume.TabIndex = 5;
            this.tcbVolume.ThumbColor = System.Drawing.Color.White;
            this.tcbVolume.Value = 40;
            this.tcbVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tcbVolume_Scroll);
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.btnMore, BunifuAnimatorNS.DecorationType.None);
            this.btnMore.Image = ((System.Drawing.Image)(resources.GetObject("btnMore.Image")));
            this.btnMore.ImageActive = null;
            this.btnMore.Location = new System.Drawing.Point(33, 55);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(24, 27);
            this.btnMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMore.TabIndex = 4;
            this.btnMore.TabStop = false;
            this.ToolTip.SetToolTip(this.btnMore, "More");
            this.btnMore.Zoom = 0;
            this.btnMore.Click += new System.EventHandler(this.btnMenuMore_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenFile.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.btnOpenFile, BunifuAnimatorNS.DecorationType.None);
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.ImageActive")));
            this.btnOpenFile.Location = new System.Drawing.Point(5, 56);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(24, 25);
            this.btnOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.TabStop = false;
            this.ToolTip.SetToolTip(this.btnOpenFile, "Open");
            this.btnOpenFile.Zoom = 0;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.tsTransition.SetDecoration(this.lblTemp, BunifuAnimatorNS.DecorationType.None);
            this.lblTemp.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(1, 6);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(35, 16);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "00:00";
            // 
            // lblVolume
            // 
            this.lblVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolume.AutoSize = true;
            this.tsTransition.SetDecoration(this.lblVolume, BunifuAnimatorNS.DecorationType.None);
            this.lblVolume.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(590, 58);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(20, 16);
            this.lblVolume.TabIndex = 3;
            this.lblVolume.Text = "40";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxTemp.AutoSize = true;
            this.tsTransition.SetDecoration(this.lblMaxTemp, BunifuAnimatorNS.DecorationType.None);
            this.lblMaxTemp.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblMaxTemp.ForeColor = System.Drawing.Color.White;
            this.lblMaxTemp.Location = new System.Drawing.Point(576, 6);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(35, 16);
            this.lblMaxTemp.TabIndex = 3;
            this.lblMaxTemp.Text = "00:00";
            // 
            // tcbTemp
            // 
            this.tcbTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsTransition.SetDecoration(this.tcbTemp, BunifuAnimatorNS.DecorationType.None);
            this.tcbTemp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.tcbTemp.HoverState.Parent = this.tcbTemp;
            this.tcbTemp.IndicateFocus = false;
            this.tcbTemp.Location = new System.Drawing.Point(42, 8);
            this.tcbTemp.Name = "tcbTemp";
            this.tcbTemp.Size = new System.Drawing.Size(528, 12);
            this.tcbTemp.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.tcbTemp.TabIndex = 2;
            this.tcbTemp.ThumbColor = System.Drawing.Color.White;
            this.tcbTemp.Value = 0;
            this.tcbTemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcbTemp_MouseDown);
            this.tcbTemp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tcbTemp_MouseUp);
            // 
            // guna2Separator2
            // 
            this.tsTransition.SetDecoration(this.guna2Separator2, BunifuAnimatorNS.DecorationType.None);
            this.guna2Separator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2Separator2.FillThickness = 2;
            this.guna2Separator2.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(614, 2);
            this.guna2Separator2.TabIndex = 1;
            // 
            // btnPlayControls
            // 
            this.btnPlayControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlayControls.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.btnPlayControls, BunifuAnimatorNS.DecorationType.None);
            this.btnPlayControls.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayControls.Image")));
            this.btnPlayControls.ImageActive = null;
            this.btnPlayControls.Location = new System.Drawing.Point(267, 36);
            this.btnPlayControls.Name = "btnPlayControls";
            this.btnPlayControls.Size = new System.Drawing.Size(79, 47);
            this.btnPlayControls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlayControls.TabIndex = 0;
            this.btnPlayControls.TabStop = false;
            this.btnPlayControls.Zoom = 0;
            this.btnPlayControls.Click += new System.EventHandler(this.btnPlayControls_Click);
            // 
            // btnNextControls
            // 
            this.btnNextControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextControls.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.btnNextControls, BunifuAnimatorNS.DecorationType.None);
            this.btnNextControls.Image = ((System.Drawing.Image)(resources.GetObject("btnNextControls.Image")));
            this.btnNextControls.ImageActive = null;
            this.btnNextControls.Location = new System.Drawing.Point(360, 40);
            this.btnNextControls.Name = "btnNextControls";
            this.btnNextControls.Size = new System.Drawing.Size(77, 45);
            this.btnNextControls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNextControls.TabIndex = 0;
            this.btnNextControls.TabStop = false;
            this.btnNextControls.Zoom = 0;
            this.btnNextControls.Click += new System.EventHandler(this.btnNextControls_Click);
            // 
            // btnBackControls
            // 
            this.btnBackControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackControls.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.btnBackControls, BunifuAnimatorNS.DecorationType.None);
            this.btnBackControls.Image = ((System.Drawing.Image)(resources.GetObject("btnBackControls.Image")));
            this.btnBackControls.ImageActive = null;
            this.btnBackControls.Location = new System.Drawing.Point(176, 40);
            this.btnBackControls.Name = "btnBackControls";
            this.btnBackControls.Size = new System.Drawing.Size(77, 45);
            this.btnBackControls.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBackControls.TabIndex = 0;
            this.btnBackControls.TabStop = false;
            this.btnBackControls.Zoom = 0;
            this.btnBackControls.Click += new System.EventHandler(this.btnBackControls_Click);
            // 
            // pnlMore
            // 
            this.pnlMore.BackColor = System.Drawing.Color.Transparent;
            this.pnlMore.Controls.Add(this.guna2VSeparator3);
            this.pnlMore.Controls.Add(this.guna2VSeparator2);
            this.pnlMore.Controls.Add(this.guna2Separator5);
            this.pnlMore.Controls.Add(this.guna2Separator4);
            this.pnlMore.Controls.Add(this.btnFullScreen);
            this.pnlMore.Controls.Add(this.btnLoad);
            this.pnlMore.Controls.Add(this.btnSave);
            this.tsTransition.SetDecoration(this.pnlMore, BunifuAnimatorNS.DecorationType.None);
            this.pnlMore.Location = new System.Drawing.Point(186, 308);
            this.pnlMore.Name = "pnlMore";
            this.pnlMore.Size = new System.Drawing.Size(85, 132);
            this.pnlMore.TabIndex = 5;
            this.pnlMore.Visible = false;
            // 
            // guna2VSeparator3
            // 
            this.tsTransition.SetDecoration(this.guna2VSeparator3, BunifuAnimatorNS.DecorationType.None);
            this.guna2VSeparator3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2VSeparator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2VSeparator3.FillThickness = 2;
            this.guna2VSeparator3.Location = new System.Drawing.Point(83, 2);
            this.guna2VSeparator3.Name = "guna2VSeparator3";
            this.guna2VSeparator3.Size = new System.Drawing.Size(2, 128);
            this.guna2VSeparator3.TabIndex = 3;
            // 
            // guna2VSeparator2
            // 
            this.tsTransition.SetDecoration(this.guna2VSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.guna2VSeparator2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2VSeparator2.FillThickness = 2;
            this.guna2VSeparator2.Location = new System.Drawing.Point(0, 2);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(2, 128);
            this.guna2VSeparator2.TabIndex = 2;
            // 
            // guna2Separator5
            // 
            this.tsTransition.SetDecoration(this.guna2Separator5, BunifuAnimatorNS.DecorationType.None);
            this.guna2Separator5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2Separator5.FillThickness = 2;
            this.guna2Separator5.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(85, 2);
            this.guna2Separator5.TabIndex = 1;
            // 
            // guna2Separator4
            // 
            this.tsTransition.SetDecoration(this.guna2Separator4, BunifuAnimatorNS.DecorationType.None);
            this.guna2Separator4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2Separator4.FillThickness = 2;
            this.guna2Separator4.Location = new System.Drawing.Point(0, 130);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(85, 2);
            this.guna2Separator4.TabIndex = 0;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Activecolor = System.Drawing.Color.Transparent;
            this.btnFullScreen.BackColor = System.Drawing.Color.Transparent;
            this.btnFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFullScreen.BorderRadius = 0;
            this.btnFullScreen.ButtonText = "Full Scr.";
            this.btnFullScreen.Cursor = System.Windows.Forms.Cursors.Default;
            this.tsTransition.SetDecoration(this.btnFullScreen, BunifuAnimatorNS.DecorationType.None);
            this.btnFullScreen.DisabledColor = System.Drawing.Color.Gray;
            this.btnFullScreen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFullScreen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFullScreen.Iconimage")));
            this.btnFullScreen.Iconimage_right = null;
            this.btnFullScreen.Iconimage_right_Selected = null;
            this.btnFullScreen.Iconimage_Selected = null;
            this.btnFullScreen.IconMarginLeft = 0;
            this.btnFullScreen.IconMarginRight = 0;
            this.btnFullScreen.IconRightVisible = true;
            this.btnFullScreen.IconRightZoom = 0D;
            this.btnFullScreen.IconVisible = true;
            this.btnFullScreen.IconZoom = 34D;
            this.btnFullScreen.IsTab = false;
            this.btnFullScreen.Location = new System.Drawing.Point(-1, 50);
            this.btnFullScreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Normalcolor = System.Drawing.Color.Transparent;
            this.btnFullScreen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnFullScreen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFullScreen.selected = false;
            this.btnFullScreen.Size = new System.Drawing.Size(85, 23);
            this.btnFullScreen.TabIndex = 4;
            this.btnFullScreen.Text = "Full Scr.";
            this.btnFullScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFullScreen.Textcolor = System.Drawing.Color.White;
            this.btnFullScreen.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Activecolor = System.Drawing.Color.Transparent;
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.BorderRadius = 0;
            this.btnLoad.ButtonText = "Load";
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Default;
            this.tsTransition.SetDecoration(this.btnLoad, BunifuAnimatorNS.DecorationType.None);
            this.btnLoad.DisabledColor = System.Drawing.Color.Gray;
            this.btnLoad.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLoad.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLoad.Iconimage")));
            this.btnLoad.Iconimage_right = null;
            this.btnLoad.Iconimage_right_Selected = null;
            this.btnLoad.Iconimage_Selected = null;
            this.btnLoad.IconMarginLeft = 0;
            this.btnLoad.IconMarginRight = 0;
            this.btnLoad.IconRightVisible = true;
            this.btnLoad.IconRightZoom = 0D;
            this.btnLoad.IconVisible = true;
            this.btnLoad.IconZoom = 32D;
            this.btnLoad.IsTab = false;
            this.btnLoad.Location = new System.Drawing.Point(-1, 28);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLoad.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLoad.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLoad.selected = false;
            this.btnLoad.Size = new System.Drawing.Size(85, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoad.Textcolor = System.Drawing.Color.White;
            this.btnLoad.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.tsTransition.SetDecoration(this.btnSave, BunifuAnimatorNS.DecorationType.None);
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 32D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(-1, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(85, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlPlaylist
            // 
            this.pnlPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlaylist.Controls.Add(this.lsbPlaylist);
            this.tsTransition.SetDecoration(this.pnlPlaylist, BunifuAnimatorNS.DecorationType.None);
            this.pnlPlaylist.Location = new System.Drawing.Point(153, 26);
            this.pnlPlaylist.Name = "pnlPlaylist";
            this.pnlPlaylist.Size = new System.Drawing.Size(614, 350);
            this.pnlPlaylist.TabIndex = 6;
            // 
            // lsbPlaylist
            // 
            this.lsbPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lsbPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbPlaylist.ContextMenuStrip = this.cxmsMenuStrip;
            this.tsTransition.SetDecoration(this.lsbPlaylist, BunifuAnimatorNS.DecorationType.None);
            this.lsbPlaylist.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lsbPlaylist.ForeColor = System.Drawing.Color.White;
            this.lsbPlaylist.FormattingEnabled = true;
            this.lsbPlaylist.ItemHeight = 17;
            this.lsbPlaylist.Location = new System.Drawing.Point(2, 2);
            this.lsbPlaylist.Name = "lsbPlaylist";
            this.lsbPlaylist.Size = new System.Drawing.Size(608, 340);
            this.lsbPlaylist.TabIndex = 0;
            this.lsbPlaylist.SelectedIndexChanged += new System.EventHandler(this.lsbPlaylist_SelectedIndexChanged);
            // 
            // cxmsMenuStrip
            // 
            this.tsTransition.SetDecoration(this.cxmsMenuStrip, BunifuAnimatorNS.DecorationType.None);
            this.cxmsMenuStrip.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cxmsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator2,
            this.topMostToolStripMenuItem,
            this.toolStripSeparator4,
            this.repeatToolStripMenuItem,
            this.muteToolStripMenuItem,
            this.toolStripSeparator3,
            this.helpToolStripMenuItem});
            this.cxmsMenuStrip.Name = "cxmsMenuStrip";
            this.cxmsMenuStrip.Size = new System.Drawing.Size(130, 204);
            this.cxmsMenuStrip.Opened += new System.EventHandler(this.cxmsMenuStrip_Opened);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.btnPlayControls_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.CheckOnClick = true;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.topMostToolStripMenuItem.Text = "Top Most";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.topMostToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(126, 6);
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.repeatToolStripMenuItem.Text = "Repeat";
            this.repeatToolStripMenuItem.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // muteToolStripMenuItem
            // 
            this.muteToolStripMenuItem.Name = "muteToolStripMenuItem";
            this.muteToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.muteToolStripMenuItem.Text = "Mute";
            this.muteToolStripMenuItem.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(126, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayer.Controls.Add(this.pnlwmpPause);
            this.pnlPlayer.Controls.Add(this.wmpPlayer);
            this.tsTransition.SetDecoration(this.pnlPlayer, BunifuAnimatorNS.DecorationType.None);
            this.pnlPlayer.Location = new System.Drawing.Point(153, 26);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(614, 349);
            this.pnlPlayer.TabIndex = 7;
            // 
            // pnlwmpPause
            // 
            this.pnlwmpPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlwmpPause.BackColor = System.Drawing.Color.Black;
            this.pnlwmpPause.BorderRadius = 45;
            this.pnlwmpPause.Controls.Add(this.pictureBox1);
            this.tsTransition.SetDecoration(this.pnlwmpPause, BunifuAnimatorNS.DecorationType.None);
            this.pnlwmpPause.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlwmpPause.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlwmpPause.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlwmpPause.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlwmpPause.Location = new System.Drawing.Point(260, 130);
            this.pnlwmpPause.Name = "pnlwmpPause";
            this.pnlwmpPause.ShadowDecoration.Parent = this.pnlwmpPause;
            this.pnlwmpPause.Size = new System.Drawing.Size(93, 93);
            this.pnlwmpPause.TabIndex = 9;
            this.pnlwmpPause.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.tsTransition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // wmpPlayer
            // 
            this.wmpPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmpPlayer.ContextMenuStrip = this.cxmsMenuStrip;
            this.tsTransition.SetDecoration(this.wmpPlayer, BunifuAnimatorNS.DecorationType.None);
            this.wmpPlayer.Enabled = true;
            this.wmpPlayer.Location = new System.Drawing.Point(2, 2);
            this.wmpPlayer.Name = "wmpPlayer";
            this.wmpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPlayer.OcxState")));
            this.wmpPlayer.Size = new System.Drawing.Size(608, 347);
            this.wmpPlayer.TabIndex = 0;
            this.wmpPlayer.MouseDownEvent += new AxWMPLib._WMPOCXEvents_MouseDownEventHandler(this.wmpPlayer_MouseDownEvent);
            // 
            // lblNotfication2
            // 
            this.lblNotfication2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotfication2.AutoSize = true;
            this.tsTransition.SetDecoration(this.lblNotfication2, BunifuAnimatorNS.DecorationType.None);
            this.lblNotfication2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotfication2.Location = new System.Drawing.Point(435, 1);
            this.lblNotfication2.Name = "lblNotfication2";
            this.lblNotfication2.Size = new System.Drawing.Size(82, 17);
            this.lblNotfication2.TabIndex = 8;
            this.lblNotfication2.Text = "the update?";
            // 
            // lblNotficationLink
            // 
            this.lblNotficationLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNotficationLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotficationLink.AutoSize = true;
            this.tsTransition.SetDecoration(this.lblNotficationLink, BunifuAnimatorNS.DecorationType.None);
            this.lblNotficationLink.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotficationLink.LinkColor = System.Drawing.Color.Black;
            this.lblNotficationLink.Location = new System.Drawing.Point(372, 1);
            this.lblNotficationLink.Name = "lblNotficationLink";
            this.lblNotficationLink.Size = new System.Drawing.Size(68, 17);
            this.lblNotficationLink.TabIndex = 7;
            this.lblNotficationLink.TabStop = true;
            this.lblNotficationLink.Text = "download";
            this.ToolTip.SetToolTip(this.lblNotficationLink, "Download update for Player");
            this.lblNotficationLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.lblNotficationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNotficationLink_Click);
            // 
            // lblNotfication1
            // 
            this.lblNotfication1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotfication1.AutoSize = true;
            this.tsTransition.SetDecoration(this.lblNotfication1, BunifuAnimatorNS.DecorationType.None);
            this.lblNotfication1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotfication1.ForeColor = System.Drawing.Color.Black;
            this.lblNotfication1.Location = new System.Drawing.Point(58, 1);
            this.lblNotfication1.Name = "lblNotfication1";
            this.lblNotfication1.Size = new System.Drawing.Size(319, 17);
            this.lblNotfication1.TabIndex = 0;
            this.lblNotfication1.Text = "The player already has a new version, do you want to";
            // 
            // pnlNotfications
            // 
            this.pnlNotfications.BackColor = System.Drawing.Color.Orange;
            this.pnlNotfications.Controls.Add(this.btnClosePnlUpdate);
            this.pnlNotfications.Controls.Add(this.lblNotfication2);
            this.pnlNotfications.Controls.Add(this.lblNotficationLink);
            this.pnlNotfications.Controls.Add(this.lblNotfication1);
            this.tsTransition.SetDecoration(this.pnlNotfications, BunifuAnimatorNS.DecorationType.None);
            this.pnlNotfications.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNotfications.Location = new System.Drawing.Point(153, 26);
            this.pnlNotfications.Name = "pnlNotfications";
            this.pnlNotfications.Size = new System.Drawing.Size(614, 18);
            this.pnlNotfications.TabIndex = 9;
            this.pnlNotfications.Visible = false;
            // 
            // btnClosePnlUpdate
            // 
            this.btnClosePnlUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosePnlUpdate.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.btnClosePnlUpdate, BunifuAnimatorNS.DecorationType.None);
            this.btnClosePnlUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnClosePnlUpdate.Image")));
            this.btnClosePnlUpdate.ImageActive = null;
            this.btnClosePnlUpdate.Location = new System.Drawing.Point(595, 1);
            this.btnClosePnlUpdate.Name = "btnClosePnlUpdate";
            this.btnClosePnlUpdate.Size = new System.Drawing.Size(16, 16);
            this.btnClosePnlUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClosePnlUpdate.TabIndex = 9;
            this.btnClosePnlUpdate.TabStop = false;
            this.ToolTip.SetToolTip(this.btnClosePnlUpdate, "Close Update");
            this.btnClosePnlUpdate.Zoom = 0;
            this.btnClosePnlUpdate.Click += new System.EventHandler(this.btnClosePnlUpdate_Click);
            // 
            // lsMenu
            // 
            this.lsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsTransition.SetDecoration(this.lsMenu, BunifuAnimatorNS.DecorationType.None);
            this.lsMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.lsMenu.FillThickness = 2;
            this.lsMenu.Location = new System.Drawing.Point(5, 31);
            this.lsMenu.Name = "lsMenu";
            this.lsMenu.Size = new System.Drawing.Size(143, 2);
            this.lsMenu.TabIndex = 1;
            // 
            // guna2VSeparator1
            // 
            this.tsTransition.SetDecoration(this.guna2VSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.guna2VSeparator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(151, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(2, 444);
            this.guna2VSeparator1.TabIndex = 6;
            // 
            // pnlLeft
            // 
            this.pnlLeft.AllowDrop = true;
            this.pnlLeft.Controls.Add(this.guna2VSeparator1);
            this.pnlLeft.Controls.Add(this.pictureBox2);
            this.pnlLeft.Controls.Add(this.btnSettings);
            this.pnlLeft.Controls.Add(this.btnPlaylist);
            this.pnlLeft.Controls.Add(this.btnPlayer);
            this.pnlLeft.Controls.Add(this.btnHome);
            this.pnlLeft.Controls.Add(this.lsMenu);
            this.pnlLeft.Controls.Add(this.btnMenu);
            this.tsTransition.SetDecoration(this.pnlLeft, BunifuAnimatorNS.DecorationType.None);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 26);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(153, 444);
            this.pnlLeft.TabIndex = 0;
            this.pnlLeft.Click += new System.EventHandler(this.pnlLeft_Click);
            this.pnlLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlControls_DragDrop);
            this.pnlLeft.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlControls_DragEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(3, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.BorderRadius = 0;
            this.btnSettings.ButtonText = "     Settings";
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.tsTransition.SetDecoration(this.btnSettings, BunifuAnimatorNS.DecorationType.None);
            this.btnSettings.DisabledColor = System.Drawing.Color.Gray;
            this.btnSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSettings.Iconimage = global::_303Player.Properties.Resources.Settings;
            this.btnSettings.Iconimage_right = null;
            this.btnSettings.Iconimage_right_Selected = null;
            this.btnSettings.Iconimage_Selected = null;
            this.btnSettings.IconMarginLeft = 0;
            this.btnSettings.IconMarginRight = 0;
            this.btnSettings.IconRightVisible = true;
            this.btnSettings.IconRightZoom = 0D;
            this.btnSettings.IconVisible = true;
            this.btnSettings.IconZoom = 40D;
            this.btnSettings.IsTab = true;
            this.btnSettings.Location = new System.Drawing.Point(0, 252);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSettings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSettings.selected = false;
            this.btnSettings.Size = new System.Drawing.Size(152, 39);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "     Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSettings.Textcolor = System.Drawing.Color.White;
            this.btnSettings.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Click += new System.EventHandler(this.btnLeftPanel_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlaylist.BorderRadius = 0;
            this.btnPlaylist.ButtonText = "    Playlist";
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Default;
            this.tsTransition.SetDecoration(this.btnPlaylist, BunifuAnimatorNS.DecorationType.None);
            this.btnPlaylist.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlaylist.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlaylist.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Iconimage")));
            this.btnPlaylist.Iconimage_right = null;
            this.btnPlaylist.Iconimage_right_Selected = null;
            this.btnPlaylist.Iconimage_Selected = null;
            this.btnPlaylist.IconMarginLeft = 0;
            this.btnPlaylist.IconMarginRight = 0;
            this.btnPlaylist.IconRightVisible = true;
            this.btnPlaylist.IconRightZoom = 0D;
            this.btnPlaylist.IconVisible = true;
            this.btnPlaylist.IconZoom = 40D;
            this.btnPlaylist.IsTab = true;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 214);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPlaylist.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPlaylist.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPlaylist.selected = false;
            this.btnPlaylist.Size = new System.Drawing.Size(152, 39);
            this.btnPlaylist.TabIndex = 4;
            this.btnPlaylist.Text = "    Playlist";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlaylist.Textcolor = System.Drawing.Color.White;
            this.btnPlaylist.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.Click += new System.EventHandler(this.btnLeftPanel_Click);
            // 
            // btnPlayer
            // 
            this.btnPlayer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnPlayer.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayer.BorderRadius = 0;
            this.btnPlayer.ButtonText = "Player";
            this.btnPlayer.Cursor = System.Windows.Forms.Cursors.Default;
            this.tsTransition.SetDecoration(this.btnPlayer, BunifuAnimatorNS.DecorationType.None);
            this.btnPlayer.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlayer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlayer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPlayer.Iconimage")));
            this.btnPlayer.Iconimage_right = null;
            this.btnPlayer.Iconimage_right_Selected = null;
            this.btnPlayer.Iconimage_Selected = null;
            this.btnPlayer.IconMarginLeft = 0;
            this.btnPlayer.IconMarginRight = 0;
            this.btnPlayer.IconRightVisible = true;
            this.btnPlayer.IconRightZoom = 0D;
            this.btnPlayer.IconVisible = true;
            this.btnPlayer.IconZoom = 62D;
            this.btnPlayer.IsTab = true;
            this.btnPlayer.Location = new System.Drawing.Point(0, 176);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPlayer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPlayer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPlayer.selected = false;
            this.btnPlayer.Size = new System.Drawing.Size(152, 39);
            this.btnPlayer.TabIndex = 3;
            this.btnPlayer.Text = "Player";
            this.btnPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlayer.Textcolor = System.Drawing.Color.White;
            this.btnPlayer.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer.Click += new System.EventHandler(this.btnLeftPanel_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "   Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.tsTransition.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 42D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(0, 138);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(152, 39);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "   Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnLeftPanel_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.tsTransition.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(5, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(27, 23);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.ToolTip.SetToolTip(this.btnMenu, "Menu");
            this.btnMenu.Zoom = 0;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 18;
            this.FormElipse.TargetControl = this;
            // 
            // tmTimer
            // 
            this.tmTimer.Interval = 1000;
            this.tmTimer.Tick += new System.EventHandler(this.tmTimer_Tick);
            // 
            // ToolTip
            // 
            this.ToolTip.AllowLinksHandling = true;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ToolTip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ToolTip.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolTip.ForeColor = System.Drawing.Color.White;
            this.ToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 470);
            this.ContextMenuStrip = this.cxmsMenuStrip;
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlNotfications);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlPlaylist);
            this.Controls.Add(this.pnlMore);
            this.tsTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitleIcon)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconHome)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNextControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackControls)).EndInit();
            this.pnlMore.ResumeLayout(false);
            this.pnlPlaylist.ResumeLayout(false);
            this.cxmsMenuStrip.ResumeLayout(false);
            this.pnlPlayer.ResumeLayout(false);
            this.pnlwmpPause.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).EndInit();
            this.pnlNotfications.ResumeLayout(false);
            this.pnlNotfications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePnlUpdate)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlHome;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximize;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private System.Windows.Forms.Label lblTitle;
        private BunifuAnimatorNS.BunifuTransition tsTransition;
        private System.Windows.Forms.Label lblTitleHome;
        private System.Windows.Forms.PictureBox pbIconHome;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private System.Windows.Forms.Panel pnlControls;
        private Bunifu.Framework.UI.BunifuImageButton btnPlayControls;
        private Bunifu.Framework.UI.BunifuImageButton btnNextControls;
        private Bunifu.Framework.UI.BunifuImageButton btnBackControls;
        private Bunifu.Framework.UI.BunifuImageButton btnOpenFile;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblMaxTemp;
        public Guna.UI2.WinForms.Guna2TrackBar tcbTemp;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Bunifu.Framework.UI.BunifuImageButton btnMute;
        private Bunifu.Framework.UI.BunifuImageButton btnRepeat;
        private Guna.UI2.WinForms.Guna2TrackBar tcbVolume;
        private Bunifu.Framework.UI.BunifuImageButton btnMore;
        private System.Windows.Forms.Panel pnlPlayer;
        public AxWMPLib.AxWindowsMediaPlayer wmpPlayer;
        private System.Windows.Forms.Panel pnlPlaylist;
        private System.Windows.Forms.Panel pnlMore;
        private System.Windows.Forms.ListBox lsbPlaylist;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator3;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnLoad;
        private Bunifu.Framework.UI.BunifuFlatButton btnFullScreen;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Timer tmTimer;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip;
        private System.Windows.Forms.SaveFileDialog sfdSavePlaylist;
        private System.Windows.Forms.ContextMenuStrip cxmsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.PictureBox pbTitleIcon;
        private System.Windows.Forms.Panel pnlNotfications;
        private System.Windows.Forms.Label lblNotfication2;
        private System.Windows.Forms.LinkLabel lblNotficationLink;
        private Bunifu.Framework.UI.BunifuImageButton btnClosePnlUpdate;
        private System.Windows.Forms.Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlaylist;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlayer;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private Guna.UI2.WinForms.Guna2Separator lsMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Guna.UI2.WinForms.Guna2ShadowForm FormShadow;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlwmpPause;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNotfication1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSettings;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnRandom;
    }
}

