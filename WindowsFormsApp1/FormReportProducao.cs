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
    public partial class FormReportProducao : Form
    {
        public FormReportProducao()
        {
            InitializeComponent();
        }

        private void FormReportProducao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'TIMDataSet1.procReportProducao'. Você pode movê-la ou removê-la conforme necessário.
            // this.procReportProducaoTableAdapter.Fill(this.TIMDataSet1.procReportProducao);
            // TODO: esta linha de código carrega dados na tabela 'TIMDataSet1.vwReportPedido1'. Você pode movê-la ou removê-la conforme necessário.
            // this.vwReportPedido1TableAdapter.Fill(this.TIMDataSet1.vwReportPedido1);

            dateDataIni.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 27 Feb 2012".  
            dateDataIni.CustomFormat = "yyyy-MM-dd' 00:00:00'";

            dateDataFim.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 27 Feb 2012".  
            dateDataFim.CustomFormat = "yyyy-MM-dd ' 23:59:59'";

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

       // private void button1_Click(object sender, EventArgs e)
        //{
        
//        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            int vmes = Convert.ToInt32(textBox2.Text);
            int vdia = Convert.ToInt32(textBox1.Text);

            // TODO: esta linha de código carrega dados na tabela 'TIMDataSet1.vwReportPedido1'. Você pode movê-la ou removê-la conforme necessário.
            this.procReportProducaoTableAdapter1.Fill(this.TIMDataSet1.procReportProducao, dateDataIni.Value, dateDataFim.Value, vdia, vmes);
            this.reportViewer1.RefreshReport();
        }
    }
}
