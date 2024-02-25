
namespace WindowsFormsApp1
{
    partial class Form15
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.фИОклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цельвизитаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыдачипропускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времявыходаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыНаТерриторииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пропускаDataSet = new WindowsFormsApp1.ПропускаDataSet();
            this.клиенты_на_территорииTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.Клиенты_на_территорииTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыНаТерриторииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(932, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОклиентаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.цельвизитаDataGridViewTextBoxColumn,
            this.датавыдачипропускаDataGridViewTextBoxColumn,
            this.времявыходаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентыНаТерриторииBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1103, 207);
            this.dataGridView1.TabIndex = 3;
            // 
            // фИОклиентаDataGridViewTextBoxColumn
            // 
            this.фИОклиентаDataGridViewTextBoxColumn.DataPropertyName = "ФИО_клиента";
            this.фИОклиентаDataGridViewTextBoxColumn.HeaderText = "ФИО_клиента";
            this.фИОклиентаDataGridViewTextBoxColumn.Name = "фИОклиентаDataGridViewTextBoxColumn";
            this.фИОклиентаDataGridViewTextBoxColumn.Width = 200;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.Width = 180;
            // 
            // цельвизитаDataGridViewTextBoxColumn
            // 
            this.цельвизитаDataGridViewTextBoxColumn.DataPropertyName = "Цель_визита";
            this.цельвизитаDataGridViewTextBoxColumn.HeaderText = "Цель_визита";
            this.цельвизитаDataGridViewTextBoxColumn.Name = "цельвизитаDataGridViewTextBoxColumn";
            this.цельвизитаDataGridViewTextBoxColumn.Width = 200;
            // 
            // датавыдачипропускаDataGridViewTextBoxColumn
            // 
            this.датавыдачипропускаDataGridViewTextBoxColumn.DataPropertyName = "Дата_выдачи_пропуска";
            this.датавыдачипропускаDataGridViewTextBoxColumn.HeaderText = "Дата_выдачи_пропуска";
            this.датавыдачипропускаDataGridViewTextBoxColumn.Name = "датавыдачипропускаDataGridViewTextBoxColumn";
            this.датавыдачипропускаDataGridViewTextBoxColumn.Width = 230;
            // 
            // времявыходаDataGridViewTextBoxColumn
            // 
            this.времявыходаDataGridViewTextBoxColumn.DataPropertyName = "Время_выхода";
            this.времявыходаDataGridViewTextBoxColumn.HeaderText = "Время_выхода";
            this.времявыходаDataGridViewTextBoxColumn.Name = "времявыходаDataGridViewTextBoxColumn";
            this.времявыходаDataGridViewTextBoxColumn.Width = 230;
            // 
            // клиентыНаТерриторииBindingSource
            // 
            this.клиентыНаТерриторииBindingSource.DataMember = "Клиенты на территории";
            this.клиентыНаТерриторииBindingSource.DataSource = this.пропускаDataSet;
            // 
            // пропускаDataSet
            // 
            this.пропускаDataSet.DataSetName = "ПропускаDataSet";
            this.пропускаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиенты_на_территорииTableAdapter
            // 
            this.клиенты_на_территорииTableAdapter.ClearBeforeFill = true;
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 316);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form15";
            this.Text = "Кто в данный момент находится на территорию из Клиентов";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыНаТерриторииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ПропускаDataSet пропускаDataSet;
        private System.Windows.Forms.BindingSource клиентыНаТерриторииBindingSource;
        private ПропускаDataSetTableAdapters.Клиенты_на_территорииTableAdapter клиенты_на_территорииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цельвизитаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыдачипропускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времявыходаDataGridViewTextBoxColumn;
    }
}