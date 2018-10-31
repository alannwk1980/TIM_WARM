using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using AcessoBancoDados;
using Negocios;
using ObjetoTransferencia;

namespace TIM
{
    public partial class Report : Form
    {

        System.Data.SqlClient.SqlConnection con = new SqlConnection(Properties.Settings.Default.TIMConnectionString);
        SqlCommand cmd;

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'TIMDataSet1.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter1.Fill(this.TIMDataSet1.tbUsuario);
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet.tbPendencia'. Você pode movê-la ou removê-la conforme necessário.
            this.tbPendenciaTableAdapter.Fill(this.tIMDataSet.tbPendencia);
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.tIMDataSet.tbUsuario);

            /*
            // TODO: esta linha de código carrega dados na tabela 'TIMDataSet1.vwReportPedido1'. Você pode movê-la ou removê-la conforme necessário.
            this.vwReportPedido1TableAdapter.Fill(this.TIMDataSet1.vwReportPedido1, );

            // this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

       
            // TODO: esta linha de código carrega dados na tabela 'TIMDataSet1.vwReportPedido1'. Você pode movê-la ou removê-la conforme necessário.
            this.vwReportPedido1TableAdapter.Fill(this.TIMDataSet1.vwReportPedido1, comboBox1.Text );
            
            // this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

            reportViewer1.Visible = true;
            if (comboBox1.Text != "[TODOS]")
            {
                button2.Enabled = true;
                button3.Enabled = false;
                label3.Visible = true;
              
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                comboBox2.Visible = false;
                comboBox2.Text = "";
                comboBox3.Text = "";
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
             
                label3.Visible = true;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                comboBox2.Visible = false;
                comboBox2.Text = "";
                comboBox3.Text = "";


            }

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label9.Visible = true;
            button3.Enabled = true;
            comboBox2.Visible = true;
            comboBox2.Text = "";
            comboBox3.Text = "";
            //textBox2.Text = comboBox2.SelectedValue.ToString();
            //textBox1.Text = comboBox1.SelectedValue.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Sem Pendência")
            {
                comboBox3.Enabled = false;
                comboBox3.Text = "";
            }
            else
            {
                comboBox3.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (comboBox2.Text == "")
            {
                MessageBox.Show("Favor escolha o status");
                comboBox2.BackColor = Color.Red;
            }
            else if (comboBox3.Text == "")
            {
                MessageBox.Show("Favor escolha o novo operador");
                comboBox3.BackColor = Color.Red;
                comboBox2.BackColor = Color.White;
            }
            else
            {
                comboBox2.BackColor = Color.White;
                comboBox3.BackColor = Color.White;
                string varLogin = comboBox1.SelectedValue.ToString();
                int varIdPendencia = Convert.ToInt32(comboBox2.SelectedValue.ToString());

                if (comboBox3.Text == "[TODOS]")
                {
                    label8.Text = comboBox3.Text;

                    label6.Visible = true;
                    label7.Visible = true;
                    //label8.Visible = true;
                    label10.Visible = true;
                    label11.Text = "[PEDIDO NOVO]";
                    label11.Visible = true;
                    label12.Text = "E direcionados para a fila de pedidos";
                    label12.Visible = true;
                    panel1.Visible = true;
                    listBox1.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;


                    con.Open();
                    cmd = new SqlCommand(" procPedidoConfirmaUpdate '" + varLogin + "', '" + varIdPendencia + "' ", con);
                    SqlDataReader dr2;
                    dr2 = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr2);


                    List<string> lst = new List<string>();
                    foreach (DataRow r in dt.Rows)
                    {
                        lst.Add(r["Pedido"].ToString());
                    }
                    //listBox1.Items.Clear();
                    listBox1.DataSource = lst;

                    con.Close();

                }
                else
                {


                    label8.Text = comboBox3.Text;

                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label10.Visible = true;
                    label11.Text = "[EM TRATAMENTO]";
                    label11.Visible = true;
                    label12.Text = "E direcionados ao operador :";
                    
                    label12.Visible = true;
                    panel1.Visible = true;
                    listBox1.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;


                    con.Open();
                    cmd = new SqlCommand(" procPedidoConfirmaUpdate '" + varLogin + "', '" + varIdPendencia + "' ", con);
                    SqlDataReader dr2;
                    dr2 = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr2);


                    List<string> lst = new List<string>();
                    foreach (DataRow r in dt.Rows)
                    {
                        lst.Add(r["Pedido"].ToString());
                    }
                    //listBox1.Items.Clear();
                    listBox1.DataSource = lst;

                    con.Close();
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            panel1.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label8.Visible = false;
            listBox1.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string varLogin = comboBox1.SelectedValue.ToString();
            string varLoginNew = comboBox3.SelectedValue.ToString();
            int varIdPendencia = Convert.ToInt32(comboBox2.SelectedValue.ToString());

            if(varLoginNew == "[TODOS]")

            {
                varLoginNew = null;

                con.Open();
                cmd = new SqlCommand(" procPedidoUpdateReport1 '" + varLogin + "', '" + varIdPendencia + "', '" + varLoginNew + "', null ", con);
                SqlDataReader dr2;
                dr2 = cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Atualizado com sucesso");

                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                panel1.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label8.Visible = false;
                listBox1.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
            }

            else
            {
                con.Open();
                cmd = new SqlCommand(" procPedidoUpdateReport1 '" + varLogin + "', '" + varIdPendencia + "', '" + varLoginNew + "', 7 ", con);
                SqlDataReader dr2;
                dr2 = cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Atualizado com sucesso");

                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                panel1.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label8.Visible = false;
                listBox1.Visible = false;
                button4.Visible = false;
                button5.Visible = false;

            }

        
           

        }
    }
}
