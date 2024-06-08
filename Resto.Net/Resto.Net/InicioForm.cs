namespace Resto.Net
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void Dise�o_Click(object sender, EventArgs e)
        {
            Dise�o dise�oForm = new Dise�o();
            dise�oForm.Show();
            dise�oForm.Location = this.Location;
            this.Hide();
        }

        private void Previuw_Click(object sender, EventArgs e)
        {
            Previuw previuwForm = new Previuw();
            previuwForm.Show();
            previuwForm.Location = this.Location;
            this.Hide();
        }
      

        private void InicioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
