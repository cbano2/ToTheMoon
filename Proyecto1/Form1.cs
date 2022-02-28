namespace Proyecto1



{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

       

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Form convertidor = new Form2() ; 

            convertidor.Show();

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            buttonIngresar.Enabled = false; 
        }

        private void controlBotones()
        {
            if (nombre.Text.Trim() != String.Empty && nombre.Text.All( Char.IsLetter ) )
            {
                buttonIngresar.Enabled = true;
                errorProvider1.SetError(nombre, "");
            }
            else
            {
                if (!nombre.Text.All(Char.IsLetter))
                {
                    errorProvider1.SetError(nombre, "El nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(nombre, "Debe introducir su nombre");
                }
                buttonIngresar.Enabled = false;
                nombre.Focus();
            }
            
        }


        private void nombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones(); 
        }
    }
}