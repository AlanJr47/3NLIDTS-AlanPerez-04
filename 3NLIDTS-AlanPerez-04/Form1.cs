using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_AlanPerez_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            string apellidos = txbApellidos.Text;
            string telefono = txbTelefono.Text;
            string edad = txbEdad.Text;
            string estatura = txbEstatura.Text;
            string genero = "";
            if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }
            else if (rbMasculino.Checked)
            {
                genero = "Masculino";
            }
            else if (rbOtro.Checked)
            {
                genero = "Otro";
            }
            string mensaje = $" Nombre: {nombre}\n\r Apellidos: {apellidos}\n\r Telefono: {telefono}\n\r Edad: {edad}\n\r Estatura: {estatura}\n\r Genero: {genero}";
            // ruta de almacenamiento
            string rutaArchivo = "C:\\Users\\A11an\\Documentos Programacion Avanzada\\3NAgoDic26.txt";
            bool ArchivoExiste = File.Exists(rutaArchivo);
            using (StreamWriter escritor = new StreamWriter(rutaArchivo, true))
            {
                if (ArchivoExiste)
                {
                    escritor.WriteLine();
                }
                escritor.WriteLine(mensaje);

            }
            MessageBox.Show(mensaje, "Confirmación de resgistro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbNombre.Clear();
            txbApellidos.Clear();
            txbTelefono.Clear();
            txbEstatura.Clear();
            txbEdad.Clear();
            rbFemenino.Checked = false;
            rbMasculino .Checked = false;
            rbOtro .Checked = false;
        }
    }
}
