using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci
{
    internal class Helper
    {
        public static void Temizle(Control.ControlCollection controlCollection) 
        {
          foreach (Control control in controlCollection)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Name == "rbnKucuk")
                    {
                        rb.Checked = true;
                    }
                    else { rb.Checked = false; }
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;  

                }
                else if(control is FlowLayoutPanel)
                {
                    FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)control;
                    Temizle(flowLayoutPanel.Controls);
                }
                else if (control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;
                    Temizle(groupBox.Controls);
                }
            }
        }
    }
}
