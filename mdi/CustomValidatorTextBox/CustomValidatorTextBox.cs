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
	/// <summary>
	/// Componente que nos permite controlar los datos que el usuario introduce antes de ser enviados a la BBDD.
	/// Tambien nos permite informar mensajes de error o informacion.
	/// </summary>
	public class CustomValidatorTextBox : System.Windows.Forms.TextBox
	{
		
		#region "Propiedades"
		/// <summary>
		/// Indica a que campo de laa BBDD hace referencia
		/// </summary>
		public String zzCampoBd { get; set; }
		
		/// <summary>
		/// Indica si el componente ha de validar la longitud del texto
		/// </summary>
		public Boolean zzValidateLength { get; set; }
		
		/// <summary>
		/// Indica la longitud maxima que puede tener el texto.
		/// </summary>
		public Int16 zzValidMaxLength { get; set; }
		
		/// <summary>
		/// Indica si se ha de validar si el texto es un numero
		/// </summary>
		public Boolean zzValidateIsNumeric { get; set; }
		
		/// <summary>
		/// Propiedad que devuelve el texto escapado.
		/// </summary>
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
		
		#endregion

		#region "Metodos"
		
		/// <summary>
		/// Metodo para poner el texto en modo de error.
		/// Despues de 5 segundos oculta el componente.
		/// </summary>
		/// <param name="msg">Texto que se mostrara como error</param>
		public void setError(String msg)
		{
			this.Visible = true;

			this.ForeColor = System.Drawing.Color.Black;
			this.BackColor = System.Drawing.Color.Red;
			this.Text = msg;
			Thread th = new Thread(new ThreadStart(sleep));
			th.Start();
		}
		
		/// <summary>
		/// Metodo que pone el texto en modo error y no lo oculta. A los 3 segundos le quita el modo error.
		/// </summary>
		/// <param name="msg">Texto que se mostrara como error</param>
		public void setErrorColor(String msg)
		{
			this.Visible = true;

			this.ForeColor = System.Drawing.Color.Black;
			this.BackColor = System.Drawing.Color.Red;
			this.Text = msg;

			Thread th = new Thread(new ThreadStart(changeColor));
			th.Start();

		}

		/// <summary>
		/// Metodo usado por setErrorColor. Cambia el color del texto a rojo, para indicar que es un error.
		/// Despues de 3 segundos lo vuelve a Blanco.
		/// </summary>
		private void changeColor()
		{
			Thread.Sleep(3000);
			SetControlPropertyThreadSafe(this, "BackColor",  System.Drawing.Color.White);
			SetControlPropertyThreadSafe(this, "Text", "");
			
		}

		/// <summary>
		/// Metodo que pone el texto en modo menaje de informacion. 
		/// Despues de 5 segundos lo oculta.
		/// </summary>
		/// <param name="msg">Mensaje a mostrar como informacion.</param>
		public void setOK(String msg)
		{
			this.Visible = true;
			this.ForeColor = System.Drawing.Color.Black;
			this.BackColor = System.Drawing.Color.Green;
			this.Text = msg;
			Thread th = new Thread(new ThreadStart(sleep));
			th.Start();

		}

		/// <summary>
		/// Metodo que utiliza un delegado para acceder a una propiedad del componente (Cualquiera) desde otro thread.
		/// </summary>
		/// <param name="control">Componente interno a cambiar.</param>
		/// <param name="propertyName">Propiedad que se va a cambiar</param>
		/// <param name="propertyValue">valor de la propiedad.</param>
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

		
		/// <summary>
		/// Metodo usado para hacer esperar al thread 3 segundos antes de cambiar otra vez la propiedad "Visible"
		/// </summary>
		private void sleep()
		{
			Thread.Sleep(3000);
			SetControlPropertyThreadSafe(this, "Visible", false);
		}

		
		/// <summary>
		/// Metodo que se lanza al abandonar el componente.
		/// Es usado para hacer las comprobaciones del texto.
		/// Si alguna comprobacion falla elimina el texto.
		/// </summary>
		/// <param name="e">Parametro del evento</param>
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
		
		/// <summary>
		/// Metodo que comprueba si la cadena enviada es un numero valido.
		/// </summary>
		/// <param name="str">Cadena a comprobar</param>
		/// <returns>Booleano con el resultado de la comprobacion, true si es un numero correcto, false si no lo es.</returns>
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
		
		#endregion
		
		
		#region "Delegados"
		
		/// <summary>
		/// Delegado para poder cambiar propiedades del control desde otro Thread.
		/// </summary>
		private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);

		#endregion

	}
}
