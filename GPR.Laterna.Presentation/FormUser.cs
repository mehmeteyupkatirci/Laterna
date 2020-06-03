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
    public partial class FormUser : Form
    {
        private UserConnector _userConnector;
        CustomMessageBox customMessageBox;
        public FormUser()
        {
            InitializeComponent();
            _userConnector = new UserConnector();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            tbxName.Text = Properties.Settings.Default.User.Name;
            tbxEmail.Text = Properties.Settings.Default.User.Email;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           User user = _userConnector.Update(tbxEmail.Text, tbxName.Text,tbxPassword.Text,tbxPasswordValidate.Text);
            if (user==null)
            {
                Properties.Settings.Default.CustomMessage = "Girdiğiniz bilgileri kontrol ediniz";
                customMessageBox = new CustomMessageBox();
                customMessageBox.Show();
            }
            else
            {
                Properties.Settings.Default.User = user;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.CustomMessage = "Bilgileriniz başarıyla değiştirildi";
                customMessageBox = new CustomMessageBox();
                customMessageBox.Show();
            }
        }

        private void btnPlaylists_Click(object sender, EventArgs e)
        {
            MsgPlaylistAdd msgPlaylistAdd = new MsgPlaylistAdd();
            msgPlaylistAdd.Show();
        }
    }
}

