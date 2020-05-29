using GPR.Laterna.Presentation.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPR.Laterna.Presentation
{
    public partial class Login : Form
    {
        private UserConnector _userConnector;
        private MainForm _mainForm;
        public Login(MainForm mainForm)
        {
            InitializeComponent();
            _userConnector = new UserConnector();
            _mainForm = mainForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş olamaz");
            }
            var user = _userConnector.Login(txtUsername.Text,txtPassword.Text);

            if(user != null)
            {
                Properties.Settings.Default.User = user;
                Properties.Settings.Default.isLogin = true;
                Properties.Settings.Default.Save();

                _mainForm.BtnHide();
                _mainForm.Reset();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Paroloa Hatalı");
            }
        }
    }
}
