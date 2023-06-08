namespace Telefon_Rehberi_Uygulaması_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label isimLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label soyisimLabel;
            this.telefonRehberiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.telefonRehberiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.isimTextBox = new System.Windows.Forms.TextBox();
            this.telefonMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.telefonRehberiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonRehberiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonrehberiDataSet = new Telefon_Rehberi_Uygulaması_2.telefonrehberiDataSet();
            this.telefonRehberiTableAdapter = new Telefon_Rehberi_Uygulaması_2.telefonrehberiDataSetTableAdapters.TelefonRehberiTableAdapter();
            this.tableAdapterManager = new Telefon_Rehberi_Uygulaması_2.telefonrehberiDataSetTableAdapters.TableAdapterManager();
            this.soyisimTextBox = new System.Windows.Forms.TextBox();
            isimLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            soyisimLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.telefonRehberiBindingNavigator)).BeginInit();
            this.telefonRehberiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonRehberiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonRehberiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonrehberiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // telefonRehberiBindingNavigator
            // 
            this.telefonRehberiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.telefonRehberiBindingNavigator.BackColor = System.Drawing.Color.Aqua;
            this.telefonRehberiBindingNavigator.BindingSource = this.telefonRehberiBindingSource;
            this.telefonRehberiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.telefonRehberiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.telefonRehberiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.telefonRehberiBindingNavigatorSaveItem});
            this.telefonRehberiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.telefonRehberiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.telefonRehberiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.telefonRehberiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.telefonRehberiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.telefonRehberiBindingNavigator.Name = "telefonRehberiBindingNavigator";
            this.telefonRehberiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.telefonRehberiBindingNavigator.Size = new System.Drawing.Size(674, 25);
            this.telefonRehberiBindingNavigator.TabIndex = 0;
            this.telefonRehberiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
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
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // telefonRehberiBindingNavigatorSaveItem
            // 
            this.telefonRehberiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.telefonRehberiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("telefonRehberiBindingNavigatorSaveItem.Image")));
            this.telefonRehberiBindingNavigatorSaveItem.Name = "telefonRehberiBindingNavigatorSaveItem";
            this.telefonRehberiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.telefonRehberiBindingNavigatorSaveItem.Text = "Save Data";
            this.telefonRehberiBindingNavigatorSaveItem.Click += new System.EventHandler(this.telefonRehberiBindingNavigatorSaveItem_Click);
            // 
            // isimLabel
            // 
            isimLabel.AutoSize = true;
            isimLabel.Location = new System.Drawing.Point(65, 35);
            isimLabel.Name = "isimLabel";
            isimLabel.Size = new System.Drawing.Size(28, 13);
            isimLabel.TabIndex = 1;
            isimLabel.Text = "Isim:";
            // 
            // isimTextBox
            // 
            this.isimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonRehberiBindingSource, "Isim", true));
            this.isimTextBox.Location = new System.Drawing.Point(116, 32);
            this.isimTextBox.Name = "isimTextBox";
            this.isimTextBox.Size = new System.Drawing.Size(100, 20);
            this.isimTextBox.TabIndex = 2;
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(65, 87);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 5;
            telefonLabel.Text = "Telefon:";
            // 
            // telefonMaskedTextBox
            // 
            this.telefonMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonRehberiBindingSource, "Telefon", true));
            this.telefonMaskedTextBox.Location = new System.Drawing.Point(116, 84);
            this.telefonMaskedTextBox.Mask = "(999) 000-0000";
            this.telefonMaskedTextBox.Name = "telefonMaskedTextBox";
            this.telefonMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonMaskedTextBox.TabIndex = 6;
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new System.Drawing.Point(231, 35);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(37, 13);
            adresLabel.TabIndex = 7;
            adresLabel.Text = "Adres:";
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonRehberiBindingSource, "Adres", true));
            this.adresTextBox.Location = new System.Drawing.Point(283, 32);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(328, 72);
            this.adresTextBox.TabIndex = 8;
            // 
            // telefonRehberiDataGridView
            // 
            this.telefonRehberiDataGridView.AutoGenerateColumns = false;
            this.telefonRehberiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.telefonRehberiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telefonRehberiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.telefonRehberiDataGridView.DataSource = this.telefonRehberiBindingSource;
            this.telefonRehberiDataGridView.Location = new System.Drawing.Point(67, 136);
            this.telefonRehberiDataGridView.Name = "telefonRehberiDataGridView";
            this.telefonRehberiDataGridView.Size = new System.Drawing.Size(544, 170);
            this.telefonRehberiDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Kimlik";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kimlik";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Isim";
            this.dataGridViewTextBoxColumn2.HeaderText = "Isim";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Adres";
            this.dataGridViewTextBoxColumn5.HeaderText = "Adres";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // telefonRehberiBindingSource
            // 
            this.telefonRehberiBindingSource.DataMember = "TelefonRehberi";
            this.telefonRehberiBindingSource.DataSource = this.telefonrehberiDataSet;
            // 
            // telefonrehberiDataSet
            // 
            this.telefonrehberiDataSet.DataSetName = "telefonrehberiDataSet";
            this.telefonrehberiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telefonRehberiTableAdapter
            // 
            this.telefonRehberiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TelefonRehberiTableAdapter = this.telefonRehberiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Telefon_Rehberi_Uygulaması_2.telefonrehberiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // soyisimLabel
            // 
            soyisimLabel.AutoSize = true;
            soyisimLabel.Location = new System.Drawing.Point(65, 61);
            soyisimLabel.Name = "soyisimLabel";
            soyisimLabel.Size = new System.Drawing.Size(45, 13);
            soyisimLabel.TabIndex = 9;
            soyisimLabel.Text = "Soyisim:";
            // 
            // soyisimTextBox
            // 
            this.soyisimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonRehberiBindingSource, "Soyisim", true));
            this.soyisimTextBox.Location = new System.Drawing.Point(116, 58);
            this.soyisimTextBox.Name = "soyisimTextBox";
            this.soyisimTextBox.Size = new System.Drawing.Size(100, 20);
            this.soyisimTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(674, 376);
            this.Controls.Add(soyisimLabel);
            this.Controls.Add(this.soyisimTextBox);
            this.Controls.Add(this.telefonRehberiDataGridView);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonMaskedTextBox);
            this.Controls.Add(isimLabel);
            this.Controls.Add(this.isimTextBox);
            this.Controls.Add(this.telefonRehberiBindingNavigator);
            this.Name = "Form1";
            this.Text = "Telefon Rehberi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.telefonRehberiBindingNavigator)).EndInit();
            this.telefonRehberiBindingNavigator.ResumeLayout(false);
            this.telefonRehberiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonRehberiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonRehberiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonrehberiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private telefonrehberiDataSet telefonrehberiDataSet;
        private System.Windows.Forms.BindingSource telefonRehberiBindingSource;
        private telefonrehberiDataSetTableAdapters.TelefonRehberiTableAdapter telefonRehberiTableAdapter;
        private telefonrehberiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator telefonRehberiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton telefonRehberiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox isimTextBox;
        private System.Windows.Forms.MaskedTextBox telefonMaskedTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.DataGridView telefonRehberiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox soyisimTextBox;
    }
}

