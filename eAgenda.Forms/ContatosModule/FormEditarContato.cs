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

        public FormEditarContato(int idSelecionado)
        {
            InitializeComponent();
            this.idSelecionado = idSelecionado;
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
    }
}
