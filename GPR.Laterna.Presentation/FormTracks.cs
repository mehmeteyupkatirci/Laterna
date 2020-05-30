﻿using GPR.Laterna.Presentation.Business;
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
    public partial class FormTracks : Form
    {
        public static long TrackId = 0;
        private TrackConnector _trackConnector;
        private UserConnector _userConnector;
        public FormTracks()
        {
            InitializeComponent();
            _trackConnector = new TrackConnector();
            _userConnector = new UserConnector();
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
            TrackId = Convert.ToInt64(dgwTrack.Rows[dgwTrack.CurrentRow.Index].Cells[0].Value);
        }

        private void DgwTrackCurrentRow()
        {
            TrackId = Convert.ToInt64(dgwTrack.Rows[dgwTrack.CurrentRow.Index].Cells[0].Value);
        }

        private void btnTrackShow_Click(object sender, EventArgs e)
        {
            DgwTrackCurrentRow();
            MsgTrack msgTrack = new MsgTrack();
            msgTrack.Show();
        }

        private void btnTrackFlw_Click(object sender, EventArgs e)
        {
            DgwTrackCurrentRow();
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                var result = _userConnector.FollowTrack(Properties.Settings.Default.User.Id, TrackId);
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

        private void btnTrackLike_Click(object sender, EventArgs e)
        {
            DgwTrackCurrentRow();
            if (BtnLoginWarning.EvaluateBtnClick())
            {
                var result = _userConnector.LikedTrack(Properties.Settings.Default.User.Id, TrackId);
                if (result)
                {
                    MessageBox.Show("Beğenme başarılı");
                }
                else
                {
                    MessageBox.Show("Zaten beğenilmiş");
                }
            }
        }
    }
}
