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
    public partial class FormReportMonitoria : Form

    {
        System.Data.SqlClient.SqlConnection con = new SqlConnection(Properties.Settings.Default.TIMConnectionString);
        SqlCommand cmd;


        public FormReportMonitoria()
        {
            InitializeComponent();
        }

        private void FormReportMonitoria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'TIMDataSet1.tbPendencia'. Você pode movê-la ou removê-la conforme necessário.
            this.tbPendenciaTableAdapter.Fill(this.TIMDataSet1.tbPendencia);
            this.tbAprovadoTableAdapter.FillBy(this.TIMDataSet1.tbAprovado);
            this.tbUsuarioTableAdapter.FillBy(this.TIMDataSet1.tbUsuario);

            dateDataIni.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 27 Feb 2012".  
            dateDataIni.CustomFormat = "yyyy-MM-dd' 00:00:00'";

            dateDataFim.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 27 Feb 2012".  
            dateDataFim.CustomFormat = "yyyy-MM-dd ' 23:59:59'";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            string varLogin = comboBKO.SelectedValue.ToString();
            DateTime varlll = dateDataIni.Value;
            DateTime var222 = dateDataFim.Value;


            // TODO: esta linha de código carrega dados na tabela 'TIMDataSet1.procMonitoria'. Você pode movê-la ou removê-la conforme necessário.
            this.procMonitoriaTableAdapter.Fill(this.TIMDataSet1.procMonitoria, varLogin, comboAprovado.Text, varlll, var222, comboStatus.Text);
            this.reportViewer1.RefreshReport();
            button1.Enabled = true;
            comboBox1.Text = "";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbAprovadoTableAdapter.FillBy(this.TIMDataSet1.tbAprovado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbUsuarioTableAdapter.FillBy(this.TIMDataSet1.tbUsuario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button3.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox1.Text = "";
            comboBox2.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("O pedido será trocado de Status, Confirma?", "AVISO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                int varIdPendencia = Convert.ToInt32(comboBox2.SelectedValue.ToString());
                int varpedido = Convert.ToInt32(comboBox1.SelectedValue.ToString());


                con.Open();
                cmd = new SqlCommand(" procPedidoUpdateMonitoria '" + varpedido + "', '" + varIdPendencia + "' ", con);
                SqlDataReader dr2;
                dr2 = cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Atualizado com sucesso");


                button3.Enabled = false;
                button3.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox1.Text = "";
                comboBox2.Text = "";
                button1.Enabled = false;
                comboBox1.Text = "";


                string varLogin = comboBKO.SelectedValue.ToString();


                // TODO: esta linha de código carrega dados na tabela 'TIMDataSet1.procMonitoria'. Você pode movê-la ou removê-la conforme necessário.
                this.procMonitoriaTableAdapter.Fill(this.TIMDataSet1.procMonitoria, varLogin, comboAprovado.Text, dateDataIni.Value, dateDataFim.Value, comboStatus.Text);
                this.reportViewer1.RefreshReport();
                button1.Enabled = true;
                comboBox1.Text = "";

            }

            else
            {
                MessageBox.Show("Cancelado pelo operador");

                button3.Enabled = false;
                button3.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox1.Text = "";
                comboBox2.Text = "";
                button1.Enabled = false;
                comboBox1.Text = "";


                string varLogin = comboBKO.SelectedValue.ToString();


                // TODO: esta linha de código carrega dados na tabela 'TIMDataSet1.procMonitoria'. Você pode movê-la ou removê-la conforme necessário.
                this.procMonitoriaTableAdapter.Fill(this.TIMDataSet1.procMonitoria, varLogin, comboAprovado.Text, dateDataIni.Value, dateDataFim.Value, comboStatus.Text);
                this.reportViewer1.RefreshReport();
                button1.Enabled = true;
                comboBox1.Text = "";

            }



        }

        private void comboBKO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBKO.Text == "[TODOS]") 
            {
                button2.Enabled = false;

            }

            else
            {
                button2.Enabled = true;
            }
        }
    }
}
