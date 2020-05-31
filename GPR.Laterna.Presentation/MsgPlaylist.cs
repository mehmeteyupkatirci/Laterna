using GPR.Laterna.Presentation.Business;
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
    public partial class MsgPlaylist : Form
    {
        private PlaylistConnector _playlistConnector;
        public MsgPlaylist()
        {
            InitializeComponent();
            _playlistConnector = new PlaylistConnector();
        }

        private void btnArtistFlw_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MsgPlaylist_Load(object sender, EventArgs e)
        {
            long id = FormPlaylist.PlaylistId;

            var playlist = _playlistConnector.GetPlaylist(id);
            if (playlist.Name.Length > 25)
            {
                //veritabanından gelen artist isimlerinin 25 karakterden kısa tutulma işlemi: 
                lblName.Text = playlist.Name.Substring(0, 25) + "...";
            }
            else
            {
                lblName.Text = playlist.Name;
            }
        }

        //panelden formu hareket ettirmek için : 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
