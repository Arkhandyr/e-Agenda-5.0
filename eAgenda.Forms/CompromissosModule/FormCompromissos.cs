using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Forms.CompromissosModule
{
    public partial class FormCompromissos : Form
    {
        ControladorCompromisso ctrlCompromisso = new ControladorCompromisso();
        ControladorContato ctrlContato = new ControladorContato();

        public FormCompromissos()
        {
            InitializeComponent();
        }

        private void FormCompromissos_Load(object sender, EventArgs e)
        {
            Compromissos.Clear();

            List<Compromisso> compromissos = new List<Compromisso>();
            compromissos = ctrlCompromisso.SelecionarTodos();
            foreach (Compromisso compromisso in compromissos)
            {
                DataRow registro = Compromissos.NewRow();

                registro["Id"] = compromisso.Id;
                registro["Assunto"] = compromisso.Assunto;
                registro["Local"] = compromisso.Local;
                registro["Link"] = compromisso.Link;
                registro["Data"] = compromisso.Data.ToShortDateString();
                registro["Horário Inicial"] = compromisso.HoraInicio;
                registro["Horário Final"] = compromisso.HoraTermino;
                registro["Contato"] = compromisso.Contato != null ? compromisso.Contato.Nome : "";

                Compromissos.Rows.Add(registro);
                dgvCompromissos.DataMember = "Compromissos";
            }
        }

        private void FormCompromissos_Activated(object sender, EventArgs e)
        {
            Compromissos.Clear();

            List<Compromisso> compromissos = new List<Compromisso>();
            compromissos = ctrlCompromisso.SelecionarTodos();
            foreach (Compromisso compromisso in compromissos)
            {
                DataRow registro = Compromissos.NewRow();

                registro["Id"] = compromisso.Id;
                registro["Assunto"] = compromisso.Assunto;
                registro["Local"] = compromisso.Local;
                registro["Link"] = compromisso.Link;
                registro["Data"] = compromisso.Data.ToShortDateString();
                registro["Horário Inicial"] = compromisso.HoraInicio;
                registro["Horário Final"] = compromisso.HoraTermino;
                registro["Contato"] = compromisso.Contato != null ? compromisso.Contato.Nome : "";
                Compromissos.Rows.Add(registro);
                dgvCompromissos.DataMember = "Compromissos";
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FormAdicionarCompromisso formAddCompromisso = new FormAdicionarCompromisso();
            formAddCompromisso.Show();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            int indiceColuna = dgvCompromissos.SelectedCells[0].RowIndex;
            DataGridViewRow linhaSelecionada = dgvCompromissos.Rows[indiceColuna];
            int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            ctrlCompromisso.Excluir(idSelecionado);

            Compromissos.Clear();

            List<Compromisso> compromissos = new List<Compromisso>();
            compromissos = ctrlCompromisso.SelecionarTodos();
            foreach (Compromisso compromisso in compromissos)
            {
                DataRow registro = Compromissos.NewRow();

                registro["Id"] = compromisso.Id;
                registro["Assunto"] = compromisso.Assunto;
                registro["Local"] = compromisso.Local;
                registro["Link"] = compromisso.Link;
                registro["Data"] = compromisso.Data.ToShortDateString();
                registro["Horário Inicial"] = compromisso.HoraInicio;
                registro["Horário Final"] = compromisso.HoraTermino;
                registro["Contato"] = compromisso.Contato != null ? compromisso.Contato.Nome : "";

                Compromissos.Rows.Add(registro);
                dgvCompromissos.DataMember = "Compromissos";
            }
        }
        private void btEditar_Click(object sender, EventArgs e)
        {
            int indiceColuna = dgvCompromissos.SelectedCells[0].RowIndex;
            DataGridViewRow linhaSelecionada = dgvCompromissos.Rows[indiceColuna];
            int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            FormEditarCompromisso formEditCompromisso = new FormEditarCompromisso(idSelecionado);
            formEditCompromisso.Show();
        }


        private void rbCompromissosFuturos_CheckedChanged(object sender, EventArgs e)
        {
            rbDiário.Enabled = (rbCompromissosFuturos.Checked == true);
            rbMensal.Enabled = (rbCompromissosFuturos.Checked == true);
            gbOrdenacao.ForeColor = Color.Black;
            rbDiário.ForeColor = Color.Black;
            rbMensal.ForeColor = Color.Black;

            Compromissos.Clear();

            List<Compromisso> compromissos = new List<Compromisso>();
            compromissos = ctrlCompromisso.SelecionarCompromissosFuturos(DateTime.Now, DateTime.MaxValue);
            foreach (Compromisso compromisso in compromissos)
            {
                DataRow registro = Compromissos.NewRow();

                registro["Id"] = compromisso.Id;
                registro["Assunto"] = compromisso.Assunto;
                registro["Local"] = compromisso.Local;
                registro["Link"] = compromisso.Link;
                registro["Data"] = compromisso.Data.ToShortDateString();
                registro["Horário Inicial"] = compromisso.HoraInicio;
                registro["Horário Final"] = compromisso.HoraTermino;
                registro["Contato"] = compromisso.Contato != null ? compromisso.Contato.Nome : "";

                Compromissos.Rows.Add(registro);
                dgvCompromissos.DataMember = "Compromissos";
            }
        }

        private void rbCompromissosPassados_CheckedChanged(object sender, EventArgs e)
        {
            gbOrdenacao.ForeColor = Color.FromArgb(115, 98, 48);

            Compromissos.Clear();

            List<Compromisso> compromissos = new List<Compromisso>();
            compromissos = ctrlCompromisso.SelecionarCompromissosPassados(DateTime.Now);
            foreach (Compromisso compromisso in compromissos)
            {
                DataRow registro = Compromissos.NewRow();

                registro["Id"] = compromisso.Id;
                registro["Assunto"] = compromisso.Assunto;
                registro["Local"] = compromisso.Local;
                registro["Link"] = compromisso.Link;
                registro["Data"] = compromisso.Data.ToShortDateString();
                registro["Horário Inicial"] = compromisso.HoraInicio;
                registro["Horário Final"] = compromisso.HoraTermino;
                registro["Contato"] = compromisso.Contato != null ? compromisso.Contato.Nome : "";

                Compromissos.Rows.Add(registro);
                dgvCompromissos.DataMember = "Compromissos";
            }
        }

        private void rbDiário_CheckedChanged(object sender, EventArgs e)
        {
            Compromissos.Clear();

            DateTime dataAux = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
            List<Compromisso> compromissos = new List<Compromisso>();
            compromissos = ctrlCompromisso.SelecionarCompromissosFuturos(DateTime.Now, dataAux);
            foreach (Compromisso compromisso in compromissos)
            {
                DataRow registro = Compromissos.NewRow();

                registro["Id"] = compromisso.Id;
                registro["Assunto"] = compromisso.Assunto;
                registro["Local"] = compromisso.Local;
                registro["Link"] = compromisso.Link;
                registro["Data"] = compromisso.Data.ToShortDateString();
                registro["Horário Inicial"] = compromisso.HoraInicio;
                registro["Horário Final"] = compromisso.HoraTermino;
                registro["Contato"] = compromisso.Contato != null ? compromisso.Contato.Nome : "";

                Compromissos.Rows.Add(registro);
                dgvCompromissos.DataMember = "Compromissos";
            }
        }

        private void rbMensal_CheckedChanged(object sender, EventArgs e)
        {
            Compromissos.Clear();

            DateTime dataAux = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            List<Compromisso> compromissos = new List<Compromisso>();
            compromissos = ctrlCompromisso.SelecionarCompromissosFuturos(DateTime.Now, dataAux);
            foreach (Compromisso compromisso in compromissos)
            {
                DataRow registro = Compromissos.NewRow();

                registro["Id"] = compromisso.Id;
                registro["Assunto"] = compromisso.Assunto;
                registro["Local"] = compromisso.Local;
                registro["Link"] = compromisso.Link;
                registro["Data"] = compromisso.Data.ToShortDateString();
                registro["Horário Inicial"] = compromisso.HoraInicio;
                registro["Horário Final"] = compromisso.HoraTermino;
                registro["Contato"] = compromisso.Contato != null ? compromisso.Contato.Nome : "";

                Compromissos.Rows.Add(registro);
                dgvCompromissos.DataMember = "Compromissos";
            }
        }
    }
}
