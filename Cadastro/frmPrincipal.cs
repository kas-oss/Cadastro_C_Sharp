using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class frmPrincipal : Form
    {
        List<Pessoa> pessoas;

        public frmPrincipal()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            dtpNascimento.Text = DateTime.Now.ToShortDateString();
            
            cbboxEC.Items.Clear();
            cbboxEC.Items.Add("Casado");
            cbboxEC.Items.Add("Solteiro");
            cbboxEC.Items.Add("Viuvo");
            cbboxEC.Items.Add("Divorciado");  
            cbboxEC.SelectedIndex = 0;

            radioM.Checked = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarAlterar_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == tboxNome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }

            if (tboxNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome.");
                tboxNome.Focus();
                return;
            }

            if (tboxTel.Text == "")
            {
                MessageBox.Show("Preencha o campo Telefone.");
                tboxTel.Focus();
                return;
            }

            char sexo;

            if (radioM.Checked)
            {
                sexo = 'M';
            } 
            else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Pessoa p = new Pessoa();

            p.Nome = tboxNome.Text;
            p.DataNascimento = dtpNascimento.Text;
            p.EstadoCivil = cbboxEC.SelectedItem.ToString();
            p.Telefone = tboxTel.Text;
            p.Fuma = checkFuma.Checked;
            p.Bebe = checkAlcool.Checked;
            p.Sexo = sexo;

            if (index < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }

            Limpar();

            Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (pessoas.Count != 0)
            {
                int indice = lista.SelectedIndex;
                pessoas.RemoveAt(indice);
                Listar();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Listar()
        {
            lista.Items.Clear();
            foreach (Pessoa p in pessoas)
            {           
                lista.Items.Add(p.Nome);
            }
        }

        private void Limpar()
        {
            tboxNome.Text = "";
            dtpNascimento.Text = DateTime.Now.ToShortDateString();
            tboxTel.Text = "";
            cbboxEC.SelectedIndex = 0;
            checkAlcool.Checked = false;
            checkFuma.Checked = false;
            radioM.Checked = true;
            tboxNome.Focus();
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lista.SelectedIndex;

            Pessoa p = pessoas[index];

            tboxNome.Text          = p.Nome;
            tboxTel.Text           = p.Nome;
            cbboxEC.SelectedItem   = p.EstadoCivil;
            dtpNascimento.Text     = p.DataNascimento;
            checkAlcool.Checked    = p.Bebe;
            checkFuma.Checked      = p.Fuma;

            switch (p.Sexo)
            {
                case 'M':
                    radioM.Checked = true;
                    break;
                case 'F':
                    radioF.Checked = true;
                    break;
                case 'O':
                    radioM.Checked = true;
                    break;
            }

        }

    }

}
