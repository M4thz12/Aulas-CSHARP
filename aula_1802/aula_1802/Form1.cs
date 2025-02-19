namespace aula_1802
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            validarUsuario(txtUsuario.Text, txtSenha.Text);
            txtSenha.Clear();
            txtUsuario.Clear();
        }

        inicio telaNova = new inicio();
        private void validarUsuario(string usuario, string senha)
        {
            if (usuario == "fiap" && senha == "2025")
            {
                MessageBox.Show("Usuario e senha corretos!");
                telaNova.Show();
            }
            else
            {
                MessageBox.Show("Usuario e senha incorretos!");
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
