using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPR.Laterna.Presentation
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            Color randomColor = RandomColorMaker();
            panelBottom.BackColor = randomColor;
            panelTop.BackColor = randomColor;
            btnOkay.ForeColor = randomColor;
            lblMessage.ForeColor = randomColor;
            btnOkay.IconColor = randomColor;
            lblMessage.Text = Properties.Settings.Default.CustomMessage;
        }

        private static Color RandomColorMaker()
        {
            Random color = new Random();
            Color randomColor = Color.FromArgb(color.Next(255), color.Next(255), color.Next(255));
            return randomColor;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CustomMessage = null;
            this.Close();
            
        }


        //panelden formu hareket ettirmek için : 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CustomMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
