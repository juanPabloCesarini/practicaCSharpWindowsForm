using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2Ej1
{
    public partial class FRMForm1 : Form
    {
        public FRMForm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDNI_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtEdad.Clear();
            txtResultado.Clear();
            txtNombre.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, dni;
            int edad;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            dni = txtDNI.Text;
            edad = int.Parse(txtEdad.Text);

            txtResultado.Text = "Nombre: " + nombre + " Apellido: " + apellido + " DNI: " + dni + " edad: " + edad + " años";
        }
    }
}
