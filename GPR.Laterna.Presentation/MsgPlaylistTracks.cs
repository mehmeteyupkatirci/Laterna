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
    public partial class MsgPlaylistTracks : Form
    {
        private PlaylistConnector _playlistConnector;
        CustomMessageBox customMessageBox;
        public static long PlaylistId = FormPlaylist.PlaylistId;
        public static long FormPlaylistId = MsgPlaylistAdd.FormPlaylistId;
        public static long PlaylistTrackId = 0;
        public static long UserId = 0;

        public MsgPlaylistTracks()
        {
            InitializeComponent();
            _playlistConnector = new PlaylistConnector();
        }

        private void MsgPlaylistTracks_Load(object sender, EventArgs e)
        {
            if (PlaylistId == 0)
            {
                dgwPlaylistTracks.DataSource = _playlistConnector.GetPlaylistTracks(FormPlaylistId);
            }
            else
            {
                dgwPlaylistTracks.DataSource = _playlistConnector.GetPlaylistTracks(PlaylistId);
            }
            dgwPlaylistTracks.Columns["Id"].Visible = false;
            dgwPlaylistTracks.Columns["CreatedAt"].Visible = false;
            dgwPlaylistTracks.Columns["UpdatedAt"].Visible = false;
            dgwPlaylistTracks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgwPlaylistTracks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PlaylistTrackId = Convert.ToInt64(dgwPlaylistTracks.Rows[dgwPlaylistTracks.CurrentRow.Index].Cells[0].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PlaylistTrackId = Convert.ToInt64(dgwPlaylistTracks.Rows[dgwPlaylistTracks.CurrentRow.Index].Cells[0].Value);
            if (FormPlaylist.PlaylistUserId == Properties.Settings.Default.User.Id)
            {
                _playlistConnector.DeletePlaylistTrack(PlaylistTrackId);
                Properties.Settings.Default.CustomMessage = "Silme İşlemi Başarıyla Gerçekleşti";
                customMessageBox = new CustomMessageBox();
                customMessageBox.Show();
            }
            else
            {
                Properties.Settings.Default.CustomMessage = "Silme İşlemini Yalnızca Playlist \nSahibi Yapabilir";
                customMessageBox = new CustomMessageBox();
                customMessageBox.Show();
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
