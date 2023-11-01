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
    public partial class consultaEstoque : Form
    {
        public consultaEstoque()
        {
            InitializeComponent();
        }

        private void consultaEstoque_Load(object sender, EventArgs e)
        {
            CarregarBanco();
        }

        private void CarregarBanco()
        {
            MySqlConnection meuSql = new MySqlConnection("server=localhost;database=bdAlfaiataria;uid=root;pwd=jhon");
            meuSql.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from estoque", meuSql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvEstoque.DataSource = dt;
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            String conexao = "server=localhost;database=bdAlfaiataria;uid=root;pwd=jhon";
            MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
            conexaoMYSQL.Open();

            MySqlCommand comando = new MySqlCommand("update estoque set nome='" + txtnome.Text+ "',qtdmaterial='" + txtQtd.Text+ "',fornecedor='" + txtfornecedor.Text+ "',comprimento='" + txtcomprimento.Text+ "',cor='" + txtcor.Text+ "',preco='" + txtpreco.Text+ "'where id_material=" + txtcodigo.Text, conexaoMYSQL);
            comando.ExecuteNonQuery();

            txtnome.Text = "";
            txtQtd.Text = "";
            txtfornecedor.Text= "";
            txtcomprimento.Text = "";
            txtcor.Text = "";
            txtpreco.Text = "";
            CarregarBanco();

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            DialogResult caixaMensagem = MessageBox.Show("Deseja mesmo fazer excluir esse dados", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

            if (caixaMensagem == DialogResult.Yes)
            {
                string conexao = "server=localhost;database=bdAlfaiataria;uid=root;pwd=jhon";
                MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
                conexaoMYSQL.Open();
                MySqlCommand comando = new MySqlCommand("delete from estoque where id_material=" + txtcodigo.Text + ";", conexaoMYSQL);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados excluidos", "Ação feita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.Text = "";
                txtQtd.Text = "";
                txtfornecedor.Text = "";
                txtcomprimento.Text = "";
                txtcor.Text = "";   
                txtpreco.Text = "";
                CarregarBanco();
            }
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgvEstoque.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dgvEstoque.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQtd.Text = dgvEstoque.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtfornecedor.Text= dgvEstoque.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtcomprimento.Text= dgvEstoque.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtcor.Text= dgvEstoque.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtpreco.Text= dgvEstoque.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}  
