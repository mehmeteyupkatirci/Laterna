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
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
        }

        private void MsgBox_Load(object sender, EventArgs e)
        {
            int count = 0;
            while (true)
            {
                if(count == 0)
                {
                    panelBottom.BackColor = RGBColors.color6; 
                    count++;
                }
                else if(count == 1)
                {
                    panelBottom.BackColor = RGBColors.color5;
                    count++;
                }
                else if(count == 2)
                {
                    panelBottom.BackColor = RGBColors.color4;
                    count++;
                }
                else if(count == 3)
                {
                    panelBottom.BackColor = RGBColors.color3;
                    count++;
                }
                else if(count == 4)
                {
                    panelBottom.BackColor = RGBColors.color2;
                    count++;
                }
                else if (count == 5)
                {
                    panelBottom.BackColor = RGBColors.color1;
                    count++;
                }
                else
                {
                    count = 0;
                }

            }
        }


        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(255, 184, 0);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
    }
}
