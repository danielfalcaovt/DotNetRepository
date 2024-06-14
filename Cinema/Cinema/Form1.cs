namespace Cinema
{
    public partial class frmReservador : Form
    {
        public frmReservador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReservadorDeAssentos reservador = new ReservadorDeAssentos();
            reservador.Filme = "Arcane";
            reservador.ShowDialog();
        }

        private void btnFilme2_Click(object sender, EventArgs e)
        {
            ReservadorDeAssentos reservador = new ReservadorDeAssentos();
            reservador.Filme = "Os Carrinhos";
            reservador.ShowDialog();
        }
    }
}
