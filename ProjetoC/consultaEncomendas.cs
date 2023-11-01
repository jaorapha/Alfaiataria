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
    public partial class consultaEncomendas : Form
    {
        public consultaEncomendas()
        {
            InitializeComponent();
        }

        private void CarregaBanco()
        {
            MySqlConnection meuSql = new MySqlConnection("server=localhost;database=bdAlfaiataria;uid=root;pwd=jhon");
            meuSql.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from encomenda", meuSql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvEncomenda.DataSource = dt;
        }

        private void consultaEncomendas_Load(object sender, EventArgs e)
        {
            CarregaBanco();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost;database=bdAlfaiataria;uid=root;pwd=jhon";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            MySqlCommand comando = new MySqlCommand("update enconmenda set nome='" + txtnome.Text + "',medidas='" + txtmedidas.Text + "',produto='" + txtproduto.Text + "',dtEntrega='" + txtdiaentrega + "',hrEntrega='" + txtdiaentrega.Text + "',preco='" + txtpreco.Text + "',where idEncomenda=" + txtcodigoencomenda.Text , conexaoMYSQL);
            comando.ExecuteNonQuery();

            txtnome.Text = "";
            txtmedidas.Text = "";
            txtproduto.Text = "";
            txtdiaentrega.Text = "";
            txthorarioentrega.Text = "";
            txtpreco.Text = "";
            txtnome.Focus();
            CarregaBanco();
        }

        private void dgvEncomenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigoencomenda.Text = dgvEncomenda.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dgvEncomenda.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtmedidas.Text = dgvEncomenda.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtproduto.Text = dgvEncomenda.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtdiaentrega.Text = dgvEncomenda.Rows[e.RowIndex].Cells[4].Value.ToString();
            txthorarioentrega.Text = dgvEncomenda.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtpreco.Text = dgvEncomenda.Rows[e.RowIndex].Cells[5].Value.ToString();

        }
    } 
}
