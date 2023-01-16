/*
* PRÁCTICA.............: Práctica 8
* NOMBRE y APELLIDOS...: Pablo Navarro Vázquez
* CURSO y GRUPO........: 2º Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 20 de Enero de 2023
*/

namespace Practica8
{
    partial class FormCrearAlumno : Form
    {
        private Grupo grupoSel;

        public FormCrearAlumno(Grupo grupoSel)
        {
            InitializeComponent();
            this.grupoSel = grupoSel;
            Width= 500;
            Height= 400;
        }


    }
}
