using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maketChat
{
    public partial class ChangePassNick : Form
    {
        public ChangePassNick()
        {
            InitializeComponent();
        }
        private void ChangePassNick_Load(object sender, EventArgs e)
        {
            tbLogin.Text = "Login";//подсказка
            tbLogin.ForeColor = Color.Gray;

            tbPassw.Text = "Enter current password";//подсказка
            tbPassw.ForeColor = Color.Gray;

            tbNewPassw.Text = "Enter new password";//подсказка
            tbNewPassw.ForeColor = Color.LightGray;

            tbRepNewPasww.Text = "Repeat new password";//подсказка
            tbRepNewPasww.ForeColor = Color.LightGray;

        }
        private void ChangePassNick_FormClosed(object sender, FormClosedEventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        private void tbLogin_Enter(object sender, EventArgs e)
        {
            tbPassw.Text = null;
            tbPassw.ForeColor = Color.Black;
        }

        private void tbPassw_Enter(object sender, EventArgs e)
        {
            tbPassw.PasswordChar = '*';
            tbPassw.Text = null;
            tbPassw.ForeColor = Color.Black;
        }

        private void tbNewPassw_Enter(object sender, EventArgs e)
        {
            tbNewPassw.PasswordChar = '*';
            tbNewPassw.Text = null;
            tbNewPassw.ForeColor = Color.Black;
        }

        private void tbRepNewPasww_Enter(object sender, EventArgs e)
        {
            tbRepNewPasww.PasswordChar = '*';
            tbRepNewPasww.Text = null;
            tbRepNewPasww.ForeColor = Color.Black;
        }
    }
}
