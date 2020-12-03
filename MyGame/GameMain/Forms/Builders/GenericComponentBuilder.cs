using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame.GameMain.Forms.Builders
{
    public class GenericComponentBuilder : Form
    {
        public void newLabel(string labelName, string labelText, int labelTop, int labelLeft, int labelWidth, Form form)
        {
            Label label = new Label();
            label.Name = labelName;
            label.Text = labelText;
            label.Top = labelTop;
            label.Left = labelLeft;
            label.Width = labelWidth;

            addComponentToForm(form, label);
        }

        public void addComponentToForm(Form form, Control control)
        {
            form.Controls.Add(control);
        }
    }
}
