using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoC
{
    public partial class consultaAgendamento : Form
    {
        public consultaAgendamento()
        {
            InitializeComponent();
        }
        private void consultaAgendamento_Load(object sender, EventArgs e)
        {
            Carregarbanco();
        }

        private void Carregarbanco()
        {
            MySqlConnection meuSql = new MySqlConnection("server=localhost;database=bdAlfaiataria;uid=root;pwd=jhon");
            meuSql.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from agendamento", meuSql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvAgendamento.DataSource = dt;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           string conexao = "server=localhost,database=bdAlfaiataria;uid=root;pwd=jhon";
            MySqlConnection coneaxaoMYSQL = new MySqlConnection(conexao);
            MySqlCommand comando = new MySqlCommand("update gerenciamento set nome='" + txtnome + "',dtAgendamento='" + txtdiamarcado + "',horario='" + txthorario + "',compromisso='" + txtcompromisso + "',preco=" + txtpreco + "where idAgendamento='" + txtcodigoagendamento, coneaxaoMYSQL);
            comando.ExecuteNonQuery();

            txtcodigoagendamento.Text = "";
            txtnome.Text = "";
            txtdiamarcado.Text = "";
            txthorario.Text = "";
            txtcompromisso.Text = "";
            txtpreco.Text = "";
            Carregarbanco();

        }

        private void dgvAgendamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigoagendamento.Text = dgvAgendamento.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dgvAgendamento.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdiamarcado.Text = dgvAgendamento.Rows[e.RowIndex].Cells[2].Value.ToString();
            txthorario.Text = dgvAgendamento.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtcompromisso.Text = dgvAgendamento.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtpreco.Text = dgvAgendamento.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        
      
    }
}
