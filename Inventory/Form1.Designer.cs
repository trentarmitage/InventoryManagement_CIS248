namespace Inventory
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
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replaceByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new Inventory.InventoryDataSet();
            this.exitButton = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deptToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.deptComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fillByEmpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.empToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tagToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tagToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.itemTxtBox = new System.Windows.Forms.TextBox();
            this.empTxtBox = new System.Windows.Forms.TextBox();
            this.itemLbl = new System.Windows.Forms.Label();
            this.empLbl = new System.Windows.Forms.Label();
            this.deptLbl = new System.Windows.Forms.Label();
            this.snLbl = new System.Windows.Forms.Label();
            this.itemTagLbl = new System.Windows.Forms.Label();
            this.installDateLbl = new System.Windows.Forms.Label();
            this.deptTxtBox = new System.Windows.Forms.TextBox();
            this.snTxtBox = new System.Windows.Forms.TextBox();
            this.itemTagTxtBox = new System.Windows.Forms.TextBox();
            this.installDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.replaceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateBtn = new System.Windows.Forms.Button();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.replaceDate = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.notesTextbox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.notesLbl = new System.Windows.Forms.Label();
            this.inventoryTableAdapter = new Inventory.InventoryDataSetTableAdapters.InventoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Active";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Active";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ReplaceBy";
            this.dataGridViewTextBoxColumn8.HeaderText = "ReplaceBy";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Installed";
            this.dataGridViewTextBoxColumn7.HeaderText = "Installed";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ItemTag#";
            this.dataGridViewTextBoxColumn6.HeaderText = "ItemTag#";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Serial#";
            this.dataGridViewTextBoxColumn5.HeaderText = "Serial#";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn4.HeaderText = "Department";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Employee";
            this.dataGridViewTextBoxColumn3.HeaderText = "Employee";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.AllowUserToAddRows = false;
            this.inventoryDataGridView.AllowUserToDeleteRows = false;
            this.inventoryDataGridView.AllowUserToOrderColumns = true;
            this.inventoryDataGridView.AutoGenerateColumns = false;
            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.serialDataGridViewTextBoxColumn,
            this.itemTagDataGridViewTextBoxColumn,
            this.installedDataGridViewTextBoxColumn,
            this.replaceByDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.dataGridViewDeleteButton});
            this.inventoryDataGridView.DataSource = this.inventoryBindingSource;
            this.inventoryDataGridView.Location = new System.Drawing.Point(10, 12);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.ReadOnly = true;
            this.inventoryDataGridView.Size = new System.Drawing.Size(1054, 474);
            this.inventoryDataGridView.TabIndex = 3;
            this.inventoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryDataGridView_CellClick);
            this.inventoryDataGridView.SelectionChanged += new System.EventHandler(this.InventoryDataGridView_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial#";
            this.serialDataGridViewTextBoxColumn.HeaderText = "Serial#";
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            this.serialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemTagDataGridViewTextBoxColumn
            // 
            this.itemTagDataGridViewTextBoxColumn.DataPropertyName = "ItemTag#";
            this.itemTagDataGridViewTextBoxColumn.HeaderText = "ItemTag#";
            this.itemTagDataGridViewTextBoxColumn.Name = "itemTagDataGridViewTextBoxColumn";
            this.itemTagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // installedDataGridViewTextBoxColumn
            // 
            this.installedDataGridViewTextBoxColumn.DataPropertyName = "Installed";
            this.installedDataGridViewTextBoxColumn.HeaderText = "Installed";
            this.installedDataGridViewTextBoxColumn.Name = "installedDataGridViewTextBoxColumn";
            this.installedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // replaceByDataGridViewTextBoxColumn
            // 
            this.replaceByDataGridViewTextBoxColumn.DataPropertyName = "ReplaceBy";
            this.replaceByDataGridViewTextBoxColumn.HeaderText = "ReplaceBy";
            this.replaceByDataGridViewTextBoxColumn.Name = "replaceByDataGridViewTextBoxColumn";
            this.replaceByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dataGridViewDeleteButton
            // 
            this.dataGridViewDeleteButton.HeaderText = "DELETE";
            this.dataGridViewDeleteButton.Name = "dataGridViewDeleteButton";
            this.dataGridViewDeleteButton.ReadOnly = true;
            this.dataGridViewDeleteButton.Text = "DELETE";
            this.dataGridViewDeleteButton.UseColumnTextForButtonValue = true;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "InventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(968, 234);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripButton,
            this.toolStripSeparator4,
            this.deptToolStripLabel,
            this.deptComboBox,
            this.toolStripSeparator3,
            this.fillByEmpToolStripButton,
            this.empToolStripTextBox,
            this.toolStripSeparator1,
            this.tagToolStripButton,
            this.tagToolStripTextBox,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.copyToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(10, 489);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(728, 25);
            this.fillByToolStrip.TabIndex = 5;
            this.fillByToolStrip.Text = "fillByDeptToolStrip";
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(50, 22);
            this.refreshToolStripButton.Text = "Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.RefreshToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // deptToolStripLabel
            // 
            this.deptToolStripLabel.Name = "deptToolStripLabel";
            this.deptToolStripLabel.Size = new System.Drawing.Size(73, 22);
            this.deptToolStripLabel.Text = "Department:";
            // 
            // deptComboBox
            // 
            this.deptComboBox.Name = "deptComboBox";
            this.deptComboBox.Size = new System.Drawing.Size(121, 25);
            this.deptComboBox.SelectedIndexChanged += new System.EventHandler(this.DeptComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // fillByEmpToolStripButton
            // 
            this.fillByEmpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByEmpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillByEmpToolStripButton.Name = "fillByEmpToolStripButton";
            this.fillByEmpToolStripButton.Size = new System.Drawing.Size(108, 22);
            this.fillByEmpToolStripButton.Text = "Filter By Employee";
            this.fillByEmpToolStripButton.Click += new System.EventHandler(this.FillByEmpToolStripButton_Click);
            // 
            // empToolStripTextBox
            // 
            this.empToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.empToolStripTextBox.Name = "empToolStripTextBox";
            this.empToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tagToolStripButton
            // 
            this.tagToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tagToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("tagToolStripButton.Image")));
            this.tagToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tagToolStripButton.Name = "tagToolStripButton";
            this.tagToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.tagToolStripButton.Text = "Tag#";
            this.tagToolStripButton.Click += new System.EventHandler(this.TagToolStripButton_Click);
            // 
            // tagToolStripTextBox
            // 
            this.tagToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tagToolStripTextBox.Name = "tagToolStripTextBox";
            this.tagToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // itemTxtBox
            // 
            this.itemTxtBox.Location = new System.Drawing.Point(218, 45);
            this.itemTxtBox.Name = "itemTxtBox";
            this.itemTxtBox.Size = new System.Drawing.Size(100, 20);
            this.itemTxtBox.TabIndex = 2;
            // 
            // empTxtBox
            // 
            this.empTxtBox.Location = new System.Drawing.Point(218, 71);
            this.empTxtBox.Name = "empTxtBox";
            this.empTxtBox.Size = new System.Drawing.Size(100, 20);
            this.empTxtBox.TabIndex = 3;
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Location = new System.Drawing.Point(6, 48);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(30, 13);
            this.itemLbl.TabIndex = 9;
            this.itemLbl.Text = "Item:";
            // 
            // empLbl
            // 
            this.empLbl.AutoSize = true;
            this.empLbl.Location = new System.Drawing.Point(6, 74);
            this.empLbl.Name = "empLbl";
            this.empLbl.Size = new System.Drawing.Size(56, 13);
            this.empLbl.TabIndex = 10;
            this.empLbl.Text = "Employee:";
            // 
            // deptLbl
            // 
            this.deptLbl.AutoSize = true;
            this.deptLbl.Location = new System.Drawing.Point(6, 100);
            this.deptLbl.Name = "deptLbl";
            this.deptLbl.Size = new System.Drawing.Size(65, 13);
            this.deptLbl.TabIndex = 10;
            this.deptLbl.Text = "Department:";
            // 
            // snLbl
            // 
            this.snLbl.AutoSize = true;
            this.snLbl.Location = new System.Drawing.Point(6, 126);
            this.snLbl.Name = "snLbl";
            this.snLbl.Size = new System.Drawing.Size(46, 13);
            this.snLbl.TabIndex = 10;
            this.snLbl.Text = "Serial #:";
            // 
            // itemTagLbl
            // 
            this.itemTagLbl.AutoSize = true;
            this.itemTagLbl.Location = new System.Drawing.Point(6, 152);
            this.itemTagLbl.Name = "itemTagLbl";
            this.itemTagLbl.Size = new System.Drawing.Size(62, 13);
            this.itemTagLbl.TabIndex = 10;
            this.itemTagLbl.Text = "Item Tag #:";
            // 
            // installDateLbl
            // 
            this.installDateLbl.AutoSize = true;
            this.installDateLbl.Location = new System.Drawing.Point(6, 181);
            this.installDateLbl.Name = "installDateLbl";
            this.installDateLbl.Size = new System.Drawing.Size(63, 13);
            this.installDateLbl.TabIndex = 10;
            this.installDateLbl.Text = "Install Date:";
            // 
            // deptTxtBox
            // 
            this.deptTxtBox.Location = new System.Drawing.Point(218, 97);
            this.deptTxtBox.Name = "deptTxtBox";
            this.deptTxtBox.Size = new System.Drawing.Size(100, 20);
            this.deptTxtBox.TabIndex = 4;
            // 
            // snTxtBox
            // 
            this.snTxtBox.Location = new System.Drawing.Point(218, 123);
            this.snTxtBox.Name = "snTxtBox";
            this.snTxtBox.Size = new System.Drawing.Size(100, 20);
            this.snTxtBox.TabIndex = 5;
            // 
            // itemTagTxtBox
            // 
            this.itemTagTxtBox.Location = new System.Drawing.Point(218, 149);
            this.itemTagTxtBox.Name = "itemTagTxtBox";
            this.itemTagTxtBox.Size = new System.Drawing.Size(100, 20);
            this.itemTagTxtBox.TabIndex = 6;
            // 
            // installDateTimePicker
            // 
            this.installDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.installDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.installDateTimePicker.Location = new System.Drawing.Point(118, 175);
            this.installDateTimePicker.Name = "installDateTimePicker";
            this.installDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.installDateTimePicker.TabIndex = 7;
            // 
            // replaceDateTimePicker
            // 
            this.replaceDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.replaceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.replaceDateTimePicker.Location = new System.Drawing.Point(118, 201);
            this.replaceDateTimePicker.Name = "replaceDateTimePicker";
            this.replaceDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.replaceDateTimePicker.TabIndex = 8;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(118, 234);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(118, 47);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(62, 17);
            this.activeCheckBox.TabIndex = 1;
            this.activeCheckBox.Text = "Active?";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(9, 234);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 9;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(218, 19);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.ReadOnly = true;
            this.idTextbox.Size = new System.Drawing.Size(100, 20);
            this.idTextbox.TabIndex = 0;
            // 
            // replaceDate
            // 
            this.replaceDate.AutoSize = true;
            this.replaceDate.Location = new System.Drawing.Point(6, 207);
            this.replaceDate.Name = "replaceDate";
            this.replaceDate.Size = new System.Drawing.Size(99, 13);
            this.replaceDate.TabIndex = 10;
            this.replaceDate.Text = "Replacement Date:";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(6, 22);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(21, 13);
            this.idLbl.TabIndex = 0;
            this.idLbl.Text = "ID:";
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.exportButton);
            this.inputGroupBox.Controls.Add(this.notesTextbox);
            this.inputGroupBox.Controls.Add(this.clearBtn);
            this.inputGroupBox.Controls.Add(this.notesLbl);
            this.inputGroupBox.Controls.Add(this.idLbl);
            this.inputGroupBox.Controls.Add(this.exitButton);
            this.inputGroupBox.Controls.Add(this.idTextbox);
            this.inputGroupBox.Controls.Add(this.updateBtn);
            this.inputGroupBox.Controls.Add(this.insertBtn);
            this.inputGroupBox.Controls.Add(this.activeCheckBox);
            this.inputGroupBox.Controls.Add(this.itemTxtBox);
            this.inputGroupBox.Controls.Add(this.empTxtBox);
            this.inputGroupBox.Controls.Add(this.deptTxtBox);
            this.inputGroupBox.Controls.Add(this.replaceDate);
            this.inputGroupBox.Controls.Add(this.replaceDateTimePicker);
            this.inputGroupBox.Controls.Add(this.installDateLbl);
            this.inputGroupBox.Controls.Add(this.snTxtBox);
            this.inputGroupBox.Controls.Add(this.itemTagLbl);
            this.inputGroupBox.Controls.Add(this.installDateTimePicker);
            this.inputGroupBox.Controls.Add(this.snLbl);
            this.inputGroupBox.Controls.Add(this.itemTagTxtBox);
            this.inputGroupBox.Controls.Add(this.deptLbl);
            this.inputGroupBox.Controls.Add(this.itemLbl);
            this.inputGroupBox.Controls.Add(this.empLbl);
            this.inputGroupBox.Location = new System.Drawing.Point(10, 517);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(1054, 266);
            this.inputGroupBox.TabIndex = 21;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(968, 197);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 13;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // notesTextbox
            // 
            this.notesTextbox.Location = new System.Drawing.Point(407, 18);
            this.notesTextbox.MaxLength = 1000;
            this.notesTextbox.Multiline = true;
            this.notesTextbox.Name = "notesTextbox";
            this.notesTextbox.Size = new System.Drawing.Size(528, 239);
            this.notesTextbox.TabIndex = 12;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(243, 234);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // notesLbl
            // 
            this.notesLbl.AutoSize = true;
            this.notesLbl.Location = new System.Drawing.Point(346, 22);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(38, 13);
            this.notesLbl.TabIndex = 9;
            this.notesLbl.Text = "Notes:";
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1074, 785);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.inventoryDataGridView);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Inventory Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private InventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private InventoryDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByEmpToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.TextBox itemTxtBox;
        private System.Windows.Forms.TextBox empTxtBox;
        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.Label empLbl;
        private System.Windows.Forms.Label deptLbl;
        private System.Windows.Forms.Label snLbl;
        private System.Windows.Forms.Label itemTagLbl;
        private System.Windows.Forms.Label installDateLbl;
        private System.Windows.Forms.TextBox deptTxtBox;
        private System.Windows.Forms.TextBox snTxtBox;
        private System.Windows.Forms.TextBox itemTagTxtBox;
        private System.Windows.Forms.DateTimePicker installDateTimePicker;
        private System.Windows.Forms.DateTimePicker replaceDateTimePicker;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn replaceByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewDeleteButton;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.Label replaceDate;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox notesTextbox;
        private System.Windows.Forms.Label notesLbl;
        private System.Windows.Forms.ToolStripComboBox deptComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel deptToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox empToolStripTextBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tagToolStripButton;
        private System.Windows.Forms.ToolStripTextBox tagToolStripTextBox;
    }
}

