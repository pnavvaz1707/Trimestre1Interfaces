/*
* PRÁCTICA.............: Práctica 9
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 31 de Enero de 2023
*/
namespace Practica9
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void contadorSplash_Tick(object sender, EventArgs e)
        {
            barraProgresoSplash.Increment(2);
            if (barraProgresoSplash.Value == barraProgresoSplash.Maximum)
            {
                contadorSplash.Stop();
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.Show();
            }
        }
    }
}
