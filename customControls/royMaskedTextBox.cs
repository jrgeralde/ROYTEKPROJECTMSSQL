using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RoyTekProjectSQL.customControls
{
    public class royMaskedTextBox : System.Windows.Forms.TextBox
    {
        protected override void OnKeyDown(KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }

            else
            {
                base.OnKeyDown(e);
            }
        }

    }
}
