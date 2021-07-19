using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
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

namespace eAgenda.Forms.CompromissosModule
{
    public partial class FormEditarCompromisso : Form
    {
        ControladorCompromisso ctrlCompromisso = new ControladorCompromisso();
        ControladorContato ctrlContato = new ControladorContato();
        int idSelecionado;

        public FormEditarCompromisso(int idSelecionado)
        {
            InitializeComponent();
            this.idSelecionado = idSelecionado;
        }
        private void FormEditarCompromisso_Load(object sender, EventArgs e)
        {
            cbContato.Items.Clear();

            foreach (Contato contato in ctrlContato.SelecionarTodos())
            {
                cbContato.Items.Add(contato.Id + " - " + contato.Nome);
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            string[] strContato = cbContato.SelectedItem.ToString().Split(' ');
            Contato contato = ctrlContato.SelecionarPorId(int.Parse(strContato[0]));

            string[] strHorarioInicial = tbHorarioInicial.Text.Split(':');
            TimeSpan horarioInicio = new TimeSpan(int.Parse(strHorarioInicial[0]), int.Parse(strHorarioInicial[1]), 0);

            string[] strHorarioFinal = tbHorarioFinal.Text.Split(':');
            TimeSpan horarioFinal = new TimeSpan(int.Parse(strHorarioFinal[0]), int.Parse(strHorarioFinal[1]), 0);

            Compromisso compromisso = new Compromisso(tbAssunto.Text, tbLocal.Text, tbLink.Text, dateTimeData.Value,
               horarioInicio, horarioFinal, contato);
            if (ctrlCompromisso.Editar(idSelecionado, compromisso) == "ESTA_VALIDO")
            {
                MessageBox.Show("Compromisso editado com sucesso!");
                this.Close();
            }
        }

    }
}
