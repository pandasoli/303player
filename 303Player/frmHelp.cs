using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Microsoft.VisualBasic.Devices;
using System.IO;
using System.Drawing.Printing;

namespace _303Player
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
            FormShadow.SetShadowForm(this);
            Theme(Properties.Settings.Default.Theme);
        }

        public void Theme(string Theme)
        {
            if (Theme == "Dark")
            {

            }
            else if (Theme == "White")
            {
                this.BackColor = Color.White;
                pnlTop.BackColor = Color.White;
                txbHelpMessage.ForeColor = Color.Black;
                txbHelpMessage.BackColor = Color.White;
                guna2Separator1.FillColor = Color.Black;
                guna2Separator2.FillColor = Color.Black;
                guna2Separator3.FillColor = Color.Black;
                guna2VSeparator1.FillColor = Color.Black;
                guna2VSeparator2.FillColor = Color.Black;
                label1.ForeColor = Color.Black;
                btnSendHelp.Image = Properties.Resources.Send_Dark;
                ToolTip.BackColor = Color.White;
                ToolTip.BorderColor = Color.Black;
                ToolTip.ForeColor = Color.Black;
            }
            else if (Theme == "Blue")
            {
                btnClose.Image = Properties.Resources.CircleButtonBlueTheme;
                btnClose.ImageActive = Properties.Resources.ActiveCircleButtonBlueTheme;
                btnMinimize.Image = Properties.Resources.CircleButtonBlueTheme;
                btnMinimize.ImageActive = Properties.Resources.ActiveCircleButtonBlueTheme;

                this.BackColor = Color.FromArgb(0, 43, 54);
                pnlTop.BackColor = Color.FromArgb(0, 30, 38);
                txbHelpMessage.BackColor = this.BackColor;
                guna2Separator1.FillColor = Color.FromArgb(0, 30, 38);
                guna2Separator2.FillColor = Color.FromArgb(0, 30, 38);
                guna2Separator3.FillColor = Color.FromArgb(0, 30, 38);
                guna2VSeparator1.FillColor = Color.FromArgb(0, 30, 38);
                guna2VSeparator2.FillColor = Color.FromArgb(0, 30, 38);
                btnSendHelp.Image = Properties.Resources.Send;
                ToolTip.BackColor = Color.FromArgb(0, 43, 54);
                ToolTip.BorderColor = Color.FromArgb(0, 30, 38);
            }
            else if (Theme == "Oranje")
            {
                this.BackColor = Color.FromArgb(25, 25, 25);
                pnlTop.BackColor = Color.FromArgb(25, 25, 25);
                txbHelpMessage.BackColor = this.BackColor;
                txbHelpMessage.ForeColor = Color.FromArgb(203, 67, 31);
                guna2Separator1.FillColor = Color.FromArgb(21, 21, 21);
                guna2Separator2.FillColor = Color.FromArgb(21, 21, 21);
                guna2Separator3.FillColor = Color.FromArgb(21, 21, 21);
                guna2VSeparator1.FillColor = Color.FromArgb(21, 21, 21);
                guna2VSeparator2.FillColor = Color.FromArgb(21, 21, 21);
                btnSendHelp.Image = Properties.Resources.Send;
                ToolTip.BackColor = Color.FromArgb(25, 25, 25);
                ToolTip.BorderColor = Color.FromArgb(21, 21, 21);
                ToolTip.ForeColor = Color.FromArgb(203, 67, 31);
            }

            if (Properties.Settings.Default.Title == true)
            {
                btnClose.Image = Properties.Resources.btnClose;
                btnClose.ImageActive = Properties.Resources.btnCloseActive;
                btnMinimize.Image = Properties.Resources.btnMinimize;
                btnMinimize.ImageActive = Properties.Resources.btnMinimizeActive;

                pnlTop.BackColor = Color.FromArgb(192, 192, 192);
                guna2Separator1.FillColor = Color.DarkGray;
                label1.ForeColor = Color.Black;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) { Close(); }

        private void btnMinimize_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void btnSendHelp_Click(object sender, EventArgs e)
        {
            SmtpClient Client = new SmtpClient();
            NetworkCredential Credenciais = new NetworkCredential();

            Client.Host = "smtp.gmail.com";
            Client.Port = 587;
            Client.EnableSsl = true;
            Client.DeliveryMethod = SmtpDeliveryMethod.Network;
            Client.UseDefaultCredentials = false;

            Credenciais.UserName = "anonymouns303";
            Credenciais.Password = "10450000";

            Client.Credentials = Credenciais;

            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("anonymouns303@gmail.com");
            Message.Subject = "Player - Help";
            Message.Body = txbHelpMessage.Text;
            Message.To.Add("elitonlopes36@gmail.com");

            Network net = new Network();
            try
            {
                Client.Send(Message);

                txbHelpMessage.Clear();
                notifyIcon.ShowBalloonTip(1000, "Successful", "Help sent successfully", ToolTipIcon.Info);
            }
            catch
            {
                txbHelpMessage.Clear();
                notifyIcon.ShowBalloonTip(1000, "Error", "Unknown error", ToolTipIcon.Error);
            }
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width - 50, 30);
            string[] Version = File.ReadAllLines("Version.303");
            lblVersion.Text = "Version" + Version[0];
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.Location.Y < 0)
            {
                this.Location = new Point(this.Location.X, 0);
            }
        }
    }
}
