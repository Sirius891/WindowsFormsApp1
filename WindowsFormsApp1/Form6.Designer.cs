
namespace WindowsFormsApp1
{
    partial class Form6
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
            System.Windows.Forms.Label фИО_водителяLabel;
            System.Windows.Forms.Label водительское_удостоверениеLabel;
            System.Windows.Forms.Label серия_и_номер_паспортаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.водителиDataGridView = new System.Windows.Forms.DataGridView();
            this.фИОводителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.водительскоеудостоверениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияиномерпаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.водителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пропускаDataSet = new WindowsFormsApp1.ПропускаDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.водителиTableAdapter = new WindowsFormsApp1.ПропускаDataSetTableAdapters.ВодителиTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ПропускаDataSetTableAdapters.TableAdapterManager();
            this.фИО_водителяTextBox = new System.Windows.Forms.TextBox();
            this.водительское_удостоверениеTextBox = new System.Windows.Forms.TextBox();
            this.серия_и_номер_паспортаTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            фИО_водителяLabel = new System.Windows.Forms.Label();
            водительское_удостоверениеLabel = new System.Windows.Forms.Label();
            серия_и_номер_паспортаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.водителиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // фИО_водителяLabel
            // 
            фИО_водителяLabel.AutoSize = true;
            фИО_водителяLabel.Location = new System.Drawing.Point(33, 313);
            фИО_водителяLabel.Name = "фИО_водителяLabel";
            фИО_водителяLabel.Size = new System.Drawing.Size(143, 20);
            фИО_водителяLabel.TabIndex = 54;
            фИО_водителяLabel.Text = "ФИО водителя:";
            // 
            // водительское_удостоверениеLabel
            // 
            водительское_удостоверениеLabel.AutoSize = true;
            водительское_удостоверениеLabel.Location = new System.Drawing.Point(33, 348);
            водительское_удостоверениеLabel.Name = "водительское_удостоверениеLabel";
            водительское_удостоверениеLabel.Size = new System.Drawing.Size(271, 20);
            водительское_удостоверениеLabel.TabIndex = 56;
            водительское_удостоверениеLabel.Text = "Водительское удостоверение:";
            // 
            // серия_и_номер_паспортаLabel
            // 
            серия_и_номер_паспортаLabel.AutoSize = true;
            серия_и_номер_паспортаLabel.Location = new System.Drawing.Point(33, 380);
            серия_и_номер_паспортаLabel.Name = "серия_и_номер_паспортаLabel";
            серия_и_номер_паспортаLabel.Size = new System.Drawing.Size(222, 20);
            серия_и_номер_паспортаLabel.TabIndex = 58;
            серия_и_номер_паспортаLabel.Text = "Серия и номер паспорта:";
            // 
            // водителиDataGridView
            // 
            this.водителиDataGridView.AutoGenerateColumns = false;
            this.водителиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.водителиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОводителяDataGridViewTextBoxColumn,
            this.водительскоеудостоверениеDataGridViewTextBoxColumn,
            this.серияиномерпаспортаDataGridViewTextBoxColumn});
            this.водителиDataGridView.DataSource = this.водителиBindingSource;
            this.водителиDataGridView.Location = new System.Drawing.Point(22, 57);
            this.водителиDataGridView.Name = "водителиDataGridView";
            this.водителиDataGridView.Size = new System.Drawing.Size(1107, 220);
            this.водителиDataGridView.TabIndex = 39;
            // 
            // фИОводителяDataGridViewTextBoxColumn
            // 
            this.фИОводителяDataGridViewTextBoxColumn.DataPropertyName = "ФИО_водителя";
            this.фИОводителяDataGridViewTextBoxColumn.HeaderText = "ФИО_водителя";
            this.фИОводителяDataGridViewTextBoxColumn.Name = "фИОводителяDataGridViewTextBoxColumn";
            this.фИОводителяDataGridViewTextBoxColumn.Width = 300;
            // 
            // водительскоеудостоверениеDataGridViewTextBoxColumn
            // 
            this.водительскоеудостоверениеDataGridViewTextBoxColumn.DataPropertyName = "Водительское_удостоверение";
            this.водительскоеудостоверениеDataGridViewTextBoxColumn.HeaderText = "Водительское_удостоверение";
            this.водительскоеудостоверениеDataGridViewTextBoxColumn.Name = "водительскоеудостоверениеDataGridViewTextBoxColumn";
            this.водительскоеудостоверениеDataGridViewTextBoxColumn.Width = 300;
            // 
            // серияиномерпаспортаDataGridViewTextBoxColumn
            // 
            this.серияиномерпаспортаDataGridViewTextBoxColumn.DataPropertyName = "Серия_и_номер_паспорта";
            this.серияиномерпаспортаDataGridViewTextBoxColumn.HeaderText = "Серия_и_номер_паспорта";
            this.серияиномерпаспортаDataGridViewTextBoxColumn.Name = "серияиномерпаспортаDataGridViewTextBoxColumn";
            this.серияиномерпаспортаDataGridViewTextBoxColumn.Width = 300;
            // 
            // водителиBindingSource
            // 
            this.водителиBindingSource.DataMember = "Водители";
            this.водителиBindingSource.DataSource = this.пропускаDataSet;
            // 
            // пропускаDataSet
            // 
            this.пропускаDataSet.DataSetName = "ПропускаDataSet";
            this.пропускаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(711, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 43);
            this.button1.TabIndex = 52;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(711, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 43);
            this.button3.TabIndex = 51;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // водителиTableAdapter
            // 
            this.водителиTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Пропуски_клиентовTableAdapter = null;
            this.tableAdapterManager.РегистрацияTableAdapter = null;
            this.tableAdapterManager.СкладыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // фИО_водителяTextBox
            // 
            this.фИО_водителяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водителиBindingSource, "ФИО_водителя", true));
            this.фИО_водителяTextBox.Location = new System.Drawing.Point(310, 313);
            this.фИО_водителяTextBox.Name = "фИО_водителяTextBox";
            this.фИО_водителяTextBox.Size = new System.Drawing.Size(352, 26);
            this.фИО_водителяTextBox.TabIndex = 55;
            // 
            // водительское_удостоверениеTextBox
            // 
            this.водительское_удостоверениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водителиBindingSource, "Водительское_удостоверение", true));
            this.водительское_удостоверениеTextBox.Location = new System.Drawing.Point(310, 345);
            this.водительское_удостоверениеTextBox.Name = "водительское_удостоверениеTextBox";
            this.водительское_удостоверениеTextBox.Size = new System.Drawing.Size(352, 26);
            this.водительское_удостоверениеTextBox.TabIndex = 57;
            // 
            // серия_и_номер_паспортаTextBox
            // 
            this.серия_и_номер_паспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.водителиBindingSource, "Серия_и_номер_паспорта", true));
            this.серия_и_номер_паспортаTextBox.Location = new System.Drawing.Point(310, 377);
            this.серия_и_номер_паспортаTextBox.Name = "серия_и_номер_паспортаTextBox";
            this.серия_и_номер_паспортаTextBox.Size = new System.Drawing.Size(352, 26);
            this.серия_и_номер_паспортаTextBox.TabIndex = 59;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.водителиBindingSource;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1152, 25);
            this.bindingNavigator1.TabIndex = 60;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(937, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 43);
            this.button2.TabIndex = 61;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(фИО_водителяLabel);
            this.Controls.Add(this.фИО_водителяTextBox);
            this.Controls.Add(водительское_удостоверениеLabel);
            this.Controls.Add(this.водительское_удостоверениеTextBox);
            this.Controls.Add(серия_и_номер_паспортаLabel);
            this.Controls.Add(this.серия_и_номер_паспортаTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.водителиDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form6";
            this.Text = "Справочник Водители";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.водителиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пропускаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView водителиDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private ПропускаDataSet пропускаDataSet;
        private System.Windows.Forms.BindingSource водителиBindingSource;
        private ПропускаDataSetTableAdapters.ВодителиTableAdapter водителиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОводителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn водительскоеудостоверениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияиномерпаспортаDataGridViewTextBoxColumn;
        private ПропускаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox фИО_водителяTextBox;
        private System.Windows.Forms.TextBox водительское_удостоверениеTextBox;
        private System.Windows.Forms.TextBox серия_и_номер_паспортаTextBox;
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
        private System.Windows.Forms.Button button2;
    }
}