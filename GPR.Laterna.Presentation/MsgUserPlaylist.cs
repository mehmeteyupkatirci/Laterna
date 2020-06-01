using GPR.Laterna.Presentation.Business;
using GPR.Laterna.Presentation.Helpers;
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
    public partial class MsgUserPlaylist : Form
    {
        private PlaylistConnector _playlistConnector;
        public static long PlaylistId = 0;
        CustomMessageBox customMessageBox;
        public MsgUserPlaylist()
        {
            InitializeComponent();
            _playlistConnector = new PlaylistConnector();
        }

        private void UserPlaylist_Load(object sender, EventArgs e)
        {
            dgwUserPlaylist.DataSource = _playlistConnector.GetUserPlaylists(Properties.Settings.Default.User.Id);
            dgwUserPlaylist.Columns["Name"].HeaderText = "Playlist Adı";
            dgwUserPlaylist.Columns["Description"].HeaderText = "Açıklama";
            dgwUserPlaylist.Columns["Public"].HeaderText = "Herkese Açık";
            dgwUserPlaylist.Columns["Id"].Visible = false;
            dgwUserPlaylist.Columns["UserId"].Visible = false;
            dgwUserPlaylist.Columns["DeletedAt"].Visible = false;
            dgwUserPlaylist.Columns["CreatedAt"].Visible = false;
            dgwUserPlaylist.Columns["UpdatedAt"].Visible = false;
            dgwUserPlaylist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgwUserPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PlaylistId = Convert.ToInt64(dgwUserPlaylist.Rows[dgwUserPlaylist.CurrentRow.Index].Cells[0].Value);
        }

        //panelden formu hareket ettirmek için : 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void UserPlaylist_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            long trackId = FormTracks.TrackId;
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                var result = _playlistConnector.AddPlaylistTrack(PlaylistId, trackId);
                if (result)
                {
                    Properties.Settings.Default.CustomMessage = "Şarkı Başarıyla Seçtiğiniz Playliste Eklenmiştir";
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
                else
                {
                    Properties.Settings.Default.CustomMessage = "Şarkı Zaten Mevcut Playlist'te var";
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
            }
        }
    }
}
