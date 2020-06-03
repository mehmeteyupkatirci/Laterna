using GPR.Laterna.Entities.Concrete;
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
    public partial class FormRegister : Form
    {
        private UserConnector _userConnector;
        CustomMessageBox customMessageBox;
        public FormRegister()
        {
            InitializeComponent();
            _userConnector = new UserConnector();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = _userConnector.Add(txtEmail.Text, txtName.Text, txtPassword.Text, txtRePassword.Text);
            if (user == null)
            {
                Properties.Settings.Default.CustomMessage = "Eksik yada hatalı giriş yaptınız!";
                customMessageBox = new CustomMessageBox();
                customMessageBox.Show();
            }
            else
            {
                Properties.Settings.Default.User = user;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.CustomMessage = "Başarıyla üye oldunuz!";
                customMessageBox = new CustomMessageBox();
                customMessageBox.Show();
            }

        }
    }
}
