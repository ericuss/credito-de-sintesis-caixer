using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomValidatorTextBox
{
    public class CustomValidatorTextBox : System.Windows.Forms.TextBox
    {
        public String ValidValue
        {
            get
            {
                if (this.Text.Contains("'"))
                {
                    this.Text = this.Text.Replace("'", "''");
                }
                else if (this.Text.Contains('"'))
                {
                    this.Text = this.Text.Replace("\"", "\\\"");
                }
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }
    }
}
