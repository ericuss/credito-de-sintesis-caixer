using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;

namespace CustomValidatorTextBox
{
    public class CustomValidatorTextBox : System.Windows.Forms.TextBox
    {
        public String zzCampoBd { get; set; }     
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

            this.ForeColor = System.Drawing.Color.Black;
            this.BackColor = System.Drawing.Color.Red;
            this.Text = msg;
            Thread th = new Thread(new ThreadStart(sleep));
            th.Start();
        }

        public void setErrorColor(String msg)
        {
            this.Visible = true;

            this.ForeColor = System.Drawing.Color.Black;
            this.BackColor = System.Drawing.Color.Red;
            this.Text = msg;

            Thread th = new Thread(new ThreadStart(changeColor));
            th.Start();

        }

        private void changeColor()
        {
            Thread.Sleep(3000);
            SetControlPropertyThreadSafe(this, "BackColor",  System.Drawing.Color.White);
            SetControlPropertyThreadSafe(this, "Text", "");
          
        }

        public void setOK(String msg)
        {
            this.Visible = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.BackColor = System.Drawing.Color.Green;
            this.Text = msg;
            Thread th = new Thread(new ThreadStart(sleep));
            th.Start();

        }

        private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);

        public static void SetControlPropertyThreadSafe(Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate(SetControlPropertyThreadSafe), new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, control, new object[] { propertyValue });
            }
        }

        private void sleep()
        {
            Thread.Sleep(3000);
            SetControlPropertyThreadSafe(this, "Visible", false);
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
