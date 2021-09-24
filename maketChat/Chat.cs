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
    public partial class Chat : Form
    {
        bool logout;
        public Chat()
        {
            InitializeComponent();
        }
        private void Chat_Load(object sender, EventArgs e)
        {
            logout = false;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox2.SelectedItem.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        private void Chat_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (logout == false)
            {
                Application.Exit();
            }
            
        }

        private void changeNickPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
            ChangePassNick changePassNick = new ChangePassNick();
            changePassNick.Show();
        }

        private void btSendMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
