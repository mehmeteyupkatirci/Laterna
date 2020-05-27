using GPR.Laterna.Presentation.Business;
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
        public static int ArtistId = 0;
        private ArtistConnector _artistConnector;
        public FormArtists()
        {
            InitializeComponent();
            _artistConnector = new ArtistConnector();
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

        }

        private void btnArtistShow_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwArtist.Rows[dgwArtist.CurrentRow.Index].Cells[0].Value);
            ArtistId = id;
            MsgArtist msgArtist = new MsgArtist();
            msgArtist.Show();
        }
    }

}
