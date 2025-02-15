using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyTekProjectSQL.customControls
{
    public class royN0TextBox : System.Windows.Forms.TextBox
    {
       // bool ignoreChange = false;
       // List<string> storageUndo = null;
       // List<string> storageRedo = null;

        /*
        
        protected override void OnCreateControl()
        {
          //  base.OnCreateControl();
            this.TextAlign = HorizontalAlignment.Right;
            ignoreChange = true;
            storageUndo = new List<string>();
             ignoreChange = false;
           
        }

        
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (!ignoreChange)
            {
                this.ClearUndo();
                if (storageUndo.Count > 2048) storageUndo.RemoveAt(0);
                if (storageRedo.Count > 2048) storageRedo.RemoveAt(0);

                storageUndo.Add(this.Text);
            }
        }
        */
        protected override void OnLeave(EventArgs e)
        {
            String txt = this.Text.Trim();
            if (txt == "") txt = "0";

            int i = int.Parse(txt);
            String st = i.ToString("N0");

            this.Text = st;
             base.OnLeave(e);
         }

        protected override void OnEnter(EventArgs e)
        {
            String st = this.Text;

            st=st.Replace(",", "");
            this.Text = st;
            base.OnEnter(e);
        }
        
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch !=8) // && ch!=46)  numbers, backspace and decimal point
            {
                e.Handled = true;
            }
        }

        
        protected override void OnKeyDown(KeyEventArgs e)
        {
          
            /*
            if (e.KeyCode == Keys.Z && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                this.ClearUndo();
                ignoreChange = true;
                this.Undo();
                ignoreChange = false;
            }
            else if (e.KeyCode == Keys.Y && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                this.ClearUndo();
                ignoreChange = true;
                this.Redo();
                ignoreChange = false;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                this.ClearUndo();
                ignoreChange = true;
                this.Undo();
                ignoreChange = false;

            }
            */
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

        /*
        public void Redo()
        {
            if (storageRedo.Count > 0)
            {
                this.ignoreChange = true;
                this.Text = storageRedo[storageRedo.Count - 1];
                storageUndo.Add(this.Text);
                storageRedo.RemoveAt(storageRedo.Count - 1);
                this.ignoreChange = false;
            }
        }

        public new void Undo()
        {
            if (storageUndo.Count > 0)
            {
                this.ignoreChange = true;
                storageRedo.Add(this.Text);
                this.Text = storageUndo[storageUndo.Count - 1];
                storageUndo.RemoveAt(storageUndo.Count - 1);
                this.ignoreChange = false;
            }
        }
        */
    }
}
