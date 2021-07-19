using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
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
    public partial class FormAdicionarTarefa : Form
    {
        ControladorTarefa ctrlTarefa = new ControladorTarefa();

        public FormAdicionarTarefa()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            int prior = Convert.ToInt32(cbPrioridade.SelectedIndex.ToString());
            Tarefa tarefa = new Tarefa(tbTitulo.Text, DateTime.Now, (PrioridadeEnum)prior);
            if (ctrlTarefa.InserirNovo(tarefa) == "ESTA_VALIDO")
            {
                tbTitulo.Text = "";
                cbPrioridade.Text = "";
                MessageBox.Show("Tarefa inserida com sucesso!");
            }
        }
    }
}
