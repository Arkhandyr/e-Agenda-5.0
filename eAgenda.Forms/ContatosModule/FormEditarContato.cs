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
    public partial class FormEditarContato : Form
    {
        ControladorContato ctrlContato = new ControladorContato();
        int idSelecionado;
        String[] contatoSelecionado;

        public FormEditarContato(int idSelecionado, String[] contatoSelecionado)
        {
            InitializeComponent();
            this.idSelecionado = idSelecionado;
            this.contatoSelecionado = contatoSelecionado;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato(tbNome.Text, tbEmail.Text, tbTelefone.Text, tbEmpresa.Text, tbCargo.Text);
            if (ctrlContato.Editar(idSelecionado, contato) == "ESTA_VALIDO")
            {
                MessageBox.Show("Contato editado com sucesso!");
                this.Close();
            }
        }

        private void FormEditarContato_Load(object sender, EventArgs e)
        {
            tbNome.Text = contatoSelecionado[0];
            tbEmail.Text = contatoSelecionado[1];
            tbTelefone.Text = contatoSelecionado[2];
            tbEmpresa.Text = contatoSelecionado[3];
            tbCargo.Text = contatoSelecionado[4];
        }
    }
}
