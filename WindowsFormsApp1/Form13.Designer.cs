
namespace WindowsFormsApp1
{
    partial class Form13
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ПропускаDataSet = new WindowsFormsApp1.ПропускаDataSet();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.DataTable1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.фИОводителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаавтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.регестрационныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеорганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цельвизитаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиескладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыдачипропускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяотбытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.пропуски_клиентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пропуски_клиентовTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.Пропуски_клиентовTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ПропускаDataSetTableAdapters.TableAdapterManager();
            this.водителиTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.ВодителиTableAdapter();
            this.складыTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.СкладыTableAdapter();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.водителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пропускаDataSet1 = new WindowsFormsApp1.ПропускаDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.складыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ПропускаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропуски_клиентовBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.складыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ПропускаDataSet
            // 
            this.ПропускаDataSet.DataSetName = "ПропускаDataSet";
            this.ПропускаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.ПропускаDataSet;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(475, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОводителяDataGridViewTextBoxColumn,
            this.маркаавтомобиляDataGridViewTextBoxColumn,
            this.регестрационныйНомерDataGridViewTextBoxColumn,
            this.наименованиеорганизацииDataGridViewTextBoxColumn,
            this.цельвизитаDataGridViewTextBoxColumn,
            this.наименованиескладаDataGridViewTextBoxColumn,
            this.датавыдачипропускаDataGridViewTextBoxColumn,
            this.времяотбытияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.DataTable1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1378, 277);
            this.dataGridView1.TabIndex = 2;
            // 
            // фИОводителяDataGridViewTextBoxColumn
            // 
            this.фИОводителяDataGridViewTextBoxColumn.DataPropertyName = "ФИО_водителя";
            this.фИОводителяDataGridViewTextBoxColumn.HeaderText = "ФИО_водителя";
            this.фИОводителяDataGridViewTextBoxColumn.Name = "фИОводителяDataGridViewTextBoxColumn";
            this.фИОводителяDataGridViewTextBoxColumn.Width = 200;
            // 
            // маркаавтомобиляDataGridViewTextBoxColumn
            // 
            this.маркаавтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Марка_автомобиля";
            this.маркаавтомобиляDataGridViewTextBoxColumn.HeaderText = "Марка_автомобиля";
            this.маркаавтомобиляDataGridViewTextBoxColumn.Name = "маркаавтомобиляDataGridViewTextBoxColumn";
            this.маркаавтомобиляDataGridViewTextBoxColumn.Width = 170;
            // 
            // регестрационныйНомерDataGridViewTextBoxColumn
            // 
            this.регестрационныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Регестрационный номер";
            this.регестрационныйНомерDataGridViewTextBoxColumn.HeaderText = "Регестрационный номер";
            this.регестрационныйНомерDataGridViewTextBoxColumn.Name = "регестрационныйНомерDataGridViewTextBoxColumn";
            this.регестрационныйНомерDataGridViewTextBoxColumn.Width = 250;
            // 
            // наименованиеорганизацииDataGridViewTextBoxColumn
            // 
            this.наименованиеорганизацииDataGridViewTextBoxColumn.DataPropertyName = "Наименование_организации";
            this.наименованиеорганизацииDataGridViewTextBoxColumn.HeaderText = "Наименование_организации";
            this.наименованиеорганизацииDataGridViewTextBoxColumn.Name = "наименованиеорганизацииDataGridViewTextBoxColumn";
            this.наименованиеорганизацииDataGridViewTextBoxColumn.Width = 250;
            // 
            // цельвизитаDataGridViewTextBoxColumn
            // 
            this.цельвизитаDataGridViewTextBoxColumn.DataPropertyName = "Цель_визита";
            this.цельвизитаDataGridViewTextBoxColumn.HeaderText = "Цель_визита";
            this.цельвизитаDataGridViewTextBoxColumn.Name = "цельвизитаDataGridViewTextBoxColumn";
            this.цельвизитаDataGridViewTextBoxColumn.Width = 170;
            // 
            // наименованиескладаDataGridViewTextBoxColumn
            // 
            this.наименованиескладаDataGridViewTextBoxColumn.DataPropertyName = "Наименование_склада";
            this.наименованиескладаDataGridViewTextBoxColumn.HeaderText = "Наименование_склада";
            this.наименованиескладаDataGridViewTextBoxColumn.Name = "наименованиескладаDataGridViewTextBoxColumn";
            this.наименованиескладаDataGridViewTextBoxColumn.Width = 200;
            // 
            // датавыдачипропускаDataGridViewTextBoxColumn
            // 
            this.датавыдачипропускаDataGridViewTextBoxColumn.DataPropertyName = "Дата_выдачи_пропуска";
            this.датавыдачипропускаDataGridViewTextBoxColumn.HeaderText = "Дата_выдачи_пропуска";
            this.датавыдачипропускаDataGridViewTextBoxColumn.Name = "датавыдачипропускаDataGridViewTextBoxColumn";
            this.датавыдачипропускаDataGridViewTextBoxColumn.Width = 230;
            // 
            // времяотбытияDataGridViewTextBoxColumn
            // 
            this.времяотбытияDataGridViewTextBoxColumn.DataPropertyName = "Время_отбытия";
            this.времяотбытияDataGridViewTextBoxColumn.HeaderText = "Время_отбытия";
            this.времяотбытияDataGridViewTextBoxColumn.Name = "времяотбытияDataGridViewTextBoxColumn";
            this.времяотбытияDataGridViewTextBoxColumn.Width = 170;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // пропуски_клиентовBindingSource
            // 
            this.пропуски_клиентовBindingSource.DataMember = "Пропуски_клиентов";
            this.пропуски_клиентовBindingSource.DataSource = this.ПропускаDataSet;
            // 
            // пропуски_клиентовTableAdapter
            // 
            this.пропуски_клиентовTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ПропускаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВодителиTableAdapter = this.водителиTableAdapter;
            this.tableAdapterManager.Временные_пропуски_ВодителиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.МашиныTableAdapter = null;
            this.tableAdapterManager.ОрганизацииTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.Пропуски_клиентовTableAdapter = this.пропуски_клиентовTableAdapter;
            this.tableAdapterManager.РегистрацияTableAdapter = null;
            this.tableAdapterManager.СкладыTableAdapter = this.складыTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // водителиTableAdapter
            // 
            this.водителиTableAdapter.ClearBeforeFill = true;
            // 
            // складыTableAdapter
            // 
            this.складыTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(239, 70);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Начальная дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(244, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Конечная";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список посещавших машин за произвольную дату";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 125);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найти конкретного водителя который вьезжал на территорию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(37, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите ФИО водителя";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.водителиBindingSource;
            this.comboBox1.DisplayMember = "ФИО_водителя";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // водителиBindingSource
            // 
            this.водителиBindingSource.DataMember = "Водители";
            this.водителиBindingSource.DataSource = this.пропускаDataSet1;
            // 
            // пропускаDataSet1
            // 
            this.пропускаDataSet1.DataSetName = "ПропускаDataSet";
            this.пропускаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(475, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.dateTimePicker4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(726, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 246);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кто посещал конкретный склад за произвольную дату";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker3.Location = new System.Drawing.Point(15, 160);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Выберите промежутки между датами";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(237, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Конечная";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберите нужный склад";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(21, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Начальная дата";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.складыBindingSource;
            this.comboBox2.DisplayMember = "Наименование_склада";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(30, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(298, 28);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "Наименование_склада";
            // 
            // складыBindingSource
            // 
            this.складыBindingSource.DataMember = "Склады";
            this.складыBindingSource.DataSource = this.пропускаDataSet1;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker4.Location = new System.Drawing.Point(232, 160);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker4.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(138, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 34);
            this.button3.TabIndex = 1;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1207, 576);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 46);
            this.button4.TabIndex = 10;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 634);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form13";
            this.Text = "Запросы Водители";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ПропускаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропуски_клиентовBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.складыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ПропускаDataSet ПропускаDataSet;
        private ПропускаDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОводителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаавтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn регестрационныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеорганизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цельвизитаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиескладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыдачипропускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяотбытияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource пропуски_клиентовBindingSource;
        private ПропускаDataSetTableAdapters.Пропуски_клиентовTableAdapter пропуски_клиентовTableAdapter;
        private ПропускаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private ПропускаDataSetTableAdapters.ВодителиTableAdapter водителиTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private ПропускаDataSet пропускаDataSet1;
        private System.Windows.Forms.BindingSource водителиBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private ПропускаDataSetTableAdapters.СкладыTableAdapter складыTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource складыBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button button4;
    }
}