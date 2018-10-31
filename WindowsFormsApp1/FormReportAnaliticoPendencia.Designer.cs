namespace TIM
{
    partial class FormReportAnaliticoPendencia
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
            this.vwReportAnaliticoPendenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TIMDataSet1 = new TIM.TIMDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vwReportAnaliticoPendenciaTableAdapter = new TIM.TIMDataSet1TableAdapters.vwReportAnaliticoPendenciaTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tbUsuarioTableAdapter = new TIM.TIMDataSet1TableAdapters.tbUsuarioTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.vwReportAnaliticoPendenciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vwReportAnaliticoPendenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwReportAnaliticoPendenciaBindingSource1)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // vwReportAnaliticoPendenciaBindingSource
            // 
            this.vwReportAnaliticoPendenciaBindingSource.DataMember = "vwReportAnaliticoPendencia";
            this.vwReportAnaliticoPendenciaBindingSource.DataSource = this.TIMDataSet1;
            // 
            // TIMDataSet1
            // 
            this.TIMDataSet1.DataSetName = "TIMDataSet1";
            this.TIMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetAnaliticoPedido";
            reportDataSource1.Value = this.vwReportAnaliticoPendenciaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TIM.ReportAnaliticoPendencia .rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1362, 625);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // vwReportAnaliticoPendenciaTableAdapter
            // 
            this.vwReportAnaliticoPendenciaTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tbUsuarioBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(280, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "login";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.TIMDataSet1;
            // 
            // button1
            // 
            this.button1.Image = global::TIM.Properties.Resources.refresh_arrow_1546__1_;
            this.button1.Location = new System.Drawing.Point(1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 39);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.vwReportAnaliticoPendenciaBindingSource1;
            this.comboBox2.DisplayMember = "ID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(179, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "ID";
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // vwReportAnaliticoPendenciaBindingSource1
            // 
            this.vwReportAnaliticoPendenciaBindingSource1.DataMember = "vwReportAnaliticoPendencia";
            this.vwReportAnaliticoPendenciaBindingSource1.DataSource = this.TIMDataSet1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(110, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 9);
            this.label9.TabIndex = 21;
            this.label9.Text = "Atualizar Pedidos";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Image = global::TIM.Properties.Resources.Atualizar1;
            this.button3.Location = new System.Drawing.Point(116, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 39);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 9);
            this.label3.TabIndex = 19;
            this.label3.Text = "Editar Pedidos";
            // 
            // button4
            // 
            this.button4.Image = global::TIM.Properties.Resources.EditarRegistro;
            this.button4.Location = new System.Drawing.Point(57, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 39);
            this.button4.TabIndex = 18;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1364, 25);
            this.fillBy1ToolStrip.TabIndex = 22;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(182, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Código do pedido";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(284, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome BKO";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 9);
            this.label4.TabIndex = 25;
            this.label4.Text = "Atualizar";
            // 
            // FormReportAnaliticoPendencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 682);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportAnaliticoPendencia";
            this.Text = "Relatório Analítico de Pendencias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReportAnaliticoPendencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwReportAnaliticoPendenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwReportAnaliticoPendenciaBindingSource1)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vwReportAnaliticoPendenciaBindingSource;
        private TIMDataSet1 TIMDataSet1;
        private TIMDataSet1TableAdapters.vwReportAnaliticoPendenciaTableAdapter vwReportAnaliticoPendenciaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private TIMDataSet1TableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource vwReportAnaliticoPendenciaBindingSource1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}