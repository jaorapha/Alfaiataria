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
    public partial class Encomenda : Form
    {
        public Encomenda()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnome.Text == "" && txtmedidas.Text == "" && txtproduto.Text == "" && txtdiaentrega.Text == "" && txthrentrega.Text == "" && txtpreco.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txtnome.Focus();
                }
                else if(txtnome.Text == "" || txtmedidas.Text == "" || txtproduto.Text == "" || txtdiaentrega.Text == "" || txthrentrega.Text == "" || txtpreco.Text == "")
                {
                    MessageBox.Show("Verefique se todos os campos estão preenchidos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else {
                    MySqlConnection meuSql = new MySqlConnection("server=lovalhost;database=bdAlfaiate;uid=root;pwd=jhon");
                    meuSql.Open();

                    MySqlCommand comando = new MySqlCommand("insert into encomenda(nome,medidas,produto,dtEntrega,hrEntrega,preco) values ('" + txtnome + "','" + txtmedidas + "','" + txtproduto + "','" + txtdiaentrega + "','" + txthrentrega + "'," + txtpreco + ");", meuSql);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Certo", "Encomenda registrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtnome.Text = "";
                    txtmedidas.Text = "";
                    txtproduto.Text = "";
                    txtdiaentrega.Text = "";
                    txthrentrega.Text = "";
                    txtpreco.Text = "";
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Verifique onde você escreveu isso " + ex.Message, "Algo deu errado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           

        }
    }
}
