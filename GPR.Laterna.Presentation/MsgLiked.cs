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
    public partial class MsgLiked : Form
    {
        private UserConnector _userConnector;
        private static long ULAlbumId = 0;
        private static long ULArtistId = 0;
        private static long ULTrackId = 0;
        private static long ULPlaylistId = 0;
        private static long UserId = Properties.Settings.Default.User.Id;
        CustomMessageBox customMessageBox;
        public MsgLiked()
        {
            InitializeComponent();
            _userConnector = new UserConnector();
        }
        private void MsgLiked_Load(object sender, EventArgs e)
        {
            LoadTrackDGV();
            LoadAlbumDGV();
            LoadArtistDGV();
            LoadPlaylistDGV();
        }

        private void LoadPlaylistDGV()
        {
            dgwPlaylist.DataSource = _userConnector.GetUserLikedPlaylists(UserId);
            dgwPlaylist.Columns["Id"].Visible = false;
            dgwPlaylist.Columns["CreatedAt"].Visible = false;
            dgwPlaylist.Columns["UpdatedAt"].Visible = false;
            dgwPlaylist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadArtistDGV()
        {
            dgwArtist.DataSource = _userConnector.GetUserLikedArtists(UserId);
            dgwArtist.Columns["Id"].Visible = false;
            dgwArtist.Columns["CreatedAt"].Visible = false;
            dgwArtist.Columns["UpdatedAt"].Visible = false;
            dgwArtist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadAlbumDGV()
        {
            dgwAlbums.DataSource = _userConnector.GetUserLikedAlbums(UserId);
            dgwAlbums.Columns["Id"].Visible = false;
            dgwAlbums.Columns["CreatedAt"].Visible = false;
            dgwAlbums.Columns["UpdatedAt"].Visible = false;
            dgwAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadTrackDGV()
        {
            dgwTrack.DataSource = _userConnector.GetUserLikedTracks(UserId);
            dgwTrack.Columns["Id"].Visible = false;
            dgwTrack.Columns["CreatedAt"].Visible = false;
            dgwTrack.Columns["UpdatedAt"].Visible = false;
            dgwTrack.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnArtistClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwArtist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ULArtistId = Convert.ToInt64(dgwArtist.Rows[dgwArtist.CurrentRow.Index].Cells[0].Value);
        }

        private void dgwAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ULAlbumId = Convert.ToInt64(dgwAlbums.Rows[dgwAlbums.CurrentRow.Index].Cells[0].Value);
        }

        private void dgwTrack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ULTrackId = Convert.ToInt64(dgwTrack.Rows[dgwTrack.CurrentRow.Index].Cells[0].Value);
        }

        private void dgwPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ULPlaylistId = Convert.ToInt64(dgwPlaylist.Rows[dgwPlaylist.CurrentRow.Index].Cells[0].Value);
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            var album = _userConnector.GetLikedAlbumName(ULAlbumId);
            _userConnector.DeleteUserLikedAlbum(ULAlbumId);
            LoadAlbumDGV();
            Properties.Settings.Default.CustomMessage = album.Name +", Beğenmekten Vazgeçildi";
            customMessageBox = new CustomMessageBox();
            customMessageBox.Show();
        }
        private void btnArtist_Click(object sender, EventArgs e)
        {
            var artist = _userConnector.GetLikedArtistName(ULArtistId);
            _userConnector.DeleteUserLikedArtist(ULArtistId);
            LoadArtistDGV();
            Properties.Settings.Default.CustomMessage = artist.Name +", Beğenmekten Vazgeçildi";
            customMessageBox = new CustomMessageBox();
            customMessageBox.Show();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            var track = _userConnector.GetLikedTrackName(ULTrackId);
            _userConnector.DeleteUserLikedTrack(ULTrackId);
            LoadTrackDGV();
            Properties.Settings.Default.CustomMessage = track.Name + ", Beğenmekten Vazgeçildi";
            customMessageBox = new CustomMessageBox();
            customMessageBox.Show();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            var playlist = _userConnector.GetLikedPlaylistName(ULPlaylistId);
            _userConnector.DeleteUserLikedPlaylist(ULPlaylistId);
            LoadPlaylistDGV();
            Properties.Settings.Default.CustomMessage = playlist.Name + ", Beğenmekten Vazgeçildi";
            customMessageBox = new CustomMessageBox();
            customMessageBox.Show();
        }
        //panelden formu hareket ettirmek için : 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void MsgLiked_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
