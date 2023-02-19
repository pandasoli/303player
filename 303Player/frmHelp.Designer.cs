namespace _303Player
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txbHelpMessage = new System.Windows.Forms.TextBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.ToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.btnSendHelp = new Bunifu.Framework.UI.BunifuImageButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.dcControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dcControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblVersion = new System.Windows.Forms.Label();
            this.FormShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.guna2Separator1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(308, 26);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnMinimize.ImageActive")));
            this.btnMinimize.Location = new System.Drawing.Point(26, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(18, 18);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.ToolTip.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.Zoom = 0;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageActive")));
            this.btnClose.Location = new System.Drawing.Point(4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.ToolTip.SetToolTip(this.btnClose, "Close");
            this.btnClose.Zoom = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Help";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 24);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(308, 2);
            this.guna2Separator1.TabIndex = 0;
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 18;
            this.Elipse.TargetControl = this;
            // 
            // txbHelpMessage
            // 
            this.txbHelpMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txbHelpMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbHelpMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHelpMessage.ForeColor = System.Drawing.Color.White;
            this.txbHelpMessage.Location = new System.Drawing.Point(20, 55);
            this.txbHelpMessage.Multiline = true;
            this.txbHelpMessage.Name = "txbHelpMessage";
            this.txbHelpMessage.Size = new System.Drawing.Size(269, 402);
            this.txbHelpMessage.TabIndex = 1;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2Separator2.FillThickness = 2;
            this.guna2Separator2.Location = new System.Drawing.Point(17, 53);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(275, 2);
            this.guna2Separator2.TabIndex = 2;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2Separator3.FillThickness = 2;
            this.guna2Separator3.Location = new System.Drawing.Point(18, 457);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(273, 2);
            this.guna2Separator3.TabIndex = 3;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(17, 55);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(2, 404);
            this.guna2VSeparator1.TabIndex = 4;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2VSeparator2.FillThickness = 2;
            this.guna2VSeparator2.Location = new System.Drawing.Point(290, 55);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(2, 404);
            this.guna2VSeparator2.TabIndex = 5;
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
            // btnSendHelp
            // 
            this.btnSendHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnSendHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnSendHelp.Image")));
            this.btnSendHelp.ImageActive = null;
            this.btnSendHelp.Location = new System.Drawing.Point(136, 483);
            this.btnSendHelp.Name = "btnSendHelp";
            this.btnSendHelp.Size = new System.Drawing.Size(37, 42);
            this.btnSendHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSendHelp.TabIndex = 6;
            this.btnSendHelp.TabStop = false;
            this.ToolTip.SetToolTip(this.btnSendHelp, "Send your Help");
            this.btnSendHelp.Zoom = 0;
            this.btnSendHelp.Click += new System.EventHandler(this.btnSendHelp_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Send";
            this.notifyIcon.Visible = true;
            // 
            // dcControl1
            // 
            this.dcControl1.Fixed = true;
            this.dcControl1.Horizontal = true;
            this.dcControl1.TargetControl = this.label1;
            this.dcControl1.Vertical = true;
            // 
            // dcControl
            // 
            this.dcControl.Fixed = true;
            this.dcControl.Horizontal = true;
            this.dcControl.TargetControl = this.pnlTop;
            this.dcControl.Vertical = true;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.DimGray;
            this.lblVersion.Location = new System.Drawing.Point(0, 518);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(57, 16);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "lblVersion";
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(308, 537);
            this.Controls.Add(this.btnSendHelp);
            this.Controls.Add(this.guna2VSeparator2);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.txbHelpMessage);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHelp";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip;
        private Bunifu.Framework.UI.BunifuImageButton btnSendHelp;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.TextBox txbHelpMessage;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private Bunifu.Framework.UI.BunifuDragControl dcControl1;
        private Bunifu.Framework.UI.BunifuDragControl dcControl;
        private System.Windows.Forms.Label lblVersion;
        private Guna.UI2.WinForms.Guna2ShadowForm FormShadow;
    }
}