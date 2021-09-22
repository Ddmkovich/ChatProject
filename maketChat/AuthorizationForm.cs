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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void authorizationForm_Load(object sender, EventArgs e)
        {
            tbLogin.Text = "Login";//подсказка
            tbLogin.ForeColor = Color.Gray;

            tbPassw.Text = "Password";//подсказка
            tbPassw.ForeColor = Color.Gray;
        }

        private void btRegistr_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            this.Hide();
            regForm.Show();
        }


        private void authorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chat chat = new Chat();
            chat.Show();
        }

        private void tbLogin_Enter(object sender, EventArgs e)
        {
            tbLogin.Text = null;
            tbLogin.ForeColor = Color.Black;
        }

        private void tbPassw_Enter(object sender, EventArgs e)
        {
            tbPassw.PasswordChar = '*';
            tbPassw.Text = null;
            tbPassw.ForeColor = Color.Black;
        }
    }
}
