using System;
using System.Windows.Forms;

namespace Practica6
{
    /*
    * PRÁCTICA.............: Práctica 6.
    * NOMBRE Y APELLIDOS...: Fulanito de los Palotes
    * CURSO Y GRUPO........: 2º Desarrollo de Interfaces
    * TÍTULO DE LA PRÁCTICA: Aplicaciones de Formulario. Controles Básicos.
    * FECHA DE ENTREGA.....: 7 de diciembre de 2022
    */
    public partial class FormMain : Form
    {

        Empleado empleado;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int categoria, numHijos, numTrienios, numHorasExtras;

            categoria = Convert.ToInt16(cboCategoria.Text);
            numHijos = Convert.ToInt16(cboNumHijos.Text);
            numTrienios = Convert.ToInt16(cboNumTrienios.Text);
            numHorasExtras = Convert.ToInt16(cboNumHorasExtras.Text);

            empleado = new Empleado(txtNif.Text, txtNombreEmpleado.Text, categoria, numHijos, numTrienios);

            Nomina nomina = new Nomina(empleado, dtpFecha.Value, numHorasExtras);

            txtSalarioBase.Text = nomina.SalarioBase.ToString("C2");
            txtAntiguedad.Text = nomina.ImporteAntiguedad.ToString("C2");
            txtNumHorasExtrasDevengos.Text = nomina.ImporteHorasExtras.ToString("C2");
            txtPagaExtra.Text = nomina.DevengosPagaExtra.ToString("C2");
            txtTotalDevengos.Text = nomina.TotalDevengos.ToString("C2");


            txtCotizSS.Text = nomina.CotizacionSegSoc.ToString("C2");
            txtCotizDesempleo.Text = nomina.CotizacionSegDes.ToString("C2");
            txtIRPF.Text = nomina.RetencionIRPF.ToString("C2");
            txtTotalDescuentos.Text = nomina.TotalDescuentos.ToString("C2");

            txtLiquido.Text = (nomina.TotalDevengos - nomina.TotalDescuentos).ToString("C2");

            grpFormCrearEmpleado.Enabled = false;
            grpHojaSalarial.Visible = true;
        }

        private void pasarAlSigControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtNif_Leave(object sender, EventArgs e)
        {
            if (!Auxiliar.comprobarNif(txtNif.Text))
            {
                MessageBox.Show("El dni introducido no es válido", "NIF no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNif.Text = "";
                this.ActiveControl = txtNif;
            }
        }

        private void txtNombreEmpleado_Leave(object sender, EventArgs e)
        {
            if (!Auxiliar.comprobarNombre(txtNombreEmpleado.Text))
            {
                MessageBox.Show("El nombre es obligatorio y solo puede contener letras, guión y espacio", "Nombre no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreEmpleado.Text = "";
                this.ActiveControl = txtNombreEmpleado;
            }
        }

        private void cboCategoria_Leave(object sender, EventArgs e)
        {
            try
            {
                int categoria = Convert.ToInt16(cboCategoria.Text);
                if (!Auxiliar.comprobarEnteroEnUnRango(categoria, 1, 3))
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Datos no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCategoria.Text = "";
                this.ActiveControl = cboCategoria;
            }
        }

        private void cboNumHijos_Leave(object sender, EventArgs e)
        {
            try
            {
                int numHijos = Convert.ToInt16(cboNumHijos.Text);
                if (!Auxiliar.comprobarEnteroEnUnRango(numHijos, 0, 4))
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Datos no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNumHijos.Text = "0";
            }
        }

        private void cboNumTrienios_Leave(object sender, EventArgs e)
        {
            try
            {
                int numTrienios = Convert.ToInt16(cboNumTrienios.Text);
                if (!Auxiliar.comprobarEnteroEnUnRango(numTrienios, 1, 12))
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Datos no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNumTrienios.Text = "0";
            }
        }

        private void cboNumHorasExtras_Leave(object sender, EventArgs e)
        {
            try
            {
                int numHorasExtras = Convert.ToInt16(cboNumHorasExtras.Text);
                if (!Auxiliar.comprobarEnteroEnUnRango(numHorasExtras, 0, 15))
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Datos no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNumHorasExtras.Text = "";
                this.ActiveControl = cboNumHorasExtras;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            grpFormCrearEmpleado.Enabled = true;
            grpHojaSalarial.Visible = false;
        }
    }
}
