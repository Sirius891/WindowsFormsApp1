
namespace WindowsFormsApp1
{
    partial class Form14
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.фИОводителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеорганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыдачипропускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цельвизитаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиескладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяотбытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.водителиНаТерриторииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пропускаDataSet = new WindowsFormsApp1.ПропускаDataSet();
            this.водители_на_территорииTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.Водители_на_территорииTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водителиНаТерриторииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОводителяDataGridViewTextBoxColumn,
            this.наименованиеорганизацииDataGridViewTextBoxColumn,
            this.датавыдачипропускаDataGridViewTextBoxColumn,
            this.цельвизитаDataGridViewTextBoxColumn,
            this.наименованиескладаDataGridViewTextBoxColumn,
            this.времяотбытияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.водителиНаТерриторииBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1056, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // фИОводителяDataGridViewTextBoxColumn
            // 
            this.фИОводителяDataGridViewTextBoxColumn.DataPropertyName = "ФИО_водителя";
            this.фИОводителяDataGridViewTextBoxColumn.HeaderText = "ФИО_водителя";
            this.фИОводителяDataGridViewTextBoxColumn.Name = "фИОводителяDataGridViewTextBoxColumn";
            this.фИОводителяDataGridViewTextBoxColumn.Width = 200;
            // 
            // наименованиеорганизацииDataGridViewTextBoxColumn
            // 
            this.наименованиеорганизацииDataGridViewTextBoxColumn.DataPropertyName = "Наименование_организации";
            this.наименованиеорганизацииDataGridViewTextBoxColumn.HeaderText = "Наименование_организации";
            this.наименованиеорганизацииDataGridViewTextBoxColumn.Name = "наименованиеорганизацииDataGridViewTextBoxColumn";
            this.наименованиеорганизацииDataGridViewTextBoxColumn.Width = 230;
            // 
            // датавыдачипропускаDataGridViewTextBoxColumn
            // 
            this.датавыдачипропускаDataGridViewTextBoxColumn.DataPropertyName = "Дата_выдачи_пропуска";
            this.датавыдачипропускаDataGridViewTextBoxColumn.HeaderText = "Дата_выдачи_пропуска";
            this.датавыдачипропускаDataGridViewTextBoxColumn.Name = "датавыдачипропускаDataGridViewTextBoxColumn";
            this.датавыдачипропускаDataGridViewTextBoxColumn.Width = 210;
            // 
            // цельвизитаDataGridViewTextBoxColumn
            // 
            this.цельвизитаDataGridViewTextBoxColumn.DataPropertyName = "Цель_визита";
            this.цельвизитаDataGridViewTextBoxColumn.HeaderText = "Цель_визита";
            this.цельвизитаDataGridViewTextBoxColumn.Name = "цельвизитаDataGridViewTextBoxColumn";
            this.цельвизитаDataGridViewTextBoxColumn.Width = 180;
            // 
            // наименованиескладаDataGridViewTextBoxColumn
            // 
            this.наименованиескладаDataGridViewTextBoxColumn.DataPropertyName = "Наименование_склада";
            this.наименованиескладаDataGridViewTextBoxColumn.HeaderText = "Наименование_склада";
            this.наименованиескладаDataGridViewTextBoxColumn.Name = "наименованиескладаDataGridViewTextBoxColumn";
            this.наименованиескладаDataGridViewTextBoxColumn.Width = 190;
            // 
            // времяотбытияDataGridViewTextBoxColumn
            // 
            this.времяотбытияDataGridViewTextBoxColumn.DataPropertyName = "Время_отбытия";
            this.времяотбытияDataGridViewTextBoxColumn.HeaderText = "Время_отбытия";
            this.времяотбытияDataGridViewTextBoxColumn.Name = "времяотбытияDataGridViewTextBoxColumn";
            this.времяотбытияDataGridViewTextBoxColumn.Width = 180;
            // 
            // водителиНаТерриторииBindingSource
            // 
            this.водителиНаТерриторииBindingSource.DataMember = "Водители на территории";
            this.водителиНаТерриторииBindingSource.DataSource = this.пропускаDataSet;
            // 
            // пропускаDataSet
            // 
            this.пропускаDataSet.DataSetName = "ПропускаDataSet";
            this.пропускаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // водители_на_территорииTableAdapter
            // 
            this.водители_на_территорииTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(899, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form14";
            this.Text = "Кто в данный момент находится на территории из Водителей";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водителиНаТерриторииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ПропускаDataSet пропускаDataSet;
        private System.Windows.Forms.BindingSource водителиНаТерриторииBindingSource;
        private ПропускаDataSetTableAdapters.Водители_на_территорииTableAdapter водители_на_территорииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОводителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеорганизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыдачипропускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цельвизитаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиескладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяотбытияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}