using Sport.AppForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport.Services
{
    /// <summary>
    /// PKGH
    /// Настройка форм и элементов управления.
    /// </summary>
    internal class UserExperienceManager
    {
        public static void SetTitle(Form form, string text)
        {
            Label label = form.Controls.Find("titleLabelAttentionFont", true).FirstOrDefault() as Label;
            label.Text = text.ToUpper();
            form.Text = text;
        }

        public static void CustomizeControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Name.Contains("AttentionBackground"))
                {
                    control.BackColor = ColorTranslator.FromHtml(Constants.Color.attentionColor);
                }
                if (control.Name.Contains("AttentionFont"))
                {
                    control.ForeColor = ColorTranslator.FromHtml(Constants.Color.attentionColor);
                }
            }
            
        }
    }
}
