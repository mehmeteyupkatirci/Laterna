using GPR.Laterna.Presentation.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPR.Laterna.Presentation
{
    public partial class MsgArtist : Form
    {
        private ArtistConnector _artistConnector;
        public MsgArtist()
        {
            InitializeComponent();
            _artistConnector = new ArtistConnector();
        }

        private void MsgArtist_Load(object sender, EventArgs e)
        {
            int a =Convert.ToInt32( FormArtists.ArtistId );
            var artist =_artistConnector.GetArtist(a);
            lblName.Text = artist.Name;
            lblGenres.Text = artist.Genres;
            lblPopularity.Text = artist.Popularity.ToString();

            string img = artist.Images;
            var request = WebRequest.Create(img);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pcbImages.Image = Bitmap.FromStream(stream);
            }
        }

        private void btnArtistFlw_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //panelden formu hareket ettirmek için : 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
