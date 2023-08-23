using System.Data;

namespace AplicacionTomarNotas
{
    public partial class Form1 : Form
    {

        DataTable tabla;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            int indice = dtGridTabla.CurrentCell.RowIndex;

            String tituloNotaSeleccionada = tabla.Rows[indice].ItemArray[0].ToString();

            String mensajeNotaSeleccionada = tabla.Rows[indice].ItemArray[1].ToString();

            if (tituloNotaSeleccionada == txtTitulo.Text && mensajeNotaSeleccionada == txtMensaje.Text)
            {

                txtTitulo.Text = String.Empty;

                txtMensaje.Text = String.Empty;

            }

            tabla.Rows[indice].Delete();

        }

        private void btnNueva_Click(object sender, EventArgs e)
        {

            txtTitulo.Text = String.Empty;

            txtMensaje.Text = String.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            tabla = new DataTable();

            tabla.Columns.Add("Titulo", typeof(String));

            tabla.Columns.Add("Mensaje", typeof(String));

            dtGridTabla.DataSource = tabla;

            dtGridTabla.Columns["Mensaje"].Visible = false;

            dtGridTabla.Columns["Titulo"].Width = 250;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtTitulo.Text == String.Empty || txtMensaje.Text == String.Empty) MessageBox.Show("Error. Debes llenar los campos de texto para almacenar una nota");

            else tabla.Rows.Add(txtTitulo.Text, txtMensaje.Text);

            txtTitulo.Text = String.Empty;

            txtMensaje.Text = String.Empty;

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {

            try
            {
                int indice = dtGridTabla.CurrentCell.RowIndex;

                if (indice > -1)
                {

                    txtTitulo.Text = tabla.Rows[indice].ItemArray[0].ToString();

                    txtMensaje.Text = tabla.Rows[indice].ItemArray[1].ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error. No existe ninguna nota. Crea una para poder leerla");
            }


        }
    }
}