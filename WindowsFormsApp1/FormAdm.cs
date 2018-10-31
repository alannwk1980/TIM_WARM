using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OleDb;


namespace TIM
{
    public partial class FormAdm : Form
    {

        System.Data.SqlClient.SqlConnection con = new SqlConnection(TIM.Properties.Settings.Default.TIMConnectionString);
        SqlCommand cmd;

        
        public FormAdm()
        {
            InitializeComponent();

            buttonImport.Enabled = false;
            buttonClear.Enabled = false;
        }

        public FormAdm(string parametro) : this()

        {
            textBoxLoginADM.Text = parametro;
        }

        private void FormAdm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet.tbAtividade'. Você pode movê-la ou removê-la conforme necessário.
            this.tbAtividadeTableAdapter.Fill(this.tIMDataSet.tbAtividade);

        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
           // string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\\Import\\Planilha.xls';Extended Properties='Excel 12.0; HDR=Yes\'";
            string conn = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Import\\Planilha.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;'");

            OleDbConnection origem = default(OleDbConnection);
            origem = new OleDbConnection(conn);
            OleDbCommand selecao = default(OleDbCommand);
            selecao = new OleDbCommand("Select * from [Fraude$]", origem);

            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = selecao;
            DataSet ds = new DataSet();
            adaptador.Fill(ds);

            dataGridViewImport.DataSource = ds.Tables[0];
            origem.Close();

           // cmd = new SqlCommand(" INSERT INTO[TIM].[dbo].[AuditoriaPedidoStage]",con);

            con.Open();

            SqlBulkCopy importar = default(SqlBulkCopy);
            importar = new SqlBulkCopy(con);
            importar.DestinationTableName = "tbImportFraude";
            importar.WriteToServer(ds.Tables[0]);

           // SqlDataReader dr;
            //dr = cmd.ExecuteReader();


            con.Close();

           
            
            con.Open();
            cmd = new SqlCommand(" select  top 1 Campo  from (select  '1' as Campo from tbImportfraude f join [AuditoriaPedidoStage] A on  f.NomeArquivo =  A.NomeArquivo union select 2 as Campo) b order by 1 ", con);
            SqlDataReader dr2;
            dr2 = cmd.ExecuteReader();

          


            while (dr2.Read())
            {
                string valida = dr2["Campo"].ToString();

                switch (valida)
                {


                    case "1":
                
                    MessageBox.Show("Arquivo já importado anteriormente");
                   
                        buttonImport.Enabled = false;
                        break;

                    default:
                    
                        string insere = "I";
                        textBox1.Text = insere;
                        break;
                }

                

            }
            con.Close();


            if (textBox1.Text == "I")
            {
                string vAtividade = comboBox7.Text;

                // cmd = new SqlCommand("INSERT INTO[TIM].[dbo].[AuditoriaPedidoStage] ([CPF_CNPJ],[Empresa],[Pedido],[TipoNegociacao],[DataInclusão],[Canal],[NomeArquivo], AbaArquivo, Prioridade) select CNPJ, Razao,Numero,Tipo,DATA,Canal,NomeArquivo,AbaArquivo, 100 from tbImportfraude", con);
                cmd = new SqlCommand(" procInserePedidosImportados '" + vAtividade + "'"  , con);
                con.Open();
                SqlDataReader dr3;
                dr3 = cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Importado com sucesso");
                buttonImport.Enabled = false;
                buttonClear.Enabled = false;
                comboBox7.Enabled = false;

            }

            button1.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("truncate table tbImportFraude", con);
            con.Open();
            SqlDataReader dr3;
            dr3 = cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Tabela temporaria [tbImportFraude] limpa com sucesso");
            buttonImport.Enabled = true;


        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonClear.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            cmd = new SqlCommand("procDistribuiPedidos", con);
            con.Open();
            SqlDataReader dr3;
            dr3 = cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Pedisdos novos distribuidos com sucesso");
            buttonImport.Enabled = false;
            buttonClear.Enabled = false;
            comboBox7.Enabled = false;
            button1.Enabled = false;


        }
    }
}


