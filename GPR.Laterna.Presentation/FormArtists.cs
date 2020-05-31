using GPR.Laterna.Entities.Concrete;
using GPR.Laterna.Presentation.Business;
using GPR.Laterna.Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPR.Laterna.Presentation
{
    public partial class FormArtists : Form
    {
        public static long ArtistId = 0;

        CustomMessageBox customMessageBox;

        private ArtistConnector _artistConnector;
        private UserConnector _userConnector;

        private List<UserLikedArtist> _userLikedArtists;
        private List<UserFollowedArtist> _userFollowedArtists;

        public FormArtists()
        {
            InitializeComponent();
            _artistConnector = new ArtistConnector();
            _userConnector = new UserConnector();

            _userLikedArtists = new List<UserLikedArtist>();
            _userFollowedArtists = new List<UserFollowedArtist>();
        }

        private void FormArtists_Load(object sender, EventArgs e)
        {
            dgwArtist.DataSource = _artistConnector.GetAll();
            dgwArtist.Columns["Name"].HeaderText = "Şarkıcı Adı";
            dgwArtist.Columns["Genres"].HeaderText = "Türü";
            dgwArtist.Columns["Popularity"].HeaderText = "Popülerlik %100";
            dgwArtist.Columns["SpotId"].HeaderText = "Spotify Id";
            dgwArtist.Columns["Id"].Visible = false;
            dgwArtist.Columns["Images"].Visible = false;
            dgwArtist.Columns["CreatedAt"].Visible = false;
            dgwArtist.Columns["Checked"].Visible = false;
            dgwArtist.Columns["Searched"].Visible = false;
            dgwArtist.Columns["UpdatedAt"].Visible = false;
            dgwArtist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (Properties.Settings.Default.isLogin)
            {
                _userLikedArtists = _userConnector.GetUserLikedArtists(Properties.Settings.Default.User.Id);
                _userFollowedArtists = _userConnector.GetUserFollowedArtists(Properties.Settings.Default.User.Id);
            }
        }

        private void dgwArtist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ArtistId = Convert.ToInt64(dgwArtist.Rows[dgwArtist.CurrentRow.Index].Cells[0].Value);
            var theLikedArtist = _userLikedArtists.Where(x => x.ArtistId == ArtistId).FirstOrDefault();
            var theFollowedArtist = _userFollowedArtists.Where(x=>x.ArtistId == ArtistId).FirstOrDefault();
            if(theLikedArtist != null)
            {
                BtnArtistLike.ButtonText = "Beğendin";
            }
            else
            {
                BtnArtistLike.ButtonText = "Beğen";
            }
            if (theFollowedArtist != null)
            {
                btnArtistFollow.ButtonText = "Takip Ediliyor";
            }
            else
            {
                btnArtistFollow.ButtonText = "Takip Et";
            }
        }

        private void btnArtistShow_Click(object sender, EventArgs e)
        {
            DgwArtistCurrentRow();
            MsgArtist msgArtist = new MsgArtist();
            msgArtist.Show();
        }

        private void btnArtistFlw_Click(object sender, EventArgs e)
        {
            DgwArtistCurrentRow();
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                var result = _userConnector.FollowArtist(Properties.Settings.Default.User.Id, ArtistId);
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
        private void DgwArtistCurrentRow()
        {
            ArtistId = Convert.ToInt64(dgwArtist.Rows[dgwArtist.CurrentRow.Index].Cells[0].Value);
        }

        private void BtnArtistLike_Click(object sender, EventArgs e)
        {
            DgwArtistCurrentRow();
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                var result = _userConnector.LikedArtist(Properties.Settings.Default.User.Id, ArtistId);
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

        private void btnArtistFollow_Click(object sender, EventArgs e)
        {

            DgwArtistCurrentRow();
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                var result = _userConnector.FollowArtist(Properties.Settings.Default.User.Id, ArtistId);
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
