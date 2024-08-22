using System.Diagnostics.Eventing.Reader;

namespace RegistroContactosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            if (TextBoxNombre.Text != "" && TextBoxTelefono.Text != "" && TextBoxEmail.Text != "")
            {
                string contacto = $"{conteoRegistros}.  Nombre: {TextBoxNombre.Text}  -  Teléfono: {TextBoxTelefono.Text}  -  Correo Electrónico: {TextBoxEmail.Text}";
                ListBoxContactos.Items.Add(contacto);

                LabelEstado.Text = "Contacto agregado con éxito :)";
                LabelEstado.ForeColor = System.Drawing.Color.Green;

                conteoRegistros += 1;
            }
            else
            {
                LabelEstado.Text = "Por favor, complete todos los campos :(";
                LabelEstado.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            TextBoxNombre.Clear();
            TextBoxTelefono.Clear();   
            TextBoxEmail.Clear();
            LabelEstado.Text = "";
        }
    }
}
