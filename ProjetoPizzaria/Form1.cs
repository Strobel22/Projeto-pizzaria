using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPizzaria
{
    public partial class Form1 : Form
    {
        //instanciando a classe conexao
        Conexao con = new Conexao();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar(object sender, EventArgs e)
        {
            //vefifica os campos
            if (cmbValorPizza.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                cmbValorPizza.Focus();
            }
            else if (cmbValorOpcionais.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                cmbValorOpcionais.Focus();
            }
            else if (cmbValorPagar.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                cmbValorPagar.Focus();
            }
            else
            {
                //tratamento de erros
                try
                {
                    //inserindo dados no banco de dados
                    string sql = "insert into tbPedido(tipoPizza,valorPizza,valorOpcao,valorTotal) values(@pizza,@vpizza,@vopcao,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@pizza", MySqlDbType.Text).Value = cmbTamanhoPizza.Text;
                    cmd.Parameters.Add("@vpizza", MySqlDbType.Text).Value = cmbValorPizza.Text;
                    cmd.Parameters.Add("@vopcao", MySqlDbType.Text).Value = cmbValorOpcionais.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = cmbValorPagar.Text;
                    cmd.ExecuteNonQuery();
                    //este comando guarda os dados do banco

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTamanhoPizza.Text = "";
                    cmbValorPizza.Text = "";
                    cmbValorOpcionais.Text = "";
                    cmbValorPagar.Text = "";
                    cmbTamanhoPizza.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
















        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTamanhoPizza.Items.Add("Pequena- R$ 20,00");
            cmbTamanhoPizza.Items.Add("Média- R$ 30,00");
            cmbTamanhoPizza.Items.Add("Grande- R$ 50,00");

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Criando variável
            double valorPizza = 0, valorOpcao = 0, valorTotal = 0;

            if (cmbTamanhoPizza.SelectedIndex == 0)
            {
                valorPizza = 20;
            }
            else if (cmbTamanhoPizza.SelectedIndex == 1)
            {
                valorPizza = 30;
            }
            else if (cmbTamanhoPizza.SelectedIndex == 2)
            {
                valorPizza = 50;
            }
            if (chkBorda.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if (chkTempero.Checked == true)
            {
                valorOpcao = valorOpcao + 6;
            }
            if (chkCebola.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if (chkCatupiry.Checked == true)
            {
                valorOpcao = valorOpcao + 4;
            }
            else
            {

            }
            valorTotal = valorPizza + valorOpcao;
            cmbValorPizza.Text = Convert.ToString(valorPizza);
            cmbValorOpcionais.Text = Convert.ToString(valorOpcao);
            cmbValorPagar.Text = Convert.ToString(valorTotal);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar2_Click(object sender, EventArgs e)
        {
            //vefifica os campos
            if (cmbValorPizza.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                cmbValorPizza.Focus();
            }
            else if (cmbValorOpcionais.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                cmbValorOpcionais.Focus();
            }
            else if (cmbValorPagar.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                cmbValorPagar.Focus();
            }
            else
            {
                //tratamento de erros
                try
                {
                    //inserindo dados no banco de dados
                    string sql = "insert into tbPedido(tipoPizza,valorPizza,valorOpcao,valorTotal) values(@pizza,@vpizza,@vopcao,@total)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@pizza", MySqlDbType.Text).Value = cmbTamanhoPizza.Text;
                    cmd.Parameters.Add("@vpizza", MySqlDbType.Text).Value = cmbValorPizza.Text;
                    cmd.Parameters.Add("@vopcao", MySqlDbType.Text).Value = cmbValorOpcionais.Text;
                    cmd.Parameters.Add("@total", MySqlDbType.Text).Value = cmbValorPagar.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTamanhoPizza.Text = "";
                    cmbValorPizza.Text = "";
                    cmbValorOpcionais.Text = "";
                    cmbValorPagar.Text = "";
                    cmbTamanhoPizza.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CarregarPedidos();
        }
      //Metodo que vai carregar as informações do DataGrid
     public void CarregarPedidos()
        {
            try
            {
                txtCodigo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cmbTamanhoPizza.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                cmbValorPizza.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cmbValorOpcionais.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                cmbValorPagar.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show("Erros ao clicar" + error);
            }

        }


        private void cmbPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (cmbPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbPedido";

                    cmd.Connection = con.ConnectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.DesConnectarBD();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                //deixa o datagrid limpo
                dataGridView1.DataSource = null;
            }
        }
    } }

