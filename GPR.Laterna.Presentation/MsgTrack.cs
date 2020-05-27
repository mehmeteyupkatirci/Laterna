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
    public partial class MsgTrack : Form
    {
        private AlbumConnector _albumConnector;
        private ArtistConnector _artistConnector;
        private TrackConnector _trackConnector;
        public MsgTrack()
        {
            InitializeComponent();
            _albumConnector = new AlbumConnector();
            _artistConnector = new ArtistConnector();
            _trackConnector = new TrackConnector();
        }

        private void btnTrackClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MsgTrack_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(FormTracks.TrackId);
            var track = _trackConnector.GetTrack(id);
            var albumId = Convert.ToInt32(track.AlbumId);
            var album = _albumConnector.GetAlbum(albumId);
            var artistId = Convert.ToInt32(album.ArtistId);
            var artist = _artistConnector.GetArtist(artistId);

            if (track.Name.Length > 25)
            {
                //Şarkı isimlerinin 25 karakterden kısa olması sağlanıyor.
                lblName.Text = track.Name.Substring(0, 25) + "...";
            }
            else
            {
                lblName.Text = track.Name;
            }
            lblPopularity.Text = track.Popularity.ToString();
            lblDuration.Text = track.DurationMs.ToString();

            if (artist.Name.Length > 25)
            {
                //Albüm isimlerinin 25 karakterden kısa olması sağlanıyor.
                lblArtistName.Text = artist.Name.Substring(0, 25) + "...";
            }
            else
            {
                lblArtistName.Text = artist.Name;
            }
            lblArtistPop.Text = artist.Popularity.ToString();


            if (album.Name.Length > 25)
            {
                //Albüm isimlerinin 25 karakterden kısa olması sağlanıyor.
                lblAlbumName.Text = album.Name.Substring(0, 25) + "...";
            }
            else
            {
                lblAlbumName.Text = album.Name;
            }
            lblAlbumPop.Text = album.Popularity.ToString();

            //Veritabanında kayıtlı olan albümlerin resimlerinin url'leri burada internetten stream ediyor
            string img = album.Images;
            var request = WebRequest.Create(img);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pcbImages.Image = Bitmap.FromStream(stream);
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
