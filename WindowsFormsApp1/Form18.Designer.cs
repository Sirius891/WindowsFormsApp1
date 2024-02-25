
namespace WindowsFormsApp1
{
    partial class Form18
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.ПропускаDataSet = new WindowsFormsApp1.ПропускаDataSet();
            this.Количество_доставок_товаровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Количество_доставок_товаровTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.Количество_доставок_товаровTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ПропускаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Количество_доставок_товаровBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Количество_доставок_товаровBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(45, 7);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(957, 488);
            this.reportViewer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вернутся назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ПропускаDataSet
            // 
            this.ПропускаDataSet.DataSetName = "ПропускаDataSet";
            this.ПропускаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Количество_доставок_товаровBindingSource
            // 
            this.Количество_доставок_товаровBindingSource.DataMember = "Количество доставок товаров";
            this.Количество_доставок_товаровBindingSource.DataSource = this.ПропускаDataSet;
            // 
            // Количество_доставок_товаровTableAdapter
            // 
            this.Количество_доставок_товаровTableAdapter.ClearBeforeFill = true;
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form18";
            this.Text = "Отчёт Водители";
            this.Load += new System.EventHandler(this.Form18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ПропускаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Количество_доставок_товаровBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource Количество_доставок_товаровBindingSource;
        private ПропускаDataSet ПропускаDataSet;
        private ПропускаDataSetTableAdapters.Количество_доставок_товаровTableAdapter Количество_доставок_товаровTableAdapter;
    }
}