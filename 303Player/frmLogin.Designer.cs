namespace _303Player
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.FormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dcControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dcControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.dcControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ctxmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ctxmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormElipse
            // 
            this.FormElipse.ElipseRadius = 18;
            this.FormElipse.TargetControl = this;
            // 
            // dcControl2
            // 
            this.dcControl2.Fixed = true;
            this.dcControl2.Horizontal = true;
            this.dcControl2.TargetControl = this.label1;
            this.dcControl2.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // dcControl3
            // 
            this.dcControl3.Fixed = true;
            this.dcControl3.Horizontal = true;
            this.dcControl3.TargetControl = this.pictureBox1;
            this.dcControl3.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-69, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Enabled = false;
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2Separator3.FillThickness = 2;
            this.guna2Separator3.Location = new System.Drawing.Point(226, 174);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(291, 2);
            this.guna2Separator3.TabIndex = 0;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Enabled = false;
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2Separator2.FillThickness = 2;
            this.guna2Separator2.Location = new System.Drawing.Point(226, 126);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(291, 2);
            this.guna2Separator2.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Enabled = false;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(226, 85);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(291, 2);
            this.guna2Separator1.TabIndex = 0;
            // 
            // txbPhone
            // 
            this.txbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhone.ForeColor = System.Drawing.Color.DarkGray;
            this.txbPhone.Location = new System.Drawing.Point(226, 155);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(291, 15);
            this.txbPhone.TabIndex = 3;
            this.txbPhone.Text = "Phone";
            this.txbPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPhone.Enter += new System.EventHandler(this.txbs_Enter);
            this.txbPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbs_KeyDown);
            this.txbPhone.Leave += new System.EventHandler(this.txbs_Leave);
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txbEmail.Location = new System.Drawing.Point(226, 107);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(291, 15);
            this.txbEmail.TabIndex = 2;
            this.txbEmail.Text = "Email";
            this.txbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbEmail.Enter += new System.EventHandler(this.txbs_Enter);
            this.txbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbs_KeyDown);
            this.txbEmail.Leave += new System.EventHandler(this.txbs_Leave);
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.ForeColor = System.Drawing.Color.DarkGray;
            this.txbName.Location = new System.Drawing.Point(226, 66);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(291, 15);
            this.txbName.TabIndex = 1;
            this.txbName.Text = "Name";
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbName.Enter += new System.EventHandler(this.txbs_Enter);
            this.txbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbs_KeyDown);
            this.txbName.Leave += new System.EventHandler(this.txbs_Leave);
            // 
            // dcControl1
            // 
            this.dcControl1.Fixed = true;
            this.dcControl1.Horizontal = true;
            this.dcControl1.TargetControl = this;
            this.dcControl1.Vertical = true;
            // 
            // ctxmsMenu
            // 
            this.ctxmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.ctxmsMenu.Name = "ctxmsMenu";
            this.ctxmsMenu.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(377, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(152, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Login";
            this.btnSave.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(538, 289);
            this.ContextMenuStrip = this.ctxmsMenu;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ctxmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse FormElipse;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl dcControl2;
        private Bunifu.Framework.UI.BunifuDragControl dcControl3;
        private Bunifu.Framework.UI.BunifuDragControl dcControl1;
        private System.Windows.Forms.ContextMenuStrip ctxmsMenu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ShadowForm FormShadow;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}