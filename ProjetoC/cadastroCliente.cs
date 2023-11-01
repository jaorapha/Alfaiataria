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
    public partial class cadastroCliente : Form
    {
        public cadastroCliente()
        {
            InitializeComponent();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
          try
          {
                if (txtnome.Text == "" && txtidade.Text == "" && txtdtnascimento.Text == "" && txtcpf.Text == "" && txtsexo.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos","Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txtnome.Focus();
                }
                else if (txtnome.Text == "" || txtidade.Text == "" || txtdtnascimento.Text == "" || txtcpf.Text == "" || txtsexo.Text == "")
                {
                    MessageBox.Show("Verefique se todos os campos estão preenchidos", "Error" ,MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    MySqlConnection meuSql = new MySqlConnection("server=localhost;database=bdAlfaiataria;uid=root;pwd=jhon");
                    meuSql.Open();
                    MySqlCommand comando = new MySqlCommand("insert into cliente(nome,idade,dtnascimento,cpf,sexo) values('" + txtnome.Text + "'," + txtidade.Text + ",'" + txtdtnascimento.Text + "','" + txtcpf.Text + "','" + txtsexo.Text + "');", meuSql);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Consluido com secesso", "status Registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtnome.Text = "";
                    txtidade.Text = "";
                    txtdtnascimento.Text = "";
                    txtcpf.Text = "";
                    txtsexo.Text = "";
                    txtnome.Focus();
                }
          }catch (Exception ex) 
            {
                MessageBox.Show("Verifique onde você escreveu isso " + ex.Message, "Algo deu errado" ,MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
    }
}
