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
    public partial class frmCadastro : Form
    {
        System.Data.SqlClient.SqlConnection con = new SqlConnection(Properties.Settings.Default.TIMConnectionString);
        SqlCommand cmd;
        string vlogingeral = "";



        public frmCadastro()
        {
            InitializeComponent();
            
        }
        

        public  frmCadastro(string parametro) : this()

        {
            textBox6.Text = parametro;
            vlogingeral = parametro;
        }

        public static void ClearForm(System.Windows.Forms.Control parent)
        {
                        
            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                //Loop through all controls 
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    //Check to see if it's a textbox 
                    ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
                   
                    //If it is then set the text to String.Empty (empty textbox) 
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    //If its a RichTextBox clear the text
                    ((System.Windows.Forms.RichTextBox)ctrControl).Text = string.Empty;
                    
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    //Next check if it's a dropdown list 
                    ((System.Windows.Forms.ComboBox)ctrControl).SelectedIndex = -1;
                   
                    //If it is then set its SelectedIndex to 0 
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    //Next uncheck all checkboxes
                    ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
                  
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    //Unselect all RadioButtons
                    ((System.Windows.Forms.RadioButton)ctrControl).Checked = false;
                
                }
                
                if (ctrControl.Controls.Count > 0)
                {
                    //Call itself to get all other controls in other containers 
                    ClearForm(ctrControl);
                }
                
            }
        }

        public static void DisableForm(System.Windows.Forms.Control parent)
        {

            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                //Loop through all controls 
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    //Check to see if it's a textbox 
                    
                    ((System.Windows.Forms.TextBox)ctrControl).Enabled = false;
                    //If it is then set the text to String.Empty (empty textbox) 
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    //If its a RichTextBox clear the text
                   
                    ((System.Windows.Forms.RichTextBox)ctrControl).Enabled = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    //Next check if it's a dropdown list 
                 
                    ((System.Windows.Forms.ComboBox)ctrControl).Enabled = false;
                    //If it is then set its SelectedIndex to 0 
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    //Next uncheck all checkboxes
                 
                    ((System.Windows.Forms.CheckBox)ctrControl).Enabled = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    //Unselect all RadioButtons
                 
                    ((System.Windows.Forms.RadioButton)ctrControl).Enabled = false;
                }
                if (ctrControl.Controls.Count > 0)
                {
                    //Call itself to get all other controls in other containers 
                    DisableForm(ctrControl);
                }

            }
        }


        public static void EnableForm(System.Windows.Forms.Control parent)
        {

            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                //Loop through all controls 
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    //Check to see if it's a textbox 

                    ((System.Windows.Forms.TextBox)ctrControl).Enabled = true;
                    //If it is then set the text to String.Empty (empty textbox) 
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    //If its a RichTextBox clear the text

                    ((System.Windows.Forms.RichTextBox)ctrControl).Enabled = true;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    //Next check if it's a dropdown list 

                    ((System.Windows.Forms.ComboBox)ctrControl).Enabled = true;
                    //If it is then set its SelectedIndex to 0 
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    //Next uncheck all checkboxes

                    ((System.Windows.Forms.CheckBox)ctrControl).Enabled = true;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    //Unselect all RadioButtons

                    ((System.Windows.Forms.RadioButton)ctrControl).Enabled = true;
                }
                if (ctrControl.Controls.Count > 0)
                {
                    //Call itself to get all other controls in other containers 
                    EnableForm(ctrControl);
                }
               
            }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");

        }

        private void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
            txt.Text = txt.Text.Replace(",", ".").Trim();
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        private void AplicarEventos(TextBox txt)
        {
           txt.Enter += TirarMascara;
           txt.LostFocus += RetornarMascara;
           txt.KeyPress += ApenasValorNumerico;
        }



        public void frmCadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet3.tbPendencia'. Você pode movê-la ou removê-la conforme necessário.
            this.tbPendenciaTableAdapter.Fill(this.tIMDataSet3.tbPendencia);
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet6.tbMotivoNegativa'. Você pode movê-la ou removê-la conforme necessário.
            this.tbMotivoNegativaTableAdapter.Fill(this.tIMDataSet6.tbMotivoNegativa);
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet5.procMotivoNegativa'. Você pode movê-la ou removê-la conforme necessário.
            this.procMotivoNegativaTableAdapter.Fill(this.tIMDataSet5.procMotivoNegativa);
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet3.AuditoriaPedido'. Você pode movê-la ou removê-la conforme necessário.
            this.auditoriaPedidoTableAdapter.Fill(this.tIMDataSet3.AuditoriaPedido);
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet5.tbAtividade'. Você pode movê-la ou removê-la conforme necessário.
            this.tbAtividadeTableAdapter.Fill(this.tIMDataSet5.tbAtividade);
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet.tbTipoNegoc'. Você pode movê-la ou removê-la conforme necessário.
            this.tbTipoNegocTableAdapter.Fill(this.tIMDataSet.tbTipoNegoc);
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet3.tbCanal'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCanalTableAdapter.Fill(this.tIMDataSet3.tbCanal);
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet3.tbOrigem'. Você pode movê-la ou removê-la conforme necessário.
            this.tbOrigemTableAdapter.Fill(this.tIMDataSet3.tbOrigem);
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet3.tbAprovado'. Você pode movê-la ou removê-la conforme necessário.
            this.tbAprovadoTableAdapter.Fill(this.tIMDataSet3.tbAprovado);
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet3.UF'. Você pode movê-la ou removê-la conforme necessário.
            this.uFTableAdapter.Fill(this.tIMDataSet3.UF);




            DisableForm(this);

            comboBox7.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            dataGridView1.Show();
            groupBox1.Hide();
            label23.Hide();
            comboBox2.Hide();

            
            textBox1.Enabled = true;
            checkBox17.Enabled = true;
            checkBox18.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;

            TabPage tab = tabPage2;
            this.tabControl1.TabPages.Remove(tabPage2);




        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void auditoriaPedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAtividade_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox6_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }

        private void comboBox3_SelectedIndexChanged_2(object sender, EventArgs e)
        {

            string campo = comboBox3.Text;
            switch (campo)
            {
                case "":
                    comboBox4.Enabled = false;
                    break;
                default:
                    comboBox4.Enabled = true;
                    break;
            }

            if (comboBox7.Text == "TIM")
            {


                int valor = comboBox3.SelectedIndex;
                switch (valor)
                {
                    case 13:
                        checkBox1.Show();
                        checkBox2.Show();
                        checkBox3.Show();
                        checkBox4.Show();
                        checkBox5.Show();
                        checkBox6.Show();
                        checkBox7.Show();
                        checkBox8.Show();
                        checkBox9.Show();
                        checkBox10.Show();
                        groupBox1.Show();

                        break;
                    case 133:
                        checkBox1.Show();
                        checkBox2.Show();
                        checkBox3.Show();
                        checkBox4.Show();
                        checkBox5.Show();
                        checkBox6.Show();
                        checkBox7.Show();
                        checkBox8.Show();
                        checkBox9.Show();
                        checkBox10.Show();
                        groupBox1.Show();

                        break;
                    case 134:
                        checkBox1.Show();
                        checkBox2.Show();
                        checkBox3.Show();
                        checkBox4.Show();
                        checkBox5.Show();
                        checkBox6.Show();
                        checkBox7.Show();
                        checkBox8.Show();
                        checkBox9.Show();
                        checkBox10.Show();
                        groupBox1.Show();

                        break;
                    case 135:
                        checkBox1.Show();
                        checkBox2.Show();
                        checkBox3.Show();
                        checkBox4.Show();
                        checkBox5.Show();
                        checkBox6.Show();
                        checkBox7.Show();
                        checkBox8.Show();
                        checkBox9.Show();
                        checkBox10.Show();
                        groupBox1.Show();

                        break;
                    default:
                        checkBox1.Hide();
                        checkBox1.Hide();
                        checkBox2.Hide();
                        checkBox3.Hide();
                        checkBox4.Hide();
                        checkBox5.Hide();
                       // checkBox6.Hide();
                        checkBox7.Hide();
                        checkBox8.Hide();
                        checkBox9.Hide();
                        checkBox10.Hide();
                        checkBox1.Checked = false;
                        checkBox2.Checked = false;
                        checkBox3.Checked = false;
                        checkBox4.Checked = false;
                        checkBox5.Checked = false;
                        checkBox6.Checked = false;
                        checkBox7.Checked = false;
                        checkBox8.Checked = false;
                        checkBox9.Checked = false;
                        checkBox10.Checked = false;
                        groupBox1.Hide();


                        break;

                }
            }

            if (comboBox7.Text == "APARELHOS")
            {
                checkBox1.Hide();
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                checkBox5.Hide();
                checkBox6.Hide();
                checkBox7.Hide();
                checkBox8.Hide();
                checkBox9.Hide();
                checkBox10.Hide();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                groupBox1.Hide();

                /* int valor = comboBox3.SelectedIndex;
                 switch (valor)
                 {
                     case 13:
                         checkBox1.Show();
                         checkBox2.Show();
                         checkBox3.Show();
                         checkBox4.Show();
                         checkBox5.Show();
                         checkBox6.Show();
                         checkBox7.Show();
                         checkBox8.Show();
                         checkBox9.Show();
                         checkBox10.Show();
                         groupBox1.Show();

                         break;
                }

         */

                    if ((comboBox3.Text == "Não (Com hist. pagto) / Com Contato") || (comboBox3.Text == "Não (Com hist. pagto) / Sem contato") || (comboBox3.Text == "Não (Sem hist. pagto)") )
                {
                    comboBox2.Show();
                    label23.Show();
                    }
                    else
                    {
                    comboBox2.Hide();
                    label23.Hide();
                }

            }
                

        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string campo = comboBox4.Text;
            switch (campo)
            {
                case "":
                    comboBox5.Enabled = false;
                    break;
                default:
                    comboBox5.Enabled = true;
                    break;
            }
        }

        private void comboBox7_SelectedIndexChanged_1(object sender, EventArgs e)
        {
                     
            cmd = new SqlCommand("Select * from tbAprovado where  idResposta = '" + comboBox7.SelectedValue + "'order by 2 ", con);
            con.Open();
            SqlDataReader dr1;
            dr1 = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr1);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "descAprovado";
            con.Close();

            cmd = new SqlCommand("Select * from tbTipoNegoc where  idAtividade = '" + comboBox7.SelectedValue + "'order by 2", con);
            con.Open();
            SqlDataReader dr2;
            dr2 = cmd.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr2);
            comboBox4.DataSource = dt1;
            comboBox4.DisplayMember = "descTipoNegoc";
            
            con.Close();

            cmd = new SqlCommand("Select * from tborigem where  idAtividade = '" + comboBox7.SelectedValue + "'order by 2", con);
            con.Open();
            SqlDataReader dr3;
            dr3 = cmd.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr3);
            comboBox5.DataSource = dt2;
            comboBox5.DisplayMember = "descOrigem";

            con.Close();

            /*cmd = new SqlCommand("Select * from tbcanal order by 2", con);
            con.Open();
            SqlDataReader dr4;
            dr4 = cmd.ExecuteReader();
            DataTable dt3 = new DataTable();
            dt3.Load(dr4);
            comboBox6.DataSource = dt3;
            comboBox6.DisplayMember = "descCanal";

            con.Close();*/

            cmd = new SqlCommand("Select * from tbMotivoNegativa order by 2", con);
            con.Open();
            SqlDataReader dr5;
            dr5 = cmd.ExecuteReader();
            DataTable dt4 = new DataTable();
            dt4.Load(dr5);
            comboBox2.DataSource = dt4;
            comboBox2.DisplayMember = "DescMotivoNegativa";

            con.Close();




            if (comboBox7.SelectedIndex > -1)
                comboBox3.Enabled = true;
               

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from UF where descUf = '" + comboBox1.Text + "'", con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string particao = dr["Particao"].ToString();
                textBox4.Text = particao;              
            }
            con.Close();
        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string campo = comboBox5.Text;
            switch (campo)
            {
                case "":
                    comboBox6.Enabled = false;
                    break;
                default:
                    comboBox6.Enabled = true;
                    break;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DateTime.Now.ToShortDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tbAprovadoTableAdapter.FillBy(this.tIMDataSet.tbAprovado);
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
                this.tbAprovadoTableAdapter.FillBy(this.tIMDataSet.tbAprovado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.tbAprovadoTableAdapter.FillBy(this.tIMDataSet.tbAprovado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tbAprovadoTableAdapter.FillBy(this.tIMDataSet.tbAprovado);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void labelNotas_Click(object sender, EventArgs e)
        {

        }

        private void tbAprovadoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tIMDataSetBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbOrigemBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbParticaoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tIMDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tIMDataSetBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void labelEstado_Click(object sender, EventArgs e)
        {

        }

        private void labelParticao_Click(object sender, EventArgs e)
        {

        }

        private void labelinclusao_Click(object sender, EventArgs e)
        {

        }

        private void labellogin_Click(object sender, EventArgs e)
        {

        }

        private void labelAprovado_Click(object sender, EventArgs e)
        {

        }

        private void labelTipoNegociacao_Click(object sender, EventArgs e)
        {

        }

        private void labelOrigem_Click(object sender, EventArgs e)
        {

        }

        private void labelCabal_Click(object sender, EventArgs e)
        {

        }

        private void tbAtividadeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void uFBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void tbAprovadoBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbTipoNegocBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbOrigemBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbCanalBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbAtividadeBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbAtividadeBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tbAtividadeBindingSource3_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void auditoriaPedidoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
              //  this.auditoriaPedidoTableAdapter.FillBy(this.tIMDataSet.AuditoriaPedido, cNPJToolStripTextBox.Text);
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
                this.auditoriaPedidoTableAdapter.FillBy1(this.tIMDataSet.AuditoriaPedido);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click_2(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_4(object sender, EventArgs e)
        {

        }

        private void uFCOM_IDToolStripButton_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {

            {
              //  if (textBox11.Text == "1")
               // {
                  // uFTableAdapter.com_id(timDataSet4.UF, textBox11.Text);
                //}
               
            }

           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


            cmd = new SqlCommand("Select * from UF where descUf", con);
            con.Open();

            // cria o dataadapter...
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // preenche o dataset...
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = dataSet.Tables[0].TableName;
          
            
           
            con.Close();


        }

        private void button1_Click_3(object sender, EventArgs e)
        {

            string varcnpj = textBox1.Text;
            string vlogin = textBox6.Text;
            string vlogin1 = textBox6.Text;
            int vpendencia = 0;

            if (checkBox17.Checked == true)
            {
                vpendencia = 10;
            }

            if (checkBox18.Checked == true)
            {
                vlogin = "BKOGERAL";
               // vlogingeral = "BKOGERAL";
            }
            else
            {
                vlogin = textBox6.Text;
            }
            

            ClearForm(this);
            DisableForm(this);
            textBox6.Text = vlogin1;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dataGridView1.Show();
            textBox1.Text = varcnpj;
            button10.Enabled = false;

            AudPedidoStageNegocio audPedidoNegocio = new AudPedidoStageNegocio();

            //EstadoNegocios estadoNegocios = new EstadoNegocios();

            AudPedidoStageColecao audPedidoStageColeca = new AudPedidoStageColecao();

                    

                audPedidoStageColeca = audPedidoNegocio.ConsultarCNPJ(textBox1.Text, vpendencia, vlogin);



                if (audPedidoStageColeca.Count <= 0)
                {
                    dataGridView1.Hide();
                    MessageBox.Show("Não existe análise anterior para esse CNPJ");
                    button1.Enabled = true;
                    textBox1.Enabled = true;
                    textBox1.Text = "";
                
                }
                else
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = audPedidoStageColeca;
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                    button10.Enabled = false;
                }

            

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            tabPage2.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_5(object sender, EventArgs e)
        {
            try
            {
                this.tbMotivoNegativaTableAdapter.FillBy(this.tIMDataSet.tbMotivoNegativa);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1_orderToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbMotivoNegativaTableAdapter.FillBy1_order(this.tIMDataSet.tbMotivoNegativa);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox10_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox13_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = (dataGridView1.CurrentCell.RowIndex);

            if ((rowIndex == 0))
            {
                

                this.dataGridView1.CurrentRow.Selected = false;
                this.Cursor = Cursors.No;

                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;

            }
            else
            {

                button4.Enabled = true;
                button1.Enabled = false;

                this.Cursor = Cursors.Hand;
                this.dataGridView1.CurrentRow.Selected = true;
                this.textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
                this.textBox2.Text = dataGridView1.SelectedCells[2].Value.ToString();
                this.dateTimePicker2.Text = dataGridView1.SelectedCells[1].Value.ToString();
                this.comboBox1.Text = dataGridView1.SelectedCells[3].Value.ToString();

                this.comboBox7.Text = dataGridView1.SelectedCells[5].Value.ToString();
                this.dateTimePicker1.Text = dataGridView1.SelectedCells[6].Value.ToString();
                this.comboBox3.Text = dataGridView1.SelectedCells[8].Value.ToString();
                this.comboBox4.Text = dataGridView1.SelectedCells[9].Value.ToString();
                this.comboBox5.Text = dataGridView1.SelectedCells[10].Value.ToString();
                this.comboBox6.Text = dataGridView1.SelectedCells[11].Value.ToString();
                this.textBoxNotas.Text = dataGridView1.SelectedCells[12].Value.ToString();
                this.textBoxAnaliseG.Text = dataGridView1.SelectedCells[13].Value.ToString();
                // this.richTextBox1.Text = dataGridView1.SelectedCells[13].Value.ToString();
                this.textBox7.Text = dataGridView1.SelectedCells[14].Value.ToString();
                this.textBox8.Text = dataGridView1.SelectedCells[15].Value.ToString();
                this.textBox5.Text = dataGridView1.SelectedCells[16].Value.ToString();
                this.textBox10.Text = dataGridView1.SelectedCells[17].Value.ToString();
                this.textBox12.Text = dataGridView1.SelectedCells[18].Value.ToString();
                this.textBox9.Text = dataGridView1.SelectedCells[19].Value.ToString();
                this.textBox3.Text = dataGridView1.SelectedCells[20].Value.ToString();
                this.comboBox2.Text = dataGridView1.SelectedCells[37].Value.ToString();
                this.comboBox8.Text = dataGridView1.SelectedCells[39].Value.ToString();
                this.textBoxID.Text = dataGridView1.SelectedCells[40].Value.ToString();

                //REMOVER
                this.textBox6.Text = dataGridView1.SelectedCells[7].Value.ToString();


                if (dataGridView1.SelectedCells[21].Value.ToString() == "True")
                {
                    this.checkBox11.Checked = true;
                   
                }
                else
                {
                    this.checkBox11.Checked = false;
                }

                if (dataGridView1.SelectedCells[22].Value.ToString() == "True")
                {
                    this.checkBox16.Checked = true;
                }
                else
                {
                    this.checkBox16.Checked = false;
                }

                if (dataGridView1.SelectedCells[23].Value.ToString() == "True")
                {
                    this.checkBox12.Checked = true;
                }
                else
                {
                    this.checkBox12.Checked = false;
                }

                if (dataGridView1.SelectedCells[24].Value.ToString() == "True")
                {
                    this.checkBox14.Checked = true;
                }
                else
                {
                    this.checkBox14.Checked = false;
                }

                if (dataGridView1.SelectedCells[25].Value.ToString() == "True")
                {
                    this.checkBox13.Checked = true;
                }
                else
                {
                    this.checkBox13.Checked = false;
                }
                if (dataGridView1.SelectedCells[26].Value.ToString() == "True")
                {
                    this.checkBox15.Checked = true;
                }
                else
                {
                    this.checkBox15.Checked = false;
                }

                if (dataGridView1.SelectedCells[27].Value.ToString() == "True")
                {
                    this.checkBox1.Checked = true;
                }
                else
                {
                    this.checkBox1.Checked = false;
                }

                if (dataGridView1.SelectedCells[28].Value.ToString() == "True")
                {
                    this.checkBox2.Checked = true;
                }
                else
                {
                    this.checkBox2.Checked = false;
                }

                if (dataGridView1.SelectedCells[29].Value.ToString() == "True")
                {
                    this.checkBox3.Checked = true;
                }
                else
                {
                    this.checkBox3.Checked = false;
                }

                if (dataGridView1.SelectedCells[30].Value.ToString() == "True")
                {
                    this.checkBox10.Checked = true;
                }
                else
                {
                    this.checkBox10.Checked = false;
                }

                if (dataGridView1.SelectedCells[31].Value.ToString() == "True")
                {
                    this.checkBox4.Checked = true;
                }
                else
                {
                    this.checkBox4.Checked = false;
                }

                if (dataGridView1.SelectedCells[32].Value.ToString() == "True")
                {
                    this.checkBox5.Checked = true;
                }
                else
                {
                    this.checkBox5.Checked = false;
                }

                if (dataGridView1.SelectedCells[33].Value.ToString() == "True")
                {
                    this.checkBox6.Checked = true;
                }
                else
                {
                    this.checkBox6.Checked = false;
                }

                if (dataGridView1.SelectedCells[34].Value.ToString() == "True")
                {
                    this.checkBox7.Checked = true;
                }
                else
                {
                    this.checkBox7.Checked = false;
                }

                if (dataGridView1.SelectedCells[35].Value.ToString() == "True")
                {
                    this.checkBox8.Checked = true;
                }
                else
                {
                    this.checkBox8.Checked = false;
                }

                if (dataGridView1.SelectedCells[36].Value.ToString() == "True")
                {
                    this.checkBox9.Checked = true;
                }
                else
                {
                    this.checkBox9.Checked = false;
                }

                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;


            }



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = (dataGridView1.CurrentCell.RowIndex);

            if ((rowIndex < 0))
            {
                this.dataGridView1.CurrentRow.Selected = false;
                this.Cursor = Cursors.No;

                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;

            }
            else
            {

                button4.Enabled = true;
                button1.Enabled = false;
                this.Cursor = Cursors.Hand;
                this.dataGridView1.CurrentRow.Selected = true;
                this.textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
                this.textBox2.Text = dataGridView1.SelectedCells[2].Value.ToString();
                this.dateTimePicker2.Text = dataGridView1.SelectedCells[1].Value.ToString();
                this.comboBox1.Text = dataGridView1.SelectedCells[3].Value.ToString();

                this.comboBox7.Text = dataGridView1.SelectedCells[5].Value.ToString();
                this.dateTimePicker1.Text = dataGridView1.SelectedCells[6].Value.ToString();
                this.comboBox3.Text = dataGridView1.SelectedCells[8].Value.ToString();
                this.comboBox4.Text = dataGridView1.SelectedCells[9].Value.ToString();
                this.comboBox5.Text = dataGridView1.SelectedCells[10].Value.ToString();
                this.comboBox6.Text = dataGridView1.SelectedCells[11].Value.ToString();
                this.textBoxNotas.Text = dataGridView1.SelectedCells[12].Value.ToString();
                this.textBoxAnaliseG.Text = dataGridView1.SelectedCells[13].Value.ToString();
                //this.richTextBox1.Text = dataGridView1.SelectedCells[13].Value.ToString();
                this.textBox7.Text = dataGridView1.SelectedCells[14].Value.ToString();
                this.textBox8.Text = dataGridView1.SelectedCells[15].Value.ToString();
                this.textBox5.Text = dataGridView1.SelectedCells[16].Value.ToString();
                this.textBox10.Text = dataGridView1.SelectedCells[17].Value.ToString();
                this.textBox12.Text = dataGridView1.SelectedCells[18].Value.ToString();
                this.textBox9.Text = dataGridView1.SelectedCells[19].Value.ToString();
                this.textBox3.Text = dataGridView1.SelectedCells[20].Value.ToString();
                this.comboBox2.Text = dataGridView1.SelectedCells[37].Value.ToString();
                this.comboBox8.Text = dataGridView1.SelectedCells[39].Value.ToString();
                this.textBoxID.Text = dataGridView1.SelectedCells[40].Value.ToString();

                //REMOVER
                this.textBox6.Text = dataGridView1.SelectedCells[7].Value.ToString();


                if (dataGridView1.SelectedCells[21].Value.ToString() == "True")
                {
                    this.checkBox11.Checked = true;
                }
                else
                {
                    this.checkBox11.Checked = false;
                }

                if (dataGridView1.SelectedCells[22].Value.ToString() == "True")
                {
                    this.checkBox16.Checked = true;
                }
                else
                {
                    this.checkBox16.Checked = false;
                }

                if (dataGridView1.SelectedCells[23].Value.ToString() == "True")
                {
                    this.checkBox12.Checked = true;
                }
                else
                {
                    this.checkBox12.Checked = false;
                }

                if (dataGridView1.SelectedCells[24].Value.ToString() == "True")
                {
                    this.checkBox14.Checked = true;
                }
                else
                {
                    this.checkBox14.Checked = false;
                }

                if (dataGridView1.SelectedCells[25].Value.ToString() == "True")
                {
                    this.checkBox13.Checked = true;
                }
                else
                {
                    this.checkBox13.Checked = false;
                }
                if (dataGridView1.SelectedCells[26].Value.ToString() == "True")
                {
                    this.checkBox15.Checked = true;
                }
                else
                {
                    this.checkBox15.Checked = false;
                }

                if (dataGridView1.SelectedCells[27].Value.ToString() == "True")
                {
                    this.checkBox1.Checked = true;
                }
                else
                {
                    this.checkBox1.Checked = false;
                }

                if (dataGridView1.SelectedCells[28].Value.ToString() == "True")
                {
                    this.checkBox2.Checked = true;
                }
                else
                {
                    this.checkBox2.Checked = false;
                }

                if (dataGridView1.SelectedCells[29].Value.ToString() == "True")
                {
                    this.checkBox3.Checked = true;
                }
                else
                {
                    this.checkBox3.Checked = false;
                }

                if (dataGridView1.SelectedCells[30].Value.ToString() == "True")
                {
                    this.checkBox10.Checked = true;
                }
                else
                {
                    this.checkBox10.Checked = false;
                }

                if (dataGridView1.SelectedCells[31].Value.ToString() == "True")
                {
                    this.checkBox4.Checked = true;
                }
                else
                {
                    this.checkBox4.Checked = false;
                }

                if (dataGridView1.SelectedCells[32].Value.ToString() == "True")
                {
                    this.checkBox5.Checked = true;
                }
                else
                {
                    this.checkBox5.Checked = false;
                }

                if (dataGridView1.SelectedCells[33].Value.ToString() == "True")
                {
                    this.checkBox6.Checked = true;
                }
                else
                {
                    this.checkBox6.Checked = false;
                }

                if (dataGridView1.SelectedCells[34].Value.ToString() == "True")
                {
                    this.checkBox7.Checked = true;
                }
                else
                {
                    this.checkBox7.Checked = false;
                }

                if (dataGridView1.SelectedCells[35].Value.ToString() == "True")
                {
                    this.checkBox8.Checked = true;
                }
                else
                {
                    this.checkBox8.Checked = false;
                }

                if (dataGridView1.SelectedCells[36].Value.ToString() == "True")
                {
                    this.checkBox9.Checked = true;
                }
                else
                {
                    this.checkBox9.Checked = false;
                }

                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
            }


           

        }

        private void button3_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button4.Enabled = false;

            string vlogin = textBox6.Text;
          

            ClearForm(this);
            EnableForm(this);
            textBox6.Text = vlogin;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dataGridView1.Hide();
            groupBox1.Hide();
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            textBox6.Enabled = false;
            textBox4.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = false;

          
            

            

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
           

        }

        private void button6_Click(object sender, EventArgs e)
        {

            //InitializeComponent();

            AplicarEventos(textBox22);
            textBox25.Enabled = true;



            
            if ( textBox12.Text == "")
            {
                textBox12.Text = "0";
            }

            if (comboBox6.Text == "" || comboBox8.Text =="" || comboBox5.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || comboBox8.Text == "" || textBoxNotas.Text == "" || textBoxAnaliseG.Text == "")
            {
                MessageBox.Show("Existem campos vazios. Favor preeencher antes de salvar.");
            }
            else if (comboBox8.Text == "Sem Pendência")

            {
                if (MessageBox.Show("Pedidos SEM PENDÊNCIA não poderão ser mais alterados. Confirma?", "AVISO", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        dateTimePicker2.Value = DateTime.Now;

                        cmd = new SqlCommand(" INSERT INTO[TIM].[dbo].[AuditoriaPedidoStage]  ([CPF_CNPJ], " +
                                                                                                "[DataEnvio]," +
                                                                                                "[Pedido]," +
                                                                                                "[UF]," +
                                                                                                "[particao]," +
                                                                                                "[Atividade]," +
                                                                                                "[DataInclusão]," +
                                                                                                "[LoginAnalise]," +
                                                                                                "[Aprovado]," +
                                                                                                "[TipoNegociacao]," +
                                                                                                "[Origem]," +
                                                                                                "[Canal]," +
                                                                                                "[NotasDDR]," +
                                                                                                "[DescAnalise]," +
                                                                                                "[Empresa]," +
                                                                                                "[Ramo]," +
                                                                                                "[NomeTBP]," +
                                                                                                "[QuantAcessos]," +
                                                                                                "[QuantAparelhos]," +
                                                                                                "[Vendedor]," +
                                                                                                "[CodigoTBP]," +
                                                                                                "[FraudeTBP]," +
                                                                                                "[Reanalise]," +
                                                                                                "[C3S]," +
                                                                                                "[ByPass]," +
                                                                                                "[Portabilidade]," +
                                                                                                "[Dossie]," +
                                                                                                "[SocioAdmNaoValido]," +
                                                                                                "[TelefoneNaoExiste]," +
                                                                                                "[ClientePendencias]," +
                                                                                                "[RecenteAlteContratual]," +
                                                                                                "[AsceConsultas]," +
                                                                                                "[EmpresaRecente]," +
                                                                                                "[AcessosNaoCondiz]," +
                                                                                                "[TentativaVariosProdutos]," +
                                                                                                "[InatividadeComer]," +
                                                                                                "[DocumentoFalso]," +
                                                                                                "[MotivoNegativa]," +
                                                                                                "[idPendencia]) values('" + textBox1.Text + "', '" + dateTimePicker2.Value + "'," +
                                                                                                "'" + textBox2.Text + "','" + comboBox1.Text + "', '" + textBox4.Text + "', '" + comboBox7.Text + "'," +
                                                                                                "'" + dateTimePicker1.Value + "','" + textBox6.Text + "','" + comboBox3.Text + "', " +
                                                                                                "'" + comboBox4.Text + "','" + comboBox5.Text + "', '" + comboBox6.Text + "','" + textBoxNotas.Text + "' , '" + textBoxAnaliseG.Text + "'" +
                                                                                                ", '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox5.Text + "', '" + textBox10.Text + "', '" + textBox12.Text + "'," +
                                                                                                "'" + textBox9.Text + "','" + textBox3.Text + "' ,'" + checkBox11.Checked + "','" + checkBox16.Checked + "','" + checkBox12.Checked + "', " +
                                                                                                "'" + checkBox14.Checked + "','" + checkBox13.Checked + "','" + checkBox15.Checked + "','" + checkBox1.Checked + "','" + checkBox2.Checked + "'," +
                                                                                                "'" + checkBox3.Checked + "','" + checkBox10.Checked + "','" + checkBox4.Checked + "','" + checkBox5.Checked + "','" + checkBox6.Checked + "'," +
                                                                                                "'" + checkBox7.Checked + "','" + checkBox8.Checked + "','" + checkBox9.Checked + "','" + comboBox2.Text + "','" + comboBox8.SelectedValue + "')", con);
                        con.Open();
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();


                        con.Close();

                        MessageBox.Show("Inserido com Sucesso");


                        // if (((comboBox3.Text == "Não (Com hist. pagto) / Com Contato") || (comboBox3.Text == "Não (Com hist. pagto) / Sem contato") || (comboBox3.Text == "Não (Sem hist. pagto)") || (comboBox3.Text == "Não (Fraude Subscrição)")) & int.Parse(textBox12.Text) > 0)

                        if (((comboBox3.Text == "Não (Com hist. pagto) / Com Contato") || (comboBox3.Text == "Não (Com hist. pagto) / Sem contato") ||
                           (comboBox3.Text == "Não (Sem hist. pagto)") || (comboBox3.Text == "Não (Fraude Subscrição)") || (comboBox3.Text == "NÃO")
                           || (comboBox3.Text == "AssinaturaDivergente") || (comboBox3.Text == "Doc.Nãovalidada") || (comboBox3.Text == "FraudenabaseTIM"))
                           & int.Parse(textBox12.Text) > 0 & comboBox8.Text == "Em Tratamento")

                        {
                            string levalogin = textBox6.Text;
                            string levaCNPJ = textBox1.Text;


                            this.tabControl1.TabPages.Add(tabPage2);
                            this.tabControl1.TabPages.Remove(tabPage1);
                            MessageBox.Show("Favor Cadastrar os aparelhos antes de concluir");

                            textBox18.Text = levaCNPJ;
                            textBox16.Text = levalogin;


                        }


                        string vCNPJ = textBox1.Text;
                        textBox1.Text = "";
                        string vlogin = textBox6.Text;
                        string vpedido = textBox2.Text;
                        string vAtividade = comboBox7.Text;
                        ClearForm(this);

                        dateTimePicker3.Value = DateTime.Now;
                        textBox18.Text = vCNPJ;
                        textBox17.Text = vpedido;
                        textBox19.Text = vAtividade;
                        textBox16.Text = vlogin;
                        textBox6.Text = vlogin;
                        dateTimePicker1.Value = DateTime.Now;
                        dateTimePicker2.Value = DateTime.Now;

                        textBox20.Enabled = true;
                        textBox26.Enabled = true;
                        textBox22.Enabled = true;
                        textBox21.Enabled = true;
                        textBox23.Enabled = true;
                        textBox25.Enabled = false;
                        textBox24.Enabled = true;
                        button10.Enabled = true;
                        textBox25.Enabled = true;




                    }



                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
            else
            {

                dateTimePicker2.Value = DateTime.Now;

                cmd = new SqlCommand(" INSERT INTO[TIM].[dbo].[AuditoriaPedidoStage]  ([CPF_CNPJ], " +
                                                                                               "[DataEnvio]," +
                                                                                               "[Pedido]," +
                                                                                               "[UF]," +
                                                                                               "[particao]," +
                                                                                               "[Atividade]," +
                                                                                               "[DataInclusão]," +
                                                                                               "[LoginAnalise]," +
                                                                                               "[Aprovado]," +
                                                                                               "[TipoNegociacao]," +
                                                                                               "[Origem]," +
                                                                                               "[Canal]," +
                                                                                               "[NotasDDR]," +
                                                                                               "[DescAnalise]," +
                                                                                               "[Empresa]," +
                                                                                               "[Ramo]," +
                                                                                               "[NomeTBP]," +
                                                                                               "[QuantAcessos]," +
                                                                                               "[QuantAparelhos]," +
                                                                                               "[Vendedor]," +
                                                                                               "[CodigoTBP]," +
                                                                                               "[FraudeTBP]," +
                                                                                               "[Reanalise]," +
                                                                                               "[C3S]," +
                                                                                               "[ByPass]," +
                                                                                               "[Portabilidade]," +
                                                                                               "[Dossie]," +
                                                                                               "[SocioAdmNaoValido]," +
                                                                                               "[TelefoneNaoExiste]," +
                                                                                               "[ClientePendencias]," +
                                                                                               "[RecenteAlteContratual]," +
                                                                                               "[AsceConsultas]," +
                                                                                               "[EmpresaRecente]," +
                                                                                               "[AcessosNaoCondiz]," +
                                                                                               "[TentativaVariosProdutos]," +
                                                                                               "[InatividadeComer]," +
                                                                                               "[DocumentoFalso]," +
                                                                                               "[MotivoNegativa]," +
                                                                                               "[idPendencia]) values('" + textBox1.Text + "', '" + dateTimePicker2.Value + "'," +
                                                                                               "'" + textBox2.Text + "','" + comboBox1.Text + "', '" + textBox4.Text + "', '" + comboBox7.Text + "'," +
                                                                                               "'" + dateTimePicker1.Value + "','" + textBox6.Text + "','" + comboBox3.Text + "', " +
                                                                                               "'" + comboBox4.Text + "','" + comboBox5.Text + "', '" + comboBox6.Text + "','" + textBoxNotas.Text + "' , '" + textBoxAnaliseG.Text + "'" +
                                                                                               ", '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox5.Text + "', '" + textBox10.Text + "', '" + textBox12.Text + "'," +
                                                                                               "'" + textBox9.Text + "','" + textBox3.Text + "' ,'" + checkBox11.Checked + "','" + checkBox16.Checked + "','" + checkBox12.Checked + "', " +
                                                                                               "'" + checkBox14.Checked + "','" + checkBox13.Checked + "','" + checkBox15.Checked + "','" + checkBox1.Checked + "','" + checkBox2.Checked + "'," +
                                                                                               "'" + checkBox3.Checked + "','" + checkBox10.Checked + "','" + checkBox4.Checked + "','" + checkBox5.Checked + "','" + checkBox6.Checked + "'," +
                                                                                               "'" + checkBox7.Checked + "','" + checkBox8.Checked + "','" + checkBox9.Checked + "','" + comboBox2.Text + "','" + comboBox8.SelectedValue + "')", con);
                con.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();


                con.Close();

                MessageBox.Show("Inserido com Sucesso");

                //if (((comboBox3.Text == "Não (Com hist. pagto) / Com Contato") || (comboBox3.Text == "Não (Com hist. pagto) / Sem contato") || (comboBox3.Text == "Não (Sem hist. pagto)") || (comboBox3.Text == "Não (Fraude Subscrição)")) & int.Parse(textBox12.Text) > 0 )

                if (((comboBox3.Text == "Não (Com hist. pagto) / Com Contato") || (comboBox3.Text == "Não (Com hist. pagto) / Sem contato") ||
                           (comboBox3.Text == "Não (Sem hist. pagto)") || (comboBox3.Text == "Não (Fraude Subscrição)") || (comboBox3.Text == "NÃO")
                           || (comboBox3.Text == "AssinaturaDivergente") || (comboBox3.Text == "Doc.Nãovalidada") || (comboBox3.Text == "FraudenabaseTIM"))
                           & int.Parse(textBox12.Text) > 0 & comboBox8.Text == "Em Tratamento")

                {
                    string levalogin = textBox6.Text;
                    string levaCNPJ = textBox1.Text;


                    this.tabControl1.TabPages.Add(tabPage2);
                    this.tabControl1.TabPages.Remove(tabPage1);
                    MessageBox.Show("Favor Cadastrar os aparelhos antes de concluir");

                    textBox18.Text = levaCNPJ;
                    textBox16.Text = levalogin;


                }

                string vCNPJ = textBox1.Text;
                textBox1.Text = "";
                string vlogin = textBox6.Text;
                string vpedido = textBox2.Text;
                string vAtividade = comboBox7.Text;
                ClearForm(this);

                dateTimePicker3.Value = DateTime.Now;
                textBox18.Text = vCNPJ;
                textBox17.Text = vpedido;
                textBox19.Text = vAtividade;
                textBox16.Text = vlogin;
                textBox6.Text = vlogin;
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;

                textBox20.Enabled = true;
                textBox26.Enabled = true;
                textBox22.Enabled = true;
                textBox21.Enabled = true;
                textBox23.Enabled = true;
                textBox25.Enabled = true;
                textBox24.Enabled = true;
                button10.Enabled = true;

            }

        }

        private void toolTipSalvar_Popup(object sender, PopupEventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox17.Checked == true)
            {
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBox8.Text == "Sem Pendência")
            {
                MessageBox.Show("Não é possivel editar um pedido finalizado", "AVISO");
                //textBoxAnaliseG.Enabled = true;
                textBoxAnaliseG.Enabled = true;
                textBoxNotas.Enabled = true;
            }
            else
            {
                EnableForm(this);
                textBox6.Enabled = false;
                textBox2.Enabled = false;
                textBox1.Enabled = false;
                textBox4.Enabled = false;
                comboBox7.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = true;
                button6.Enabled = false;
                dataGridView1.Hide();
                button7.Enabled = true;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Todas as alterações no pedido serão perdidas", "AVISO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string vlogin = textBox6.Text;
                ClearForm(this);
                DisableForm(this);
                textBox1.Enabled = true;
                button1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                checkBox17.Enabled = true;
                checkBox18.Enabled = true;
                textBox6.Text = vlogin;
                button10.Enabled = true;

            }
           else
            {
                
            }

            this.textBox6.Text = vlogingeral;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (comboBox8.Text == "Sem Pendência")
            {


                if (comboBox6.Text == "" || comboBox8.Text == "" || comboBox5.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == ""  || textBox12.Text == ""  || comboBox8.Text == "" || textBoxNotas.Text == "" || textBoxAnaliseG.Text == ""
                    )
                {
                    MessageBox.Show("Existem campos vazios. Favor preeencher antes de salvar.");
                }

                else if (MessageBox.Show("Pedidos SEM PENDÊNCIA não poderão ser mais alterados. Confirma?", "AVISO", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    {
                        dateTimePicker2.Value = DateTime.Now;

                       


                        cmd = new SqlCommand("UPDATE [TIM].[dbo].[AuditoriaPedidoStage]" +
                          "SET [CPF_CNPJ] = '" + textBox1.Text + "' " +
                          ",[Pedido] = '" + textBox2.Text + "' " +
                          ",[DataEnvio] = '" + dateTimePicker2.Value + "' " +
                          ",[UF] = '" + comboBox1.Text + "' " +
                          ",[particao] = '" + textBox4.Text + "' " +
                          ",[Atividade] = '" + comboBox7.Text + "' " +
                          ",[DataInclusão] = '" + dateTimePicker1.Value + "' " +
                          ",[LoginAnalise] = '" + textBox6.Text + "' " +
                          ",[Aprovado] = '" + comboBox3.Text + "' " +
                          ",[TipoNegociacao] = '" + comboBox4.Text + "' " +
                          ",[Origem] = '" + comboBox5.Text + "' " +
                          ",[Canal] = '" + comboBox6.Text + "' " +
                          ",[NotasDDR] = '" + textBoxNotas.Text + "' " +
                          ",[DescAnalise] = '" + textBoxAnaliseG.Text + "' " +
                          ",[Empresa] = '" + textBox7.Text + "' " +
                          ",[Ramo] = '" + textBox8.Text + "' " +
                          ",[NomeTBP] = '" + textBox5.Text + "' " +
                          ",[QuantAcessos] = '" + textBox10.Text + "' " +
                          ",[QuantAparelhos] = '" + textBox12.Text + "' " +
                          ",[Vendedor] = '" + textBox9.Text + "' " +
                          ",[CodigoTBP] = '" + textBox3.Text + "' " +
                          ",[FraudeTBP] = '" + checkBox11.Checked + "' " +
                          ",[Reanalise] = '" + checkBox16.Checked + "' " +
                          ",[C3S] = '" + checkBox12.Checked + "' " +
                          ",[ByPass] = '" + checkBox14.Checked + "' " +
                          ",[Portabilidade] = '" + checkBox13.Checked + "' " +
                          ",[Dossie] = '" + checkBox15.Checked + "' " +
                          ",[SocioAdmNaoValido] = '" + checkBox1.Checked + "' " +
                          ",[TelefoneNaoExiste] = '" + checkBox2.Checked + "' " +
                          ",[ClientePendencias] = '" + checkBox3.Checked + "' " +
                          ",[RecenteAlteContratual] = '" + checkBox10.Checked + "' " +
                          ",[AsceConsultas] = '" + checkBox4.Checked + "' " +
                          ",[EmpresaRecente] = '" + checkBox5.Checked + "' " +
                          ",[AcessosNaoCondiz] = '" + checkBox6.Checked + "' " +
                          ",[TentativaVariosProdutos] = '" + checkBox7.Checked + "' " +
                          ",[InatividadeComer] = '" + checkBox8.Checked + "' " +
                          ",[DocumentoFalso] = '" + checkBox9.Checked + "' " +
                          ",[MotivoNegativa] = '" + comboBox2.Text + "' " +
                          ",[idPendencia] = '" + comboBox8.SelectedValue + "' where [CPF_CNPJ] = '" + textBox1.Text + "' and [ID] = '" + textBoxID.Text + "' and [Pedido] =  '" + textBox2.Text + "' ", con);
                        con.Open();
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();

                       





                        con.Close();

                        MessageBox.Show("Atualizado com Sucesso");
                      


                        if (((comboBox3.Text == "Não (Com hist. pagto) / Com Contato") || (comboBox3.Text == "Não (Com hist. pagto) / Sem contato") || 
                            (comboBox3.Text == "Não (Sem hist. pagto)") || (comboBox3.Text == "Não (Fraude Subscrição)")|| (comboBox3.Text == "NÃO") 
                            || (comboBox3.Text == "AssinaturaDivergente") || (comboBox3.Text == "Doc.Nãovalidada") || (comboBox3.Text == "FraudenabaseTIM"))
                            & int.Parse(textBox12.Text) > 0 & comboBox8.Text == "Em Tratamento")
                        {
                            
                            string levalogin = textBox6.Text;
                            string levaCNPJ = textBox1.Text;
                            string levaPedido  = textBox2.Text;
                            string levaAtividade = comboBox7.Text;


                            this.tabControl1.TabPages.Add(tabPage2);
                            this.tabControl1.TabPages.Remove(tabPage1);

                            //MessageBox.Show("Favor Cadastrar os aparelhos antes de concluir");

                            textBox18.Text = levaCNPJ;
                            textBox16.Text = levalogin;
                            textBox17.Text = levaPedido;
                            textBox19.Text = levaAtividade;

                            textBox20.Enabled = true;
                            textBox26.Enabled = true;
                            textBox25.Enabled = true;
                            textBox22.Enabled = true;
                            textBox21.Enabled = true;
                            textBox23.Enabled = true;
                            textBox24.Enabled = true;

                        }


                        textBox1.Text = "";
                        string vlogin1 = textBox6.Text;

                        ClearForm(this);
                        textBox6.Text = vlogin1;
                        dateTimePicker1.Value = DateTime.Now;
                        dateTimePicker2.Value = DateTime.Now;
                        button1.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = false;
                        button5.Enabled = false;
                        button6.Enabled = false;
                        button7.Enabled = false;
                        button10.Enabled = true;




                    }
                }


            }
            else
            {
                //try
                {

                    dateTimePicker2.Value = DateTime.Now;

                    //string analise = textBoxAnaliseG.Text.Replace("\r\n", "<br>");


                    cmd = new SqlCommand("UPDATE [TIM].[dbo].[AuditoriaPedidoStage]" +
                      "SET [CPF_CNPJ] = '" + textBox1.Text + "' "+
                      ",[Pedido] = '" + textBox2.Text + "' "+
                      ",[DataEnvio] = '" + dateTimePicker2.Value + "' "+
                      ",[UF] = '" + comboBox1.Text + "' "+
                      ",[particao] = '" + textBox4.Text + "' "+
                      ",[Atividade] = '" + comboBox7.Text + "' "+
                      ",[DataInclusão] = '" + dateTimePicker1.Value + "' "+
                      ",[LoginAnalise] = '" + textBox6.Text + "' "+
                      ",[Aprovado] = '" + comboBox3.Text + "' "+
                      ",[TipoNegociacao] = '" + comboBox4.Text + "' "+
                      ",[Origem] = '" + comboBox5.Text + "' "+
                      ",[Canal] = '" + comboBox6.Text + "' "+
                      ",[NotasDDR] = '" + textBoxNotas.Text + "' "+
                      ",[DescAnalise] = '" + textBoxAnaliseG.Text + "' "+
                      ",[Empresa] = '" + textBox7.Text + "' "+
                      ",[Ramo] = '" + textBox8.Text + "' "+
                      ",[NomeTBP] = '" + textBox5.Text + "' "+
                      ",[QuantAcessos] = '" + textBox10.Text + "' "+
                      ",[QuantAparelhos] = '" + textBox12.Text + "' "+
                      ",[Vendedor] = '" + textBox9.Text + "' "+
                      ",[CodigoTBP] = '" + textBox3.Text + "' "+
                      ",[FraudeTBP] = '" + checkBox11.Checked + "' "+
                      ",[Reanalise] = '" + checkBox16.Checked + "' "+
                      ",[C3S] = '" + checkBox12.Checked + "' "+
                      ",[ByPass] = '" + checkBox14.Checked + "' "+
                      ",[Portabilidade] = '" + checkBox13.Checked + "' "+
                      ",[Dossie] = '" + checkBox15.Checked + "' "+
                      ",[SocioAdmNaoValido] = '" + checkBox1.Checked + "' "+
                      ",[TelefoneNaoExiste] = '" + checkBox2.Checked + "' "+
                      ",[ClientePendencias] = '" + checkBox3.Checked + "' "+
                      ",[RecenteAlteContratual] = '" + checkBox10.Checked + "' "+
                      ",[AsceConsultas] = '" + checkBox4.Checked + "' "+
                      ",[EmpresaRecente] = '" + checkBox5.Checked + "' "+
                      ",[AcessosNaoCondiz] = '" + checkBox6.Checked + "' "+
                      ",[TentativaVariosProdutos] = '" + checkBox7.Checked + "' "+
                      ",[InatividadeComer] = '" + checkBox8.Checked + "' "+
                      ",[DocumentoFalso] = '" + checkBox9.Checked + "' "+
                      ",[MotivoNegativa] = '" + comboBox2.Text + "' "+
                      ",[idPendencia] = '" + comboBox8.SelectedValue + "' where [CPF_CNPJ] = '" + textBox1.Text + "'  and [ID] = '" + textBoxID.Text + "' and [Pedido] =  '" + textBox2.Text + "' ", con);
                    con.Open();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();


                    con.Close();

                    MessageBox.Show("Atualizado com Sucesso");


                    if (((comboBox3.Text == "Não (Com hist. pagto) / Com Contato") || (comboBox3.Text == "Não (Com hist. pagto) / Sem contato") ||
                           (comboBox3.Text == "Não (Sem hist. pagto)") || (comboBox3.Text == "Não (Fraude Subscrição)") || (comboBox3.Text == "NÃO")
                           || (comboBox3.Text == "AssinaturaDivergente") || (comboBox3.Text == "Doc.Nãovalidada") || (comboBox3.Text == "FraudenabaseTIM"))
                           & int.Parse(textBox12.Text) > 0 & comboBox8.Text == "Em Tratamento" )
                    {


                        string levalogin = textBox6.Text;
                        string levaCNPJ = textBox1.Text;
                        string levaPedido = textBox2.Text;
                        string levaAtividade = comboBox7.Text;

                        this.tabControl1.TabPages.Add(tabPage2);
                        this.tabControl1.TabPages.Remove(tabPage1);

                        textBox18.Text = levaCNPJ;
                        textBox16.Text = levalogin;
                        textBox17.Text = levaPedido;
                        textBox19.Text = levaAtividade;

                        MessageBox.Show("Favor Cadastrar os aparelhos antes de concluir");

                        textBox20.Enabled = true;
                        textBox26.Enabled = true;
                        textBox25.Enabled = true;
                        textBox22.Enabled = true;
                        textBox21.Enabled = true;
                        textBox23.Enabled = true;
                        textBox24.Enabled = true;




                    }


                    


                   



                }

                 //  catch (Exception ex)
                //{
                //    throw new Exception(ex.Message);
                //}

            }

            /*
            textBox1.Text = "";
            string vlogin = textBox6.Text;
            ClearForm(this);
            textBox6.Text = vlogin;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button10.Enabled = true;
            */

            //  REMOVER 
            this.textBox6.Text = vlogingeral;

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

          //  textBox22.Text = textBox22.Text.Replace("R$", "").Trim();
          //  textBox22.Text = textBox22.Text.Replace(",", ".").Trim();
            textBox22.Enabled = false;
            string vUnitario = textBox22.Text;
            vUnitario = vUnitario.Replace("R$", "").Trim();
            vUnitario = vUnitario.Replace(",", ".").Trim();


            decimal pValor = 0;
            decimal.TryParse(vUnitario.Trim(), out pValor);

            decimal pQtde = 0;
            decimal.TryParse(textBox26.Text.Trim(), out pQtde);

            AplicarEventos(textBox25);
            textBox25.Text = ((pValor * pQtde)/100).ToString("N2");
            textBox25.Text = string.Format("R$ {0}", textBox25.Text);
                        
            textBox25.Enabled = false;
            textBox22.Enabled = false;


        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox20.Text = "";
            textBox26.Text = "";
            textBox22.Text = "";
            textBox25.Text = "";
            textBox24.Text = "";
            textBox21.Text = "";
            textBox23.Text = "";
            textBox22.Enabled = true;



        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                textBox25.Text = textBox25.Text.Replace("R$ ", "").Trim();


                cmd = new SqlCommand(" INSERT INTO[TIM].[dbo].[tbAparelho]              ([CPF_CNPJ], " +
                                                                                        "[DataInclusao]," +
                                                                                        "[Pedido]," +
                                                                                        "[Atividade]," +
                                                                                        "[LoginAnalise]," +
                                                                                        "[descModelo]," +
                                                                                        "[nQuantidade]," +
                                                                                        "[nValorUn]," +
                                                                                        "[nValorNegoc]," +
                                                                                        "[res1]," +
                                                                                        "[res2]," +
                                                                                        "[res3]" +
                                                                                        ") values('" + textBox18.Text + "', '" + dateTimePicker3.Value + "'," +
                                                                                        "'" + textBox17.Text + "','" + textBox19.Text + "', '" + textBox16.Text + "', '" + textBox20.Text + "'," +
                                                                                        "'" + textBox26.Text + "','" + textBox22.Text + "','" + textBox25.Text + "', " +
                                                                                        "'" + textBox24.Text + "','" + textBox21.Text + "', '" + textBox23.Text + "')", con);
                con.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();


                con.Close();

                if (MessageBox.Show("Cadastrar novo modelo ?", "AVISO", MessageBoxButtons.YesNo) == DialogResult.Yes)

                {
                    textBox20.Text = "";
                    textBox26.Text = "";
                    textBox22.Text = "";
                    textBox25.Text = "";
                    textBox22.Enabled = true;
                }

                else
                {
                    if (MessageBox.Show("Tem certeza que não pretende mais cadastrar aparelhos para o pedido atual ?", "AVISO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.tabControl1.TabPages.Add(tabPage1);

                        this.tabControl1.TabPages.Remove(tabPage2);

                        DisableForm(this);
                        comboBox7.SelectedIndex = -1;
                        comboBox6.SelectedIndex = -1;
                        comboBox3.SelectedIndex = -1;
                        comboBox4.SelectedIndex = -1;
                        comboBox7.SelectedIndex = -1;
                        comboBox1.SelectedIndex = -1;
                        comboBox5.SelectedIndex = -1;
                        checkBox1.Hide();
                        checkBox2.Hide();
                        checkBox3.Hide();
                        checkBox4.Hide();
                        checkBox5.Hide();
                        checkBox6.Hide();
                        checkBox7.Hide();
                        checkBox8.Hide();
                        checkBox9.Hide();
                        comboBox3.Enabled = false;
                        comboBox4.Enabled = false;
                        comboBox5.Enabled = false;
                        comboBox6.Enabled = false;
                        dataGridView1.Show();
                        groupBox1.Hide();
                        label23.Hide();
                        comboBox2.Hide();
                        button1.Enabled = true;



                        textBox1.Enabled = true;
                        checkBox17.Enabled = true;
                        checkBox18.Enabled = true;
                        button4.Enabled = false;
                        button5.Enabled = false;
                        button6.Enabled = false;
                        button7.Enabled = false;


                    }
                }

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        private void textBox26_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void labelCPF_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            dateTimePicker2.Value = DateTime.Now;
            button10.Enabled = false;
            con.Open();
            cmd = new SqlCommand(" procBuscaCNPJ '" + textBox6.Text + "', '" + dateTimePicker2.Value + "' ", con);
            SqlDataReader dr2;
            dr2 = cmd.ExecuteReader();




            while (dr2.Read())
            {
                string valida = dr2["CPF_CNPJ"].ToString();

                switch (valida)
                {


                    case "":

                        MessageBox.Show("Não foram encontrados novos Pedidos");

                       
                        break;

                    default:


                        textBox1.Text = valida;
                        break;
                }



            }
            con.Close();
        }

        private void textBoxAnaliseG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}