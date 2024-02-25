
namespace WindowsFormsApp1
{
    partial class Form4
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
            System.Windows.Forms.Label код_водителяLabel;
            System.Windows.Forms.Label код_организацииLabel;
            System.Windows.Forms.Label код_автомобиляLabel;
            System.Windows.Forms.Label дата_выдачи_пропускаLabel;
            System.Windows.Forms.Label время_отбытияLabel;
            System.Windows.Forms.Label цель_визитаLabel;
            System.Windows.Forms.Label код_складаLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.Windows.Forms.Label код_пропускаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.машиныTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.МашиныTableAdapter();
            this.складыTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.СкладыTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.организацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.машиныToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ктоСейчасНаходитсяНаПредприятииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ктоВоСколькоПриезжалВТеченииДняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингОрганизацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингВодителейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пропускаDataSet = new WindowsFormsApp1.ПропускаDataSet();
            this.временные_пропуски_ВодителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.временные_пропуски_ВодителиTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.Временные_пропуски_ВодителиTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ПропускаDataSetTableAdapters.TableAdapterManager();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.водителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.организацииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.машиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.складыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.водителиTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.ВодителиTableAdapter();
            this.организацииTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.ОрганизацииTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.код_пропускаTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.сотрудникиTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.СотрудникиTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            код_водителяLabel = new System.Windows.Forms.Label();
            код_организацииLabel = new System.Windows.Forms.Label();
            код_автомобиляLabel = new System.Windows.Forms.Label();
            дата_выдачи_пропускаLabel = new System.Windows.Forms.Label();
            время_отбытияLabel = new System.Windows.Forms.Label();
            цель_визитаLabel = new System.Windows.Forms.Label();
            код_складаLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            код_пропускаLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.временные_пропуски_ВодителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.машиныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // код_водителяLabel
            // 
            код_водителяLabel.AutoSize = true;
            код_водителяLabel.Location = new System.Drawing.Point(25, 98);
            код_водителяLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            код_водителяLabel.Name = "код_водителяLabel";
            код_водителяLabel.Size = new System.Drawing.Size(186, 20);
            код_водителяLabel.TabIndex = 66;
            код_водителяLabel.Text = "Выберите водителя:";
            // 
            // код_организацииLabel
            // 
            код_организацииLabel.AutoSize = true;
            код_организацииLabel.Location = new System.Drawing.Point(25, 138);
            код_организацииLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            код_организацииLabel.Name = "код_организацииLabel";
            код_организацииLabel.Size = new System.Drawing.Size(213, 20);
            код_организацииLabel.TabIndex = 68;
            код_организацииLabel.Text = "Выберите организацию:";
            // 
            // код_автомобиляLabel
            // 
            код_автомобиляLabel.AutoSize = true;
            код_автомобиляLabel.Location = new System.Drawing.Point(25, 178);
            код_автомобиляLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            код_автомобиляLabel.Name = "код_автомобиляLabel";
            код_автомобиляLabel.Size = new System.Drawing.Size(295, 20);
            код_автомобиляLabel.TabIndex = 70;
            код_автомобиляLabel.Text = "Выберите гос номер автомобиля:";
            // 
            // дата_выдачи_пропускаLabel
            // 
            дата_выдачи_пропускаLabel.AutoSize = true;
            дата_выдачи_пропускаLabel.Location = new System.Drawing.Point(25, 220);
            дата_выдачи_пропускаLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            дата_выдачи_пропускаLabel.Name = "дата_выдачи_пропускаLabel";
            дата_выдачи_пропускаLabel.Size = new System.Drawing.Size(207, 20);
            дата_выдачи_пропускаLabel.TabIndex = 72;
            дата_выдачи_пропускаLabel.Text = "Дата выдачи пропуска:";
            // 
            // время_отбытияLabel
            // 
            время_отбытияLabel.AutoSize = true;
            время_отбытияLabel.Location = new System.Drawing.Point(25, 260);
            время_отбытияLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            время_отбытияLabel.Name = "время_отбытияLabel";
            время_отбытияLabel.Size = new System.Drawing.Size(145, 20);
            время_отбытияLabel.TabIndex = 74;
            время_отбытияLabel.Text = "Время отбытия:";
            // 
            // цель_визитаLabel
            // 
            цель_визитаLabel.AutoSize = true;
            цель_визитаLabel.Location = new System.Drawing.Point(25, 298);
            цель_визитаLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            цель_визитаLabel.Name = "цель_визитаLabel";
            цель_визитаLabel.Size = new System.Drawing.Size(122, 20);
            цель_визитаLabel.TabIndex = 76;
            цель_визитаLabel.Text = "Цель визита:";
            // 
            // код_складаLabel
            // 
            код_складаLabel.AutoSize = true;
            код_складаLabel.Location = new System.Drawing.Point(25, 338);
            код_складаLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            код_складаLabel.Name = "код_складаLabel";
            код_складаLabel.Size = new System.Drawing.Size(68, 20);
            код_складаLabel.TabIndex = 78;
            код_складаLabel.Text = "Cклад:";
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(25, 378);
            код_сотрудникаLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(279, 20);
            код_сотрудникаLabel.TabIndex = 80;
            код_сотрудникаLabel.Text = "Сотрудника выдавший пропуск:";
            // 
            // код_пропускаLabel
            // 
            код_пропускаLabel.AutoSize = true;
            код_пропускаLabel.Location = new System.Drawing.Point(25, 67);
            код_пропускаLabel.Name = "код_пропускаLabel";
            код_пропускаLabel.Size = new System.Drawing.Size(128, 20);
            код_пропускаLabel.TabIndex = 91;
            код_пропускаLabel.Text = "Код пропуска:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(47, 432);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 47);
            this.button3.TabIndex = 34;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(221, 432);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 47);
            this.button1.TabIndex = 35;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(709, 464);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 47);
            this.button2.TabIndex = 36;
            this.button2.Text = "Выйти из аккаунта";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // машиныTableAdapter
            // 
            this.машиныTableAdapter.ClearBeforeFill = true;
            // 
            // складыTableAdapter
            // 
            this.складыTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(939, 31);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.водителиToolStripMenuItem,
            this.организацииToolStripMenuItem,
            this.машиныToolStripMenuItem1});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(215, 25);
            this.справочникиToolStripMenuItem.Text = "Заполнить справочники";
            // 
            // водителиToolStripMenuItem
            // 
            this.водителиToolStripMenuItem.Name = "водителиToolStripMenuItem";
            this.водителиToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.водителиToolStripMenuItem.Text = "Водители";
            this.водителиToolStripMenuItem.Click += new System.EventHandler(this.водителиToolStripMenuItem_Click);
            // 
            // организацииToolStripMenuItem
            // 
            this.организацииToolStripMenuItem.Name = "организацииToolStripMenuItem";
            this.организацииToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.организацииToolStripMenuItem.Text = "Организации";
            this.организацииToolStripMenuItem.Click += new System.EventHandler(this.организацииToolStripMenuItem_Click);
            // 
            // машиныToolStripMenuItem1
            // 
            this.машиныToolStripMenuItem1.Name = "машиныToolStripMenuItem1";
            this.машиныToolStripMenuItem1.Size = new System.Drawing.Size(185, 26);
            this.машиныToolStripMenuItem1.Text = "Машины";
            this.машиныToolStripMenuItem1.Click += new System.EventHandler(this.машиныToolStripMenuItem1_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ктоСейчасНаходитсяНаПредприятииToolStripMenuItem,
            this.ктоВоСколькоПриезжалВТеченииДняToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(213, 25);
            this.запросыToolStripMenuItem.Text = "Сформировать запросы";
            // 
            // ктоСейчасНаходитсяНаПредприятииToolStripMenuItem
            // 
            this.ктоСейчасНаходитсяНаПредприятииToolStripMenuItem.Name = "ктоСейчасНаходитсяНаПредприятииToolStripMenuItem";
            this.ктоСейчасНаходитсяНаПредприятииToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.ктоСейчасНаходитсяНаПредприятииToolStripMenuItem.Text = "Кто сейчас находится на предприятии";
            this.ктоСейчасНаходитсяНаПредприятииToolStripMenuItem.Click += new System.EventHandler(this.ктоСейчасНаходитсяНаПредприятииToolStripMenuItem_Click);
            // 
            // ктоВоСколькоПриезжалВТеченииДняToolStripMenuItem
            // 
            this.ктоВоСколькоПриезжалВТеченииДняToolStripMenuItem.Name = "ктоВоСколькоПриезжалВТеченииДняToolStripMenuItem";
            this.ктоВоСколькоПриезжалВТеченииДняToolStripMenuItem.Size = new System.Drawing.Size(383, 26);
            this.ктоВоСколькоПриезжалВТеченииДняToolStripMenuItem.Text = "Универсальные запросы";
            this.ктоВоСколькоПриезжалВТеченииДняToolStripMenuItem.Click += new System.EventHandler(this.ктоВоСколькоПриезжалВТеченииДняToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рейтингОрганизацийToolStripMenuItem,
            this.рейтингВодителейToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(203, 25);
            this.отчётыToolStripMenuItem.Text = "Сформировать Отчёты";
            // 
            // рейтингОрганизацийToolStripMenuItem
            // 
            this.рейтингОрганизацийToolStripMenuItem.Name = "рейтингОрганизацийToolStripMenuItem";
            this.рейтингОрганизацийToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.рейтингОрганизацийToolStripMenuItem.Text = "Рейтинг организаций";
            this.рейтингОрганизацийToolStripMenuItem.Click += new System.EventHandler(this.рейтингОрганизацийToolStripMenuItem_Click);
            // 
            // рейтингВодителейToolStripMenuItem
            // 
            this.рейтингВодителейToolStripMenuItem.Name = "рейтингВодителейToolStripMenuItem";
            this.рейтингВодителейToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.рейтингВодителейToolStripMenuItem.Text = "Рейтинг складов";
            this.рейтингВодителейToolStripMenuItem.Click += new System.EventHandler(this.рейтингВодителейToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(191, 25);
            this.выходToolStripMenuItem.Text = "Выйти из программы";
            // 
            // пропускаDataSet
            // 
            this.пропускаDataSet.DataSetName = "ПропускаDataSet";
            this.пропускаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // временные_пропуски_ВодителиBindingSource
            // 
            this.временные_пропуски_ВодителиBindingSource.DataMember = "Временные_пропуски_Водители";
            this.временные_пропуски_ВодителиBindingSource.DataSource = this.пропускаDataSet;
            // 
            // временные_пропуски_ВодителиTableAdapter
            // 
            this.временные_пропуски_ВодителиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ПропускаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.Временные_пропуски_ВодителиTableAdapter = this.временные_пропуски_ВодителиTableAdapter;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.МашиныTableAdapter = this.машиныTableAdapter;
            this.tableAdapterManager.ОрганизацииTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.Пропуски_клиентовTableAdapter = null;
            this.tableAdapterManager.РегистрацияTableAdapter = null;
            this.tableAdapterManager.СкладыTableAdapter = this.складыTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(322, 374);
            this.код_сотрудникаTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.ReadOnly = true;
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(331, 26);
            this.код_сотрудникаTextBox.TabIndex = 81;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.временные_пропуски_ВодителиBindingSource, "Время_отбытия", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(331, 26);
            this.dateTimePicker1.TabIndex = 82;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.временные_пропуски_ВодителиBindingSource, "Дата_выдачи_пропуска", true));
            this.dateTimePicker2.Location = new System.Drawing.Point(322, 220);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(331, 26);
            this.dateTimePicker2.TabIndex = 83;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.временные_пропуски_ВодителиBindingSource, "Код_водителя", true));
            this.comboBox1.DataSource = this.водителиBindingSource;
            this.comboBox1.DisplayMember = "ФИО_водителя";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(322, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(331, 28);
            this.comboBox1.TabIndex = 84;
            this.comboBox1.ValueMember = "Код_водителя";
            // 
            // водителиBindingSource
            // 
            this.водителиBindingSource.DataMember = "Водители";
            this.водителиBindingSource.DataSource = this.пропускаDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.временные_пропуски_ВодителиBindingSource, "Код_организации", true));
            this.comboBox2.DataSource = this.организацииBindingSource;
            this.comboBox2.DisplayMember = "Наименование_организации";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(322, 135);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(331, 28);
            this.comboBox2.TabIndex = 85;
            this.comboBox2.ValueMember = "Код_Организации";
            // 
            // организацииBindingSource
            // 
            this.организацииBindingSource.DataMember = "Организации";
            this.организацииBindingSource.DataSource = this.пропускаDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.временные_пропуски_ВодителиBindingSource, "Код_автомобиля", true));
            this.comboBox3.DataSource = this.машиныBindingSource;
            this.comboBox3.DisplayMember = "Регестрационный номер";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(322, 175);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(331, 28);
            this.comboBox3.TabIndex = 86;
            this.comboBox3.ValueMember = "Код_автомобиля";
            // 
            // машиныBindingSource
            // 
            this.машиныBindingSource.DataMember = "Машины";
            this.машиныBindingSource.DataSource = this.пропускаDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(322, 298);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(331, 28);
            this.comboBox4.TabIndex = 87;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.временные_пропуски_ВодителиBindingSource, "Код_склада", true));
            this.comboBox5.DataSource = this.складыBindingSource;
            this.comboBox5.DisplayMember = "Наименование_склада";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(322, 335);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(331, 28);
            this.comboBox5.TabIndex = 88;
            this.comboBox5.ValueMember = "Код_склада";
            // 
            // складыBindingSource
            // 
            this.складыBindingSource.DataMember = "Склады";
            this.складыBindingSource.DataSource = this.пропускаDataSet;
            // 
            // водителиTableAdapter
            // 
            this.водителиTableAdapter.ClearBeforeFill = true;
            // 
            // организацииTableAdapter
            // 
            this.организацииTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.машиныBindingSource, "Марка_автомобиля", true));
            this.textBox1.Location = new System.Drawing.Point(669, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(232, 26);
            this.textBox1.TabIndex = 89;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.временные_пропуски_ВодителиBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 31);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(939, 25);
            this.bindingNavigator1.TabIndex = 91;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // код_пропускаTextBox
            // 
            this.код_пропускаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.временные_пропуски_ВодителиBindingSource, "Код_пропуска", true));
            this.код_пропускаTextBox.Location = new System.Drawing.Point(322, 61);
            this.код_пропускаTextBox.Name = "код_пропускаTextBox";
            this.код_пропускаTextBox.Size = new System.Drawing.Size(331, 26);
            this.код_пропускаTextBox.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Марка автомобиля:";
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.временные_пропуски_ВодителиBindingSource, "Код_сотрудника", true));
            this.textBox2.Location = new System.Drawing.Point(669, 375);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(25, 26);
            this.textBox2.TabIndex = 90;
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this.пропускаDataSet;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(код_пропускаLabel);
            this.Controls.Add(this.код_пропускаTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(код_водителяLabel);
            this.Controls.Add(код_организацииLabel);
            this.Controls.Add(код_автомобиляLabel);
            this.Controls.Add(дата_выдачи_пропускаLabel);
            this.Controls.Add(время_отбытияLabel);
            this.Controls.Add(цель_визитаLabel);
            this.Controls.Add(код_складаLabel);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form4";
            this.Text = "Основная форма программы для КПП автомобилей";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.временные_пропуски_ВодителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.машиныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ПропускаDataSetTableAdapters.МашиныTableAdapter машиныTableAdapter;
        private ПропускаDataSetTableAdapters.СкладыTableAdapter складыTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem водителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem организацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem машиныToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ктоСейчасНаходитсяНаПредприятииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ктоВоСколькоПриезжалВТеченииДняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейтингОрганизацийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейтингВодителейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private ПропускаDataSet пропускаDataSet;
        private System.Windows.Forms.BindingSource временные_пропуски_ВодителиBindingSource;
        private ПропускаDataSetTableAdapters.Временные_пропуски_ВодителиTableAdapter временные_пропуски_ВодителиTableAdapter;
        private ПропускаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.BindingSource водителиBindingSource;
        private ПропускаDataSetTableAdapters.ВодителиTableAdapter водителиTableAdapter;
        private System.Windows.Forms.BindingSource организацииBindingSource;
        private ПропускаDataSetTableAdapters.ОрганизацииTableAdapter организацииTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource машиныBindingSource;
        private System.Windows.Forms.BindingSource складыBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox код_пропускаTextBox;
        private System.Windows.Forms.Label label1;
        private ПропускаDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
    }
}