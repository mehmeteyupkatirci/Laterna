using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPR.Laterna.Presentation.Helpers
{
    public class BtnLoginWarning
    {
        public static bool EvaluateBtnClick()
        {
            if (!Properties.Settings.Default.isLogin)
            {
                MessageBox.Show("Lütfen giriş yapınız");
                return false;
            }
            return true;
        }
    }
}
