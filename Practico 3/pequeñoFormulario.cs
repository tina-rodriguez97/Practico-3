using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Practico_3
{
    public partial class peque�oFormulario : Form
    {
        public peque�oFormulario()
        {
            InitializeComponent();
        }

        private void rbMujer_CheckedChanged(object sender, EventArgs e)
        {

            imgSeleccionar.Image = Properties.Resources.mujer; ;

        }

        private void rbHombre_CheckedChanged(object sender, EventArgs e)
        {

            imgSeleccionar.Image = Properties.Resources.varon;

        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string errores = "";
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();

            // Verificar si todos los campos est�n completos
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))

            {
                errores += "Debe completar todos los campos.\n";
            }
            else
            {
                // Validar DNI
                if (!Regex.IsMatch(txtDNI.Text, @"^\d+$"))
                {
                    errores += "El campo DNI solo permite n�meros.\n";
                }

                // Validar Nombre
                if (!Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
                {
                    errores += "El campo Nombre solo permite letras.\n";
                }

                // Validar Apellido
                if (!Regex.IsMatch(apellido, @"^[a-zA-Z\s]+$"))
                {
                    errores += "El campo Apellido solo permite letras.\n";
                }

                // Validar Telefono
                if (!Regex.IsMatch(txtTelefono.Text, @"^\d+$"))
                {
                    errores += "El campo Telefono solo permite n�meros.\n";
                }
            }

            // Actualizar el label "modificar" con los campos que se han completado
            lblModificar.Text = string.IsNullOrWhiteSpace(nombre) && string.IsNullOrWhiteSpace(apellido)
                ? "modificar"
                : $"{nombre} {apellido}".Trim();

            // Mostrar los errores si existen
            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show(errores, "Errores de Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Si hay errores, no continuar con la inserci�n
            }

            // Mostrar la ventana de confirmaci�n
            DialogResult result = MessageBox.Show(
                "�Seguro que desea insertar un nuevo cliente?",
                "Confirmaci�n",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1); // Button1 pone el foco en "S�"

            // Si el usuario selecciona "S�"
            if (result == DialogResult.Yes)
            {
                string nombreCompleto = $"{nombre} {apellido}".Trim();

                // Mostrar el mensaje de que el cliente se insert� correctamente
                MessageBox.Show(
                    $"El cliente '{nombreCompleto}' se insert� correctamente.",
                    "Cliente Insertado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = $"{txtNombre.Text} {txtApellido.Text}";

            // Mostrar la ventana de confirmaci�n para eliminar
            DialogResult result = MessageBox.Show(
                $"Est� a punto de eliminar al cliente: {nombreCompleto}",
                "Confirmaci�n de Eliminaci�n",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2); // Button2 pone el foco en "No"

            // Si el usuario selecciona "S�"
            if (result == DialogResult.Yes)
            {
                // Mostrar el mensaje de que el cliente se elimin� correctamente
                MessageBox.Show(
                    $"El cliente '{nombreCompleto}' se elimin� correctamente.",
                    "Cliente Eliminado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        
    }
}
