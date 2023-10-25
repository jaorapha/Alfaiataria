using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void mercadoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque telacastroEstoque = new Estoque();
            telacastroEstoque.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroCliente telacadastroCliente = new cadastroCliente();
            telacadastroCliente.Show();
        }

        private void clientesCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaCliente teladecunsultaCliente = new consultaCliente();
            teladecunsultaCliente.Show();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agendamento telaAgendamento = new agendamento();
            telaAgendamento.Show();
        }

        private void horáriosMarcadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaAgendamento telaconsultaAgendamento = new consultaAgendamento();
            telaconsultaAgendamento.Show();
        }

        private void encomendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encomenda telaEncomenda = new Encomenda();
            telaEncomenda.Show();
        }

        private void tecidosDisponiveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaEstoque telaconsultaEstoque = new consultaEstoque();
            telaconsultaEstoque.Show();
        }

        private void encomendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaEncomendas telaconsultaEncomenda = new consultaEncomendas();
            telaconsultaEncomenda.Show();
        }
    }
}
