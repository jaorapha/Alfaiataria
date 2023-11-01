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
    public partial class agendamento : Form
    {
        public agendamento()
        {
            InitializeComponent();
        }

        private void btnagendar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnome.Text == "" && txtdtagendamento.Text == "" && txthorario.Text == "" && txtcompromisso.Text == "" && txtpreco.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txtnome.Focus();
                }
                else if (txtnome.Text == "" || txtdtagendamento.Text == "" || txthorario.Text == "" || txtcompromisso.Text == "" || txtpreco.Text == "")
                {
                    MessageBox.Show("Verefique se todos os campos estão preenchidos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    MySqlConnection meuSql = new MySqlConnection("server=localhost;database=bdAlfaiataria;uid=root;pwd=jhon");
                    meuSql.Open();

                    MySqlCommand comando = new MySqlCommand("insert into agendamento(nome,dtAgendamento,horario,compromisso,preco) values('" + txtnome.Text + "','" + txtdtagendamento.Text + "','" + txthorario.Text + "','" + txtcompromisso.Text + "'," + txtpreco.Text + ");", meuSql);
                    comando.ExecuteNonQuery();

                    MessageBox.Show("O agendamento foi feito", "Certo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnome.Text = "";
                    txtdtagendamento.Text = "";
                    txthorario.Text = "";
                    txtcompromisso.Text = "";
                    txtpreco.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique onde você escreveu isso " + ex.Message, "Algo deu errado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

           
        }

        private void agendamento_Load(object sender, EventArgs e)
        {

        }

        private void txtcompromisso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
