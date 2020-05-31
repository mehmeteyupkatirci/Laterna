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
            CustomMessageBox customMessageBox;
            if (!Properties.Settings.Default.isLogin)
            {
                Properties.Settings.Default.CustomMessage= "Lütfen giriş yapınız";
                customMessageBox = new CustomMessageBox();
                customMessageBox.Show();
                return false;
            }
            return true;
        }
    }
}
