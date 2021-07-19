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
    public partial class FormContatos : Form
    {
        ControladorContato ctrlContato = new ControladorContato();

        public FormContatos()
        {
            InitializeComponent();
        }

        private void FormContatos_Load(object sender, EventArgs e)
        {
            Contatos.Clear();

            List<Contato> contatos = new List<Contato>();
            contatos = ctrlContato.SelecionarTodos();
            foreach (Contato contato in contatos)
            {
                DataRow registro = Contatos.NewRow();

                registro["Id"] = contato.Id;
                registro["Nome"] = contato.Nome;
                registro["E-Mail"] = contato.Email;
                registro["Telefone"] = contato.Telefone;
                registro["Empresa"] = contato.Empresa;
                registro["Cargo"] = contato.Cargo;

                Contatos.Rows.Add(registro);
                dgvContatos.DataMember = "Contatos";
            }
        }

        private void FormContatos_Activated(object sender, EventArgs e)
        {
            Contatos.Clear();

            List<Contato> contatos = new List<Contato>();
            contatos = ctrlContato.SelecionarTodos();
            foreach (Contato contato in contatos)
            {
                DataRow registro = Contatos.NewRow();

                registro["ID"] = contato.Id;
                registro["Nome"] = contato.Nome;
                registro["E-Mail"] = contato.Email;
                registro["Telefone"] = contato.Telefone;
                registro["Empresa"] = contato.Empresa;
                registro["Cargo"] = contato.Cargo;

                Contatos.Rows.Add(registro);
                dgvContatos.DataMember = "Contatos";
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            FormAdicionarContato formAddContato = new FormAdicionarContato();
            formAddContato.Show();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            int indiceColuna = dgvContatos.SelectedCells[0].RowIndex;
            DataGridViewRow linhaSelecionada = dgvContatos.Rows[indiceColuna];
            int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            ctrlContato.Excluir(idSelecionado);

            Contatos.Clear();

            List<Contato> contatos = new List<Contato>();
            contatos = ctrlContato.SelecionarTodos();
            foreach (Contato contato in contatos)
            {
                DataRow registro = Contatos.NewRow();

                registro["ID"] = contato.Id;
                registro["Nome"] = contato.Nome;
                registro["E-Mail"] = contato.Email;
                registro["Telefone"] = contato.Telefone;
                registro["Empresa"] = contato.Empresa;
                registro["Cargo"] = contato.Cargo;

                Contatos.Rows.Add(registro);
                dgvContatos.DataMember = "Contatos";
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int indiceColuna = dgvContatos.SelectedCells[0].RowIndex;
            DataGridViewRow linhaSelecionada = dgvContatos.Rows[indiceColuna];
            int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            String[] contatoSelecionado = {
                linhaSelecionada.Cells[1].Value.ToString(),
                linhaSelecionada.Cells[2].Value.ToString(),
                linhaSelecionada.Cells[3].Value.ToString(),
                linhaSelecionada.Cells[4].Value.ToString(),
                linhaSelecionada.Cells[5].Value.ToString()};

            FormEditarContato formEditContato = new FormEditarContato(idSelecionado, contatoSelecionado);
            formEditContato.Show();
        }

    }
}
