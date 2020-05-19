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




            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn.HeaderText = "image";
            //dgwArtist.Columns.Insert(0, imageColumn);
            //foreach (DataGridViewRow row in dgwArtist.Rows)
            //{
            //    var url = row.Cells["Images"].Value.ToString();
            //    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
            //    myRequest.Method = "GET";
            //    HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            //    Bitmap bitmap = new Bitmap(myResponse.GetResponseStream());
            //    myResponse.Close();

            //    row.Cells[0].Value = bitmap;
            //}
        }

    }   

}
