using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Forms.ContatosModule
{
    public partial class FormAdicionarContato : Form
    {
        ControladorContato ctrlContato = new ControladorContato();

        public FormAdicionarContato()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato(tbNome.Text, tbEmail.Text, tbTelefone.Text, tbEmpresa.Text, tbCargo.Text);
            if (ctrlContato.InserirNovo(contato) == "ESTA_VALIDO")
            {
                tbNome.Text = "";
                tbEmail.Text = "";
                tbTelefone.Text = "";
                tbEmpresa.Text = "";
                tbCargo.Text = "";
                MessageBox.Show("Contato inserido com sucesso!");
            }
        }
    }
}
