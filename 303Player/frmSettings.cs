using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _303Player
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();

            FormShadow.SetShadowForm(this);
            Theme(Properties.Settings.Default.Theme);
            if (Properties.Settings.Default.Wallpaper != "")
            {
                txbWallpaper.Text = Properties.Settings.Default.Wallpaper;
            }
            lblVolume.Text = Convert.ToString(Properties.Settings.Default.FavoriteVolume);
            tcbVolume.Value = Properties.Settings.Default.FavoriteVolume;

            if (Properties.Settings.Default.LateralMenu == true)
            {
                rbWith.Checked = true;
            }
            else if (Properties.Settings.Default.LateralMenu == false)
            {
                rbWithout.Checked = true;
            }
        }
        Color notSelectTxb = Color.FromArgb(64, 64, 64);

        public void Theme(string Theme)
        {
            if (Theme == "Dark")
            {

            }
            else if (Theme == "White")
            {
                this.BackColor = Color.White;
                ToolTip.BackColor = Color.White;
                ToolTip.BorderColor = Color.Black;
                ToolTip.ForeColor = Color.Black;

                //pnlTitle
                lblTitle.ForeColor = Color.Black;
                guna2Separator1.FillColor = Color.Black;

                //rbs
                rbWith.BackColor = Color.White;
                rbWith.ForeColor = Color.Black;
                rbWith.CheckedState.BorderColor = Color.Black;
                rbWith.CheckedState.FillColor = Color.White;
                rbWith.CheckedState.InnerColor = Color.Black;
                rbWith.UncheckedState.BorderColor = Color.Black;

                rbWithout.BackColor = Color.White;
                rbWithout.ForeColor = Color.Black;
                rbWithout.CheckedState.BorderColor = Color.Black;
                rbWithout.CheckedState.FillColor = Color.White;
                rbWithout.CheckedState.InnerColor = Color.Black;
                rbWithout.UncheckedState.BorderColor = Color.Black;

                //Buttons
                Color Button = Color.FromArgb(0, 120, 215);
                btnFind.BackColor = Button;
                btnFind.ForeColor = Color.White;

                btnThemeSelect.BackColor = Button;
                btnThemeSelect.ForeColor = Color.White;

                btnSave.BackColor = Button;
                btnSave.ForeColor = Color.White;

                btnReboot.Iconimage = Properties.Resources.Load_Dark;

                //Label
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                lblVolume.ForeColor = Color.Black;

                //Resto
                tcbVolume.FillColor = Color.FromArgb(41, 39, 40);
                tcbVolume.ThumbColor = Button;
                guna2Separator2.FillColor = Color.Black;
                txbWallpaper.BackColor = Color.White;

                //pnlTheme
                btnReturn.Image = Properties.Resources.Return_Dark;
                pbThemeDark.BackColor = Color.FromArgb(25, 25, 25);
                guna2Separator1.FillColor = Color.Black;
                guna2Separator2.FillColor = Color.Black;
            }
            else if (Theme == "Blue")
            {
                btnClose.Image = Properties.Resources.CircleButtonBlueTheme;
                btnClose.ImageActive = Properties.Resources.ActiveCircleButtonBlueTheme;

                //Buttons
                btnFind.FillColor = Color.FromArgb(64, 86, 92);
                btnFind.ForeColor = Color.White;
                btnThemeSelect.FillColor = Color.FromArgb(64, 86, 92);
                btnThemeSelect.ForeColor = Color.White;
                btnSave.FillColor = Color.FromArgb(64, 86, 92);
                btnSave.ForeColor = Color.White;

                //Themes
                this.BackColor = Color.FromArgb(0, 43, 54);
                ToolTip.BackColor = Color.FromArgb(0, 43, 54);
                ToolTip.BorderColor = Color.FromArgb(0, 30, 38);
                ToolTip.ForeColor = Color.White;

                SelectTheme.BorderColor = Color.FromArgb(64, 86, 92);
                SelectTheme.FillColor = Color.FromArgb(64, 86, 92);
                SelectTheme.FillGradientColor = Color.FromArgb(64, 86, 92);
                SelectTheme.SelectionColor = Color.FromArgb(64, 86, 92);

                SelectTitle.BorderColor = Color.FromArgb(64, 86, 92);
                SelectTitle.FillColor = Color.FromArgb(64, 86, 92);
                SelectTitle.FillGradientColor = Color.FromArgb(64, 86, 92);
                SelectTitle.SelectionColor = Color.FromArgb(64, 86, 92);

                //pnlTitle
                pnlTop.BackColor = Color.FromArgb(0, 30, 38);
                guna2Separator1.FillColor = Color.FromArgb(0, 30, 38);

                //rbs
                rbWith.ForeColor = Color.White;
                rbWith.CheckedState.BorderColor = Color.White;
                rbWith.CheckedState.FillColor = this.BackColor;
                rbWith.CheckedState.InnerColor = Color.White;
                rbWith.UncheckedState.BorderColor = Color.White;

                rbWithout.ForeColor = Color.White;
                rbWithout.CheckedState.BorderColor = Color.White;
                rbWithout.CheckedState.FillColor = this.BackColor;
                rbWithout.CheckedState.InnerColor = Color.White;
                rbWithout.UncheckedState.BorderColor = Color.White;

                //Resto
                tcbVolume.FillColor = Color.FromArgb(47, 68, 74);
                tcbVolume.ThumbColor = Color.White;
                guna2Separator2.FillColor = Color.FromArgb(0, 30, 38);
                txbWallpaper.BackColor = this.BackColor;
                txbWallpaper.ForeColor = Color.FromArgb(64, 86, 92);
                notSelectTxb = Color.FromArgb(64, 86, 92);

                //pnlTheme
                pbThemeDark.BackColor = Color.FromArgb(25, 25, 25);
            }
            else if (Theme == "Oranje")
            {
                this.BackColor = Color.FromArgb(25, 25, 25);
                ToolTip.BackColor = Color.FromArgb(25, 25, 25);
                ToolTip.BorderColor = Color.FromArgb(21, 21, 21);
                ToolTip.ForeColor = Color.FromArgb(203, 67, 31);

                //pnlTitle
                pnlTop.BackColor = Color.FromArgb(25, 25, 25);
                guna2Separator1.FillColor = Color.FromArgb(21, 21, 21);

                //rbs
                rbWith.ForeColor = Color.White;
                rbWith.CheckedState.BorderColor = Color.White;
                rbWith.CheckedState.FillColor = this.BackColor;
                rbWith.CheckedState.InnerColor = Color.FromArgb(203, 67, 31);
                rbWith.UncheckedState.BorderColor = Color.White;

                rbWithout.ForeColor = Color.White;
                rbWithout.CheckedState.BorderColor = Color.White;
                rbWithout.CheckedState.FillColor = this.BackColor;
                rbWithout.CheckedState.InnerColor = Color.FromArgb(203, 67, 31);
                rbWithout.UncheckedState.BorderColor = Color.White;

                //Resto
                tcbVolume.FillColor = Color.FromArgb(41, 39, 40);
                tcbVolume.ThumbColor = Color.FromArgb(203, 67, 31);
                guna2Separator2.FillColor = Color.FromArgb(21, 21, 21);
                txbWallpaper.BackColor = this.BackColor;

                //pnlTheme
                pbThemeDark.BackColor = Color.FromArgb(25, 25, 25);
            }

            if (Properties.Settings.Default.Title == true)
            {
                btnClose.Image = Properties.Resources.btnClose;
                btnClose.ImageActive = Properties.Resources.btnCloseActive;

                pnlTop.BackColor = Color.FromArgb(192, 192, 192);
                guna2Separator1.FillColor = Color.DarkGray;
                lblTitle.ForeColor = Color.Black;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemeSelect_Click(object sender, EventArgs e)
        {
            pnlThemes.Location = new Point(0, 26);
            pnlThemes.BringToFront();
            if (pnlThemes.Visible == false)
            {
                if (Properties.Settings.Default.Theme == "White") { SelectTheme.Location = new Point(pbThemeWhite.Location.X - 3, pbThemeWhite.Location.Y - 3); }
                if (Properties.Settings.Default.Theme == "Blue") { SelectTheme.Location = new Point(pbThemeBlue.Location.X - 3, pbThemeBlue.Location.Y - 3); }
                if (Properties.Settings.Default.Theme == "Oranje" || Properties.Settings.Default.Theme == "Ubuntu") { SelectTheme.Location = new Point(pbThemeOranje.Location.X - 3, pbThemeOranje.Location.Y - 3); }

                if (Properties.Settings.Default.Title == true)
                {
                    SelectTitle.Location = new Point(pnlTitleMacOS.Location.X - 3, pnlTitleMacOS.Location.Y - 3);
                }
                tsTransitionThemePanel.ShowSync(pnlThemes);
            }
            else { tsTransitionThemePanel.HideSync(pnlThemes); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbWallpaper.Text != "Wallpaper") {
                Properties.Settings.Default.Wallpaper = txbWallpaper.Text;
            }
            else
            {
                Properties.Settings.Default.Wallpaper = "";
            }

            Properties.Settings.Default.LateralMenu = rbWith.Checked;

            Properties.Settings.Default.FavoriteVolume = tcbVolume.Value;
            Properties.Settings.Default.Save();
            btnReboot.Visible = true;
            MessageBox.Show("Saved Successfull!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tcbVolume_Scroll(object sender, ScrollEventArgs e)
        {
            lblVolume.Text = tcbVolume.Value.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ofdOpen.Title = "Open Media";
            ofdOpen.Filter = "Png file|*.png";
            ofdOpen.Multiselect = false;
            if (ofdOpen.ShowDialog() == DialogResult.OK)
            {
                txbWallpaper.Text = ofdOpen.FileName.Substring(2, ofdOpen.FileName.Length - 2);
            }
        }

        private void pbThemes_Click(object sender, EventArgs e)
        {

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            string[] Version = File.ReadAllLines("Version.303");
            lblVersion.Text = "Version " + Version[0];
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Player.exe");
            Application.Exit();
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.Location.Y < 0)
            {
                this.Location = new Point(this.Location.X, 0);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            tsTransitionThemePanel.HideSync(pnlThemes);
        }

        private void ThemeSelector_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            SelectTheme.Location = new Point(pb.Location.X - 3, pb.Location.Y - 3);
            Properties.Settings.Default.Theme = pb.Name.Substring(7, pb.Name.Length - 7);
        }

        private void pbTitle_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuGradientPanel pbTitle = (Bunifu.Framework.UI.BunifuGradientPanel)sender;
            SelectTitle.Location = new Point(pbTitle.Location.X - 3, pbTitle.Location.Y - 3);
            if (pbTitle.Name == "pnlTitlePersonalized") { Properties.Settings.Default.Title = false; }
            else if (pbTitle.Name == "pnlTitleMacOS") { Properties.Settings.Default.Title = true; }
        }

        private void txbWallpaper_Enter(object sender, EventArgs e)
        {
            pnlThemes.Visible = false;
            if (txbWallpaper.Text == "Wallpaper")
            {
                txbWallpaper.Text = "";
            }
            txbWallpaper.ForeColor = Color.White;
        }

        private void txbWallpaper_Leave(object sender, EventArgs e)
        {
            if (txbWallpaper.Text == "")
            {
                txbWallpaper.Text = "Wallpaper";
            }
            txbWallpaper.ForeColor = notSelectTxb;
        }
    }
}
