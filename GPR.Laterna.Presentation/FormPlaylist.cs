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
    public partial class FormPlaylist : Form
    {
        private PlaylistConnector _playlistConnector;
        public FormPlaylist()
        {
            InitializeComponent();
            _playlistConnector = new PlaylistConnector();
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
        }
    }
}
