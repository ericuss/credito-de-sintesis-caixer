using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace CustomValidatorTextBox
{
    public class CustomValidatorTextBox : System.Windows.Forms.TextBox
    {
        public Boolean zzValidateLength { get; set; }
        public Int16 zzValidMaxLength { get; set; }
        public Boolean zzValidateIsNumeric { get; set; }
      
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

        public void setError(String msg)
        {
            this.Visible = true;
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.BackColor = System.Drawing.Color.Red;
            this.Text = msg;
        }
        public void setOK(String msg)
        {
            this.Visible = true;
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.BackColor = System.Drawing.Color.Green;
            this.Text = msg;

        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            ((CustomValidatorTextBox)source).Visible = false;
        }


        protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
        {
            if (this.zzValidateLength == true)
            {
                if (this.Text.Length > this.zzValidMaxLength)
                {
                    this.Text = "";
                }
            }
            if (this.zzValidateIsNumeric == true)
            {
                if (!isNumeric(this.Text))
                {
                    this.Text = "";
                }
            }
        }
        private static Boolean isNumeric(String str)
        {
            try
            {
                Double i;
                i = Convert.ToDouble(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
