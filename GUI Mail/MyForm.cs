using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Mail
{
    public class MyForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            if (DataWorker.CurrentUser != null)
            {
                if (DataWorker.CurrentUser.Theme == "Green")
                {
                    foreach (Button control in GetAll(this, typeof(Button)))
                    {
                        control.BackColor = ColorTranslator.FromHtml("#BAD696");
                        control.FlatStyle = FlatStyle.Flat;
                        control.FlatAppearance.BorderSize = 1;
                        control.FlatAppearance.BorderColor = Color.Green;
                    }
                    foreach (var control in GetAll(this, typeof(MenuStrip)))
                    {
                        control.BackColor = ColorTranslator.FromHtml("#a3db60");
                    }
                    /*foreach (var control in GetAll(this, typeof(RichTextBox)))
                    {
                        control.BackColor = ColorTranslator.FromHtml("#212E3F");
                        control.ForeColor = Color.White;
                    }
                    foreach (var control in GetAll(this, typeof(ListView)))
                    {
                        control.BackColor = ColorTranslator.FromHtml("#212E3F");
                        control.ForeColor = Color.White;
                    }*/
                    BackColor = ColorTranslator.FromHtml("#E4F1C3");
                }
            }
        }

        public
            List<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type).ToList();
        }
    }
}
