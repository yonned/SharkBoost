namespace OtimizaçãoCésar
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Equals("admin") && txtSenha.Text.Equals("123"))
                {
                    // Inicio do SharkBoost v0.1:

                    // Pequeno projeto de otimização feito por César Rodrigues Ribeiro (@Zuqqt no GitHub)!


                    MessageBox.Show(
                        "Incrível amigo, você está logado!",
                        "Verificado!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    // Criação do menu no novo formulário:
                    var menu = new MenuRestrito();
                    menu.Show();

                    // Não fecha o programa, mantém ele aberto:
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Olha.. um erro!",
                        "Usuário ou Senha Incorretos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    // Resetar a senha se estiver errada:
                    txtUsuario.Focus();
                    txtSenha.Text = "";

                }

            }
            catch (Exception ex)
            {

            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mensagem caso o usuário se esqueça!
            MessageBox.Show("Olha.. contate o administrador!",
                        "Esqueceu a senha mesmo?",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
        }
    }
}