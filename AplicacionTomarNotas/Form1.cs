namespace AplicacionTomarNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnNueva_Click(object sender, EventArgs e)
        {

            txtTitulo.Text = String.Empty;

            txtMensaje.Text = String.Empty;

        }
    }
}