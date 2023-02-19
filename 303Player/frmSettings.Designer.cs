namespace _303Player
{
    partial class frmSettings
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.txbWallpaper = new System.Windows.Forms.TextBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label3 = new System.Windows.Forms.Label();
            this.tcbVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbWith = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbWithout = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dcControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlThemes = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pbThemeOranje = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pbThemeBlue = new System.Windows.Forms.PictureBox();
            this.btnReturn = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlTitleMacOS = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlTitlePersonalized = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pbThemeWhite = new System.Windows.Forms.PictureBox();
            this.pbThemeDark = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SelectTitle = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SelectTheme = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.btnReboot = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.dcControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblVersion = new System.Windows.Forms.Label();
            this.FormShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.tsTransitionThemePanel = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnThemeSelect = new Guna.UI2.WinForms.Guna2Button();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlThemes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThemeOranje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThemeBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThemeWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThemeDark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.guna2Separator1);
            this.tsTransitionThemePanel.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(362, 26);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(157, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 16);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Settings";
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.tsTransitionThemePanel.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageActive")));
            this.btnClose.Location = new System.Drawing.Point(4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.ToolTip.SetToolTip(this.btnClose, "Close");
            this.btnClose.Zoom = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Separator1
            // 
            this.tsTransitionThemePanel.SetDecoration(this.guna2Separator1, BunifuAnimatorNS.DecorationType.None);
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 24);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(362, 2);
            this.guna2Separator1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Background wallpaper";
            // 
            // txbWallpaper
            // 
            this.txbWallpaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txbWallpaper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tsTransitionThemePanel.SetDecoration(this.txbWallpaper, BunifuAnimatorNS.DecorationType.None);
            this.txbWallpaper.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbWallpaper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbWallpaper.Location = new System.Drawing.Point(3, 69);
            this.txbWallpaper.Name = "txbWallpaper";
            this.txbWallpaper.Size = new System.Drawing.Size(166, 15);
            this.txbWallpaper.TabIndex = 3;
            this.txbWallpaper.Text = "Wallpaper";
            this.txbWallpaper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbWallpaper.Enter += new System.EventHandler(this.txbWallpaper_Enter);
            this.txbWallpaper.Leave += new System.EventHandler(this.txbWallpaper_Leave);
            // 
            // guna2Separator2
            // 
            this.tsTransitionThemePanel.SetDecoration(this.guna2Separator2, BunifuAnimatorNS.DecorationType.None);
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2Separator2.Location = new System.Drawing.Point(3, 86);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(166, 1);
            this.guna2Separator2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Favorite volume";
            // 
            // tcbVolume
            // 
            this.tsTransitionThemePanel.SetDecoration(this.tcbVolume, BunifuAnimatorNS.DecorationType.None);
            this.tcbVolume.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.tcbVolume.HoverState.Parent = this.tcbVolume;
            this.tcbVolume.IndicateFocus = false;
            this.tcbVolume.Location = new System.Drawing.Point(12, 152);
            this.tcbVolume.Name = "tcbVolume";
            this.tcbVolume.Size = new System.Drawing.Size(157, 12);
            this.tcbVolume.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.tcbVolume.TabIndex = 6;
            this.tcbVolume.ThumbColor = System.Drawing.Color.White;
            this.tcbVolume.Value = 40;
            this.tcbVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tcbVolume_Scroll);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.lblVolume, BunifuAnimatorNS.DecorationType.None);
            this.lblVolume.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(175, 148);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(20, 16);
            this.lblVolume.TabIndex = 2;
            this.lblVolume.Text = "40";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lateral menu";
            // 
            // rbWith
            // 
            this.rbWith.Animated = true;
            this.rbWith.AutoSize = true;
            this.rbWith.Checked = true;
            this.rbWith.CheckedState.BorderColor = System.Drawing.Color.White;
            this.rbWith.CheckedState.BorderThickness = 1;
            this.rbWith.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.rbWith.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbWith.CheckedState.InnerOffset = -4;
            this.tsTransitionThemePanel.SetDecoration(this.rbWith, BunifuAnimatorNS.DecorationType.None);
            this.rbWith.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWith.ForeColor = System.Drawing.Color.White;
            this.rbWith.Location = new System.Drawing.Point(12, 218);
            this.rbWith.Name = "rbWith";
            this.rbWith.Size = new System.Drawing.Size(50, 20);
            this.rbWith.TabIndex = 7;
            this.rbWith.TabStop = true;
            this.rbWith.Text = "With";
            this.rbWith.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.rbWith.UncheckedState.BorderThickness = 1;
            this.rbWith.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbWith.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbWithout
            // 
            this.rbWithout.Animated = true;
            this.rbWithout.AutoSize = true;
            this.rbWithout.CheckedState.BorderColor = System.Drawing.Color.White;
            this.rbWithout.CheckedState.BorderThickness = 1;
            this.rbWithout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.rbWithout.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbWithout.CheckedState.InnerOffset = -4;
            this.tsTransitionThemePanel.SetDecoration(this.rbWithout, BunifuAnimatorNS.DecorationType.None);
            this.rbWithout.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWithout.ForeColor = System.Drawing.Color.White;
            this.rbWithout.Location = new System.Drawing.Point(81, 218);
            this.rbWithout.Name = "rbWithout";
            this.rbWithout.Size = new System.Drawing.Size(68, 20);
            this.rbWithout.TabIndex = 7;
            this.rbWithout.Text = "Without";
            this.rbWithout.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.rbWithout.UncheckedState.BorderThickness = 1;
            this.rbWithout.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbWithout.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Theme";
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 18;
            this.FormElipse.TargetControl = this;
            // 
            // dcControl
            // 
            this.dcControl.Fixed = true;
            this.dcControl.Horizontal = true;
            this.dcControl.TargetControl = this.pnlTop;
            this.dcControl.Vertical = true;
            // 
            // pnlThemes
            // 
            this.pnlThemes.BackColor = System.Drawing.Color.Transparent;
            this.pnlThemes.Controls.Add(this.label13);
            this.pnlThemes.Controls.Add(this.pbThemeOranje);
            this.pnlThemes.Controls.Add(this.label12);
            this.pnlThemes.Controls.Add(this.pbThemeBlue);
            this.pnlThemes.Controls.Add(this.btnReturn);
            this.pnlThemes.Controls.Add(this.pnlTitleMacOS);
            this.pnlThemes.Controls.Add(this.label11);
            this.pnlThemes.Controls.Add(this.pnlTitlePersonalized);
            this.pnlThemes.Controls.Add(this.pbThemeWhite);
            this.pnlThemes.Controls.Add(this.pbThemeDark);
            this.pnlThemes.Controls.Add(this.label7);
            this.pnlThemes.Controls.Add(this.label9);
            this.pnlThemes.Controls.Add(this.label8);
            this.pnlThemes.Controls.Add(this.label1);
            this.pnlThemes.Controls.Add(this.label6);
            this.pnlThemes.Controls.Add(this.shapeContainer1);
            this.tsTransitionThemePanel.SetDecoration(this.pnlThemes, BunifuAnimatorNS.DecorationType.None);
            this.pnlThemes.Location = new System.Drawing.Point(360, 24);
            this.pnlThemes.Name = "pnlThemes";
            this.pnlThemes.Size = new System.Drawing.Size(362, 413);
            this.pnlThemes.TabIndex = 8;
            this.pnlThemes.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(292, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Oranje";
            // 
            // pbThemeOranje
            // 
            this.pbThemeOranje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(67)))), ((int)(((byte)(31)))));
            this.pbThemeOranje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsTransitionThemePanel.SetDecoration(this.pbThemeOranje, BunifuAnimatorNS.DecorationType.None);
            this.pbThemeOranje.Location = new System.Drawing.Point(282, 49);
            this.pbThemeOranje.Name = "pbThemeOranje";
            this.pbThemeOranje.Size = new System.Drawing.Size(64, 33);
            this.pbThemeOranje.TabIndex = 5;
            this.pbThemeOranje.TabStop = false;
            this.pbThemeOranje.Click += new System.EventHandler(this.ThemeSelector_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(209, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Blue";
            // 
            // pbThemeBlue
            // 
            this.pbThemeBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.pbThemeBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsTransitionThemePanel.SetDecoration(this.pbThemeBlue, BunifuAnimatorNS.DecorationType.None);
            this.pbThemeBlue.Location = new System.Drawing.Point(192, 49);
            this.pbThemeBlue.Name = "pbThemeBlue";
            this.pbThemeBlue.Size = new System.Drawing.Size(64, 33);
            this.pbThemeBlue.TabIndex = 5;
            this.pbThemeBlue.TabStop = false;
            this.pbThemeBlue.Click += new System.EventHandler(this.ThemeSelector_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.tsTransitionThemePanel.SetDecoration(this.btnReturn, BunifuAnimatorNS.DecorationType.None);
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageActive = null;
            this.btnReturn.Location = new System.Drawing.Point(-8, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(57, 23);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReturn.TabIndex = 8;
            this.btnReturn.TabStop = false;
            this.btnReturn.Zoom = 0;
            this.btnReturn.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pnlTitleMacOS
            // 
            this.pnlTitleMacOS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitleMacOS.BackgroundImage")));
            this.pnlTitleMacOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitleMacOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsTransitionThemePanel.SetDecoration(this.pnlTitleMacOS, BunifuAnimatorNS.DecorationType.None);
            this.pnlTitleMacOS.GradientBottomLeft = System.Drawing.Color.Silver;
            this.pnlTitleMacOS.GradientBottomRight = System.Drawing.Color.Silver;
            this.pnlTitleMacOS.GradientTopLeft = System.Drawing.Color.Silver;
            this.pnlTitleMacOS.GradientTopRight = System.Drawing.Color.Silver;
            this.pnlTitleMacOS.Location = new System.Drawing.Point(110, 375);
            this.pnlTitleMacOS.Name = "pnlTitleMacOS";
            this.pnlTitleMacOS.Quality = 10;
            this.pnlTitleMacOS.Size = new System.Drawing.Size(31, 20);
            this.pnlTitleMacOS.TabIndex = 7;
            this.pnlTitleMacOS.Click += new System.EventHandler(this.pbTitle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(155, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Theme";
            // 
            // pnlTitlePersonalized
            // 
            this.pnlTitlePersonalized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitlePersonalized.BackgroundImage")));
            this.pnlTitlePersonalized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitlePersonalized.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsTransitionThemePanel.SetDecoration(this.pnlTitlePersonalized, BunifuAnimatorNS.DecorationType.None);
            this.pnlTitlePersonalized.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlTitlePersonalized.GradientBottomRight = System.Drawing.Color.Lime;
            this.pnlTitlePersonalized.GradientTopLeft = System.Drawing.Color.Yellow;
            this.pnlTitlePersonalized.GradientTopRight = System.Drawing.Color.Red;
            this.pnlTitlePersonalized.Location = new System.Drawing.Point(27, 375);
            this.pnlTitlePersonalized.Name = "pnlTitlePersonalized";
            this.pnlTitlePersonalized.Quality = 10;
            this.pnlTitlePersonalized.Size = new System.Drawing.Size(31, 20);
            this.pnlTitlePersonalized.TabIndex = 7;
            this.pnlTitlePersonalized.Click += new System.EventHandler(this.pbTitle_Click);
            // 
            // pbThemeWhite
            // 
            this.pbThemeWhite.BackColor = System.Drawing.Color.White;
            this.pbThemeWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsTransitionThemePanel.SetDecoration(this.pbThemeWhite, BunifuAnimatorNS.DecorationType.None);
            this.pbThemeWhite.Location = new System.Drawing.Point(102, 49);
            this.pbThemeWhite.Name = "pbThemeWhite";
            this.pbThemeWhite.Size = new System.Drawing.Size(64, 33);
            this.pbThemeWhite.TabIndex = 5;
            this.pbThemeWhite.TabStop = false;
            this.ToolTip.SetToolTip(this.pbThemeWhite, "White Theme");
            this.pbThemeWhite.Click += new System.EventHandler(this.ThemeSelector_Click);
            // 
            // pbThemeDark
            // 
            this.pbThemeDark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsTransitionThemePanel.SetDecoration(this.pbThemeDark, BunifuAnimatorNS.DecorationType.None);
            this.pbThemeDark.Location = new System.Drawing.Point(12, 49);
            this.pbThemeDark.Name = "pbThemeDark";
            this.pbThemeDark.Size = new System.Drawing.Size(64, 33);
            this.pbThemeDark.TabIndex = 5;
            this.pbThemeDark.TabStop = false;
            this.ToolTip.SetToolTip(this.pbThemeDark, "Dark Theme");
            this.pbThemeDark.Click += new System.EventHandler(this.ThemeSelector_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(115, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "White";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(98, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mac OS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Personalized";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title Bar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dark";
            // 
            // shapeContainer1
            // 
            this.tsTransitionThemePanel.SetDecoration(this.shapeContainer1, BunifuAnimatorNS.DecorationType.None);
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.SelectTitle,
            this.SelectTheme});
            this.shapeContainer1.Size = new System.Drawing.Size(362, 413);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // SelectTitle
            // 
            this.SelectTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SelectTitle.BorderWidth = 2;
            this.SelectTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SelectTitle.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SelectTitle.Location = new System.Drawing.Point(24, 372);
            this.SelectTitle.Name = "SelectTitle";
            this.SelectTitle.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SelectTitle.Size = new System.Drawing.Size(37, 26);
            // 
            // SelectTheme
            // 
            this.SelectTheme.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SelectTheme.BorderWidth = 2;
            this.SelectTheme.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SelectTheme.FillGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SelectTheme.Location = new System.Drawing.Point(9, 46);
            this.SelectTheme.Name = "SelectTheme";
            this.SelectTheme.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.SelectTheme.Size = new System.Drawing.Size(70, 39);
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
            // btnReboot
            // 
            this.btnReboot.Activecolor = System.Drawing.Color.Transparent;
            this.btnReboot.BackColor = System.Drawing.Color.Transparent;
            this.btnReboot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReboot.BorderRadius = 0;
            this.btnReboot.ButtonText = "";
            this.btnReboot.Cursor = System.Windows.Forms.Cursors.Default;
            this.tsTransitionThemePanel.SetDecoration(this.btnReboot, BunifuAnimatorNS.DecorationType.None);
            this.btnReboot.DisabledColor = System.Drawing.Color.Gray;
            this.btnReboot.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReboot.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReboot.Iconimage")));
            this.btnReboot.Iconimage_right = null;
            this.btnReboot.Iconimage_right_Selected = null;
            this.btnReboot.Iconimage_Selected = null;
            this.btnReboot.IconMarginLeft = 0;
            this.btnReboot.IconMarginRight = 0;
            this.btnReboot.IconRightVisible = true;
            this.btnReboot.IconRightZoom = 0D;
            this.btnReboot.IconVisible = true;
            this.btnReboot.IconZoom = 40D;
            this.btnReboot.IsTab = false;
            this.btnReboot.Location = new System.Drawing.Point(220, 405);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReboot.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnReboot.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReboot.selected = false;
            this.btnReboot.Size = new System.Drawing.Size(23, 23);
            this.btnReboot.TabIndex = 10;
            this.btnReboot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReboot.Textcolor = System.Drawing.Color.White;
            this.btnReboot.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolTip.SetToolTip(this.btnReboot, "Reboot Player System");
            this.btnReboot.Visible = false;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // dcControl1
            // 
            this.dcControl1.Fixed = true;
            this.dcControl1.Horizontal = true;
            this.dcControl1.TargetControl = this.lblTitle;
            this.dcControl1.Vertical = true;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.tsTransitionThemePanel.SetDecoration(this.lblVersion, BunifuAnimatorNS.DecorationType.None);
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.DimGray;
            this.lblVersion.Location = new System.Drawing.Point(0, 415);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(57, 16);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "lblVersion";
            // 
            // tsTransitionThemePanel
            // 
            this.tsTransitionThemePanel.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.tsTransitionThemePanel.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.tsTransitionThemePanel.DefaultAnimation = animation1;
            // 
            // btnThemeSelect
            // 
            this.btnThemeSelect.Animated = true;
            this.btnThemeSelect.CheckedState.Parent = this.btnThemeSelect;
            this.btnThemeSelect.CustomImages.Parent = this.btnThemeSelect;
            this.tsTransitionThemePanel.SetDecoration(this.btnThemeSelect, BunifuAnimatorNS.DecorationType.None);
            this.btnThemeSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnThemeSelect.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemeSelect.ForeColor = System.Drawing.Color.White;
            this.btnThemeSelect.HoverState.Parent = this.btnThemeSelect;
            this.btnThemeSelect.Location = new System.Drawing.Point(44, 282);
            this.btnThemeSelect.Name = "btnThemeSelect";
            this.btnThemeSelect.ShadowDecoration.Parent = this.btnThemeSelect;
            this.btnThemeSelect.Size = new System.Drawing.Size(106, 23);
            this.btnThemeSelect.TabIndex = 11;
            this.btnThemeSelect.Text = "Select";
            this.btnThemeSelect.Click += new System.EventHandler(this.btnThemeSelect_Click);
            // 
            // btnFind
            // 
            this.btnFind.Animated = true;
            this.btnFind.CheckedState.Parent = this.btnFind;
            this.btnFind.CustomImages.Parent = this.btnFind;
            this.tsTransitionThemePanel.SetDecoration(this.btnFind, BunifuAnimatorNS.DecorationType.None);
            this.btnFind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnFind.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.HoverState.Parent = this.btnFind;
            this.btnFind.Location = new System.Drawing.Point(175, 66);
            this.btnFind.Name = "btnFind";
            this.btnFind.ShadowDecoration.Parent = this.btnFind;
            this.btnFind.Size = new System.Drawing.Size(106, 23);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Find...";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.tsTransitionThemePanel.SetDecoration(this.btnSave, BunifuAnimatorNS.DecorationType.None);
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(249, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(362, 435);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnThemeSelect);
            this.Controls.Add(this.pnlThemes);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.rbWithout);
            this.Controls.Add(this.rbWith);
            this.Controls.Add(this.tcbVolume);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.txbWallpaper);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTop);
            this.tsTransitionThemePanel.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlThemes.ResumeLayout(false);
            this.pnlThemes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThemeOranje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThemeBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThemeWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThemeDark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbWallpaper;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TrackBar tcbVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2RadioButton rbWith;
        private Guna.UI2.WinForms.Guna2RadioButton rbWithout;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private Bunifu.Framework.UI.BunifuDragControl dcControl;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip;
        private System.Windows.Forms.Panel pnlThemes;
        private System.Windows.Forms.PictureBox pbThemeWhite;
        private System.Windows.Forms.PictureBox pbThemeDark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private Bunifu.Framework.UI.BunifuDragControl dcControl1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersion;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape SelectTitle;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape SelectTheme;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlTitlePersonalized;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuFlatButton btnReboot;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlTitleMacOS;
        private Bunifu.Framework.UI.BunifuImageButton btnReturn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbThemeOranje;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbThemeBlue;
        private Guna.UI2.WinForms.Guna2ShadowForm FormShadow;
        private BunifuAnimatorNS.BunifuTransition tsTransitionThemePanel;
        private Guna.UI2.WinForms.Guna2Button btnThemeSelect;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnFind;
    }
}