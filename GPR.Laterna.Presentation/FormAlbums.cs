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
        private AlbumConnector _albumConnector;
        private UserConnector _userConnector;
        public FormAlbums()
        {
            InitializeComponent();
            _albumConnector = new AlbumConnector();
            _userConnector = new UserConnector();
        }

        private void FormAlbums_Load(object sender, EventArgs e)
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
            MsgAlbum msgAlbum = new MsgAlbum();
            msgAlbum.Show();
        }

        private void dgwAlbum_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AlbumId = Convert.ToInt64(dgwAlbum.Rows[dgwAlbum.CurrentRow.Index].Cells[0].Value);
        }

        private void btnAlbumFlw_Click(object sender, EventArgs e)
        {
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                var result = _userConnector.FollowAlbum(Properties.Settings.Default.User.Id, AlbumId);
                if (result)
                {
                    MessageBox.Show("Takip etme başarılı");
                }
                else
                {
                    MessageBox.Show("Zaten takip edilmiş");
                }

            }
        }

        private void btnAlbumLike_Click(object sender, EventArgs e)
        {
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                var result = _userConnector.LikedAlbum(Properties.Settings.Default.User.Id, AlbumId);
                if (result)
                {
                    MessageBox.Show("Beğenme işlemi başarılı");
                }
                else
                {
                    MessageBox.Show("Zaten beğenilmiş");
                }

            }
        }
    }
}
