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
    public partial class MsgAlbum : Form
    {
        private AlbumConnector _albumConnector;
        private ArtistConnector _artistConnector;
        public MsgAlbum()
        {
            InitializeComponent();
            _albumConnector = new AlbumConnector();
            _artistConnector = new ArtistConnector();
        }

        private void MsgAlbum_Load(object sender, EventArgs e)
        {
            long id = 0;
            if (FormAlbums.AlbumId == 0)
            {
                id = MainForm.AlbumId;
            }
            else
            {
                id = FormAlbums.AlbumId;
            }
            var album = _albumConnector.GetAlbum(id);
            var artistId = Convert.ToInt64(album.ArtistId);
            var artist = _artistConnector.GetArtist(artistId);
            
            if (album.Name.Length > 25)
            {
                //Albüm isimlerinin 25 karakterden kısa olması sağlanıyor.
                lblName.Text = album.Name.Substring(0,25) + "...";
            }
            else
            {
                lblName.Text = album.Name;
            }

            //veritabanından gelen verilerin labellara yazıldığı yer
            lblArtist.Text = artist.Name;
            lblArtistPop.Text = artist.Popularity.ToString();
            lblPopularity.Text = album.Popularity.ToString();
            lblRelease.Text = album.ReleaseData.ToString();


            //Veritabanında kayıtlı olan albümlerin resimlerinin url'leri burada internetten stream ediyor
            string img = album.Images;
            var request = WebRequest.Create(img);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pcbImages.Image = Bitmap.FromStream(stream);
            }
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            this.Close();
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
