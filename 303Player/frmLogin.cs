using _303Player.dbProgramsDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _303Player
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            FormShadow.SetShadowForm(this);
        }

        tbProgramUsersTableAdapter tbPrograms = new tbProgramUsersTableAdapter();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name, email, phone;
            if (txbName.Text == "Name") { name = "0"; }
            else { name = txbName.Text; }

            if (txbEmail.Text == "Email") { email = "0"; }
            else { email = txbEmail.Text; }

            if (txbPhone.Text == "Phone") { phone = "0"; }
            else { phone = txbPhone.Text; }

            try
            {
                if (name == "0" || email == "0" || phone == "0")
                {
                    MessageBox.Show("Error! you have not filled in all the data.",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tbPrograms.returnExistentEmail("Player", email) == null)
                {
                    tbPrograms.insertUser(
                              name,
                              email,
                              phone,
                              "Player"
                              );

                    Properties.Settings.Default.isLogged = true;
                    Properties.Settings.Default.Save();
                    Close();
                }
                else
                {
                    MessageBox.Show("Email already in the database!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error when trying to connect, you may not be connected to the internet or sql no longer exists!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pictureBox1.Select();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbs_Enter(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;

            if (txb.Text == txb.Name.Substring(3, txb.Name.Length - 3))
            {
                txb.Clear();
            }
            txb.ForeColor = Color.White;
        }

        private void txbs_Leave(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;

            if (txb.Text == "")
            {
                txb.Text = txb.Name.Substring(3, txb.Name.Length - 3);
            }
            txb.ForeColor = Color.DarkGray;
        }

        private void txbs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox txb = (TextBox)sender;

                if (txb.Name == "txbName")
                {
                    txbEmail.Select();
                }
                if (txb.Name == "txbEmail")
                {
                    txbPhone.Select();
                }
                if (txb.Name == "txbPhone")
                {
                    btnLogin_Click(txbPhone, e);
                }
            }
        }
    }
}
