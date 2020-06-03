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
    public partial class FormAlbums : Form
    {
        public static long AlbumId = 0;

        CustomMessageBox customMessageBox;

        private AlbumConnector _albumConnector;
        private UserConnector _userConnector;
        private List<UserFollowedAlbum> _userFollowedAlbums;
        private List<UserLikedAlbum> _userLikedAlbums;

        public FormAlbums()
        {
            InitializeComponent();
            _albumConnector = new AlbumConnector();
            _userConnector = new UserConnector();

            _userFollowedAlbums = new List<UserFollowedAlbum>();
            _userLikedAlbums = new List<UserLikedAlbum>();
        }

        private void FormAlbums_Load(object sender, EventArgs e)
        {
            LoadAlbumDGV();
            LoadUserAlbumDGV();
        }

        private void LoadUserAlbumDGV()
        {
            if (Properties.Settings.Default.isLogin)
            {
                _userLikedAlbums = _userConnector.GetUserLikedAlbums(Properties.Settings.Default.User.Id);
                _userFollowedAlbums = _userConnector.GetUserFollowedAlbums(Properties.Settings.Default.User.Id);
            }
        }

        private void LoadAlbumDGV()
        {
            dgwAlbum.DataSource = _albumConnector.GetAll();
            dgwAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //DataGridView'da gizlenecek sütunlar
            dgwAlbum.Columns["Id"].Visible = false;
            dgwAlbum.Columns["ArtistId"].Visible = false;
            dgwAlbum.Columns["AlbumTypeId"].Visible = false;
            dgwAlbum.Columns["Copyrights"].Visible = false;
            dgwAlbum.Columns["Checked"].Visible = false;
            dgwAlbum.Columns["CreatedAt"].Visible = false;
            dgwAlbum.Columns["UpdatedAt"].Visible = false;
            dgwAlbum.Columns["Images"].Visible = false;


            //DatagridView 'da gözükecek sütunlar ve Türkçe isimlendirme işlemi
            dgwAlbum.Columns["Name"].HeaderText = "Albüm Adı";
            dgwAlbum.Columns["SpotId"].HeaderText = "Spotify Id";
            dgwAlbum.Columns["Popularity"].HeaderText = "Popülerlik %100";
            dgwAlbum.Columns["ReleaseData"].HeaderText = "Çıkış Tarihi";
        }

        private void btnAlbumShow_Click(object sender, EventArgs e)
        {
            DgwAlbumCurrenRow();
            MsgAlbum msgAlbum = new MsgAlbum();
            msgAlbum.Show();
        }

        private void dgwAlbum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlbumId = Convert.ToInt64(dgwAlbum.Rows[dgwAlbum.CurrentRow.Index].Cells[0].Value);
            var theLikedAlbum = _userLikedAlbums.Where(x=>x.AlbumId==AlbumId).FirstOrDefault();
            var theFollowedAlbum = _userFollowedAlbums.Where(x=>x.AlbumId==AlbumId).FirstOrDefault();
            if (theLikedAlbum != null)
            {
                btnAlbumLike.ButtonText = "Beğenmekten\nVazgeç";
                btnAlbumLike.Font = new Font("Microsoft Sans Serif", 10);
            }
            else
            {
                btnAlbumLike.Font = new Font("Microsoft Sans Serif", 14);
                btnAlbumLike.ButtonText = "Beğen";
            }
            if (theFollowedAlbum != null)
            {
                btnAlbumFlw.ButtonText = "Takipten Çık";
            }
            else
            {
                btnAlbumFlw.ButtonText = "Takip Et";
            }
        }

        private void btnAlbumFlw_Click(object sender, EventArgs e)
        {
            DgwAlbumCurrenRow();
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                var result = _userConnector.FollowAlbum(Properties.Settings.Default.User.Id, AlbumId);
                if (result)
                {
                    Properties.Settings.Default.CustomMessage = "Takip Etme İşlemi Başarılı";
                    LoadAlbumDGV();
                    LoadUserAlbumDGV();
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
                else
                {
                    var theFollowedAlbum = _userFollowedAlbums.Where(x => x.AlbumId == AlbumId).FirstOrDefault();
                    _userConnector.DeleteUserFollowedAlbum(theFollowedAlbum.Id);
                    Properties.Settings.Default.CustomMessage = "Takipten Çıkarıldı";
                    LoadAlbumDGV();
                    LoadUserAlbumDGV();
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
            }
        }

        private void btnAlbumLike_Click(object sender, EventArgs e)
        {
            DgwAlbumCurrenRow();
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                var result = _userConnector.LikedAlbum(Properties.Settings.Default.User.Id, AlbumId);
                if (result)
                {
                    Properties.Settings.Default.CustomMessage = "Beğenme İşlemi Başarılı";
                    LoadAlbumDGV();
                    LoadUserAlbumDGV();
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }
                else
                {
                    var theLikedAlbum = _userLikedAlbums.Where(x => x.AlbumId == AlbumId).FirstOrDefault();
                    _userConnector.DeleteUserLikedAlbum(theLikedAlbum.Id);
                    Properties.Settings.Default.CustomMessage = "Beğenmekten Vazgeçildi";
                    LoadAlbumDGV();
                    LoadUserAlbumDGV();
                    customMessageBox = new CustomMessageBox();
                    customMessageBox.Show();
                }

            }
        }

        private void DgwAlbumCurrenRow()
        {
            AlbumId = Convert.ToInt64(dgwAlbum.Rows[dgwAlbum.CurrentRow.Index].Cells[0].Value);
        }
    }
}
