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
    public partial class RegForm : Form
    {
        AuthorizationForm authorizationForm = new AuthorizationForm();
        public RegForm()
        {
            InitializeComponent();
        }
        private void RegForm_Load(object sender, EventArgs e)
        {

            tbLogin.Text = "Login";//подсказка
            tbLogin.ForeColor = Color.Gray;

            tbPassw.Text = "Password";//подсказка
            tbPassw.ForeColor = Color.Gray;

            tbRepPassw.Text = "Repeat password";//подсказка
            tbRepPassw.ForeColor = Color.Gray;
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void regForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            authorizationForm.Show();
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            label2.Text = ("Ошибка ввода!");
        }

        private void tbLogin_Enter(object sender, EventArgs e)
        {

        }

        private void tbPassw_Enter(object sender, EventArgs e)
        {
            tbPassw.PasswordChar = '*';
            tbPassw.Text = null;
            tbPassw.ForeColor = Color.Black;
        }

        private void tbRepPassw_Enter(object sender, EventArgs e)
        {
            tbRepPassw.PasswordChar = '*';
            tbRepPassw.Text = null;
            tbRepPassw.ForeColor = Color.Black;
        }
    }
}
