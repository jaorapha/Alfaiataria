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
using System.Globalization;

namespace ProjetoC
{
    public partial class consultaCliente : Form
    {
        public consultaCliente()
        {
            InitializeComponent();
        }

        private void consultaCliente_Load(object sender, EventArgs e)
        {
            CarregarBanco();
        }

        private void CarregarBanco()
        {
            MySqlConnection meuSql = new MySqlConnection("server=localhost;database=bdAlfaiataria;uid=root;pwd=jhon");
            meuSql.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from cliente", meuSql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCliente.DataSource = dt;
        }
        
        

        private void btnAltearar_Click(object sender, EventArgs e)
        {
                string conexao = "server=localhost;database=bdAlfaiataria;uid=root;pwd=jhon";
                MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
                conexaoMYSQL.Open();

                MySqlCommand comando = new MySqlCommand("update cliente set nome= '" + txtnome.Text + "',idade=" + txtidade.Text + ",dtnascimento= '" + txtdatanasc.Text + "',cpf='" + txtcpf.Text + "' ,sexo='" + txtsexo.Text + "' where idCliente=" + txtcodigocliente.Text, conexaoMYSQL);
                comando.ExecuteNonQuery();
                MessageBox.Show("Status", "Os dados foram alterados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnome.Text = "";
                txtidade.Text = "";
                txtidade.Text = "";
                txtdatanasc.Text = "";
                txtcpf.Text = "";
                txtsexo.Text = "";
                txtcodigocliente.Text = "";
                CarregarBanco();
                
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
            txtcodigocliente.Text = dgvCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dgvCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtidade.Text = dgvCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdatanasc.Text = dgvCliente.Rows[e.RowIndex].Cells[3].Value.ToString();   
            txtcpf.Text = dgvCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtsexo.Text = dgvCliente.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            DialogResult caixaMensagem = MessageBox.Show("Deseja mesmo fazer excluir esse dados", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (caixaMensagem == DialogResult.Yes)
            {
                string conexao = "server=localhost;database=bdAlfaiataria;uid=root;pwd=jhon";
                MySqlConnection conexaoMYSQL = new MySqlConnection(conexao);
                conexaoMYSQL.Open();
                MySqlCommand comando = new MySqlCommand("delete from cliente where idCliente=" + txtcodigocliente.Text + ";", conexaoMYSQL);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados excluidos", "Ação feita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.Text = "";
                txtidade.Text = "";
                txtidade.Text = "";
                txtdatanasc.Text = "";
                txtcpf.Text = "";
                txtsexo.Text = "";
                txtcodigocliente.Text = "";
                CarregarBanco();
            }
        }
    }
}


