
namespace WindowsFormsApp1
{
    partial class Form5
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
            System.Windows.Forms.Label код_клиентаLabel;
            System.Windows.Forms.Label код_отделаLabel;
            System.Windows.Forms.Label дата_выдачи_пропускаLabel;
            System.Windows.Forms.Label время_выходаLabel;
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.Windows.Forms.Label цель_визитаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьЗапросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пропускаDataSet = new WindowsFormsApp1.ПропускаDataSet();
            this.пропуски_клиентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пропуски_клиентовTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.Пропуски_клиентовTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ПропускаDataSetTableAdapters.TableAdapterManager();
            this.клиентыTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.КлиентыTableAdapter();
            this.отделыTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.ОтделыTableAdapter();
            this.пропуски_клиентовBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.пропуски_клиентовBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.отделыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.цель_визитаTextBox = new System.Windows.Forms.TextBox();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ктоСейчасНаходитсяНаТерриториюИзКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.универсальныйЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингОтделовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            код_клиентаLabel = new System.Windows.Forms.Label();
            код_отделаLabel = new System.Windows.Forms.Label();
            дата_выдачи_пропускаLabel = new System.Windows.Forms.Label();
            время_выходаLabel = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            цель_визитаLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропуски_клиентовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропуски_клиентовBindingNavigator)).BeginInit();
            this.пропуски_клиентовBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_клиентаLabel
            // 
            код_клиентаLabel.AutoSize = true;
            код_клиентаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_клиентаLabel.Location = new System.Drawing.Point(22, 83);
            код_клиентаLabel.Name = "код_клиентаLabel";
            код_клиентаLabel.Size = new System.Drawing.Size(173, 20);
            код_клиентаLabel.TabIndex = 68;
            код_клиентаLabel.Text = "Выберите клиента:";
            // 
            // код_отделаLabel
            // 
            код_отделаLabel.AutoSize = true;
            код_отделаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_отделаLabel.Location = new System.Drawing.Point(22, 116);
            код_отделаLabel.Name = "код_отделаLabel";
            код_отделаLabel.Size = new System.Drawing.Size(166, 20);
            код_отделаLabel.TabIndex = 70;
            код_отделаLabel.Text = "Выберите отдела:";
            // 
            // дата_выдачи_пропускаLabel
            // 
            дата_выдачи_пропускаLabel.AutoSize = true;
            дата_выдачи_пропускаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_выдачи_пропускаLabel.Location = new System.Drawing.Point(22, 149);
            дата_выдачи_пропускаLabel.Name = "дата_выдачи_пропускаLabel";
            дата_выдачи_пропускаLabel.Size = new System.Drawing.Size(207, 20);
            дата_выдачи_пропускаLabel.TabIndex = 72;
            дата_выдачи_пропускаLabel.Text = "Дата выдачи пропуска:";
            // 
            // время_выходаLabel
            // 
            время_выходаLabel.AutoSize = true;
            время_выходаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            время_выходаLabel.Location = new System.Drawing.Point(22, 182);
            время_выходаLabel.Name = "время_выходаLabel";
            время_выходаLabel.Size = new System.Drawing.Size(135, 20);
            время_выходаLabel.TabIndex = 74;
            время_выходаLabel.Text = "Время выхода:";
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            код_сотрудникаLabel.Location = new System.Drawing.Point(22, 215);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(167, 20);
            код_сотрудникаLabel.TabIndex = 76;
            код_сотрудникаLabel.Text = "Выдал Сотрудник:";
            // 
            // цель_визитаLabel
            // 
            цель_визитаLabel.AutoSize = true;
            цель_визитаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            цель_визитаLabel.Location = new System.Drawing.Point(22, 248);
            цель_визитаLabel.Name = "цель_визитаLabel";
            цель_визитаLabel.Size = new System.Drawing.Size(122, 20);
            цель_визитаLabel.TabIndex = 78;
            цель_визитаLabel.Text = "Цель визита:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(637, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 43);
            this.button1.TabIndex = 37;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(637, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 43);
            this.button3.TabIndex = 36;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(787, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 43);
            this.button2.TabIndex = 38;
            this.button2.Text = "Выйти из аккаунта";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.сформироватьЗапросыToolStripMenuItem,
            this.сформироватьОтчётыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 29);
            this.menuStrip1.TabIndex = 65;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem1});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(219, 25);
            this.справочникиToolStripMenuItem.Text = "Заполнить справочники:";
            this.справочникиToolStripMenuItem.Click += new System.EventHandler(this.справочникиToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem1
            // 
            this.клиентыToolStripMenuItem1.Name = "клиентыToolStripMenuItem1";
            this.клиентыToolStripMenuItem1.Size = new System.Drawing.Size(150, 26);
            this.клиентыToolStripMenuItem1.Text = "Клиенты";
            this.клиентыToolStripMenuItem1.Click += new System.EventHandler(this.клиентыToolStripMenuItem1_Click);
            // 
            // сформироватьЗапросыToolStripMenuItem
            // 
            this.сформироватьЗапросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ктоСейчасНаходитсяНаТерриториюИзКлиентовToolStripMenuItem,
            this.универсальныйЗапросToolStripMenuItem});
            this.сформироватьЗапросыToolStripMenuItem.Name = "сформироватьЗапросыToolStripMenuItem";
            this.сформироватьЗапросыToolStripMenuItem.Size = new System.Drawing.Size(213, 25);
            this.сформироватьЗапросыToolStripMenuItem.Text = "Сформировать запросы";
            // 
            // сформироватьОтчётыToolStripMenuItem
            // 
            this.сформироватьОтчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рейтингОтделовToolStripMenuItem});
            this.сформироватьОтчётыToolStripMenuItem.Name = "сформироватьОтчётыToolStripMenuItem";
            this.сформироватьОтчётыToolStripMenuItem.Size = new System.Drawing.Size(201, 25);
            this.сформироватьОтчётыToolStripMenuItem.Text = "Сформировать отчёты";
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
            // пропуски_клиентовBindingSource
            // 
            this.пропуски_клиентовBindingSource.DataMember = "Пропуски_клиентов";
            this.пропуски_клиентовBindingSource.DataSource = this.пропускаDataSet;
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
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.Временные_пропуски_ВодителиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager.МашиныTableAdapter = null;
            this.tableAdapterManager.ОрганизацииTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = this.отделыTableAdapter;
            this.tableAdapterManager.Пропуски_клиентовTableAdapter = this.пропуски_клиентовTableAdapter;
            this.tableAdapterManager.РегистрацияTableAdapter = null;
            this.tableAdapterManager.СкладыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // отделыTableAdapter
            // 
            this.отделыTableAdapter.ClearBeforeFill = true;
            // 
            // пропуски_клиентовBindingNavigator
            // 
            this.пропуски_клиентовBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.пропуски_клиентовBindingNavigator.BindingSource = this.пропуски_клиентовBindingSource;
            this.пропуски_клиентовBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.пропуски_клиентовBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.пропуски_клиентовBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.пропуски_клиентовBindingNavigatorSaveItem});
            this.пропуски_клиентовBindingNavigator.Location = new System.Drawing.Point(0, 29);
            this.пропуски_клиентовBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.пропуски_клиентовBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.пропуски_клиентовBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.пропуски_клиентовBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.пропуски_клиентовBindingNavigator.Name = "пропуски_клиентовBindingNavigator";
            this.пропуски_клиентовBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.пропуски_клиентовBindingNavigator.Size = new System.Drawing.Size(1007, 25);
            this.пропуски_клиентовBindingNavigator.TabIndex = 66;
            this.пропуски_клиентовBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
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
            // пропуски_клиентовBindingNavigatorSaveItem
            // 
            this.пропуски_клиентовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.пропуски_клиентовBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("пропуски_клиентовBindingNavigatorSaveItem.Image")));
            this.пропуски_клиентовBindingNavigatorSaveItem.Name = "пропуски_клиентовBindingNavigatorSaveItem";
            this.пропуски_клиентовBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.пропуски_клиентовBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.пропуски_клиентовBindingNavigatorSaveItem.Click += new System.EventHandler(this.пропуски_клиентовBindingNavigatorSaveItem_Click_2);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пропуски_клиентовBindingSource, "Время_выхода", true));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(355, 26);
            this.dateTimePicker1.TabIndex = 80;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пропуски_клиентовBindingSource, "Дата_выдачи_пропуска", true));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(239, 149);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(355, 26);
            this.dateTimePicker2.TabIndex = 81;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.пропуски_клиентовBindingSource, "Код_клиента", true));
            this.comboBox2.DataSource = this.клиентыBindingSource;
            this.comboBox2.DisplayMember = "ФИО_клиента";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(239, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(355, 28);
            this.comboBox2.TabIndex = 83;
            this.comboBox2.ValueMember = "Код_клиента";
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.пропускаDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.пропуски_клиентовBindingSource, "Код_отдела", true));
            this.comboBox3.DataSource = this.отделыBindingSource;
            this.comboBox3.DisplayMember = "Наименование";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(239, 116);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(355, 28);
            this.comboBox3.TabIndex = 84;
            this.comboBox3.ValueMember = "Код_отдела";
            // 
            // отделыBindingSource
            // 
            this.отделыBindingSource.DataMember = "Отделы";
            this.отделыBindingSource.DataSource = this.пропускаDataSet;
            // 
            // цель_визитаTextBox
            // 
            this.цель_визитаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пропуски_клиентовBindingSource, "Цель_визита", true));
            this.цель_визитаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.цель_визитаTextBox.Location = new System.Drawing.Point(239, 248);
            this.цель_визитаTextBox.Name = "цель_визитаTextBox";
            this.цель_визитаTextBox.Size = new System.Drawing.Size(355, 26);
            this.цель_визитаTextBox.TabIndex = 79;
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(239, 215);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.ReadOnly = true;
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(355, 26);
            this.код_сотрудникаTextBox.TabIndex = 77;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пропуски_клиентовBindingSource, "Код_сотрудника", true));
            this.textBox1.Location = new System.Drawing.Point(600, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(20, 20);
            this.textBox1.TabIndex = 85;
            // 
            // ктоСейчасНаходитсяНаТерриториюИзКлиентовToolStripMenuItem
            // 
            this.ктоСейчасНаходитсяНаТерриториюИзКлиентовToolStripMenuItem.Name = "ктоСейчасНаходитсяНаТерриториюИзКлиентовToolStripMenuItem";
            this.ктоСейчасНаходитсяНаТерриториюИзКлиентовToolStripMenuItem.Size = new System.Drawing.Size(475, 26);
            this.ктоСейчасНаходитсяНаТерриториюИзКлиентовToolStripMenuItem.Text = "Кто сейчас находится на территорию из клиентов";
            this.ктоСейчасНаходитсяНаТерриториюИзКлиентовToolStripMenuItem.Click += new System.EventHandler(this.ктоСейчасНаходитсяНаТерриториюИзКлиентовToolStripMenuItem_Click);
            // 
            // универсальныйЗапросToolStripMenuItem
            // 
            this.универсальныйЗапросToolStripMenuItem.Name = "универсальныйЗапросToolStripMenuItem";
            this.универсальныйЗапросToolStripMenuItem.Size = new System.Drawing.Size(475, 26);
            this.универсальныйЗапросToolStripMenuItem.Text = "Универсальный запрос";
            this.универсальныйЗапросToolStripMenuItem.Click += new System.EventHandler(this.универсальныйЗапросToolStripMenuItem_Click);
            // 
            // рейтингОтделовToolStripMenuItem
            // 
            this.рейтингОтделовToolStripMenuItem.Name = "рейтингОтделовToolStripMenuItem";
            this.рейтингОтделовToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.рейтингОтделовToolStripMenuItem.Text = "Рейтинг отделов";
            this.рейтингОтделовToolStripMenuItem.Click += new System.EventHandler(this.рейтингОтделовToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 366);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(код_клиентаLabel);
            this.Controls.Add(код_отделаLabel);
            this.Controls.Add(дата_выдачи_пропускаLabel);
            this.Controls.Add(время_выходаLabel);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(цель_визитаLabel);
            this.Controls.Add(this.цель_визитаTextBox);
            this.Controls.Add(this.пропуски_клиентовBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "Form5";
            this.Text = "Основная форма программы для КПП клиентов";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропуски_клиентовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропуски_клиентовBindingNavigator)).EndInit();
            this.пропуски_клиентовBindingNavigator.ResumeLayout(false);
            this.пропуски_клиентовBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сформироватьЗапросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private ПропускаDataSet пропускаDataSet;
        private System.Windows.Forms.BindingSource пропуски_клиентовBindingSource;
        private ПропускаDataSetTableAdapters.Пропуски_клиентовTableAdapter пропуски_клиентовTableAdapter;
        private ПропускаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator пропуски_клиентовBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton пропуски_клиентовBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox цель_визитаTextBox;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private ПропускаDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private ПропускаDataSetTableAdapters.ОтделыTableAdapter отделыTableAdapter;
        private System.Windows.Forms.BindingSource отделыBindingSource;
        private System.Windows.Forms.ToolStripMenuItem ктоСейчасНаходитсяНаТерриториюИзКлиентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem универсальныйЗапросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейтингОтделовToolStripMenuItem;
    }
}