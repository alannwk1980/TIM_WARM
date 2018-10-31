namespace TIM
{
    partial class FormReportProducao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateDataFim = new System.Windows.Forms.DateTimePicker();
            this.dateDataIni = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.procReportProducaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TIMDataSet1 = new TIM.TIMDataSet1();
            this.vwReportPedido1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwReportPedido1TableAdapter = new TIM.TIMDataSet1TableAdapters.vwReportPedido1TableAdapter();
            this.procReportProducaoTableAdapter1 = new TIM.TIMDataSet1TableAdapters.procReportProducaoTableAdapter();
            this.procReportProducaoTableAdapter = new TIM.TIMDataSet1TableAdapters.procReportProducaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.procReportProducaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwReportPedido1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet11111";
            reportDataSource1.Value = this.procReportProducaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TIM.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-10, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1362, 654);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // dateDataFim
            // 
            this.dateDataFim.Location = new System.Drawing.Point(244, 20);
            this.dateDataFim.Name = "dateDataFim";
            this.dateDataFim.Size = new System.Drawing.Size(236, 20);
            this.dateDataFim.TabIndex = 2;
            // 
            // dateDataIni
            // 
            this.dateDataIni.Location = new System.Drawing.Point(12, 20);
            this.dateDataIni.Name = "dateDataIni";
            this.dateDataIni.Size = new System.Drawing.Size(226, 20);
            this.dateDataIni.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Image = global::TIM.Properties.Resources.refresh_arrow_1546__1_;
            this.button2.Location = new System.Drawing.Point(698, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 39);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(703, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 9);
            this.label3.TabIndex = 8;
            this.label3.Text = "Atualizar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(592, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Meta diária";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Meta mensal";
            // 
            // procReportProducaoBindingSource
            // 
            this.procReportProducaoBindingSource.DataMember = "procReportProducao";
            this.procReportProducaoBindingSource.DataSource = this.TIMDataSet1;
            // 
            // TIMDataSet1
            // 
            this.TIMDataSet1.DataSetName = "TIMDataSet1";
            this.TIMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwReportPedido1BindingSource
            // 
            this.vwReportPedido1BindingSource.DataMember = "vwReportPedido1";
            this.vwReportPedido1BindingSource.DataSource = this.TIMDataSet1;
            // 
            // vwReportPedido1TableAdapter
            // 
            this.vwReportPedido1TableAdapter.ClearBeforeFill = true;
            // 
            // procReportProducaoTableAdapter1
            // 
            this.procReportProducaoTableAdapter1.ClearBeforeFill = true;
            // 
            // procReportProducaoTableAdapter
            // 
            this.procReportProducaoTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 682);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateDataIni);
            this.Controls.Add(this.dateDataFim);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportProducao";
            this.Text = "Relatório de Produtividade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReportProducao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.procReportProducaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwReportPedido1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource vwReportPedido1BindingSource;
        private TIMDataSet1 TIMDataSet1;
        private TIMDataSet1TableAdapters.vwReportPedido1TableAdapter vwReportPedido1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TIMDataSet1TableAdapters.procReportProducaoTableAdapter procReportProducaoTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateDataFim;
        private System.Windows.Forms.DateTimePicker dateDataIni;
        private System.Windows.Forms.BindingSource procReportProducaoBindingSource;
        private TIMDataSet1TableAdapters.procReportProducaoTableAdapter procReportProducaoTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}