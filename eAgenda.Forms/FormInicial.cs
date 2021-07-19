using eAgenda.Forms.CompromissosModule;
using eAgenda.Forms.ContatosModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Forms
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btTarefas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTarefas formTarefas = new FormTarefas();
            formTarefas.Closed += (s, args) => this.Show();
            formTarefas.Show();
        }

        private void bt_contatos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormContatos formContatos = new FormContatos();
            formContatos.Closed += (s, args) => this.Show();
            formContatos.Show();
        }

        private void bt_compromissos_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCompromissos formCompromissos = new FormCompromissos();
            formCompromissos.Closed += (s, args) => this.Show();
            formCompromissos.Show();
        }
    }
}
