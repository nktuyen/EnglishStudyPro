namespace ESPA
{
    partial class frmMain
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
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabPageSystem = new System.Windows.Forms.TabPage();
            this.txtSystem_Date = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lvwSystem = new System.Windows.Forms.ListView();
            this.colNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPIN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSystem_Save = new System.Windows.Forms.Button();
            this.btnSystem_New = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSystem_PIN = new System.Windows.Forms.TextBox();
            this.txtSystem_Desc = new System.Windows.Forms.TextBox();
            this.txtSystem_Version = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSystem_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.btnCategory_Save = new System.Windows.Forms.Button();
            this.btnCategory_New = new System.Windows.Forms.Button();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCategoryTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageClasses = new System.Windows.Forms.TabPage();
            this.btnClass_Save = new System.Windows.Forms.Button();
            this.btnClass_New = new System.Windows.Forms.Button();
            this.lbClasses = new System.Windows.Forms.ListBox();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClassTitle = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageVocabularies = new System.Windows.Forms.TabPage();
            this.lbVocabularies = new System.Windows.Forms.ListBox();
            this.btnVocab_Save = new System.Windows.Forms.Button();
            this.btnVocab_New = new System.Windows.Forms.Button();
            this.txtVocabName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageDictionary = new System.Windows.Forms.TabPage();
            this.tabCtrlMain.SuspendLayout();
            this.tabPageSystem.SuspendLayout();
            this.tabPageCategories.SuspendLayout();
            this.tabPageClasses.SuspendLayout();
            this.tabPageVocabularies.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabPageSystem);
            this.tabCtrlMain.Controls.Add(this.tabPageCategories);
            this.tabCtrlMain.Controls.Add(this.tabPageClasses);
            this.tabCtrlMain.Controls.Add(this.tabPageVocabularies);
            this.tabCtrlMain.Controls.Add(this.tabPageDictionary);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(728, 502);
            this.tabCtrlMain.TabIndex = 0;
            this.tabCtrlMain.SelectedIndexChanged += new System.EventHandler(this.tabCtrlMain_SelectedIndexChanged);
            // 
            // tabPageSystem
            // 
            this.tabPageSystem.Controls.Add(this.txtSystem_Date);
            this.tabPageSystem.Controls.Add(this.label8);
            this.tabPageSystem.Controls.Add(this.lvwSystem);
            this.tabPageSystem.Controls.Add(this.btnSystem_Save);
            this.tabPageSystem.Controls.Add(this.btnSystem_New);
            this.tabPageSystem.Controls.Add(this.label4);
            this.tabPageSystem.Controls.Add(this.label3);
            this.tabPageSystem.Controls.Add(this.txtSystem_PIN);
            this.tabPageSystem.Controls.Add(this.txtSystem_Desc);
            this.tabPageSystem.Controls.Add(this.txtSystem_Version);
            this.tabPageSystem.Controls.Add(this.label2);
            this.tabPageSystem.Controls.Add(this.txtSystem_Name);
            this.tabPageSystem.Controls.Add(this.label1);
            this.tabPageSystem.Location = new System.Drawing.Point(4, 22);
            this.tabPageSystem.Name = "tabPageSystem";
            this.tabPageSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSystem.Size = new System.Drawing.Size(720, 476);
            this.tabPageSystem.TabIndex = 0;
            this.tabPageSystem.Text = "System";
            this.tabPageSystem.UseVisualStyleBackColor = true;
            // 
            // txtSystem_Date
            // 
            this.txtSystem_Date.Location = new System.Drawing.Point(100, 124);
            this.txtSystem_Date.Name = "txtSystem_Date";
            this.txtSystem_Date.ReadOnly = true;
            this.txtSystem_Date.Size = new System.Drawing.Size(300, 20);
            this.txtSystem_Date.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Publish Date:";
            // 
            // lvwSystem
            // 
            this.lvwSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwSystem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNo,
            this.colName,
            this.colVersion,
            this.colDesc,
            this.colPIN,
            this.colDate});
            this.lvwSystem.FullRowSelect = true;
            this.lvwSystem.GridLines = true;
            this.lvwSystem.Location = new System.Drawing.Point(6, 157);
            this.lvwSystem.Name = "lvwSystem";
            this.lvwSystem.ShowItemToolTips = true;
            this.lvwSystem.Size = new System.Drawing.Size(708, 313);
            this.lvwSystem.TabIndex = 7;
            this.lvwSystem.UseCompatibleStateImageBehavior = false;
            this.lvwSystem.View = System.Windows.Forms.View.Details;
            this.lvwSystem.SelectedIndexChanged += new System.EventHandler(this.lvwSystem_SelectedIndexChanged);
            this.lvwSystem.DoubleClick += new System.EventHandler(this.lvwSystem_DoubleClick);
            this.lvwSystem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvwSystem_KeyDown);
            this.lvwSystem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvwSystem_KeyUp);
            // 
            // colNo
            // 
            this.colNo.Text = "#";
            this.colNo.Width = 20;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 128;
            // 
            // colVersion
            // 
            this.colVersion.Text = "Version";
            this.colVersion.Width = 50;
            // 
            // colDesc
            // 
            this.colDesc.Text = "Description";
            this.colDesc.Width = 128;
            // 
            // colPIN
            // 
            this.colPIN.Text = "PIN";
            this.colPIN.Width = 100;
            // 
            // colDate
            // 
            this.colDate.Text = "Publish Date";
            this.colDate.Width = 80;
            // 
            // btnSystem_Save
            // 
            this.btnSystem_Save.Enabled = false;
            this.btnSystem_Save.Location = new System.Drawing.Point(410, 46);
            this.btnSystem_Save.Name = "btnSystem_Save";
            this.btnSystem_Save.Size = new System.Drawing.Size(75, 23);
            this.btnSystem_Save.TabIndex = 5;
            this.btnSystem_Save.Text = "Save";
            this.btnSystem_Save.UseVisualStyleBackColor = true;
            this.btnSystem_Save.Click += new System.EventHandler(this.btnSystem_Save_Click);
            // 
            // btnSystem_New
            // 
            this.btnSystem_New.Location = new System.Drawing.Point(410, 20);
            this.btnSystem_New.Name = "btnSystem_New";
            this.btnSystem_New.Size = new System.Drawing.Size(75, 23);
            this.btnSystem_New.TabIndex = 6;
            this.btnSystem_New.Text = "New";
            this.btnSystem_New.UseVisualStyleBackColor = true;
            this.btnSystem_New.Click += new System.EventHandler(this.btnSystem_New_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "PIN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // txtSystem_PIN
            // 
            this.txtSystem_PIN.Location = new System.Drawing.Point(100, 98);
            this.txtSystem_PIN.Name = "txtSystem_PIN";
            this.txtSystem_PIN.PasswordChar = '*';
            this.txtSystem_PIN.ReadOnly = true;
            this.txtSystem_PIN.Size = new System.Drawing.Size(300, 20);
            this.txtSystem_PIN.TabIndex = 3;
            this.txtSystem_PIN.TextChanged += new System.EventHandler(this.txtSystem_PIN_TextChanged);
            // 
            // txtSystem_Desc
            // 
            this.txtSystem_Desc.Location = new System.Drawing.Point(100, 72);
            this.txtSystem_Desc.Name = "txtSystem_Desc";
            this.txtSystem_Desc.ReadOnly = true;
            this.txtSystem_Desc.Size = new System.Drawing.Size(300, 20);
            this.txtSystem_Desc.TabIndex = 2;
            this.txtSystem_Desc.TextChanged += new System.EventHandler(this.txtSystem_Desc_TextChanged);
            // 
            // txtSystem_Version
            // 
            this.txtSystem_Version.Location = new System.Drawing.Point(100, 46);
            this.txtSystem_Version.Name = "txtSystem_Version";
            this.txtSystem_Version.ReadOnly = true;
            this.txtSystem_Version.Size = new System.Drawing.Size(300, 20);
            this.txtSystem_Version.TabIndex = 1;
            this.txtSystem_Version.TextChanged += new System.EventHandler(this.txtSystem_Version_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version:";
            // 
            // txtSystem_Name
            // 
            this.txtSystem_Name.Location = new System.Drawing.Point(100, 20);
            this.txtSystem_Name.Name = "txtSystem_Name";
            this.txtSystem_Name.ReadOnly = true;
            this.txtSystem_Name.Size = new System.Drawing.Size(300, 20);
            this.txtSystem_Name.TabIndex = 0;
            this.txtSystem_Name.TextChanged += new System.EventHandler(this.txtSystem_Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.Controls.Add(this.txtCategoryID);
            this.tabPageCategories.Controls.Add(this.lbCategories);
            this.tabPageCategories.Controls.Add(this.btnCategory_Save);
            this.tabPageCategories.Controls.Add(this.btnCategory_New);
            this.tabPageCategories.Controls.Add(this.cbCategories);
            this.tabPageCategories.Controls.Add(this.label6);
            this.tabPageCategories.Controls.Add(this.txtCategoryTitle);
            this.tabPageCategories.Controls.Add(this.label7);
            this.tabPageCategories.Controls.Add(this.txtCategoryName);
            this.tabPageCategories.Controls.Add(this.label5);
            this.tabPageCategories.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategories.Size = new System.Drawing.Size(720, 476);
            this.tabPageCategories.TabIndex = 1;
            this.tabPageCategories.Text = "Categories";
            this.tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(11, 68);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(49, 20);
            this.txtCategoryID.TabIndex = 6;
            this.txtCategoryID.Visible = false;
            // 
            // lbCategories
            // 
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.Location = new System.Drawing.Point(7, 102);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(705, 368);
            this.lbCategories.TabIndex = 4;
            this.lbCategories.SelectedIndexChanged += new System.EventHandler(this.lbCategories_SelectedIndexChanged);
            this.lbCategories.DoubleClick += new System.EventHandler(this.lbCategories_DoubleClick);
            this.lbCategories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbCategories_KeyDown);
            // 
            // btnCategory_Save
            // 
            this.btnCategory_Save.Location = new System.Drawing.Point(410, 46);
            this.btnCategory_Save.Name = "btnCategory_Save";
            this.btnCategory_Save.Size = new System.Drawing.Size(75, 23);
            this.btnCategory_Save.TabIndex = 3;
            this.btnCategory_Save.Text = "Save";
            this.btnCategory_Save.UseVisualStyleBackColor = true;
            this.btnCategory_Save.Click += new System.EventHandler(this.btnCategory_Save_Click);
            // 
            // btnCategory_New
            // 
            this.btnCategory_New.Location = new System.Drawing.Point(410, 20);
            this.btnCategory_New.Name = "btnCategory_New";
            this.btnCategory_New.Size = new System.Drawing.Size(75, 23);
            this.btnCategory_New.TabIndex = 0;
            this.btnCategory_New.Text = "New";
            this.btnCategory_New.UseVisualStyleBackColor = true;
            this.btnCategory_New.Click += new System.EventHandler(this.btnCategory_New_Click);
            // 
            // cbCategories
            // 
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.Enabled = false;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(100, 20);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(300, 21);
            this.cbCategories.TabIndex = 1;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Parent:";
            // 
            // txtCategoryTitle
            // 
            this.txtCategoryTitle.Location = new System.Drawing.Point(100, 72);
            this.txtCategoryTitle.Name = "txtCategoryTitle";
            this.txtCategoryTitle.ReadOnly = true;
            this.txtCategoryTitle.Size = new System.Drawing.Size(300, 20);
            this.txtCategoryTitle.TabIndex = 2;
            this.txtCategoryTitle.TextChanged += new System.EventHandler(this.txtCategoryTitle_TextChanged);
            this.txtCategoryTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCategoryTitle_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Title:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(100, 46);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.ReadOnly = true;
            this.txtCategoryName.Size = new System.Drawing.Size(300, 20);
            this.txtCategoryName.TabIndex = 1;
            this.txtCategoryName.TextChanged += new System.EventHandler(this.txtCategoryName_TextChanged);
            this.txtCategoryName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCategoryName_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // tabPageClasses
            // 
            this.tabPageClasses.Controls.Add(this.btnClass_Save);
            this.tabPageClasses.Controls.Add(this.btnClass_New);
            this.tabPageClasses.Controls.Add(this.lbClasses);
            this.tabPageClasses.Controls.Add(this.txtClassId);
            this.tabPageClasses.Controls.Add(this.label10);
            this.tabPageClasses.Controls.Add(this.txtClassTitle);
            this.tabPageClasses.Controls.Add(this.txtClassName);
            this.tabPageClasses.Controls.Add(this.label9);
            this.tabPageClasses.Location = new System.Drawing.Point(4, 22);
            this.tabPageClasses.Name = "tabPageClasses";
            this.tabPageClasses.Size = new System.Drawing.Size(720, 476);
            this.tabPageClasses.TabIndex = 2;
            this.tabPageClasses.Text = "Classes";
            this.tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // btnClass_Save
            // 
            this.btnClass_Save.Enabled = false;
            this.btnClass_Save.Location = new System.Drawing.Point(420, 49);
            this.btnClass_Save.Name = "btnClass_Save";
            this.btnClass_Save.Size = new System.Drawing.Size(75, 23);
            this.btnClass_Save.TabIndex = 3;
            this.btnClass_Save.Text = "Save";
            this.btnClass_Save.UseVisualStyleBackColor = true;
            this.btnClass_Save.Click += new System.EventHandler(this.btnClass_Save_Click);
            // 
            // btnClass_New
            // 
            this.btnClass_New.Location = new System.Drawing.Point(420, 20);
            this.btnClass_New.Name = "btnClass_New";
            this.btnClass_New.Size = new System.Drawing.Size(75, 23);
            this.btnClass_New.TabIndex = 4;
            this.btnClass_New.Text = "New";
            this.btnClass_New.UseVisualStyleBackColor = true;
            this.btnClass_New.Click += new System.EventHandler(this.btnClass_New_Click);
            // 
            // lbClasses
            // 
            this.lbClasses.FormattingEnabled = true;
            this.lbClasses.Location = new System.Drawing.Point(9, 83);
            this.lbClasses.Name = "lbClasses";
            this.lbClasses.Size = new System.Drawing.Size(703, 381);
            this.lbClasses.TabIndex = 5;
            this.lbClasses.SelectedIndexChanged += new System.EventHandler(this.lbClasses_SelectedIndexChanged);
            this.lbClasses.DoubleClick += new System.EventHandler(this.lbClasses_DoubleClick);
            this.lbClasses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbClasses_KeyDown);
            // 
            // txtClassId
            // 
            this.txtClassId.Location = new System.Drawing.Point(9, 35);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(43, 20);
            this.txtClassId.TabIndex = 0;
            this.txtClassId.Text = "0";
            this.txtClassId.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Title:";
            // 
            // txtClassTitle
            // 
            this.txtClassTitle.Location = new System.Drawing.Point(100, 46);
            this.txtClassTitle.Name = "txtClassTitle";
            this.txtClassTitle.ReadOnly = true;
            this.txtClassTitle.Size = new System.Drawing.Size(300, 20);
            this.txtClassTitle.TabIndex = 2;
            this.txtClassTitle.TextChanged += new System.EventHandler(this.txtClassTitle_TextChanged);
            this.txtClassTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtClassTitle_KeyUp);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(100, 20);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.Size = new System.Drawing.Size(300, 20);
            this.txtClassName.TabIndex = 1;
            this.txtClassName.TextChanged += new System.EventHandler(this.txtClassName_TextChanged);
            this.txtClassName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtClassName_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name:";
            // 
            // tabPageVocabularies
            // 
            this.tabPageVocabularies.Controls.Add(this.lbVocabularies);
            this.tabPageVocabularies.Controls.Add(this.btnVocab_Save);
            this.tabPageVocabularies.Controls.Add(this.btnVocab_New);
            this.tabPageVocabularies.Controls.Add(this.txtVocabName);
            this.tabPageVocabularies.Controls.Add(this.label11);
            this.tabPageVocabularies.Location = new System.Drawing.Point(4, 22);
            this.tabPageVocabularies.Name = "tabPageVocabularies";
            this.tabPageVocabularies.Size = new System.Drawing.Size(720, 476);
            this.tabPageVocabularies.TabIndex = 4;
            this.tabPageVocabularies.Text = "Vocabularies";
            this.tabPageVocabularies.UseVisualStyleBackColor = true;
            // 
            // lbVocabularies
            // 
            this.lbVocabularies.FormattingEnabled = true;
            this.lbVocabularies.Location = new System.Drawing.Point(100, 59);
            this.lbVocabularies.Name = "lbVocabularies";
            this.lbVocabularies.Size = new System.Drawing.Size(365, 407);
            this.lbVocabularies.TabIndex = 3;
            this.lbVocabularies.SelectedIndexChanged += new System.EventHandler(this.lbVocabularies_SelectedIndexChanged);
            this.lbVocabularies.DoubleClick += new System.EventHandler(this.lbVocabularies_DoubleClick);
            this.lbVocabularies.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbVocabularies_KeyDown);
            this.lbVocabularies.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbVocabularies_KeyUp);
            // 
            // btnVocab_Save
            // 
            this.btnVocab_Save.Location = new System.Drawing.Point(390, 19);
            this.btnVocab_Save.Name = "btnVocab_Save";
            this.btnVocab_Save.Size = new System.Drawing.Size(75, 23);
            this.btnVocab_Save.TabIndex = 2;
            this.btnVocab_Save.Text = "Save";
            this.btnVocab_Save.UseVisualStyleBackColor = true;
            this.btnVocab_Save.Click += new System.EventHandler(this.btnVocab_Save_Click);
            // 
            // btnVocab_New
            // 
            this.btnVocab_New.Location = new System.Drawing.Point(310, 19);
            this.btnVocab_New.Name = "btnVocab_New";
            this.btnVocab_New.Size = new System.Drawing.Size(75, 23);
            this.btnVocab_New.TabIndex = 0;
            this.btnVocab_New.Text = "New";
            this.btnVocab_New.UseVisualStyleBackColor = true;
            this.btnVocab_New.Click += new System.EventHandler(this.btnVocab_New_Click);
            // 
            // txtVocabName
            // 
            this.txtVocabName.Location = new System.Drawing.Point(100, 20);
            this.txtVocabName.Name = "txtVocabName";
            this.txtVocabName.ReadOnly = true;
            this.txtVocabName.Size = new System.Drawing.Size(200, 20);
            this.txtVocabName.TabIndex = 1;
            this.txtVocabName.TextChanged += new System.EventHandler(this.txtVocabName_TextChanged);
            this.txtVocabName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVocabName_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Name:";
            // 
            // tabPageDictionary
            // 
            this.tabPageDictionary.Location = new System.Drawing.Point(4, 22);
            this.tabPageDictionary.Name = "tabPageDictionary";
            this.tabPageDictionary.Size = new System.Drawing.Size(720, 476);
            this.tabPageDictionary.TabIndex = 5;
            this.tabPageDictionary.Text = "Dictionary";
            this.tabPageDictionary.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 502);
            this.Controls.Add(this.tabCtrlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabCtrlMain.ResumeLayout(false);
            this.tabPageSystem.ResumeLayout(false);
            this.tabPageSystem.PerformLayout();
            this.tabPageCategories.ResumeLayout(false);
            this.tabPageCategories.PerformLayout();
            this.tabPageClasses.ResumeLayout(false);
            this.tabPageClasses.PerformLayout();
            this.tabPageVocabularies.ResumeLayout(false);
            this.tabPageVocabularies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private global::System.Windows.Forms.TabControl tabCtrlMain;
        private global::System.Windows.Forms.TabPage tabPageSystem;
        private global::System.Windows.Forms.TabPage tabPageCategories;
        private global::System.Windows.Forms.TabPage tabPageClasses;
        private global::System.Windows.Forms.TabPage tabPageVocabularies;
        private global::System.Windows.Forms.TabPage tabPageDictionary;
        private global::System.Windows.Forms.TextBox txtSystem_Version;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.TextBox txtSystem_Name;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.Label label4;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.TextBox txtSystem_PIN;
        private global::System.Windows.Forms.TextBox txtSystem_Desc;
        private global::System.Windows.Forms.Button btnSystem_Save;
        private global::System.Windows.Forms.Button btnSystem_New;
        private System.Windows.Forms.ListView lvwSystem;
        private System.Windows.Forms.ColumnHeader colNo;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colVersion;
        private System.Windows.Forms.ColumnHeader colDesc;
        private System.Windows.Forms.ColumnHeader colPIN;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCategoryTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCategory_New;
        private System.Windows.Forms.Button btnCategory_Save;
        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSystem_Date;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtClassTitle;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.ListBox lbClasses;
        private System.Windows.Forms.Button btnClass_Save;
        private System.Windows.Forms.Button btnClass_New;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVocab_Save;
        private System.Windows.Forms.Button btnVocab_New;
        private System.Windows.Forms.TextBox txtVocabName;
        private System.Windows.Forms.ListBox lbVocabularies;
    }
}

