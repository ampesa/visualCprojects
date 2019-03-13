namespace RunnerManager1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabRunnerManager = new System.Windows.Forms.TabControl();
            this.tabAddRunner = new System.Windows.Forms.TabPage();
            this.btnSaveRunner = new System.Windows.Forms.Button();
            this.gbRegistration = new System.Windows.Forms.GroupBox();
            this.numUpDownRecord = new System.Windows.Forms.NumericUpDown();
            this.lbTshirtSize = new System.Windows.Forms.ListBox();
            this.tbTshirtName = new System.Windows.Forms.TextBox();
            this.lblInsertDate = new System.Windows.Forms.Label();
            this.dtpInsertDate = new System.Windows.Forms.DateTimePicker();
            this.lblRecord = new System.Windows.Forms.Label();
            this.cbSendNews = new System.Windows.Forms.CheckBox();
            this.cbNonProfit = new System.Windows.Forms.CheckBox();
            this.cbCertificatedRecord = new System.Windows.Forms.CheckBox();
            this.lblTshirtSize = new System.Windows.Forms.Label();
            this.lblTshirtName = new System.Windows.Forms.Label();
            this.gbContactData = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.gbPersonalData = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.tbFamilyName2 = new System.Windows.Forms.TextBox();
            this.tbFamilyName1 = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbIdNumber = new System.Windows.Forms.TextBox();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFamilyName1 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblFamilyName2 = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.tabSearchEdit = new System.Windows.Forms.TabPage();
            this.btDelete = new System.Windows.Forms.Button();
            this.dgvSearchEditResult = new System.Windows.Forms.DataGridView();
            this.btSaveEdited = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbFamilyNameSearch = new System.Windows.Forms.TextBox();
            this.tbNameSearch = new System.Windows.Forms.TextBox();
            this.tbIdSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabListRunners = new System.Windows.Forms.TabPage();
            this.lbTshirtSizeSelecction = new System.Windows.Forms.ListBox();
            this.lbAgeRangeSelection = new System.Windows.Forms.ListBox();
            this.lbGenderSelection = new System.Windows.Forms.ListBox();
            this.lblListSelector = new System.Windows.Forms.Label();
            this.lblListResults = new System.Windows.Forms.Label();
            this.dgvListRunners = new System.Windows.Forms.DataGridView();
            this.btListRunners = new System.Windows.Forms.Button();
            this.lbListRunners = new System.Windows.Forms.ListBox();
            this.runnersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.runnersDataSet = new RunnerManager1.RunnersDataSet();
            this.runnersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.runnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.runnersTableAdapter = new RunnerManager1.RunnersDataSetTableAdapters.RunnersTableAdapter();
            this.lblExamen = new System.Windows.Forms.Label();
            this.tbExamenDI = new System.Windows.Forms.TextBox();
            this.tabRunnerManager.SuspendLayout();
            this.tabAddRunner.SuspendLayout();
            this.gbRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRecord)).BeginInit();
            this.gbContactData.SuspendLayout();
            this.gbPersonalData.SuspendLayout();
            this.tabSearchEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEditResult)).BeginInit();
            this.tabListRunners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRunners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRunnerManager
            // 
            this.tabRunnerManager.Controls.Add(this.tabAddRunner);
            this.tabRunnerManager.Controls.Add(this.tabSearchEdit);
            this.tabRunnerManager.Controls.Add(this.tabListRunners);
            this.tabRunnerManager.Location = new System.Drawing.Point(12, 14);
            this.tabRunnerManager.Name = "tabRunnerManager";
            this.tabRunnerManager.SelectedIndex = 0;
            this.tabRunnerManager.Size = new System.Drawing.Size(770, 493);
            this.tabRunnerManager.TabIndex = 0;
            // 
            // tabAddRunner
            // 
            this.tabAddRunner.Controls.Add(this.tbExamenDI);
            this.tabAddRunner.Controls.Add(this.lblExamen);
            this.tabAddRunner.Controls.Add(this.btnSaveRunner);
            this.tabAddRunner.Controls.Add(this.gbRegistration);
            this.tabAddRunner.Controls.Add(this.gbContactData);
            this.tabAddRunner.Controls.Add(this.gbPersonalData);
            this.tabAddRunner.Location = new System.Drawing.Point(4, 22);
            this.tabAddRunner.Name = "tabAddRunner";
            this.tabAddRunner.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddRunner.Size = new System.Drawing.Size(762, 467);
            this.tabAddRunner.TabIndex = 0;
            this.tabAddRunner.Text = "Añadir Runner";
            this.tabAddRunner.UseVisualStyleBackColor = true;
            // 
            // btnSaveRunner
            // 
            this.btnSaveRunner.Location = new System.Drawing.Point(498, 362);
            this.btnSaveRunner.Name = "btnSaveRunner";
            this.btnSaveRunner.Size = new System.Drawing.Size(158, 35);
            this.btnSaveRunner.TabIndex = 23;
            this.btnSaveRunner.Text = "Registrar Runner";
            this.btnSaveRunner.UseVisualStyleBackColor = true;
            this.btnSaveRunner.Click += new System.EventHandler(this.BtnSaveRunner_Click);
            // 
            // gbRegistration
            // 
            this.gbRegistration.Controls.Add(this.numUpDownRecord);
            this.gbRegistration.Controls.Add(this.lbTshirtSize);
            this.gbRegistration.Controls.Add(this.tbTshirtName);
            this.gbRegistration.Controls.Add(this.lblInsertDate);
            this.gbRegistration.Controls.Add(this.dtpInsertDate);
            this.gbRegistration.Controls.Add(this.lblRecord);
            this.gbRegistration.Controls.Add(this.cbSendNews);
            this.gbRegistration.Controls.Add(this.cbNonProfit);
            this.gbRegistration.Controls.Add(this.cbCertificatedRecord);
            this.gbRegistration.Controls.Add(this.lblTshirtSize);
            this.gbRegistration.Controls.Add(this.lblTshirtName);
            this.gbRegistration.Location = new System.Drawing.Point(393, 32);
            this.gbRegistration.Name = "gbRegistration";
            this.gbRegistration.Size = new System.Drawing.Size(340, 282);
            this.gbRegistration.TabIndex = 22;
            this.gbRegistration.TabStop = false;
            this.gbRegistration.Text = "Datos de la Inscripción";
            // 
            // numUpDownRecord
            // 
            this.numUpDownRecord.Location = new System.Drawing.Point(105, 86);
            this.numUpDownRecord.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numUpDownRecord.Name = "numUpDownRecord";
            this.numUpDownRecord.Size = new System.Drawing.Size(56, 20);
            this.numUpDownRecord.TabIndex = 26;
            // 
            // lbTshirtSize
            // 
            this.lbTshirtSize.FormattingEnabled = true;
            this.lbTshirtSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.lbTshirtSize.Location = new System.Drawing.Point(10, 192);
            this.lbTshirtSize.Name = "lbTshirtSize";
            this.lbTshirtSize.Size = new System.Drawing.Size(120, 69);
            this.lbTshirtSize.TabIndex = 24;
            // 
            // tbTshirtName
            // 
            this.tbTshirtName.Location = new System.Drawing.Point(115, 136);
            this.tbTshirtName.MaxLength = 15;
            this.tbTshirtName.Name = "tbTshirtName";
            this.tbTshirtName.Size = new System.Drawing.Size(198, 20);
            this.tbTshirtName.TabIndex = 25;
            // 
            // lblInsertDate
            // 
            this.lblInsertDate.AutoSize = true;
            this.lblInsertDate.Location = new System.Drawing.Point(6, 29);
            this.lblInsertDate.Name = "lblInsertDate";
            this.lblInsertDate.Size = new System.Drawing.Size(91, 13);
            this.lblInsertDate.TabIndex = 1;
            this.lblInsertDate.Text = "Fecha Inscripción";
            // 
            // dtpInsertDate
            // 
            this.dtpInsertDate.Enabled = false;
            this.dtpInsertDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInsertDate.Location = new System.Drawing.Point(105, 26);
            this.dtpInsertDate.MaxDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpInsertDate.MinDate = new System.DateTime(2019, 1, 22, 0, 0, 0, 0);
            this.dtpInsertDate.Name = "dtpInsertDate";
            this.dtpInsertDate.Size = new System.Drawing.Size(107, 20);
            this.dtpInsertDate.TabIndex = 16;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(7, 88);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(79, 13);
            this.lblRecord.TabIndex = 8;
            this.lblRecord.Text = "Marca Habitual";
            // 
            // cbSendNews
            // 
            this.cbSendNews.AutoSize = true;
            this.cbSendNews.Location = new System.Drawing.Point(213, 244);
            this.cbSendNews.Name = "cbSendNews";
            this.cbSendNews.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbSendNews.Size = new System.Drawing.Size(100, 17);
            this.cbSendNews.TabIndex = 18;
            this.cbSendNews.Text = "Recibir Noticias";
            this.cbSendNews.UseVisualStyleBackColor = true;
            // 
            // cbNonProfit
            // 
            this.cbNonProfit.AutoSize = true;
            this.cbNonProfit.Location = new System.Drawing.Point(193, 197);
            this.cbNonProfit.Name = "cbNonProfit";
            this.cbNonProfit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbNonProfit.Size = new System.Drawing.Size(120, 17);
            this.cbNonProfit.TabIndex = 19;
            this.cbNonProfit.Text = "Inscripción Solidaria";
            this.cbNonProfit.UseVisualStyleBackColor = true;
            // 
            // cbCertificatedRecord
            // 
            this.cbCertificatedRecord.AutoSize = true;
            this.cbCertificatedRecord.Location = new System.Drawing.Point(203, 87);
            this.cbCertificatedRecord.Name = "cbCertificatedRecord";
            this.cbCertificatedRecord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCertificatedRecord.Size = new System.Drawing.Size(110, 17);
            this.cbCertificatedRecord.TabIndex = 15;
            this.cbCertificatedRecord.Text = "Marca Acreditada";
            this.cbCertificatedRecord.UseVisualStyleBackColor = true;
            // 
            // lblTshirtSize
            // 
            this.lblTshirtSize.AutoSize = true;
            this.lblTshirtSize.Location = new System.Drawing.Point(7, 176);
            this.lblTshirtSize.Name = "lblTshirtSize";
            this.lblTshirtSize.Size = new System.Drawing.Size(30, 13);
            this.lblTshirtSize.TabIndex = 11;
            this.lblTshirtSize.Text = "Talla";
            // 
            // lblTshirtName
            // 
            this.lblTshirtName.AutoSize = true;
            this.lblTshirtName.Location = new System.Drawing.Point(7, 139);
            this.lblTshirtName.Name = "lblTshirtName";
            this.lblTshirtName.Size = new System.Drawing.Size(90, 13);
            this.lblTshirtName.TabIndex = 12;
            this.lblTshirtName.Text = "Nombre Camiseta";
            // 
            // gbContactData
            // 
            this.gbContactData.Controls.Add(this.tbEmail);
            this.gbContactData.Controls.Add(this.tbTelefone);
            this.gbContactData.Controls.Add(this.tbZipCode);
            this.gbContactData.Controls.Add(this.lblZipCode);
            this.gbContactData.Controls.Add(this.lblEmail);
            this.gbContactData.Controls.Add(this.lblTelefone);
            this.gbContactData.Location = new System.Drawing.Point(30, 329);
            this.gbContactData.Name = "gbContactData";
            this.gbContactData.Size = new System.Drawing.Size(337, 103);
            this.gbContactData.TabIndex = 21;
            this.gbContactData.TabStop = false;
            this.gbContactData.Text = "Datos de Contacto";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(61, 65);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(257, 20);
            this.tbEmail.TabIndex = 25;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(61, 30);
            this.tbTelefone.MaxLength = 9;
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(90, 20);
            this.tbTelefone.TabIndex = 27;
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(246, 30);
            this.tbZipCode.MaxLength = 5;
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(72, 20);
            this.tbZipCode.TabIndex = 26;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(159, 33);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(72, 13);
            this.lblZipCode.TabIndex = 7;
            this.lblZipCode.Text = "Código Postal";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 33);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Teléfono";
            // 
            // gbPersonalData
            // 
            this.gbPersonalData.Controls.Add(this.rbMale);
            this.gbPersonalData.Controls.Add(this.rbFemale);
            this.gbPersonalData.Controls.Add(this.tbFamilyName2);
            this.gbPersonalData.Controls.Add(this.tbFamilyName1);
            this.gbPersonalData.Controls.Add(this.tbName);
            this.gbPersonalData.Controls.Add(this.tbIdNumber);
            this.gbPersonalData.Controls.Add(this.lblIdNumber);
            this.gbPersonalData.Controls.Add(this.lblName);
            this.gbPersonalData.Controls.Add(this.lblFamilyName1);
            this.gbPersonalData.Controls.Add(this.dtpBirthDate);
            this.gbPersonalData.Controls.Add(this.lblFamilyName2);
            this.gbPersonalData.Controls.Add(this.lblBirthDate);
            this.gbPersonalData.Location = new System.Drawing.Point(30, 32);
            this.gbPersonalData.Name = "gbPersonalData";
            this.gbPersonalData.Size = new System.Drawing.Size(337, 282);
            this.gbPersonalData.TabIndex = 20;
            this.gbPersonalData.TabStop = false;
            this.gbPersonalData.Text = "Datos Personales";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(176, 243);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(62, 17);
            this.rbMale.TabIndex = 24;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Hombre";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.RbMale_CheckedChanged);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(84, 243);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(51, 17);
            this.rbFemale.TabIndex = 22;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Mujer";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.RbFemale_CheckedChanged);
            // 
            // tbFamilyName2
            // 
            this.tbFamilyName2.Location = new System.Drawing.Point(120, 152);
            this.tbFamilyName2.Name = "tbFamilyName2";
            this.tbFamilyName2.Size = new System.Drawing.Size(198, 20);
            this.tbFamilyName2.TabIndex = 21;
            // 
            // tbFamilyName1
            // 
            this.tbFamilyName1.Location = new System.Drawing.Point(120, 117);
            this.tbFamilyName1.Name = "tbFamilyName1";
            this.tbFamilyName1.Size = new System.Drawing.Size(198, 20);
            this.tbFamilyName1.TabIndex = 20;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(120, 75);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(198, 20);
            this.tbName.TabIndex = 19;
            // 
            // tbIdNumber
            // 
            this.tbIdNumber.BackColor = System.Drawing.SystemColors.Window;
            this.tbIdNumber.Location = new System.Drawing.Point(120, 38);
            this.tbIdNumber.MaxLength = 9;
            this.tbIdNumber.Name = "tbIdNumber";
            this.tbIdNumber.Size = new System.Drawing.Size(108, 20);
            this.tbIdNumber.TabIndex = 18;
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(6, 41);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(49, 13);
            this.lblIdNumber.TabIndex = 0;
            this.lblIdNumber.Text = "DNI/NIE";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre";
            // 
            // lblFamilyName1
            // 
            this.lblFamilyName1.AutoSize = true;
            this.lblFamilyName1.Location = new System.Drawing.Point(6, 120);
            this.lblFamilyName1.Name = "lblFamilyName1";
            this.lblFamilyName1.Size = new System.Drawing.Size(76, 13);
            this.lblFamilyName1.TabIndex = 3;
            this.lblFamilyName1.Text = "Primer Apellido";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(171, 189);
            this.dtpBirthDate.MaxDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpBirthDate.Size = new System.Drawing.Size(102, 20);
            this.dtpBirthDate.TabIndex = 17;
            this.dtpBirthDate.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // lblFamilyName2
            // 
            this.lblFamilyName2.AutoSize = true;
            this.lblFamilyName2.Location = new System.Drawing.Point(6, 155);
            this.lblFamilyName2.Name = "lblFamilyName2";
            this.lblFamilyName2.Size = new System.Drawing.Size(90, 13);
            this.lblFamilyName2.TabIndex = 4;
            this.lblFamilyName2.Text = "Segundo Apellido";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(43, 192);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(108, 13);
            this.lblBirthDate.TabIndex = 7;
            this.lblBirthDate.Text = "Fecha de Nacimiento";
            // 
            // tabSearchEdit
            // 
            this.tabSearchEdit.Controls.Add(this.btDelete);
            this.tabSearchEdit.Controls.Add(this.dgvSearchEditResult);
            this.tabSearchEdit.Controls.Add(this.btSaveEdited);
            this.tabSearchEdit.Controls.Add(this.btSearch);
            this.tabSearchEdit.Controls.Add(this.tbFamilyNameSearch);
            this.tabSearchEdit.Controls.Add(this.tbNameSearch);
            this.tabSearchEdit.Controls.Add(this.tbIdSearch);
            this.tabSearchEdit.Controls.Add(this.label1);
            this.tabSearchEdit.Controls.Add(this.label2);
            this.tabSearchEdit.Controls.Add(this.label3);
            this.tabSearchEdit.Location = new System.Drawing.Point(4, 22);
            this.tabSearchEdit.Name = "tabSearchEdit";
            this.tabSearchEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchEdit.Size = new System.Drawing.Size(762, 467);
            this.tabSearchEdit.TabIndex = 1;
            this.tabSearchEdit.Text = "Buscar y Editar";
            this.tabSearchEdit.UseVisualStyleBackColor = true;
            this.tabSearchEdit.Click += new System.EventHandler(this.TabSearchEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(518, 139);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(167, 39);
            this.btDelete.TabIndex = 30;
            this.btDelete.Text = "Eliminar";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // dgvSearchEditResult
            // 
            this.dgvSearchEditResult.AllowUserToAddRows = false;
            this.dgvSearchEditResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchEditResult.Location = new System.Drawing.Point(28, 202);
            this.dgvSearchEditResult.Name = "dgvSearchEditResult";
            this.dgvSearchEditResult.Size = new System.Drawing.Size(700, 189);
            this.dgvSearchEditResult.TabIndex = 29;
            // 
            // btSaveEdited
            // 
            this.btSaveEdited.Location = new System.Drawing.Point(518, 80);
            this.btSaveEdited.Name = "btSaveEdited";
            this.btSaveEdited.Size = new System.Drawing.Size(167, 39);
            this.btSaveEdited.TabIndex = 28;
            this.btSaveEdited.Text = "Guardar Cambios";
            this.btSaveEdited.UseVisualStyleBackColor = true;
            this.btSaveEdited.Click += new System.EventHandler(this.BtSaveEdited_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(518, 21);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(167, 39);
            this.btSearch.TabIndex = 27;
            this.btSearch.Text = "Buscar Corredor";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // tbFamilyNameSearch
            // 
            this.tbFamilyNameSearch.Location = new System.Drawing.Point(185, 119);
            this.tbFamilyNameSearch.Name = "tbFamilyNameSearch";
            this.tbFamilyNameSearch.Size = new System.Drawing.Size(198, 20);
            this.tbFamilyNameSearch.TabIndex = 26;
            // 
            // tbNameSearch
            // 
            this.tbNameSearch.Location = new System.Drawing.Point(185, 77);
            this.tbNameSearch.Name = "tbNameSearch";
            this.tbNameSearch.Size = new System.Drawing.Size(198, 20);
            this.tbNameSearch.TabIndex = 25;
            // 
            // tbIdSearch
            // 
            this.tbIdSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbIdSearch.Location = new System.Drawing.Point(185, 40);
            this.tbIdSearch.MaxLength = 9;
            this.tbIdSearch.Name = "tbIdSearch";
            this.tbIdSearch.Size = new System.Drawing.Size(108, 20);
            this.tbIdSearch.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "DNI/NIE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Primer Apellido";
            // 
            // tabListRunners
            // 
            this.tabListRunners.Controls.Add(this.lbTshirtSizeSelecction);
            this.tabListRunners.Controls.Add(this.lbAgeRangeSelection);
            this.tabListRunners.Controls.Add(this.lbGenderSelection);
            this.tabListRunners.Controls.Add(this.lblListSelector);
            this.tabListRunners.Controls.Add(this.lblListResults);
            this.tabListRunners.Controls.Add(this.dgvListRunners);
            this.tabListRunners.Controls.Add(this.btListRunners);
            this.tabListRunners.Controls.Add(this.lbListRunners);
            this.tabListRunners.Location = new System.Drawing.Point(4, 22);
            this.tabListRunners.Name = "tabListRunners";
            this.tabListRunners.Size = new System.Drawing.Size(762, 467);
            this.tabListRunners.TabIndex = 2;
            this.tabListRunners.Text = "Listar Runners";
            this.tabListRunners.UseVisualStyleBackColor = true;
            // 
            // lbTshirtSizeSelecction
            // 
            this.lbTshirtSizeSelecction.FormattingEnabled = true;
            this.lbTshirtSizeSelecction.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.lbTshirtSizeSelecction.Location = new System.Drawing.Point(306, 27);
            this.lbTshirtSizeSelecction.Name = "lbTshirtSizeSelecction";
            this.lbTshirtSizeSelecction.Size = new System.Drawing.Size(120, 95);
            this.lbTshirtSizeSelecction.TabIndex = 7;
            this.lbTshirtSizeSelecction.Visible = false;
            // 
            // lbAgeRangeSelection
            // 
            this.lbAgeRangeSelection.FormattingEnabled = true;
            this.lbAgeRangeSelection.Items.AddRange(new object[] {
            "Menores de 25 años",
            "Entre 25 y 35 años",
            "Entre 35 y 45 años",
            "Mayores de 45 años"});
            this.lbAgeRangeSelection.Location = new System.Drawing.Point(306, 27);
            this.lbAgeRangeSelection.Name = "lbAgeRangeSelection";
            this.lbAgeRangeSelection.Size = new System.Drawing.Size(120, 82);
            this.lbAgeRangeSelection.TabIndex = 6;
            this.lbAgeRangeSelection.Visible = false;
            // 
            // lbGenderSelection
            // 
            this.lbGenderSelection.FormattingEnabled = true;
            this.lbGenderSelection.Items.AddRange(new object[] {
            "hombre",
            "mujer"});
            this.lbGenderSelection.Location = new System.Drawing.Point(306, 27);
            this.lbGenderSelection.Name = "lbGenderSelection";
            this.lbGenderSelection.Size = new System.Drawing.Size(120, 82);
            this.lbGenderSelection.TabIndex = 5;
            this.lbGenderSelection.Visible = false;
            // 
            // lblListSelector
            // 
            this.lblListSelector.AutoSize = true;
            this.lblListSelector.Location = new System.Drawing.Point(23, 11);
            this.lblListSelector.Name = "lblListSelector";
            this.lblListSelector.Size = new System.Drawing.Size(121, 13);
            this.lblListSelector.TabIndex = 4;
            this.lblListSelector.Text = "Seleccion el tipo de lista";
            // 
            // lblListResults
            // 
            this.lblListResults.AutoSize = true;
            this.lblListResults.Location = new System.Drawing.Point(23, 130);
            this.lblListResults.Name = "lblListResults";
            this.lblListResults.Size = new System.Drawing.Size(63, 13);
            this.lblListResults.TabIndex = 3;
            this.lblListResults.Text = "Resultados:";
            // 
            // dgvListRunners
            // 
            this.dgvListRunners.AllowUserToAddRows = false;
            this.dgvListRunners.AllowUserToDeleteRows = false;
            this.dgvListRunners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListRunners.Location = new System.Drawing.Point(19, 146);
            this.dgvListRunners.Name = "dgvListRunners";
            this.dgvListRunners.ReadOnly = true;
            this.dgvListRunners.Size = new System.Drawing.Size(722, 301);
            this.dgvListRunners.TabIndex = 2;
            // 
            // btListRunners
            // 
            this.btListRunners.Location = new System.Drawing.Point(538, 51);
            this.btListRunners.Name = "btListRunners";
            this.btListRunners.Size = new System.Drawing.Size(110, 41);
            this.btListRunners.TabIndex = 1;
            this.btListRunners.Text = "Listar Runners";
            this.btListRunners.UseVisualStyleBackColor = true;
            this.btListRunners.Click += new System.EventHandler(this.BtListRunners_Click);
            // 
            // lbListRunners
            // 
            this.lbListRunners.FormattingEnabled = true;
            this.lbListRunners.Items.AddRange(new object[] {
            "Todos los Participantes",
            "Ver participantes por género",
            "Ver participantes por rango de edad",
            "Ver participantes por talla de camiseta",
            "Ver participantes por tiempo estimado de finalización"});
            this.lbListRunners.Location = new System.Drawing.Point(19, 27);
            this.lbListRunners.Name = "lbListRunners";
            this.lbListRunners.Size = new System.Drawing.Size(258, 82);
            this.lbListRunners.TabIndex = 0;
            this.lbListRunners.SelectedIndexChanged += new System.EventHandler(this.LbListRunners_SelectedIndexChanged);
            // 
            // runnersBindingSource2
            // 
            this.runnersBindingSource2.DataMember = "Runners";
            this.runnersBindingSource2.DataSource = this.runnersDataSet;
            // 
            // runnersDataSet
            // 
            this.runnersDataSet.DataSetName = "RunnersDataSet";
            this.runnersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // runnersBindingSource1
            // 
            this.runnersBindingSource1.DataMember = "Runners";
            this.runnersBindingSource1.DataSource = this.runnersDataSet;
            // 
            // runnersBindingSource
            // 
            this.runnersBindingSource.DataMember = "Runners";
            this.runnersBindingSource.DataSource = this.runnersDataSet;
            // 
            // runnersTableAdapter
            // 
            this.runnersTableAdapter.ClearBeforeFill = true;
            // 
            // lblExamen
            // 
            this.lblExamen.AutoSize = true;
            this.lblExamen.Location = new System.Drawing.Point(403, 329);
            this.lblExamen.Name = "lblExamen";
            this.lblExamen.Size = new System.Drawing.Size(85, 13);
            this.lblExamen.TabIndex = 24;
            this.lblExamen.Text = "Nota Examen DI";
            // 
            // tbExamenDI
            // 
            this.tbExamenDI.Location = new System.Drawing.Point(494, 326);
            this.tbExamenDI.Name = "tbExamenDI";
            this.tbExamenDI.Size = new System.Drawing.Size(100, 20);
            this.tbExamenDI.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.tabRunnerManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Runner Manager v1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabRunnerManager.ResumeLayout(false);
            this.tabAddRunner.ResumeLayout(false);
            this.tabAddRunner.PerformLayout();
            this.gbRegistration.ResumeLayout(false);
            this.gbRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRecord)).EndInit();
            this.gbContactData.ResumeLayout(false);
            this.gbContactData.PerformLayout();
            this.gbPersonalData.ResumeLayout(false);
            this.gbPersonalData.PerformLayout();
            this.tabSearchEdit.ResumeLayout(false);
            this.tabSearchEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEditResult)).EndInit();
            this.tabListRunners.ResumeLayout(false);
            this.tabListRunners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRunners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.runnersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRunnerManager;
        private System.Windows.Forms.TabPage tabAddRunner;
        private System.Windows.Forms.TabPage tabSearchEdit;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFamilyName2;
        private System.Windows.Forms.Label lblFamilyName1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInsertDate;
        private System.Windows.Forms.Label lblTshirtName;
        private System.Windows.Forms.Label lblTshirtSize;
        private System.Windows.Forms.GroupBox gbRegistration;
        private System.Windows.Forms.DateTimePicker dtpInsertDate;
        private System.Windows.Forms.CheckBox cbSendNews;
        private System.Windows.Forms.CheckBox cbNonProfit;
        private System.Windows.Forms.CheckBox cbCertificatedRecord;
        private System.Windows.Forms.GroupBox gbContactData;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.GroupBox gbPersonalData;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnSaveRunner;
        private System.Windows.Forms.TextBox tbTshirtName;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox tbFamilyName2;
        private System.Windows.Forms.TextBox tbFamilyName1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbIdNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ListBox lbTshirtSize;
        private System.Windows.Forms.NumericUpDown numUpDownRecord;
        private System.Windows.Forms.TabPage tabListRunners;
        private System.Windows.Forms.Label lblListSelector;
        private System.Windows.Forms.Label lblListResults;
        private System.Windows.Forms.DataGridView dgvListRunners;
        private System.Windows.Forms.Button btListRunners;
        private System.Windows.Forms.ListBox lbListRunners;
        private System.Windows.Forms.ListBox lbGenderSelection;
        private System.Windows.Forms.ListBox lbAgeRangeSelection;
        private System.Windows.Forms.ListBox lbTshirtSizeSelecction;
        private System.Windows.Forms.DataGridView dgvSearchEditResult;
        private System.Windows.Forms.Button btSaveEdited;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbFamilyNameSearch;
        private System.Windows.Forms.TextBox tbNameSearch;
        private System.Windows.Forms.TextBox tbIdSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RunnersDataSet runnersDataSet;
        private System.Windows.Forms.BindingSource runnersBindingSource;
        private RunnersDataSetTableAdapters.RunnersTableAdapter runnersTableAdapter;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.BindingSource runnersBindingSource1;
        private System.Windows.Forms.BindingSource runnersBindingSource2;
        private System.Windows.Forms.TextBox tbExamenDI;
        private System.Windows.Forms.Label lblExamen;
    }
}

