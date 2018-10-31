namespace TIM
{
    partial class FormAdm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxLoginADM = new System.Windows.Forms.TextBox();
            this.buttonImport = new System.Windows.Forms.Button();
            this.dataGridViewImport = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.tbAtividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIMDataSet = new TIM.TIMDataSet();
            this.labelAtividade = new System.Windows.Forms.Label();
            this.tbAtividadeTableAdapter = new TIM.TIMDataSetTableAdapters.tbAtividadeTableAdapter();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAtividadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLoginADM
            // 
            this.textBoxLoginADM.Enabled = false;
            this.textBoxLoginADM.Location = new System.Drawing.Point(697, 12);
            this.textBoxLoginADM.Name = "textBoxLoginADM";
            this.textBoxLoginADM.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoginADM.TabIndex = 0;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(687, 358);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(94, 23);
            this.buttonImport.TabIndex = 1;
            this.buttonImport.Text = "Importar";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // dataGridViewImport
            // 
            this.dataGridViewImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImport.Location = new System.Drawing.Point(14, 202);
            this.dataGridViewImport.Name = "dataGridViewImport";
            this.dataGridViewImport.Size = new System.Drawing.Size(766, 150);
            this.dataGridViewImport.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(703, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.tbAtividadeBindingSource;
            this.comboBox7.DisplayMember = "descAtividade";
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(428, 358);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(154, 21);
            this.comboBox7.TabIndex = 114;
            this.comboBox7.ValueMember = "id";
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // tbAtividadeBindingSource
            // 
            this.tbAtividadeBindingSource.DataMember = "tbAtividade";
            this.tbAtividadeBindingSource.DataSource = this.tIMDataSet;
            // 
            // tIMDataSet
            // 
            this.tIMDataSet.DataSetName = "TIMDataSet";
            this.tIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelAtividade
            // 
            this.labelAtividade.AutoSize = true;
            this.labelAtividade.Location = new System.Drawing.Point(280, 362);
            this.labelAtividade.Name = "labelAtividade";
            this.labelAtividade.Size = new System.Drawing.Size(144, 13);
            this.labelAtividade.TabIndex = 113;
            this.labelAtividade.Text = "Selecione o Tipo de Arquivo:";
            // 
            // tbAtividadeTableAdapter
            // 
            this.tbAtividadeTableAdapter.ClearBeforeFill = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(591, 358);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(95, 23);
            this.buttonClear.TabIndex = 115;
            this.buttonClear.Text = "Limpar modelo";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(686, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 116;
            this.button1.Text = "Distribuir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.labelAtividade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewImport);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.textBoxLoginADM);
            this.Name = "FormAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAdm";
            this.Load += new System.EventHandler(this.FormAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAtividadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIMDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLoginADM;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.DataGridView dataGridViewImport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label labelAtividade;
        private TIMDataSet tIMDataSet;
        private System.Windows.Forms.BindingSource tbAtividadeBindingSource;
        private TIMDataSetTableAdapters.tbAtividadeTableAdapter tbAtividadeTableAdapter;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button1;
    }
}