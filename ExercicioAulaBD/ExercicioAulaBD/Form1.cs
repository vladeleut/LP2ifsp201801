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

namespace ExercicioAulaBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server = localhost; Database = aula; Uid = root; Pwd = admin;";

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string sql = "insert into aluno(nome, cpf) values ('" + txtNome.Text + "'," + txtCPF.Text + ")";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Clone();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aulaDataSet.aluno'. Você pode movê-la ou removê-la conforme necessário.
            this.alunoTableAdapter.Fill(this.aulaDataSet.aluno);

        }
    }
}
