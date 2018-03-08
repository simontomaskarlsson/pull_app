using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pull_app__windows_forms_application
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_click(object sender, EventArgs e)
        {
            if(PasswordtextBox.Text == "swank")
            {
                this.Hide();
                Form Mainform = new MainForm();
                Mainform.Show();
            }
            else
            {
                PasswordtextBox.Text = "";
                MessageBox.Show("Wrong Password!");
            }
        }

        private void keyEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.W)
            {
                e.SuppressKeyPress = true;
                Application.Exit();
            }
        }
    }
}
