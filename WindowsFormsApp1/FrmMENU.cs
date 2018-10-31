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

namespace WindowsFormsApp1
{

  
    public partial class FormMENU : Form
    {

        System.Data.SqlClient.SqlConnection con = new SqlConnection(TIM.Properties.Settings.Default.TIMConnectionString);
        SqlCommand cmd;

        public FormMENU()
        {
            InitializeComponent();
            cadastroMenu.Enabled = false;
            consultaMenu.Enabled = false;
            relatoriomenu.Enabled = false;

        }
        

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novoCadastroMenu_Click(object sender, EventArgs e)
        {
            TIM.frmCadastro FrmCadastro = new TIM.frmCadastro(txtLogin.Text);
            FrmCadastro.MdiParent = this;
            FrmCadastro.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMENU_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("Select sum(case when login = '" + txtLogin.Text + "' and  senha = '" + txtSenha.Text + "' then 1 else 0 end) as logado from tbUsuario", con);
            con.Open();
            SqlDataReader dr1;
            dr1 = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            // dt.Load(dr1);

            string vlogin = txtLogin.Text;


            while (dr1.Read())
            {
                
                string valida = dr1["logado"].ToString();
                switch (valida)
                {
                    case "0":
                        lbMensagem.Visible = true;
                        txtLogin.Text = valida;
                        txtLogin.Text = "";
                        txtSenha.Text = "";
                        
                        break;
                    default:
                        lbMensagem.Visible = false;
                        txtLogin.Text = vlogin;
                        panel1.Visible = false;
                        label1.Visible = false;
                        label2.Visible = false;
                        lbMensagem.Visible = false;
                        txtLogin.Visible = false;
                        txtSenha.Visible = false;
                        btOK.Visible = false;
                        cadastroMenu.Enabled = true;
                        consultaMenu.Enabled = true;
                        relatoriomenu.Enabled = true;
                        usuáriosToolStripMenuItem.Enabled = true;

                        break;
                }

            }
                      
            con.Close();

            cmd = new SqlCommand("INSERT INTO [TIM].[dbo].[tbLogAcesso]([login]," + "[dataLogin], [hostname]) VALUES('" + vlogin + "' ,getdate(),  '" + Environment.MachineName + "')", con);
            con.Open();
            SqlDataReader dr2;
            dr2 = cmd.ExecuteReader();

            con.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void prospectMenu_Click(object sender, EventArgs e)
        {
            TIM.FormAdm FrmAdm = new TIM.FormAdm(txtLogin.Text);
            FrmAdm.MdiParent = this;
            FrmAdm.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TIM.FormUser FrmUser = new TIM.FormUser(txtLogin.Text);
            FrmUser.MdiParent = this;
            FrmUser.Show();
            
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TIM.Report Frmrep = new TIM.Report();
            Frmrep.MdiParent = this;
            Frmrep.Show();
        }

        private void analiticoPendênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TIM.FormReportAnaliticoPendencia FrmAnalitico = new TIM.FormReportAnaliticoPendencia();
            FrmAnalitico.MdiParent = this;
            FrmAnalitico.Show();
        }

        private void produçãoDiáriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TIM.FormReportProducao Frmproducao = new TIM.FormReportProducao();
            Frmproducao.MdiParent = this;
            Frmproducao.Show();
        }

        private void monitoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TIM.FormReportMonitoria Frmmonitoria = new TIM.FormReportMonitoria();
            Frmmonitoria.MdiParent = this;
            Frmmonitoria.Show();
        
        }

        private void menuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
