using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms.Suite;
using System.Windows.Forms.VisualStyles;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using _303Player.dbProgramsDataSetTableAdapters;

namespace _303Player
{
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();

            #region Files
            if (File.Exists("Client.303"))
            {
                try
                {
                    string[] allLines = File.ReadAllLines("Client.303");
                    string linha1 = allLines[0];
                    string linha2 = allLines[1];
                    string linha3 = allLines[2];
                    string linha4 = allLines[3];
                    string linha5 = allLines[4];

                    Properties.Settings.Default.Wallpaper = linha1;
                    Properties.Settings.Default.FavoriteVolume = Convert.ToInt32(linha2);
                    Properties.Settings.Default.LateralMenu = Convert.ToBoolean(linha3);
                    Properties.Settings.Default.Theme = linha4;
                    Properties.Settings.Default.Title = Convert.ToBoolean(linha5);
                    Properties.Settings.Default.Save();
                }
                catch
                { }
            }

            if (File.Exists("Reset.303"))
            {
                Properties.Settings.Default.Wallpaper = "";
                Properties.Settings.Default.FavoriteVolume = 40;
                Properties.Settings.Default.LateralMenu = true;
                Properties.Settings.Default.Theme = "Dark";
                Properties.Settings.Default.Title = false;
                Properties.Settings.Default.Save();
            }

            if (File.Exists("Version.303"))
            {
                string[] Version = File.ReadAllLines("Version.303");
                lblVersion.Text = "Version : " + Version[0];
            }

            if (File.Exists("Playlist.303"))
            {
                string[] List = File.ReadAllLines(@"Playlist.303");

                foreach (string Music in List)
                {
                    lsbPlaylist.Items.Add(Music);
                }
                tmTimer.Enabled = true;
                FilePath = List;
                FileName = List;
                wmpPlayer.URL = FilePath[Selected];
                pnlwmpPause.Visible = false;
                lsbPlaylist.SelectedIndex = 0;
                Title();

                File.Delete("Playlist.303");
            }

            #region Temp
            if (File.Exists(@"\Users\" + Environment.UserName + @"AppData\Local\Temp\tmp.303"))
            {
                File.Delete(@"\Users\" + Environment.UserName + @"AppData\Local\Temp\tmp.303");
            }
            StreamWriter sw = new StreamWriter(@"\Users\" + Environment.UserName + @"\AppData\Local\Temp\tmp.303");
            sw.WriteLine(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
            sw.Close();
            #endregion

            #endregion

            #region Properties
            wmpPlayer.settings.volume = Properties.Settings.Default.FavoriteVolume;
            tcbVolume.Value = wmpPlayer.settings.volume;
            lblVolume.Text = tcbVolume.Value.ToString();
            Theme(Properties.Settings.Default.Theme);
            Properties.Settings.Default.Save();

            FormShadow.SetShadowForm(this);
            LateralPanel(Properties.Settings.Default.LateralMenu, true);
            pnlMore.Location = new Point(pnlControls.Location.X + btnMore.Location.X, (pnlControls.Location.Y + btnMore.Location.Y) - pnlMore.Height);
            #endregion

            pnlHome.BringToFront();
            CheckLogin();

            frmIni ini = new frmIni();
            ini.ShowDialog();
        }
        string[] FileName, FilePath;
        bool Repeat = false, Random = false;
        int Selected = 0;
        bool Down = false;
        int LY, LX;
        bool MaximizedMode = false;
        Random rnd = new Random();
        tbProgramsTableAdapter tbPrograms = new tbProgramsTableAdapter();

        public void LateralPanel(bool Mode, bool ini)
        {
            if (!ini) {
                tsTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
                tsTransition.HideSync(pnlLeft); }
            if (!Mode)
            {
                pnlMore.Location = new Point(70, pnlMore.Location.Y);
                pnlHome.Size = new Size(728, 444);
                pnlHome.Location = new Point(39, 26);
                pnlPlayer.Size = new Size(728, 349);
                pnlPlayer.Location = new Point(39, 27);
                pnlPlaylist.Size = new Size(728, 349);
                pnlPlaylist.Location = new Point(39, 27);
                pnlLeft.Size = new Size(39, 444);
            }
            else if (Mode)
            {
                pnlMore.Location = new Point(187, pnlMore.Location.Y);
                pnlHome.Size = new Size(614, 444);
                pnlHome.Location = new Point(153, 26);
                pnlPlayer.Size = new Size(614, 349);
                pnlPlayer.Location = new Point(153, 27);
                pnlPlaylist.Size = new Size(614, 349);
                pnlPlaylist.Location = new Point(153, 27);
                pnlLeft.Size = new Size(153, 444);
            }
            if (!ini) {
                tsTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
                tsTransition.ShowSync(pnlLeft);

                tsTransition.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
                btnMenu.Visible = false;
                tsTransition.ShowSync(btnMenu); }
        }

        public void Theme(string Theme)
        {
            if (Theme == "White")
            {
                Color Azul = Color.FromArgb(0, 120, 215);

                this.BackColor = Color.White;
                pnlLeft.BackColor = Color.FromArgb(25, 25, 25);
                pnlTop.BackColor = Color.FromArgb(25, 25, 25);

                ToolTip.BackColor = Color.White;
                ToolTip.BorderColor = Color.Black;
                ToolTip.ForeColor = Color.Black;

                #region pnlTop
                lblTitle.ForeColor = Color.Black;
                guna2Separator1.FillColor = Color.Black;
                #endregion

                #region pnlLeft
                btnMenu.Image = Properties.Resources.Menu_Dark;
                lsMenu.FillColor = Color.Black;
                guna2VSeparator1.FillColor = Color.Black;
                btnHome.Iconimage = Properties.Resources.Home_Dark;
                btnPlayer.Iconimage = Properties.Resources.Play_Dark_Active;
                btnPlayer.IconZoom = 60;
                btnPlaylist.Iconimage = Properties.Resources.Playlist_Dark_Active;

                btnHome.Normalcolor = Color.Gray;
                btnHome.Activecolor = Color.Gray;
                btnHome.OnHovercolor = Color.DarkGray;
                btnHome.OnHoverTextColor = Color.Black;
                btnHome.Textcolor = Color.Black;

                btnPlayer.Activecolor = Color.Gray;
                btnPlayer.OnHovercolor = Color.DarkGray;
                btnPlayer.OnHoverTextColor = Color.Black;
                btnPlayer.Textcolor = Color.Black;

                btnPlaylist.Activecolor = Color.Gray;
                btnPlaylist.OnHovercolor = Color.DarkGray;
                btnPlaylist.OnHoverTextColor = Color.Black;
                btnPlaylist.Textcolor = Color.Black;

                btnSettings.Activecolor = Color.Gray;
                btnSettings.OnHovercolor = Color.DarkGray;
                btnSettings.OnHoverTextColor = Color.Black;
                btnSettings.Textcolor = Color.Black;
                btnSettings.Iconimage = Properties.Resources.Settings_Dark;
                #endregion

                #region pnlHome
                pbIconHome.Image = Properties.Resources.PlayerIcon_Dark;
                lblTitleHome.ForeColor = Color.Black;
                #endregion

                #region pnlPlaylist
                lsbPlaylist.BackColor = Color.White;
                lsbPlaylist.ForeColor = Color.Black;
                #endregion

                #region pnlControls
                guna2Separator2.FillColor = Color.Black;
                tcbTemp.ThumbColor = Azul;
                tcbTemp.FillColor = Color.FromArgb(41, 39, 40);
                lblTemp.ForeColor = Color.Black;
                lblMaxTemp.ForeColor = Color.Black;
                btnOpenFile.Image = Properties.Resources.Open_Dark;
                btnMore.Image = Properties.Resources.More_Dark;
                //btnRepeat.Image = Properties.Resources.Repeat;
                btnBackControls.Image = Properties.Resources.Back_Dark;
                btnPlayControls.Image = Properties.Resources.Play_Dark;
                btnNextControls.Image = Properties.Resources.Next_Dark;
                if (wmpPlayer.settings.volume > 0) { btnMute.Image = Properties.Resources.sound_Dark; }
                else if (wmpPlayer.settings.volume <= 0) { btnMute.Image = Properties.Resources.Mute_Dark; }
                tcbVolume.ThumbColor = Azul;
                tcbVolume.FillColor = Color.FromArgb(41, 39, 40);
                lblVolume.ForeColor = Color.Black;
                #endregion

                #region pnlMore
                guna2Separator4.FillColor = Color.Black;
                guna2Separator5.FillColor = Color.Black;
                guna2VSeparator3.FillColor = Color.Black;
                guna2VSeparator2.FillColor = Color.Black;

                btnSave.Textcolor = Color.Black;
                btnSave.OnHoverTextColor = Color.Black;
                btnSave.Activecolor = Color.Gray;
                btnSave.OnHovercolor = Color.DarkGray;

                btnLoad.Textcolor = Color.Black;
                btnLoad.OnHoverTextColor = Color.Black;
                btnLoad.Activecolor = Color.Gray;
                btnLoad.OnHovercolor = Color.DarkGray;

                btnFullScreen.Textcolor = Color.Black;
                btnFullScreen.OnHoverTextColor = Color.Black;
                btnFullScreen.Activecolor = Color.Gray;
                btnFullScreen.OnHovercolor = Color.DarkGray;

                btnSave.Iconimage = Properties.Resources.Save_Dark;
                btnLoad.Iconimage = Properties.Resources.Load_Dark;
                btnFullScreen.Iconimage = Properties.Resources.full_screen_50_0px;
                #endregion
            }
            else if (Theme == "Blue")
            {
                btnClose.Image = Properties.Resources.CircleButtonBlueTheme;
                btnClose.ImageActive = Properties.Resources.ActiveCircleButtonBlueTheme;
                btnMinimize.Image = Properties.Resources.CircleButtonBlueTheme;
                btnMinimize.ImageActive = Properties.Resources.ActiveCircleButtonBlueTheme;
                btnMaximize.Image = Properties.Resources.CircleButtonBlueTheme;
                btnMaximize.ImageActive = Properties.Resources.ActiveCircleButtonBlueTheme;

                this.BackColor = Color.FromArgb(0, 43, 54);
                pnlTop.BackColor = Color.FromArgb(0, 30, 38);
                lsbPlaylist.BackColor = Color.FromArgb(0, 43, 54);
                ToolTip.BackColor = Color.FromArgb(0, 43, 54);
                ToolTip.BorderColor = Color.FromArgb(0, 30, 38);

                //Separators
                guna2VSeparator1.FillColor = Color.FromArgb(0, 30, 38);
                guna2VSeparator2.FillColor = Color.FromArgb(0, 30, 38);
                guna2VSeparator3.FillColor = Color.FromArgb(0, 30, 38);
                guna2Separator1.FillColor = Color.FromArgb(0, 30, 38);
                guna2Separator2.FillColor = Color.FromArgb(0, 30, 38);
                guna2Separator4.FillColor = Color.FromArgb(0, 30, 38);
                guna2Separator5.FillColor = Color.FromArgb(0, 30, 38);
                lsMenu.FillColor = Color.FromArgb(0, 30, 38);

                //Button
                btnHome.Normalcolor = Color.FromArgb(47, 68, 74);
                btnHome.OnHovercolor = Color.FromArgb(64, 86, 92);
                btnHome.Activecolor = Color.FromArgb(47, 68, 74);
                btnPlayer.OnHovercolor = Color.FromArgb(64, 86, 92);
                btnPlayer.Activecolor = Color.FromArgb(47, 68, 74);
                btnPlaylist.OnHovercolor = Color.FromArgb(64, 86, 92);
                btnPlaylist.Activecolor = Color.FromArgb(47, 68, 74);
                btnSettings.Activecolor = Color.FromArgb(47, 68, 74);
                btnSettings.OnHovercolor = Color.FromArgb(64, 86, 92);

                btnSave.OnHovercolor = Color.FromArgb(64, 86, 92);
                btnSave.Activecolor = Color.FromArgb(47, 68, 74);
                btnLoad.OnHovercolor = Color.FromArgb(64, 86, 92);
                btnLoad.Activecolor = Color.FromArgb(47, 68, 74);
                btnFullScreen.OnHovercolor = Color.FromArgb(64, 86, 92);
                btnFullScreen.Activecolor = Color.FromArgb(47, 68, 74);

                tcbTemp.FillColor = Color.FromArgb(47, 68, 74);
                tcbVolume.FillColor = Color.FromArgb(47, 68, 74);
            }
            else if (Theme == "Oranje")
            {
                this.BackColor = Color.FromArgb(25, 25, 25);
                pnlLeft.BackColor = Color.FromArgb(25, 25, 25);
                pnlTop.BackColor = Color.FromArgb(25, 25, 25);

                ToolTip.BackColor = Color.FromArgb(25, 25, 25);
                ToolTip.BorderColor = Color.FromArgb(21, 21, 21);
                ToolTip.ForeColor = Color.FromArgb(203, 67, 31);

                #region pnlLeft
                btnHome.Normalcolor = Color.FromArgb(203, 67, 31);
                btnHome.Activecolor = Color.FromArgb(203, 67, 31);
                btnHome.OnHovercolor = Color.FromArgb(204, 84, 51);

                btnPlayer.Activecolor = Color.FromArgb(203, 67, 31);
                btnPlayer.OnHovercolor = Color.FromArgb(204, 84, 51);

                btnPlaylist.Activecolor = Color.FromArgb(203, 67, 31);
                btnPlaylist.OnHovercolor = Color.FromArgb(204, 84, 51);

                btnSettings.Activecolor = Color.FromArgb(203, 67, 31);
                btnSettings.OnHovercolor = Color.FromArgb(204, 84, 51);
                #endregion

                #region pnlControls
                tcbTemp.ThumbColor = Color.FromArgb(203, 67, 31);
                tcbVolume.ThumbColor = Color.FromArgb(203, 67, 31);
                if (wmpPlayer.settings.volume > 0) { btnMute.Image = Properties.Resources.Sound; }
                else if (wmpPlayer.settings.volume <= 0) { btnMute.Image = Properties.Resources.Mute; }
                #endregion

                #region pnlMore
                btnSave.Activecolor = Color.FromArgb(203, 67, 31);
                btnSave.OnHovercolor = Color.FromArgb(204, 84, 51);

                btnLoad.Activecolor = Color.FromArgb(203, 67, 31);
                btnLoad.OnHovercolor = Color.FromArgb(204, 84, 51);

                btnFullScreen.Activecolor = Color.FromArgb(203, 67, 31);
                btnFullScreen.OnHovercolor = Color.FromArgb(204, 84, 51);
                #endregion
            }

            if (Properties.Settings.Default.Title)
            {
                btnClose.Image = Properties.Resources.btnClose;
                btnClose.ImageActive = Properties.Resources.btnCloseActive;
                btnMinimize.Image = Properties.Resources.btnMinimize;
                btnMinimize.ImageActive = Properties.Resources.btnMinimizeActive;
                btnMaximize.Image = Properties.Resources.btnMaximize;
                btnMaximize.ImageActive = Properties.Resources.btnMaximizeActive;

                pnlTop.BackColor = Color.FromArgb(192, 192, 192);
                guna2Separator1.FillColor = Color.DarkGray;
                lblTitle.ForeColor = Color.Black;
            }
            if (File.Exists(Properties.Settings.Default.Wallpaper))
            {
                Bitmap img = new Bitmap(Properties.Settings.Default.Wallpaper);
                this.BackgroundImage = img;
            }

            pnlNotfications.BackColor = Color.Orange;
        }

        public void Pause()
        {
            pnlMore.Visible = false;
            if (wmpPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                wmpPlayer.Ctlcontrols.play();
                playToolStripMenuItem.Text = "Pause";
            }
            else if (wmpPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wmpPlayer.Ctlcontrols.pause();
                playToolStripMenuItem.Text = "Play";
            }
        }
        
        public void Title()
        {
            string Text = "Player - " + FileName[Selected];
            int x = 76;

            if (Text.Length > x)
            {
                Text = Text.Substring(0, x - 4) + " ...";
            }

            lblTitle.Text = Text;
            ToolTip.SetToolTip(lblTitle, FileName[Selected]);
            lblTitle.Location = new Point(pnlTop.Size.Width / 2 - lblTitle.Size.Width / 2, lblTitle.Location.Y);
            pbTitleIcon.Location = new Point(lblTitle.Location.X - pbTitleIcon.Width - 4, pbTitleIcon.Location.Y);
        }

        public void CheckUpdate()
        {
            try
            {
                string[] PlayerVersion = File.ReadAllLines("Version.303");
                if (tbPrograms.returnVersion("Player") != PlayerVersion[0])
                {
                    pnlNotfications.Visible = true;

                    lblNotfication1.Visible = true;
                    lblNotfication1.Text = "The player already has a new version, do you want to";
                    lblNotfication1.Location = new Point(58, lblNotfication1.Location.Y);

                    lblNotficationLink.Visible = true;
                    lblNotficationLink.Text = "download";
                    lblNotficationLink.Location = new Point(372, lblNotficationLink.Location.Y);
                    lblNotficationLink.Tag = "Update";

                    lblNotfication2.Visible = true;
                    lblNotfication2.Text = "the update?";
                    lblNotfication2.Location = new Point(435, lblNotfication2.Location.Y);

                    lblNotfication1.BringToFront();
                    lblNotficationLink.BringToFront();
                    lblNotfication2.BringToFront();

                    pnlNotfications.BringToFront();
                }
            }
            catch
            { }
        }

        public void CheckLogin()
        {
            if (!Properties.Settings.Default.isLogged)
            {
                pnlNotfications.Visible = true;

                lblNotfication1.Text = "Hi, it looks like you don't have an account in our system yet, would you like to ";
                lblNotfication1.Location = new Point(37, lblNotfication1.Location.Y);

                lblNotficationLink.Text = "create it?";
                lblNotficationLink.Location = new Point(490, lblNotficationLink.Location.Y);
                lblNotficationLink.Tag = "Login";

                lblNotfication2.Visible = false;

                lblNotfication1.BringToFront();
                lblNotficationLink.BringToFront();

                pnlNotfications.BringToFront();
            }
            else
            {
                CheckUpdate();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlLeft.Size == new Size(153, 444)) { LateralPanel(false, false); }
            else if (pnlLeft.Size == new Size(39, 444)) { LateralPanel(true, false); }
        }

        private void btnLeftPanel_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton btn = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            pnlMore.Visible = false;
            switch (btn.Name)
            {
                case "btnHome":
                    pnlHome.BringToFront();
                    break;

                case "btnPlayer":
                    btnHome.Normalcolor = Color.Transparent;
                    pnlPlayer.BringToFront();
                    pnlControls.BringToFront();
                    break;

                case "btnPlaylist":
                    btnHome.Normalcolor = Color.Transparent;
                    pnlPlaylist.BringToFront();
                    pnlControls.BringToFront();
                    lsbPlaylist.Refresh();
                    break;

                case "btnSettings":
                    btnSettings.selected = true;
                    btnHome.Normalcolor = Color.Transparent;
                    frmSettings Settings = new frmSettings();
                    Settings.ShowDialog();
                    break;
            }
            pnlNotfications.BringToFront();
        }

        private void btnMenuMore_Click(object sender, EventArgs e)
        {
            if (!pnlMore.Visible)
            {
                pnlMore.Visible = true;
                pnlMore.BringToFront();
            }
            else
            {
                pnlMore.Visible = false;
            }
        }

        private void btnPlayControls_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void btnNextControls_Click(object sender, EventArgs e)
        {
            pnlMore.Visible = false;
            wmpPlayer.Ctlcontrols.currentPosition = wmpPlayer.Ctlcontrols.currentPosition + 10;
        }

        private void btnBackControls_Click(object sender, EventArgs e)
        {
            pnlMore.Visible = false;
            if (wmpPlayer.Ctlcontrols.currentPosition <= 3)
            {

                if (Selected != 0) { Selected--; }
                else { Selected = lsbPlaylist.Items.Count - 1; }
                return;
            }
            wmpPlayer.Ctlcontrols.currentPosition = wmpPlayer.Ctlcontrols.currentPosition - 10;
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            pnlMore.Visible = false;
            var Theme = Properties.Settings.Default.Theme == "Dark" || Properties.Settings.Default.Theme == "Oranje" || Properties.Settings.Default.Theme == "Blue" || Properties.Settings.Default.Theme == "Ubuntu";
            if (wmpPlayer.settings.volume != 0)
            {
                muteToolStripMenuItem.Checked = true;
                wmpPlayer.settings.volume = 0;
                if (Theme)
                {
                    btnMute.Image = Properties.Resources.Mute;
                }
                else { btnMute.Image = Properties.Resources.Mute_Dark; }
            }
            else
            {
                muteToolStripMenuItem.Checked = false;
                wmpPlayer.settings.volume = tcbVolume.Value;
                if (Theme) { btnMute.Image = Properties.Resources.Sound; }
                else { btnMute.Image = Properties.Resources.sound_Dark; }
            }
        }

        private void tcbVolume_Scroll(object sender, ScrollEventArgs e)
        {
            pnlMore.Visible = false;

            if (wmpPlayer.settings.volume != 0 && Properties.Settings.Default.Theme == "White")
            {
                btnMute.Image = Properties.Resources.sound_Dark;
            }
            else if (wmpPlayer.settings.volume == 0 && Properties.Settings.Default.Theme == "White")
            {
                btnMute.Image = Properties.Resources.Mute_Dark;
            }

            if (wmpPlayer.settings.volume != 0)
            {
                btnMute.Image = Properties.Resources.Sound;
            }
            else if (wmpPlayer.settings.volume == 0)
            {
                btnMute.Image = Properties.Resources.Mute;
            }

            wmpPlayer.settings.volume = tcbVolume.Value;
            lblVolume.Text = tcbVolume.Value.ToString();
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            pnlMore.Visible = false;
            if (!Repeat)
            {
                btnRepeat.Image = Properties.Resources.Repeat1;
                repeatToolStripMenuItem.Checked = true;
                Repeat = true;
            }
            else if (Repeat)
            {
                btnRepeat.Image = Properties.Resources.Repeat;
                repeatToolStripMenuItem.Checked = false;
                Repeat = false;
            }
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            pnlMore.Visible = false;
            try
            {
                wmpPlayer.fullScreen = true;
            }
            catch
            { }
        }

        private void tmTimer_Tick(object sender, EventArgs e)
        {
            var End = wmpPlayer.playState == WMPLib.WMPPlayState.wmppsStopped;
            var Last = lsbPlaylist.SelectedIndex + 1 == lsbPlaylist.Items.Count;

            #region Text's

            if (wmpPlayer.Ctlcontrols.currentPositionString != "")
            {
                if (wmpPlayer.Ctlcontrols.currentPositionString.Length > 5)
                {
                    lblTemp.Text = wmpPlayer.Ctlcontrols.currentPositionString.Substring(0, 5) + "...";
                }
                else
                {
                    lblTemp.Text = wmpPlayer.Ctlcontrols.currentPositionString;
                }
            }
            else { lblTemp.Text = "00:00"; }

            if (ToolTip.GetToolTip(lblMaxTemp) != wmpPlayer.Ctlcontrols.currentItem.durationString)
            {
                ToolTip.SetToolTip(lblMaxTemp, wmpPlayer.Ctlcontrols.currentItem.durationString);
            }
            ToolTip.SetToolTip(lblTemp, wmpPlayer.Ctlcontrols.currentPositionString);

            if (tcbTemp.Maximum != (int)wmpPlayer.Ctlcontrols.currentItem.duration || lblMaxTemp.Text != wmpPlayer.Ctlcontrols.currentItem.durationString)
            {
                try
                {
                    tcbTemp.Maximum = (int)wmpPlayer.Ctlcontrols.currentItem.duration;
                }
                catch
                { }

                if (wmpPlayer.Ctlcontrols.currentItem.durationString.Length > 5)
                {
                    lblMaxTemp.Text = wmpPlayer.Ctlcontrols.currentItem.durationString.Substring(0, 5) + "...";
                }
                else { lblMaxTemp.Text = wmpPlayer.Ctlcontrols.currentItem.durationString; }
            }
            if (!Down)
            {
                try
                {
                    tcbTemp.Value = Convert.ToInt32(wmpPlayer.Ctlcontrols.currentPosition);
                }
                catch
                { }
            }

            #endregion

            #region Repeat
            if (End)
            {
                if (Random && !Repeat)
                {
                    Selected = rnd.Next(FilePath.Length + 1);
                }
                if (!Repeat && Last)
                {
                    Selected = 0;
                }
                else if (!Repeat && !Last)
                {
                    Selected++;
                }

                if (Repeat)
                {
                    wmpPlayer.Ctlcontrols.pause();
                    wmpPlayer.Ctlcontrols.play();
                }

                wmpPlayer.URL = FilePath[Selected];
            }
            #endregion

            Title();
            lsbPlaylist.SelectedIndex = Selected;
        }

        private void tcbTemp_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                wmpPlayer.Ctlcontrols.currentPosition = tcbTemp.Value;
            }
            catch
            { }
            Down = false;
        }

        private void tcbTemp_MouseDown(object sender, MouseEventArgs e)
        {
            pnlMore.Visible = false;
            Down = true;
        }

        private void lsbPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlMore.Visible = false;
            Selected = lsbPlaylist.SelectedIndex;

            if (lsbPlaylist.Items.Count > 0)
            {
                wmpPlayer.URL = FilePath[Selected];
                tmTimer.Enabled = true;
            }
            Title();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            pnlMore.Visible = false;
            ofdOpenFile.Title = "Load Playlist";
            ofdOpenFile.Multiselect = false;
            ofdOpenFile.Filter = "Plt File|*.plt|Text File|*.txt|All files|*.*";
            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                pnlwmpPause.Visible = false;
                Selected = 0;
                lsbPlaylist.Items.Clear();

                string[] OpenPlaylist = File.ReadAllLines(ofdOpenFile.FileName);
                for (int x = 0; x < OpenPlaylist.Length; x++)
                {
                    lsbPlaylist.Items.Add(OpenPlaylist[x]);
                }

                string[] Load = File.ReadAllLines(ofdOpenFile.FileName);
                FileName = Load;
                FilePath = Load;

                wmpPlayer.URL = FilePath[0];
                Title();
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            pnlMore.Visible = false;
            if (lsbPlaylist.Items.Count > 0)
            {
                sfdSavePlaylist.Title = "Save Media";
                sfdSavePlaylist.Filter = "Plt File|*.plt|Text File|*.txt|All files|*.*";
                if (sfdSavePlaylist.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter SavePlaylist = new StreamWriter(sfdSavePlaylist.FileName);
                    for (int x = 0; x < FilePath.Length; x++)
                    {
                        SavePlaylist.WriteLine(FilePath[x].Substring(2, FilePath[x].Length - 2));
                    }
                    SavePlaylist.Close();
                }
            }
        }

        private void cxmsMenuStrip_Opened(object sender, EventArgs e)
        {
            if (wmpPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                playToolStripMenuItem.Text = "Play";
            }
            else if (wmpPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                playToolStripMenuItem.Text = "Pause";
            }

            if (wmpPlayer.settings.volume == 0)
            {
                muteToolStripMenuItem.Checked = true;
            }
            else { muteToolStripMenuItem.Checked = false; }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp Help = new frmHelp();
            Help.Show();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            pnlMore.Visible = false;
            ofdOpenFile.Title = "Open Media";
            ofdOpenFile.Multiselect = true;
            ofdOpenFile.Filter = "Mp3 File|*.mp3|Ogg File|*.ogg|Wav File|*.wav|Mp4 File|*mp4|3gp File|*.3gp|Avi File|*.avi|Mov File|*.mov|Flv File|*.flv|Wmv File|*.wmv|Mpg File|*.mpg|All files|*.*";
            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                pnlwmpPause.Visible = false;
                Selected = 0;
                tmTimer.Enabled = true;

                FileName = ofdOpenFile.SafeFileNames;
                FilePath = ofdOpenFile.FileNames;
                lsbPlaylist.Items.Clear();
                for (int x = 0; x <= FileName.Length - 1; x++)
                {
                    lsbPlaylist.Items.Add(FileName[x]);
                }
                lsbPlaylist.SelectedIndex = Selected;
                wmpPlayer.URL = FilePath[Selected];
                Title();
            }
        }

        private void pnlControls_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void pnlControls_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            Selected = 0;
            pnlwmpPause.Visible = false;

            lsbPlaylist.Items.Clear();
            for (int x = 0; x <= files.Length - 1; x++)
            {
                lsbPlaylist.Items.Add(files[x]);
            }
            FilePath = files;
            FileName = files;

            wmpPlayer.URL = FilePath[0];
            tmTimer.Enabled = true;
        }

        private void topMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.TopMost) { this.TopMost = true; }
            else { this.TopMost = false; }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.Location.Y < 0)
            {
                this.Location = new Point(this.Location.X, 0);
            }
        }

        private void wmpPlayer_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
        {
            if (pnlwmpPause.Visible)
            {
                btnOpenFile_Click(sender, null);
            }
            else { Pause(); }
        }

        private void pnlLeft_Click(object sender, EventArgs e)
        {
            pnlMore.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Pause();
            }
        }

        private void btnClosePnlUpdate_Click(object sender, EventArgs e)
        {
            pnlNotfications.Visible = false;
        }

        private void Move_MouseDown(object sender, MouseEventArgs e)
        {
            if (!MaximizedMode)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (!Random)
            {
                btnRandom.Image = Properties.Resources.ActiveRandom;
                Random = true;
            }
            else
            {
                btnRandom.Image = Properties.Resources.Random;
                Random = false;
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (!MaximizedMode)
            {
                LX = this.Location.X;
                LY = this.Location.Y;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                MaximizedMode = true;
                pnlMore.Location = new Point(pnlControls.Location.X + btnMore.Location.X, (pnlControls.Location.Y + btnMore.Location.Y) - pnlMore.Height);
                return;
            }
            this.Size = new Size(767, 470);
            this.Location = new Point(LX, LY);
            MaximizedMode = false;
            pnlMore.Location = new Point(pnlControls.Location.X + btnMore.Location.X, (pnlControls.Location.Y + btnMore.Location.Y) - pnlMore.Height);
        }

        private void btnsTop_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuImageButton btn = (Bunifu.Framework.UI.BunifuImageButton)sender;

            switch (btn.Name)
            {
                case "btnClose":
                    Application.Exit();
                    break;

                case "btnMinimize":
                    this.WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        private void lblNotficationLink_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((string)lblNotficationLink.Tag == "Login")
            {
                frmLogin Login = new frmLogin();
                Login.ShowDialog();

                pnlNotfications.Visible = false;
                CheckLogin();
            }
            else if ((string)lblNotficationLink.Tag == "Update")
            {
                System.Diagnostics.Process.Start(tbPrograms.returnDownloadLink("Player"));
            }
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
