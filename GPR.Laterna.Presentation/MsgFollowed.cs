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
    public partial class MsgFollowed : Form
    {
        private UserConnector _userConnector;
        private static long UFAlbumId = 0;
        private static long UFArtistId = 0;
        private static long UFTrackId = 0;
        private static long UFPlaylistId = 0;
        private static long UserId = Properties.Settings.Default.User.Id;
        CustomMessageBox customMessageBox;
        public MsgFollowed()
        {
            InitializeComponent();
            _userConnector = new UserConnector();
        }

        private void MsgFollowed_Load(object sender, EventArgs e)
        {
            LoadTrackDGV();
            LoadAlbumDGV();
            LoadArtistDGV();
            LoadPlaylistDGV();
        }
        private void LoadPlaylistDGV()
        {
            dgwPlaylist.DataSource = _userConnector.GetUserFollowedPlaylists(UserId);
            dgwPlaylist.Columns["Id"].Visible = false;
            dgwPlaylist.Columns["CreatedAt"].Visible = false;
            dgwPlaylist.Columns["UpdatedAt"].Visible = false;
            dgwPlaylist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadArtistDGV()
        {
            dgwArtist.DataSource = _userConnector.GetUserFollowedArtists(UserId);
            dgwArtist.Columns["Id"].Visible = false;
            dgwArtist.Columns["CreatedAt"].Visible = false;
            dgwArtist.Columns["UpdatedAt"].Visible = false;
            dgwArtist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadAlbumDGV()
        {
            dgwAlbums.DataSource = _userConnector.GetUserFollowedAlbums(UserId);
            dgwAlbums.Columns["Id"].Visible = false;
            dgwAlbums.Columns["CreatedAt"].Visible = false;
            dgwAlbums.Columns["UpdatedAt"].Visible = false;
            dgwAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadTrackDGV()
        {
            dgwTrack.DataSource = _userConnector.GetUserFollowedTracks(UserId);
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
            UFArtistId = Convert.ToInt64(dgwArtist.Rows[dgwArtist.CurrentRow.Index].Cells[0].Value);
        }

        private void dgwAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UFAlbumId = Convert.ToInt64(dgwAlbums.Rows[dgwAlbums.CurrentRow.Index].Cells[0].Value);
        }

        private void dgwTrack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UFTrackId = Convert.ToInt64(dgwTrack.Rows[dgwTrack.CurrentRow.Index].Cells[0].Value);
        }

        private void dgwPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UFPlaylistId = Convert.ToInt64(dgwPlaylist.Rows[dgwPlaylist.CurrentRow.Index].Cells[0].Value);
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            _userConnector.DeleteUserFollowedArtist(UFArtistId);
            LoadArtistDGV();
            Properties.Settings.Default.CustomMessage = "Seçtiğiniz Şarkıcı Beğenmekten Vazgeçildi";
            customMessageBox = new CustomMessageBox();
            customMessageBox.Show();
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            _userConnector.DeleteUserFollowedAlbum(UFAlbumId);
            LoadAlbumDGV();
            Properties.Settings.Default.CustomMessage = "Seçtiğiniz Album Beğenmekten Vazgeçildi";
            customMessageBox = new CustomMessageBox();
            customMessageBox.Show();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            _userConnector.DeleteUserFollowedTrack(UFTrackId);
            LoadTrackDGV();
            Properties.Settings.Default.CustomMessage = "Seçtiğiniz Şarkı Beğenmekten Vazgeçildi";
            customMessageBox = new CustomMessageBox();
            customMessageBox.Show();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            _userConnector.DeleteUserFollowedPlaylist(UFPlaylistId);
            LoadPlaylistDGV();
            Properties.Settings.Default.CustomMessage = "Seçtiğiniz Playlist Beğenmekten Vazgeçildi";
            customMessageBox = new CustomMessageBox();
            customMessageBox.Show();
        }
        
        //panelden formu hareket ettirmek için : 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void MsgFollowed_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
