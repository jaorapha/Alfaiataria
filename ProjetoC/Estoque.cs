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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void btncadastar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnome.Text == "" && txtqtdtecido.Text == "" && txtfornecedor.Text == "" && txtcomprimento.Text == "" && txtcor.Text == "" && txtpreco.Text =="")
                {
                    MessageBox.Show("Preencha todos os campos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txtnome.Focus();
                }
                else if(txtnome.Text == "" || txtqtdtecido.Text == "" || txtfornecedor.Text == "" || txtcomprimento.Text == "" || txtcor.Text == "" || txtpreco.Text == "")
                {
                    MessageBox.Show("Verefique se todos os campos estão preenchidos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    MySqlConnection meuSql = new MySqlConnection("server=localhost;database=bdAlfaiataria;uid=root;pwd=jhon");
                    meuSql.Open();

                    MySqlCommand comando = new MySqlCommand("insert into estoque(nome,qtdMaterial,fornecedor,comprimento,cor,preco) values('" + txtnome.Text + "'," + txtqtdtecido.Text + ",'" + txtfornecedor.Text + "','" + txtcomprimento.Text + "','" + txtcor.Text + "'," + txtpreco.Text + ");", meuSql);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Registrado com sucesso", "Status Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnome.Text = "";
                    txtqtdtecido.Text = "";
                    txtfornecedor.Text = "";
                    txtcomprimento.Text = "";
                    txtcor.Text = "";
                    txtpreco.Text = "";
                    txtnome.Focus();

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Verifique onde você escreveu isso " + ex.Message, "Algo deu errado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Estoque_Load(object sender, EventArgs e)
        {

        }
    }
}
