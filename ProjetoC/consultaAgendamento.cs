﻿using System;
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
            MySqlConnection meuSql = new MySqlConnection("server=localhost;database=bdAlfaiataria;uid=root;pwd=jhon");
            meuSql.Open();


            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from agendamento", meuSql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvAgendamento.DataSource = dt;
        }
    }
}
