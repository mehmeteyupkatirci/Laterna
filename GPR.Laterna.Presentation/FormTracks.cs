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
    public partial class FormTracks : Form
    {
        public static int TrackId = 0;
        private TrackConnector _trackConnector;
        public FormTracks()
        {
            InitializeComponent();
            _trackConnector = new TrackConnector();
        }
        private void FormTracks_Load(object sender, EventArgs e)
        {
            dgwTrack.DataSource = _trackConnector.GetAll();
            dgwTrack.Columns["Name"].HeaderText = "Şarkı Adı";
            dgwTrack.Columns["Popularity"].HeaderText = "Popülerlik %100";
            dgwTrack.Columns["SpotId"].Visible = false;
            dgwTrack.Columns["Id"].Visible = false;
            dgwTrack.Columns["AlbumId"].Visible = false;
            dgwTrack.Columns["DurationMs"].Visible = false;
            dgwTrack.Columns["DiscNumber"].Visible = false;
            dgwTrack.Columns["CreatedAt"].Visible = false;
            dgwTrack.Columns["UpdatedAt"].Visible = false;
            dgwTrack.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dgwTrack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnTrackShow_Click(object sender, EventArgs e)
        {
            //seçili row'daki id ile form çağırma işlemi
            int id = Convert.ToInt32(dgwTrack.Rows[dgwTrack.CurrentRow.Index].Cells[0].Value);
            TrackId = id;
            MsgTrack msgTrack = new MsgTrack();
            msgTrack.Show();
        }
    }
}
