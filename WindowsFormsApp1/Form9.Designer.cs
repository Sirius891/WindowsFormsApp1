
namespace WindowsFormsApp1
{
    partial class Form9
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
            System.Windows.Forms.Label код_автомобиляLabel;
            System.Windows.Forms.Label марка_автомобиляLabel;
            System.Windows.Forms.Label регестрационный_номерLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.машиныDataGridView = new System.Windows.Forms.DataGridView();
            this.кодавтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаавтомобиляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.регестрационныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.машиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пропускаDataSet = new WindowsFormsApp1.ПропускаDataSet();
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
            this.машиныTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.МашиныTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ПропускаDataSetTableAdapters.TableAdapterManager();
            this.код_автомобиляTextBox = new System.Windows.Forms.TextBox();
            this.марка_автомобиляTextBox = new System.Windows.Forms.TextBox();
            this.регестрационный_номерTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            код_автомобиляLabel = new System.Windows.Forms.Label();
            марка_автомобиляLabel = new System.Windows.Forms.Label();
            регестрационный_номерLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.машиныDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.машиныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_автомобиляLabel
            // 
            код_автомобиляLabel.AutoSize = true;
            код_автомобиляLabel.Location = new System.Drawing.Point(12, 108);
            код_автомобиляLabel.Name = "код_автомобиляLabel";
            код_автомобиляLabel.Size = new System.Drawing.Size(155, 20);
            код_автомобиляLabel.TabIndex = 48;
            код_автомобиляLabel.Text = "Код автомобиля:";
            // 
            // марка_автомобиляLabel
            // 
            марка_автомобиляLabel.AutoSize = true;
            марка_автомобиляLabel.Location = new System.Drawing.Point(12, 140);
            марка_автомобиляLabel.Name = "марка_автомобиляLabel";
            марка_автомобиляLabel.Size = new System.Drawing.Size(175, 20);
            марка_автомобиляLabel.TabIndex = 50;
            марка_автомобиляLabel.Text = "Марка автомобиля:";
            // 
            // регестрационный_номерLabel
            // 
            регестрационный_номерLabel.AutoSize = true;
            регестрационный_номерLabel.Location = new System.Drawing.Point(12, 172);
            регестрационный_номерLabel.Name = "регестрационный_номерLabel";
            регестрационный_номерLabel.Size = new System.Drawing.Size(221, 20);
            регестрационный_номерLabel.TabIndex = 52;
            регестрационный_номерLabel.Text = "Регестрационный номер:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(237, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 43);
            this.button1.TabIndex = 41;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 43);
            this.button3.TabIndex = 40;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // машиныDataGridView
            // 
            this.машиныDataGridView.AutoGenerateColumns = false;
            this.машиныDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.машиныDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодавтомобиляDataGridViewTextBoxColumn,
            this.маркаавтомобиляDataGridViewTextBoxColumn,
            this.регестрационныйНомерDataGridViewTextBoxColumn});
            this.машиныDataGridView.DataSource = this.машиныBindingSource;
            this.машиныDataGridView.Location = new System.Drawing.Point(491, 57);
            this.машиныDataGridView.Name = "машиныDataGridView";
            this.машиныDataGridView.Size = new System.Drawing.Size(758, 220);
            this.машиныDataGridView.TabIndex = 42;
            // 
            // кодавтомобиляDataGridViewTextBoxColumn
            // 
            this.кодавтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Код_автомобиля";
            this.кодавтомобиляDataGridViewTextBoxColumn.HeaderText = "Код_автомобиля";
            this.кодавтомобиляDataGridViewTextBoxColumn.Name = "кодавтомобиляDataGridViewTextBoxColumn";
            this.кодавтомобиляDataGridViewTextBoxColumn.Width = 160;
            // 
            // маркаавтомобиляDataGridViewTextBoxColumn
            // 
            this.маркаавтомобиляDataGridViewTextBoxColumn.DataPropertyName = "Марка_автомобиля";
            this.маркаавтомобиляDataGridViewTextBoxColumn.HeaderText = "Марка_автомобиля";
            this.маркаавтомобиляDataGridViewTextBoxColumn.Name = "маркаавтомобиляDataGridViewTextBoxColumn";
            this.маркаавтомобиляDataGridViewTextBoxColumn.Width = 300;
            // 
            // регестрационныйНомерDataGridViewTextBoxColumn
            // 
            this.регестрационныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Регестрационный номер";
            this.регестрационныйНомерDataGridViewTextBoxColumn.HeaderText = "Регестрационный номер";
            this.регестрационныйНомерDataGridViewTextBoxColumn.Name = "регестрационныйНомерDataGridViewTextBoxColumn";
            this.регестрационныйНомерDataGridViewTextBoxColumn.Width = 250;
            // 
            // машиныBindingSource
            // 
            this.машиныBindingSource.DataMember = "Машины";
            this.машиныBindingSource.DataSource = this.пропускаDataSet;
            // 
            // пропускаDataSet
            // 
            this.пропускаDataSet.DataSetName = "ПропускаDataSet";
            this.пропускаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.машиныBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1261, 25);
            this.bindingNavigator1.TabIndex = 48;
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
            // машиныTableAdapter
            // 
            this.машиныTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Switchboard_ItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ПропускаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВодителиTableAdapter = null;
            this.tableAdapterManager.Временные_пропуски_ВодителиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.МашиныTableAdapter = this.машиныTableAdapter;
            this.tableAdapterManager.ОрганизацииTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.Пропуски_клиентовTableAdapter = null;
            this.tableAdapterManager.РегистрацияTableAdapter = null;
            this.tableAdapterManager.СкладыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // код_автомобиляTextBox
            // 
            this.код_автомобиляTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.машиныBindingSource, "Код_автомобиля", true));
            this.код_автомобиляTextBox.Location = new System.Drawing.Point(239, 105);
            this.код_автомобиляTextBox.Name = "код_автомобиляTextBox";
            this.код_автомобиляTextBox.Size = new System.Drawing.Size(246, 26);
            this.код_автомобиляTextBox.TabIndex = 49;
            // 
            // марка_автомобиляTextBox
            // 
            this.марка_автомобиляTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.машиныBindingSource, "Марка_автомобиля", true));
            this.марка_автомобиляTextBox.Location = new System.Drawing.Point(239, 137);
            this.марка_автомобиляTextBox.Name = "марка_автомобиляTextBox";
            this.марка_автомобиляTextBox.Size = new System.Drawing.Size(246, 26);
            this.марка_автомобиляTextBox.TabIndex = 51;
            // 
            // регестрационный_номерTextBox
            // 
            this.регестрационный_номерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.машиныBindingSource, "Регестрационный номер", true));
            this.регестрационный_номерTextBox.Location = new System.Drawing.Point(239, 169);
            this.регестрационный_номерTextBox.Name = "регестрационный_номерTextBox";
            this.регестрационный_номерTextBox.Size = new System.Drawing.Size(246, 26);
            this.регестрационный_номерTextBox.TabIndex = 53;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1085, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 43);
            this.button2.TabIndex = 54;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(код_автомобиляLabel);
            this.Controls.Add(this.код_автомобиляTextBox);
            this.Controls.Add(марка_автомобиляLabel);
            this.Controls.Add(this.марка_автомобиляTextBox);
            this.Controls.Add(регестрационный_номерLabel);
            this.Controls.Add(this.регестрационный_номерTextBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.машиныDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form9";
            this.Text = "Спровочник Машины";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.машиныDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.машиныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView машиныDataGridView;
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
        private ПропускаDataSet пропускаDataSet;
        private System.Windows.Forms.BindingSource машиныBindingSource;
        private ПропускаDataSetTableAdapters.МашиныTableAdapter машиныTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодавтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаавтомобиляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn регестрационныйНомерDataGridViewTextBoxColumn;
        private ПропускаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox код_автомобиляTextBox;
        private System.Windows.Forms.TextBox марка_автомобиляTextBox;
        private System.Windows.Forms.TextBox регестрационный_номерTextBox;
        private System.Windows.Forms.Button button2;
    }
}