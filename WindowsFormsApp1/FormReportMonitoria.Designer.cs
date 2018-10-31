namespace TIM
{
    partial class FormReportMonitoria
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.procMonitoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TIMDataSet1 = new TIM.TIMDataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDataIni = new System.Windows.Forms.DateTimePicker();
            this.dateDataFim = new System.Windows.Forms.DateTimePicker();
            this.comboBKO = new System.Windows.Forms.ComboBox();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioTableAdapter = new TIM.TIMDataSet1TableAdapters.tbUsuarioTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboAprovado = new System.Windows.Forms.ComboBox();
            this.tbAprovadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbAprovadoTableAdapter = new TIM.TIMDataSet1TableAdapters.tbAprovadoTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.procMonitoriaTableAdapter = new TIM.TIMDataSet1TableAdapters.procMonitoriaTableAdapter();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tbPendenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPendenciaTableAdapter = new TIM.TIMDataSet1TableAdapters.tbPendenciaTableAdapter();
            this.procPedidoConfirmaUpdateTableAdapter1 = new TIM.TIMDataSet1TableAdapters.procPedidoConfirmaUpdateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.procMonitoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAprovadoBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillByToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPendenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // procMonitoriaBindingSource
            // 
            this.procMonitoriaBindingSource.DataMember = "procMonitoria";
            this.procMonitoriaBindingSource.DataSource = this.TIMDataSet1;
            // 
            // TIMDataSet1
            // 
            this.TIMDataSet1.DataSetName = "TIMDataSet1";
            this.TIMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Image = global::TIM.Properties.Resources.SalvarRegistro;
            this.button2.Location = new System.Drawing.Point(440, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 39);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data Inicial:";
            // 
            // dateDataIni
            // 
            this.dateDataIni.Location = new System.Drawing.Point(-1, 19);
            this.dateDataIni.Name = "dateDataIni";
            this.dateDataIni.Size = new System.Drawing.Size(226, 20);
            this.dateDataIni.TabIndex = 8;
            // 
            // dateDataFim
            // 
            this.dateDataFim.Location = new System.Drawing.Point(0, 58);
            this.dateDataFim.Name = "dateDataFim";
            this.dateDataFim.Size = new System.Drawing.Size(225, 20);
            this.dateDataFim.TabIndex = 9;
            // 
            // comboBKO
            // 
            this.comboBKO.DataSource = this.tbUsuarioBindingSource;
            this.comboBKO.DisplayMember = "Nome";
            this.comboBKO.FormattingEnabled = true;
            this.comboBKO.Location = new System.Drawing.Point(230, 19);
            this.comboBKO.Name = "comboBKO";
            this.comboBKO.Size = new System.Drawing.Size(203, 21);
            this.comboBKO.TabIndex = 12;
            this.comboBKO.ValueMember = "login";
            this.comboBKO.SelectedIndexChanged += new System.EventHandler(this.comboBKO_SelectedIndexChanged);
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.TIMDataSet1;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Backoffice:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Aprovado:";
            // 
            // comboAprovado
            // 
            this.comboAprovado.DataSource = this.tbAprovadoBindingSource;
            this.comboAprovado.DisplayMember = "descAprovado";
            this.comboAprovado.FormattingEnabled = true;
            this.comboAprovado.Location = new System.Drawing.Point(230, 59);
            this.comboAprovado.Name = "comboAprovado";
            this.comboAprovado.Size = new System.Drawing.Size(203, 21);
            this.comboAprovado.TabIndex = 15;
            this.comboAprovado.ValueMember = "descAprovado";
            // 
            // tbAprovadoBindingSource
            // 
            this.tbAprovadoBindingSource.DataMember = "tbAprovado";
            this.tbAprovadoBindingSource.DataSource = this.TIMDataSet1;
            // 
            // tbAprovadoTableAdapter
            // 
            this.tbAprovadoTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1166, 25);
            this.fillByToolStrip.TabIndex = 17;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Visible = false;
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Pendentes",
            "Sem Pendência"});
            this.comboStatus.Location = new System.Drawing.Point(436, 19);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(121, 21);
            this.comboStatus.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status:";
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSetMonitoria";
            reportDataSource4.Value = this.procMonitoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TIM.ReportMonitoria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 103);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1360, 511);
            this.reportViewer1.TabIndex = 20;
            // 
            // procMonitoriaTableAdapter
            // 
            this.procMonitoriaTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(1364, 25);
            this.fillByToolStrip1.TabIndex = 21;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
            this.fillByToolStrip1.Visible = false;
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton1.Text = "FillBy";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::TIM.Properties.Resources.EditarRegistro;
            this.button1.Location = new System.Drawing.Point(498, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 39);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Pesquisar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Editar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Cod. Pedido";
            this.label8.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.procMonitoriaBindingSource;
            this.comboBox1.DisplayMember = "id";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(562, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(695, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Novo Status";
            this.label9.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tbPendenciaBindingSource;
            this.comboBox2.DisplayMember = "descPendencia";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(690, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.ValueMember = "ID";
            this.comboBox2.Visible = false;
            // 
            // tbPendenciaBindingSource
            // 
            this.tbPendenciaBindingSource.DataMember = "tbPendencia";
            this.tbPendenciaBindingSource.DataSource = this.TIMDataSet1;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Image = global::TIM.Properties.Resources.Atualizar1;
            this.button3.Location = new System.Drawing.Point(763, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 39);
            this.button3.TabIndex = 29;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(764, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Atualizar";
            this.label10.Visible = false;
            // 
            // tbPendenciaTableAdapter
            // 
            this.tbPendenciaTableAdapter.ClearBeforeFill = true;
            // 
            // procPedidoConfirmaUpdateTableAdapter1
            // 
            this.procPedidoConfirmaUpdateTableAdapter1.ClearBeforeFill = true;
            // 
            // FormReportMonitoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1364, 707);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboAprovado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBKO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateDataIni);
            this.Controls.Add(this.dateDataFim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fillByToolStrip1);
            this.Controls.Add(this.fillByToolStrip);
            this.Name = "FormReportMonitoria";
            this.Text = "Relatório de Monitoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReportMonitoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.procMonitoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAprovadoBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPendenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource procMonitoriaBindingSource;
        private TIMDataSet1 TIMDataSet1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDataIni;
        private System.Windows.Forms.DateTimePicker dateDataFim;
        private System.Windows.Forms.ComboBox comboBKO;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private TIMDataSet1TableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboAprovado;
        private System.Windows.Forms.BindingSource tbAprovadoBindingSource;
        private TIMDataSet1TableAdapters.tbAprovadoTableAdapter tbAprovadoTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TIMDataSet1TableAdapters.procMonitoriaTableAdapter procMonitoriaTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource tbPendenciaBindingSource;
        private TIMDataSet1TableAdapters.tbPendenciaTableAdapter tbPendenciaTableAdapter;
        private TIMDataSet1TableAdapters.procPedidoConfirmaUpdateTableAdapter procPedidoConfirmaUpdateTableAdapter1;
    }
}