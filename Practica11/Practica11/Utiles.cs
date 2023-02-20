using System;
using System.Windows.Forms;


namespace Practica11
{
	/// <summary>
	/// Descripci�n breve de Utiles.
	/// </summary>
	public class Utiles
	{
		public static bool ResolucionCorrecta(int ancho, int alto)
		{
			bool correcto = false;
			System.Drawing.Rectangle pantalla = Screen.PrimaryScreen.Bounds;
			if (pantalla.Width >= ancho && pantalla.Height >= alto)
				correcto = true;
			return correcto;
		}
	}
}
