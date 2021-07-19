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
    public partial class FormEditarTarefa : Form
    {
        ControladorTarefa ctrlTarefa = new ControladorTarefa();
        int idSelecionado;
        String[] tarefaSelecionada;

        public FormEditarTarefa(int idSelecionado, String[] tarefaSelecionada)
        {
            InitializeComponent();
            this.idSelecionado = idSelecionado;
            this.tarefaSelecionada = tarefaSelecionada;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = new Tarefa(tbTitulo.Text, DateTime.Now, (PrioridadeEnum)cbPrioridade.SelectedIndex);
            tarefa.AtualizarPercentual(Convert.ToInt32(tbPercentual.Text), DateTime.Today);
            if (ctrlTarefa.Editar(idSelecionado, tarefa) == "ESTA_VALIDO")
            {
                MessageBox.Show("Tarefa editada com sucesso!");
                this.Close();
            }
        }

        private void FormEditarTarefa_Load(object sender, EventArgs e)
        {
            tbTitulo.Text = tarefaSelecionada[0];
            tbPercentual.Text = tarefaSelecionada[2];
        }
    }
}
