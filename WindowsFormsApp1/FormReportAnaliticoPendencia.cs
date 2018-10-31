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
    public partial class FormReportAnaliticoPendencia : Form
    {

        System.Data.SqlClient.SqlConnection con = new SqlConnection(Properties.Settings.Default.TIMConnectionString);
        SqlCommand cmd;

        public FormReportAnaliticoPendencia()
        {
            InitializeComponent();
        }

        private void FormReportAnaliticoPendencia_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'TIMDataSet1.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.TIMDataSet1.tbUsuario);
            // TODO: esta linha de código carrega dados na tabela 'TIMDataSet1.vwReportAnaliticoPendencia'. Você pode movê-la ou removê-la conforme necessário.
            this.vwReportAnaliticoPendenciaTableAdapter.Fill(this.TIMDataSet1.vwReportAnaliticoPendencia);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tbUsuarioTableAdapter.Fill(this.TIMDataSet1.tbUsuario);
            this.vwReportAnaliticoPendenciaTableAdapter.Fill(this.TIMDataSet1.vwReportAnaliticoPendencia);
            this.reportViewer1.RefreshReport();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox2.Visible = false;
            comboBox1.Visible = false;
            button3.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;

        }

        /* private void textBox1_TextChanged(object sender, EventArgs e)
         {

         }*/

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "[TODOS]")
            {
                button3.Enabled = false;
            }

            else
            {
                button3.Enabled = true;
            }
        }

      //  private void textBox2_TextChanged(object sender, EventArgs e)
       // {

       // }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.vwReportAnaliticoPendenciaTableAdapter.FillBy1(this.TIMDataSet1.vwReportAnaliticoPendencia);
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox1.Text = "";
            comboBox2.Text = "";
            button3.Enabled = true;
            label1.Visible = true;
            label2.Visible = true;



        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vwReportAnaliticoPendenciaTableAdapter.FillBy(this.TIMDataSet1.vwReportAnaliticoPendencia);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vwReportAnaliticoPendenciaTableAdapter.FillBy1(this.TIMDataSet1.vwReportAnaliticoPendencia);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.vwReportAnaliticoPendenciaTableAdapter.FillBy(this.TIMDataSet1.vwReportAnaliticoPendencia);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.vwReportAnaliticoPendenciaTableAdapter.FillBy1(this.TIMDataSet1.vwReportAnaliticoPendencia);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("O pedido será trocado de Backoffice, Confirma?", "AVISO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                string varLogin = comboBox1.SelectedValue.ToString();
                
                int varIdPedido = Convert.ToInt32(comboBox2.Text.ToString());


                con.Open();
                cmd = new SqlCommand(" procPedidoUpdateAnaliticoPendencia '" + varIdPedido + "', '" + varLogin + "' ", con);
                SqlDataReader dr2;
                dr2 = cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Atualizado com sucesso");

                this.tbUsuarioTableAdapter.Fill(this.TIMDataSet1.tbUsuario);
                this.vwReportAnaliticoPendenciaTableAdapter.Fill(this.TIMDataSet1.vwReportAnaliticoPendencia);
                this.reportViewer1.RefreshReport();
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox2.Visible = false;
                comboBox1.Visible = false;
                button3.Enabled = false;
                label1.Visible = false;
                label2.Visible = false;


            }
            else
            {
                MessageBox.Show("Cancelado pelo operador");

                this.tbUsuarioTableAdapter.Fill(this.TIMDataSet1.tbUsuario);
                this.vwReportAnaliticoPendenciaTableAdapter.Fill(this.TIMDataSet1.vwReportAnaliticoPendencia);
                this.reportViewer1.RefreshReport();
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox2.Visible = false;
                comboBox1.Visible = false;
                button3.Enabled = false;
                label1.Visible = false;
                label2.Visible = false;

            }
        }
    }
}
