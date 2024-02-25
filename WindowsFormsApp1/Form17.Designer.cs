
namespace WindowsFormsApp1
{
    partial class Form17
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.ПропускаDataSet = new WindowsFormsApp1.ПропускаDataSet();
            this.Посещаимость_отделовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Посещаимость_отделовTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.Посещаимость_отделовTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ПропускаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Посещаимость_отделовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Посещаимость_отделовBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(957, 488);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 514);
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
            // Посещаимость_отделовBindingSource
            // 
            this.Посещаимость_отделовBindingSource.DataMember = "Посещаимость отделов";
            this.Посещаимость_отделовBindingSource.DataSource = this.ПропускаDataSet;
            // 
            // Посещаимость_отделовTableAdapter
            // 
            this.Посещаимость_отделовTableAdapter.ClearBeforeFill = true;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form17";
            this.Text = "Отчёт Клиенты";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ПропускаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Посещаимость_отделовBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Посещаимость_отделовBindingSource;
        private ПропускаDataSet ПропускаDataSet;
        private System.Windows.Forms.Button button1;
        private ПропускаDataSetTableAdapters.Посещаимость_отделовTableAdapter Посещаимость_отделовTableAdapter;
    }
}