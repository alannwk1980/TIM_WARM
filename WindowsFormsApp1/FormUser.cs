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
using System.Data.SqlTypes;
using AcessoBancoDados;
using Negocios;
using ObjetoTransferencia;

namespace TIM
{
    public partial class FormUser : Form
    {
        System.Data.SqlClient.SqlConnection con = new SqlConnection(TIM.Properties.Settings.Default.TIMConnectionString);
        SqlCommand cmd;



        public FormUser()
        {
            InitializeComponent();
        }

        public FormUser(string parametro) : this()

        {
            txtLogin.Text = parametro;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tIMDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.tIMDataSet.tbUsuario);
            toolStripLogin.Text = txtLogin.Text;
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

                if (ctrControl.Controls.Count > 0)
                {
                    //Call itself to get all other controls in other containers 
                    ClearForm(ctrControl);
                }


            }
        }



        private void button6_Click(object sender, EventArgs e)
        {

            if (textBoxDoc.Text == "" || textBoxNome.Text == "" || textBoxUser.Text == "" || textBoxPass.Text == "")

            {
                MessageBox.Show("Não podem haver campos vazios. Verifique!");

            }

            else
            {




                string vCNPJ = textBoxDoc.Text;
                string vlogin = textBoxUser.Text;
                int vInt = 0;

                ValidaDocNegocios validadocnegocio = new ValidaDocNegocios();
                ValidaDocColecao validadoccolecao = new ValidaDocColecao();

                validadoccolecao = validadocnegocio.ValidarDoc(vCNPJ);




                if (validadoccolecao.Count > 0)

                {
                    MessageBox.Show("Documento já cadastrado anteriormente. Verifique! ");
                    vInt = 1;
                }


                if (vInt == 0)

                {
                    ValidaLoginNegocios validaloginnegocio = new ValidaLoginNegocios();
                    ValidaDocColecao validadoccolecao1 = new ValidaDocColecao();

                    validadoccolecao1 = validaloginnegocio.ValidarLogin(vlogin);


                    if (validadoccolecao1.Count > 0)

                    {
                        MessageBox.Show("Login já existe. Verifique! ");
                    }


                    else
                    {


                        cmd = new SqlCommand(" procNovoUser '" + textBoxDoc.Text + "', '" + textBoxNome.Text + "', '" + textBoxUser.Text + "', '" + textBoxPass.Text + "'", con);
                        con.Open();
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        con.Close();


                        MessageBox.Show("Novo operador cadastrado com sucesso");

                        
                        ClearForm(this);


                        {

                        }
                    }

                }


            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            groupBox1.BringToFront();
            groupBox1.Visible = true;
            textBoxNome.Visible = true;
            textBoxDoc.Visible = true;
            textBoxUser.Visible = true;
            textBoxPass.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            buttonDescarte.Visible = true;
            buttonUpdate.Visible = true;
            groupBox1.Text = "Novo Usuário";
            button2.Visible=true;
           
            button4.Enabled = false;
            button3.Enabled = false;




        }

        private void buttonDescarte_Click(object sender, EventArgs e)
        {
            ClearForm(this);
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tIMDataSet);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.BringToFront();
            NavegatbUsuario.Visible = true;
            groupBox2.Visible = true;
            iDTextBox.Visible = true;
            nomeTextBox.Visible = true;
            cPF_RGTextBox.Visible = true;
            loginTextBox.Visible = true;
            senhaTextBox.Visible = true;
            //buttonEdita.Visible = true;
            buttonAtualiza.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
             label9.Visible = true;
            button5.Visible = true;
          
            button4.Enabled = false;
            button3.Enabled = false;



        }

        private void buttonEdita_Click(object sender, EventArgs e)
        {
          //  ClearForm(this);
        }

        private void buttonAtualiza_Click(object sender, EventArgs e)
        {


            if (iDTextBox.Text == "" || nomeTextBox.Text == "" || cPF_RGTextBox.Text == "" || loginTextBox.Text == "" || senhaTextBox.Text == "")

            {
                MessageBox.Show("Não podem haver campos vazios. Verifique!");

            }

            else
            {


                string vDoc = cPF_RGTextBox.Text;
                string vlogin = loginTextBox.Text;
                string vNome = nomeTextBox.Text;
                string vId = iDTextBox.Text;
                string vPass = senhaTextBox.Text;
                string vStatus = "";

                if (statusCheckBox.Checked == true)
                {
                    vStatus = "1";
                }
                else
                {
                    vStatus = "0";
                }


                cmd = new SqlCommand(" procAtualizaUser '" + vDoc + "', '" + vNome + "', '" + vlogin + "', '" + vPass + "' , '" + vStatus + "' , '" + vId + "' ", con);
                con.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                con.Close();

                MessageBox.Show("Atualizado com sucesso");

               
                



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm(this);
            groupBox1.Visible = false;
            textBoxNome.Visible = false;
            textBoxDoc.Visible = false;
            textBoxUser.Visible = false;
            textBoxPass.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            buttonDescarte.Visible = false;
            buttonUpdate.Visible = false;
            groupBox1.Text = "Novo Usuário";
            button2.Visible = false;
          
            button4.Enabled = true;
            button3.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NavegatbUsuario.Visible = false;
            groupBox2.Visible = false;
            iDTextBox.Visible = false;
            nomeTextBox.Visible = false;
            cPF_RGTextBox.Visible = false;
            loginTextBox.Visible = false;
            senhaTextBox.Visible = false;
            //buttonEdita.Visible = true;
            buttonAtualiza.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            button5.Visible = false;
         
            button4.Enabled = true;
            button3.Enabled = true;

        }
    }
}
