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

        private ArtistConnector _artistConnector;
        private UserConnector _userConnector;

        public FormArtists()
        {
            InitializeComponent();
            _artistConnector = new ArtistConnector();
            _userConnector = new UserConnector();
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
        }

        private void dgwArtist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ArtistId = Convert.ToInt64(dgwArtist.Rows[dgwArtist.CurrentRow.Index].Cells[0].Value);
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
                    MessageBox.Show("Takip etme başarılı");
                }
                else
                {
                    MessageBox.Show("Zaten takip edilmiş");
                }

            }
        }

        private void btnArtistLike_Click(object sender, EventArgs e)
        {
            DgwArtistCurrentRow();
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                var result =  _userConnector.LikedArtist(Properties.Settings.Default.User.Id, ArtistId);
                if (result)
                {
                    MessageBox.Show("Beğenme başarılı");
                }
                else
                {
                    MessageBox.Show("zaten beğenilmiş");
                }
            }
        } 
        
        private void DgwArtistCurrentRow()
        {
            ArtistId = Convert.ToInt64(dgwArtist.Rows[dgwArtist.CurrentRow.Index].Cells[0].Value);
        }
    }

}
