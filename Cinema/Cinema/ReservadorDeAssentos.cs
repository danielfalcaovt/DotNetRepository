using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class ReservadorDeAssentos : Form
    {
        public string Filme { get; set; }
        public string[] Assentos = new string[10];
        public ReservadorDeAssentos()
        {
            InitializeComponent();
        }

        private void ReservadorDeAssentos_Load(object sender, EventArgs e)
        {
            if (Filme.Length > 0)
            {
                lblFilme.Text = Filme;
            }
            else
            {
                lblFilme.Text = "Filme";
            }
        }

        private void pbAssento10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Assentos.Length; i++)
            {
                if (Assentos[i] == pbAssento10.Name)
                {
                    var assLista = Assentos.ToList();
                    assLista.Remove(Assentos[i]);
                    Assentos = assLista.ToArray();
                    pbAssento10.BackColor = Color.Transparent;
                    break;
                }
                if (Assentos[i] == null)
                {
                    pbAssento10.BackColor = Color.Brown;
                    Assentos[i] = pbAssento10.Name;
                    break;
                }
            }
        }

        private void pbAssento9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Assentos.Length; i++)
            {
                if (Assentos[i] == pbAssento9.Name)
                {
                    var assLista = Assentos.ToList();
                    assLista.Remove(Assentos[i]);
                    Assentos = assLista.ToArray();
                    pbAssento9.BackColor = Color.Transparent;
                    break;
                }
                if (Assentos[i] == null)
                {
                    pbAssento9.BackColor = Color.Brown;
                    Assentos[i] = pbAssento9.Name;
                    break;
                }
            }
        }

        private void pbAssento1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Assentos.Length; i++)
            {
                if (Assentos[i] == pbAssento1.Name)
                {
                    var assLista = Assentos.ToList();
                    assLista.Remove(Assentos[i]);
                    Assentos = assLista.ToArray();
                    pbAssento1.BackColor = Color.Transparent;
                    break;
                }
                if (Assentos[i] == null)
                {
                    pbAssento1.BackColor = Color.Brown;
                    Assentos[i] = pbAssento1.Name;
                    break;
                }
            }
        }

        private void pbAssento2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Assentos.Length; i++)
            {
                if (Assentos[i] == pbAssento2.Name)
                {
                    var assLista = Assentos.ToList();
                    assLista.Remove(Assentos[i]);
                    Assentos = assLista.ToArray();
                    pbAssento2.BackColor = Color.Transparent;
                    break;
                }
                if (Assentos[i] == null)
                {
                    pbAssento2.BackColor = Color.Brown;
                    Assentos[i] = pbAssento2.Name;
                    break;
                }
            }
        }
        private void pbAssento3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Assentos.Length; i++)
            {
                if (Assentos[i] == pbAssento3.Name)
                {
                    var assLista = Assentos.ToList();
                    assLista.Remove(Assentos[i]);
                    Assentos = assLista.ToArray();
                    pbAssento3.BackColor = Color.Transparent;
                    break;
                }
                if (Assentos[i] == null)
                {
                    pbAssento3.BackColor = Color.Brown;
                    Assentos[i] = pbAssento3.Name;
                    break;
                }
            }
        }

        private void pbAssento4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Assentos.Length; i++)
            {
                if (Assentos[i] == pbAssento4.Name)
                {
                    var assLista = Assentos.ToList();
                    assLista.Remove(Assentos[i]);
                    Assentos = assLista.ToArray();
                    pbAssento4.BackColor = Color.Transparent;
                    break;
                }
                if (Assentos[i] == null)
                {
                    pbAssento4.BackColor = Color.Brown;
                    Assentos[i] = pbAssento4.Name;
                    break;
                }
            }
        }

        private void pbAssento5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Assentos.Length; i++)
            {
                if (Assentos[i] == pbAssento5.Name)
                {
                    var assLista = Assentos.ToList();
                    assLista.Remove(Assentos[i]);
                    Assentos = assLista.ToArray();
                    pbAssento5.BackColor = Color.Transparent;
                    break;
                }
                if (Assentos[i] == null)
                {
                    pbAssento5.BackColor = Color.Brown;
                    Assentos[i] = pbAssento5.Name;
                    break;
                }
            }
        }

        private void pbAssento6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Assentos.Length; i++)
            {
                if (Assentos[i] == pbAssento6.Name)
                {
                    var assLista = Assentos.ToList();
                    assLista.Remove(Assentos[i]);
                    Assentos = assLista.ToArray();
                    pbAssento6.BackColor = Color.Transparent;
                    break;
                }
                if (Assentos[i] == null)
                {
                    pbAssento6.BackColor = Color.Brown;
                    Assentos[i] = pbAssento6.Name;
                    break;
                }
            }
        }

        private void pbAssento7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Assentos.Length; i++)
            {
                if (Assentos[i] == pbAssento7.Name)
                {
                    var assLista = Assentos.ToList();
                    assLista.Remove(Assentos[i]);
                    Assentos = assLista.ToArray();
                    pbAssento7.BackColor = Color.Transparent;
                    break;
                }
                if (Assentos[i] == null)
                {
                    pbAssento7.BackColor = Color.Brown;
                    Assentos[i] = pbAssento7.Name;
                    break;
                }
            }
        }

        private void pbAssento8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Assentos.Length; i++)
            {
                if (Assentos[i] == pbAssento8.Name)
                {
                    var assLista = Assentos.ToList();
                    assLista.Remove(Assentos[i]);
                    Assentos = assLista.ToArray();
                    pbAssento8.BackColor = Color.Transparent;
                    break;
                }
                if (Assentos[i] == null)
                {
                    pbAssento8.BackColor = Color.Brown;
                    Assentos[i] = pbAssento8.Name;
                    break;
                }
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            int count = 0;

            // PARA CADA ELEMENTO DENTRO DO GRUPO ASSENTOS
            foreach (Control control in gpboxAssentos.Controls)
            {
                // PARA CADA ASSENTO OCUPADO
                for (int i = 0; i < Assentos.Length; i++)
                {
                    
                    // RESETA TODOS OS ASSENTOS OCUPADOS
                    if (control.Name == Assentos[i])
                    {
                        count++;
                        control.Enabled = false;
                        control.Visible = false;
                        control.BackColor = Color.Transparent;
                    }
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Você deve solicitar ao menos 1 assento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                count = 0;
                Assentos = new string[10];
            }
        }
    }
} 