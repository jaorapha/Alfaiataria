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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtUsuario.Text == "administrador" && txtSenha.Text == "adm")
                {
                    Menu telademenu = new Menu();
                    telademenu.Show();



                }
                else if (txtUsuario.Text == "" && txtSenha.Text == "")
                {
                    MessageBox.Show("Você não preencheu um dos campos", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }

                else if (txtUsuario.Text != "administrador")
                {
                    MessageBox.Show("o campo do usuário está errado", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
                }

                else if (txtUsuario.Text == "administrador" && txtSenha.Text == "")
                {
                    MessageBox.Show("O campo senha não foi preenchido", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else if (txtUsuario.Text == "" && txtSenha.Text == "adm")
                {
                    MessageBox.Show("O campo usuário não foi preenchido", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("O campo senha está incorreto", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

            }
            catch { };
        }
    }
}
