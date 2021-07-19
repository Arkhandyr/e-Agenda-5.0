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
    public partial class FormTarefas : Form
    {
        ControladorTarefa ctrlTarefa = new ControladorTarefa();

        public FormTarefas()
        {
            InitializeComponent();
        }

        private void FormTarefas_Load(object sender, EventArgs e)
        {
            Tarefas.Clear();
            List<Tarefa> tarefas = new List<Tarefa>();
            tarefas = ctrlTarefa.SelecionarTodos();
            foreach (Tarefa tarefa in tarefas)
            {
                DataRow registro = Tarefas.NewRow();

                registro["Id"] = tarefa.Id;
                registro["Título"] = tarefa.Titulo;
                registro["Prioridade"] = tarefa.Prioridade;
                registro["Percentual"] = tarefa.Percentual;
                registro["Início"] = tarefa.DataCriacao;
                registro["Conclusão"] = tarefa.DataConclusao;

                Tarefas.Rows.Add(registro);
                dgvTarefas.DataMember = "Tarefas";
            }
            
        }

        private void rbTarefasIncompletas_CheckedChanged(object sender, EventArgs e)
        {
            Tarefas.Clear();

            List<Tarefa> tarefas = new List<Tarefa>();
            tarefas = ctrlTarefa.SelecionarTodasTarefasPendentes();
            foreach (Tarefa tarefa in tarefas)
            {
                DataRow registro = Tarefas.NewRow();

                registro["Id"] = tarefa.Id;
                registro["Título"] = tarefa.Titulo;
                registro["Prioridade"] = tarefa.Prioridade;
                registro["Percentual"] = tarefa.Percentual;
                registro["Início"] = tarefa.DataCriacao;
                registro["Conclusão"] = tarefa.DataConclusao;

                Tarefas.Rows.Add(registro);
                dgvTarefas.DataMember = "Tarefas";
            }
        }

        private void rbTarefasCompletas_CheckedChanged(object sender, EventArgs e)
        {
            Tarefas.Clear();

            List<Tarefa> tarefas = new List<Tarefa>();
            tarefas = ctrlTarefa.SelecionarTodasTarefasConcluidas();
            foreach (Tarefa tarefa in tarefas)
            {
                DataRow registro = Tarefas.NewRow();

                registro["Id"] = tarefa.Id;
                registro["Título"] = tarefa.Titulo;
                registro["Prioridade"] = tarefa.Prioridade;
                registro["Percentual"] = tarefa.Percentual;
                registro["Início"] = tarefa.DataCriacao;
                registro["Conclusão"] = tarefa.DataConclusao;

                Tarefas.Rows.Add(registro);
                dgvTarefas.DataMember = "Tarefas";
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FormAdicionarTarefa formAddTarefa = new FormAdicionarTarefa();
            formAddTarefa.Show();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            int indiceColuna = dgvTarefas.SelectedCells[0].RowIndex;
            DataGridViewRow linhaSelecionada = dgvTarefas.Rows[indiceColuna];
            int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            ctrlTarefa.Excluir(idSelecionado);

            Tarefas.Clear();

            List<Tarefa> tarefas = new List<Tarefa>();
            tarefas = ctrlTarefa.SelecionarTodos();
            foreach (Tarefa tarefa in tarefas)
            {
                DataRow registro = Tarefas.NewRow();

                registro["Id"] = tarefa.Id;
                registro["Título"] = tarefa.Titulo;
                registro["Prioridade"] = tarefa.Prioridade;
                registro["Percentual"] = tarefa.Percentual;
                registro["Início"] = tarefa.DataCriacao;
                registro["Conclusão"] = tarefa.DataConclusao;

                Tarefas.Rows.Add(registro);
                dgvTarefas.DataMember = "Tarefas";
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int indiceColuna = dgvTarefas.SelectedCells[0].RowIndex;
            DataGridViewRow linhaSelecionada = dgvTarefas.Rows[indiceColuna];
            int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            FormEditarTarefa formEditTarefa = new FormEditarTarefa(idSelecionado);
            formEditTarefa.Show();
        }

        private void FormTarefas_Activated(object sender, EventArgs e)
        {
            Tarefas.Clear();

            List<Tarefa> tarefas = new List<Tarefa>();
            tarefas = ctrlTarefa.SelecionarTodos();
            foreach (Tarefa tarefa in tarefas)
            {
                DataRow registro = Tarefas.NewRow();

                registro["Id"] = tarefa.Id;
                registro["Título"] = tarefa.Titulo;
                registro["Prioridade"] = tarefa.Prioridade;
                registro["Percentual"] = tarefa.Percentual;
                registro["Início"] = tarefa.DataCriacao;
                registro["Conclusão"] = tarefa.DataConclusao;

                Tarefas.Rows.Add(registro);
                dgvTarefas.DataMember = "Tarefas";
            }
        }
    }
}
