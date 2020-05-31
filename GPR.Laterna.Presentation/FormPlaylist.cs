using GPR.Laterna.Entities.Concrete;
using GPR.Laterna.Presentation.Business;
using GPR.Laterna.Presentation.Helpers;
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
    public partial class FormPlaylist : Form
    {
        public static long PlaylistId = 0;
        public static bool PlaylistPublic = true;
        public static long PlaylistUserId = 0;

        CustomMessageBox customMessageBox;

        private PlaylistConnector _playlistConnector;
        private UserConnector _userConnector;
        private List<UserFollowedPlaylist> _userFollowedPlaylists;
        private List<UserLikedPlaylist> _userLikedPlaylists;
        public FormPlaylist()
        {
            InitializeComponent();
            _playlistConnector = new PlaylistConnector();
            _userConnector = new UserConnector();
            _userLikedPlaylists = new List<UserLikedPlaylist>();
            _userFollowedPlaylists = new List<UserFollowedPlaylist>();
        }

        private void FormPlaylist_Load(object sender, EventArgs e)
        {
            dgwPlaylist.DataSource = _playlistConnector.GetAll();
            dgwPlaylist.Columns["Name"].HeaderText = "Playlist Adı";
            dgwPlaylist.Columns["Description"].HeaderText = "Açıklama";
            dgwPlaylist.Columns["Public"].HeaderText = "Herkese Açık";
            dgwPlaylist.Columns["Id"].Visible = false;
            dgwPlaylist.Columns["UserId"].Visible = false;
            dgwPlaylist.Columns["DeletedAt"].Visible = false;
            dgwPlaylist.Columns["CreatedAt"].Visible = false;
            dgwPlaylist.Columns["UpdatedAt"].Visible = false;
            dgwPlaylist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (Properties.Settings.Default.isLogin)
            {
                _userLikedPlaylists = _userConnector.GetUserLikedPlaylists(Properties.Settings.Default.User.Id);
                _userFollowedPlaylists = _userConnector.GetUserFollowedPlaylists(Properties.Settings.Default.User.Id);
            }
            
        }

        private void btnPlaylsitFlw_Click(object sender, EventArgs e)
        {
            if (PlaylistPublic == false)
            {
                if (PlaylistUserId == Properties.Settings.Default.User.Id)
                {

                    Properties.Settings.Default.CustomMessage = "Kendi Playlistinizi Takip Edemezsiniz";
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
                else
                {
                    Properties.Settings.Default.CustomMessage = "Bu Playlist Gizlidir";
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
            }
            else
            {
                DgwPlaylistCurrentRow();
                if (BtnLoginWarning.EvaluateBtnClick())
                {
                    if (PlaylistUserId == Properties.Settings.Default.User.Id)
                    {
                        Properties.Settings.Default.CustomMessage = "Kendi Playlistinizi Beğenemezsiniz";
                        customMessageBox = new CustomMessageBox();
                        customMessageBox.Show();
                    }
                    else
                    {
                        var result = _userConnector.FollowedPlaylist(Properties.Settings.Default.User.Id, PlaylistId);
                        if (result)
                        {
                            Properties.Settings.Default.CustomMessage = "Takip Etme İşlemi Başarılı";
                            customMessageBox = new CustomMessageBox();
                            customMessageBox.Show();
                        }
                        else
                        {
                            Properties.Settings.Default.CustomMessage = "Daha Önceden Takip Edilmiş";
                            customMessageBox = new CustomMessageBox();
                            customMessageBox.Show();
                        }
                    }
                }
            }
        }

        private void dgwPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PlaylistId = Convert.ToInt64(dgwPlaylist.Rows[dgwPlaylist.CurrentRow.Index].Cells[0].Value);
            PlaylistPublic = Convert.ToBoolean(dgwPlaylist.CurrentRow.Cells["Public"].Value);
            PlaylistUserId = Convert.ToInt64(dgwPlaylist.CurrentRow.Cells["UserId"].Value);
            var theLikedPlaylist = _userLikedPlaylists.Where(x => x.PlaylistId == PlaylistId).FirstOrDefault();
            var theFollowedPlaylist = _userFollowedPlaylists.Where(x=>x.PlaylistId == PlaylistId).FirstOrDefault();
            if (theLikedPlaylist != null)
            {
                btnPlaylistLike.ButtonText = "Beğenilmiş";
            }
            else
            {
                btnPlaylistLike.ButtonText = "Beğen";
            }
            if (theFollowedPlaylist !=null)
            {
                btnPlaylistFlw.ButtonText = "Takip Ediliyor";
            }
            else
            {
                btnPlaylistFlw.ButtonText = "Takip Et";
            }
        }

        private void DgwPlaylistCurrentRow()
        {
            PlaylistId = Convert.ToInt64(dgwPlaylist.Rows[dgwPlaylist.CurrentRow.Index].Cells[0].Value);
            PlaylistPublic = Convert.ToBoolean(dgwPlaylist.CurrentRow.Cells["Public"].Value);
            PlaylistUserId = Convert.ToInt64(dgwPlaylist.CurrentRow.Cells["UserId"].Value);
        }

        private void btnPlaylistLike_Click(object sender, EventArgs e)
        {
            if (PlaylistPublic == false)
            {
                if (PlaylistUserId == Properties.Settings.Default.User.Id)
                {
                    Properties.Settings.Default.CustomMessage = "Kendi Playlistinizi Beğenemezsiniz";
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
                else
                {
                    Properties.Settings.Default.CustomMessage = "Bu Playlist Gizlidir";
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
            }
            else
            {
                DgwPlaylistCurrentRow();
                if (BtnLoginWarning.EvaluateBtnClick())
                {
                    if (PlaylistUserId == Properties.Settings.Default.User.Id)
                    {
                        Properties.Settings.Default.CustomMessage = "Kendi Playlistinizi Beğenemezsiniz";
                        customMessageBox = new CustomMessageBox();
                        customMessageBox.Show();
                    }
                    else
                    {
                        var result = _userConnector.LikedPlaylist(Properties.Settings.Default.User.Id, PlaylistId);
                        if (result)
                        {
                            Properties.Settings.Default.CustomMessage = "Beğenme İşlemi Başarılı";
                            customMessageBox = new CustomMessageBox();
                            customMessageBox.Show();
                        }
                        else
                        {
                            Properties.Settings.Default.CustomMessage = "Daha Önceden Beğenilmiş";
                            customMessageBox = new CustomMessageBox();
                            customMessageBox.Show();
                        }
                    }
                    
                }
            }
            
        }

        private void btnPlaylistShow_Click(object sender, EventArgs e)
        {
            if (PlaylistPublic == false)
            {
                if (PlaylistUserId == Properties.Settings.Default.User.Id)
                {
                    DgwPlaylistCurrentRow();
                    MsgPlaylist msgPlaylist = new MsgPlaylist();
                    msgPlaylist.Show();
                }
                else
                {
                    Properties.Settings.Default.CustomMessage = "Bu Playlist Gizlidir";
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
            }
            else
            {
                DgwPlaylistCurrentRow();
                MsgPlaylist msgPlaylist = new MsgPlaylist();
                msgPlaylist.Show();
            }
        }
    }
}
