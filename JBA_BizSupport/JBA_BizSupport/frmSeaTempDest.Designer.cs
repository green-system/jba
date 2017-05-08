namespace JBA_BizSupport
{
    partial class frmSeaTempDest
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
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jBADBDataSet = new JBA_BizSupport.JBADBDataSet();
            this.gADATEMPPAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gADA_TEMP_PAYTableAdapter = new JBA_BizSupport.JBADBDataSetTableAdapters.GADA_TEMP_PAYTableAdapter();
            this.rEQUESTPERSONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMPPAYNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUSINESSCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUSINESSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMPPAYPURPOSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMPPAYPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMPPAYDAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMPPAYTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROGRESSSTATUSCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMPPAYOUTPUTDANDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMPPAYADMINNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCAFILEOUTPUTDANDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCAFILEADMINNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEMPPAYOUTLINEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANKCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFFICECDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTHOLDERKANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELETEFLGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANUALUPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYSTEMUPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bILLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gADATEMPPAYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(805, 188);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 27);
            this.button6.TabIndex = 7;
            this.button6.Text = "閉じる";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox1.Location = new System.Drawing.Point(71, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 19);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "目的：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(689, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "設定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "入力した文字列を基に、依頼者/事業名/目的/支払先から検索します。";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rEQUESTPERSONNAMEDataGridViewTextBoxColumn,
            this.tEMPPAYNUMBERDataGridViewTextBoxColumn,
            this.bUSINESSCDDataGridViewTextBoxColumn,
            this.bUSINESSNAMEDataGridViewTextBoxColumn,
            this.tEMPPAYPURPOSEDataGridViewTextBoxColumn,
            this.tEMPPAYPRICEDataGridViewTextBoxColumn,
            this.tEMPPAYDAYDataGridViewTextBoxColumn,
            this.cLIENTCDDataGridViewTextBoxColumn,
            this.cLIENTNAMEDataGridViewTextBoxColumn,
            this.tEMPPAYTYPEDataGridViewTextBoxColumn,
            this.pROGRESSSTATUSCDDataGridViewTextBoxColumn,
            this.tEMPPAYOUTPUTDANDTDataGridViewTextBoxColumn,
            this.tEMPPAYADMINNUMBERDataGridViewTextBoxColumn,
            this.pCAFILEOUTPUTDANDTDataGridViewTextBoxColumn,
            this.pCAFILEADMINNUMBERDataGridViewTextBoxColumn,
            this.tEMPPAYOUTLINEDataGridViewTextBoxColumn,
            this.bANKCDDataGridViewTextBoxColumn,
            this.oFFICECDDataGridViewTextBoxColumn,
            this.aCCOUNTTYPEDataGridViewTextBoxColumn,
            this.aCCOUNTHOLDERKANADataGridViewTextBoxColumn,
            this.aCCOUNTNUMBERDataGridViewTextBoxColumn,
            this.rECNUMBERDataGridViewTextBoxColumn,
            this.dELETEFLGDataGridViewTextBoxColumn,
            this.mANUALUPDATEDataGridViewTextBoxColumn,
            this.aDMINNUMBERDataGridViewTextBoxColumn,
            this.sYSTEMUPDATEDataGridViewTextBoxColumn,
            this.bILLIDDataGridViewTextBoxColumn,
            this.banknameDataGridViewTextBoxColumn,
            this.branchnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gADATEMPPAYBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(27, 55);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(897, 125);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(883, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "件数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(816, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "データ件数：";
            // 
            // jBADBDataSet
            // 
            this.jBADBDataSet.DataSetName = "JBADBDataSet";
            this.jBADBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gADATEMPPAYBindingSource
            // 
            this.gADATEMPPAYBindingSource.DataMember = "GADA_TEMP_PAY";
            this.gADATEMPPAYBindingSource.DataSource = this.jBADBDataSet;
            // 
            // gADA_TEMP_PAYTableAdapter
            // 
            this.gADA_TEMP_PAYTableAdapter.ClearBeforeFill = true;
            // 
            // rEQUESTPERSONNAMEDataGridViewTextBoxColumn
            // 
            this.rEQUESTPERSONNAMEDataGridViewTextBoxColumn.DataPropertyName = "REQUEST_PERSON_NAME";
            this.rEQUESTPERSONNAMEDataGridViewTextBoxColumn.FillWeight = 80F;
            this.rEQUESTPERSONNAMEDataGridViewTextBoxColumn.HeaderText = "依頼者";
            this.rEQUESTPERSONNAMEDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.rEQUESTPERSONNAMEDataGridViewTextBoxColumn.Name = "rEQUESTPERSONNAMEDataGridViewTextBoxColumn";
            this.rEQUESTPERSONNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tEMPPAYNUMBERDataGridViewTextBoxColumn
            // 
            this.tEMPPAYNUMBERDataGridViewTextBoxColumn.DataPropertyName = "TEMP_PAY_NUMBER";
            this.tEMPPAYNUMBERDataGridViewTextBoxColumn.FillWeight = 70F;
            this.tEMPPAYNUMBERDataGridViewTextBoxColumn.HeaderText = "仮払番号";
            this.tEMPPAYNUMBERDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.tEMPPAYNUMBERDataGridViewTextBoxColumn.Name = "tEMPPAYNUMBERDataGridViewTextBoxColumn";
            this.tEMPPAYNUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bUSINESSCDDataGridViewTextBoxColumn
            // 
            this.bUSINESSCDDataGridViewTextBoxColumn.DataPropertyName = "BUSINESS_CD";
            this.bUSINESSCDDataGridViewTextBoxColumn.FillWeight = 80F;
            this.bUSINESSCDDataGridViewTextBoxColumn.HeaderText = "事業コード";
            this.bUSINESSCDDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.bUSINESSCDDataGridViewTextBoxColumn.Name = "bUSINESSCDDataGridViewTextBoxColumn";
            this.bUSINESSCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bUSINESSNAMEDataGridViewTextBoxColumn
            // 
            this.bUSINESSNAMEDataGridViewTextBoxColumn.DataPropertyName = "BUSINESS_NAME";
            this.bUSINESSNAMEDataGridViewTextBoxColumn.FillWeight = 120F;
            this.bUSINESSNAMEDataGridViewTextBoxColumn.HeaderText = "事業名";
            this.bUSINESSNAMEDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.bUSINESSNAMEDataGridViewTextBoxColumn.Name = "bUSINESSNAMEDataGridViewTextBoxColumn";
            this.bUSINESSNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tEMPPAYPURPOSEDataGridViewTextBoxColumn
            // 
            this.tEMPPAYPURPOSEDataGridViewTextBoxColumn.DataPropertyName = "TEMP_PAY_PURPOSE";
            this.tEMPPAYPURPOSEDataGridViewTextBoxColumn.FillWeight = 150F;
            this.tEMPPAYPURPOSEDataGridViewTextBoxColumn.HeaderText = "目的";
            this.tEMPPAYPURPOSEDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.tEMPPAYPURPOSEDataGridViewTextBoxColumn.Name = "tEMPPAYPURPOSEDataGridViewTextBoxColumn";
            this.tEMPPAYPURPOSEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tEMPPAYPRICEDataGridViewTextBoxColumn
            // 
            this.tEMPPAYPRICEDataGridViewTextBoxColumn.DataPropertyName = "TEMP_PAY_PRICE";
            this.tEMPPAYPRICEDataGridViewTextBoxColumn.FillWeight = 60F;
            this.tEMPPAYPRICEDataGridViewTextBoxColumn.HeaderText = "金額";
            this.tEMPPAYPRICEDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.tEMPPAYPRICEDataGridViewTextBoxColumn.Name = "tEMPPAYPRICEDataGridViewTextBoxColumn";
            this.tEMPPAYPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tEMPPAYDAYDataGridViewTextBoxColumn
            // 
            this.tEMPPAYDAYDataGridViewTextBoxColumn.DataPropertyName = "TEMP_PAY_DAY";
            this.tEMPPAYDAYDataGridViewTextBoxColumn.FillWeight = 80F;
            this.tEMPPAYDAYDataGridViewTextBoxColumn.HeaderText = "仮払日付";
            this.tEMPPAYDAYDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.tEMPPAYDAYDataGridViewTextBoxColumn.Name = "tEMPPAYDAYDataGridViewTextBoxColumn";
            this.tEMPPAYDAYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTCDDataGridViewTextBoxColumn
            // 
            this.cLIENTCDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_CD";
            this.cLIENTCDDataGridViewTextBoxColumn.FillWeight = 90F;
            this.cLIENTCDDataGridViewTextBoxColumn.HeaderText = "支払先CODE";
            this.cLIENTCDDataGridViewTextBoxColumn.MinimumWidth = 90;
            this.cLIENTCDDataGridViewTextBoxColumn.Name = "cLIENTCDDataGridViewTextBoxColumn";
            this.cLIENTCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTNAMEDataGridViewTextBoxColumn
            // 
            this.cLIENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_NAME";
            this.cLIENTNAMEDataGridViewTextBoxColumn.FillWeight = 80F;
            this.cLIENTNAMEDataGridViewTextBoxColumn.HeaderText = "支払先";
            this.cLIENTNAMEDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.cLIENTNAMEDataGridViewTextBoxColumn.Name = "cLIENTNAMEDataGridViewTextBoxColumn";
            this.cLIENTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tEMPPAYTYPEDataGridViewTextBoxColumn
            // 
            this.tEMPPAYTYPEDataGridViewTextBoxColumn.DataPropertyName = "TEMP_PAY_TYPE";
            this.tEMPPAYTYPEDataGridViewTextBoxColumn.HeaderText = "TEMP_PAY_TYPE";
            this.tEMPPAYTYPEDataGridViewTextBoxColumn.Name = "tEMPPAYTYPEDataGridViewTextBoxColumn";
            this.tEMPPAYTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tEMPPAYTYPEDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROGRESSSTATUSCDDataGridViewTextBoxColumn
            // 
            this.pROGRESSSTATUSCDDataGridViewTextBoxColumn.DataPropertyName = "PROGRESS_STATUS_CD";
            this.pROGRESSSTATUSCDDataGridViewTextBoxColumn.HeaderText = "PROGRESS_STATUS_CD";
            this.pROGRESSSTATUSCDDataGridViewTextBoxColumn.Name = "pROGRESSSTATUSCDDataGridViewTextBoxColumn";
            this.pROGRESSSTATUSCDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROGRESSSTATUSCDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tEMPPAYOUTPUTDANDTDataGridViewTextBoxColumn
            // 
            this.tEMPPAYOUTPUTDANDTDataGridViewTextBoxColumn.DataPropertyName = "TEMP_PAY_OUTPUT_DANDT";
            this.tEMPPAYOUTPUTDANDTDataGridViewTextBoxColumn.HeaderText = "TEMP_PAY_OUTPUT_DANDT";
            this.tEMPPAYOUTPUTDANDTDataGridViewTextBoxColumn.Name = "tEMPPAYOUTPUTDANDTDataGridViewTextBoxColumn";
            this.tEMPPAYOUTPUTDANDTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tEMPPAYOUTPUTDANDTDataGridViewTextBoxColumn.Visible = false;
            // 
            // tEMPPAYADMINNUMBERDataGridViewTextBoxColumn
            // 
            this.tEMPPAYADMINNUMBERDataGridViewTextBoxColumn.DataPropertyName = "TEMP_PAY_ADMIN_NUMBER";
            this.tEMPPAYADMINNUMBERDataGridViewTextBoxColumn.HeaderText = "TEMP_PAY_ADMIN_NUMBER";
            this.tEMPPAYADMINNUMBERDataGridViewTextBoxColumn.Name = "tEMPPAYADMINNUMBERDataGridViewTextBoxColumn";
            this.tEMPPAYADMINNUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            this.tEMPPAYADMINNUMBERDataGridViewTextBoxColumn.Visible = false;
            // 
            // pCAFILEOUTPUTDANDTDataGridViewTextBoxColumn
            // 
            this.pCAFILEOUTPUTDANDTDataGridViewTextBoxColumn.DataPropertyName = "PCA_FILE_OUTPUT_DANDT";
            this.pCAFILEOUTPUTDANDTDataGridViewTextBoxColumn.HeaderText = "PCA_FILE_OUTPUT_DANDT";
            this.pCAFILEOUTPUTDANDTDataGridViewTextBoxColumn.Name = "pCAFILEOUTPUTDANDTDataGridViewTextBoxColumn";
            this.pCAFILEOUTPUTDANDTDataGridViewTextBoxColumn.ReadOnly = true;
            this.pCAFILEOUTPUTDANDTDataGridViewTextBoxColumn.Visible = false;
            // 
            // pCAFILEADMINNUMBERDataGridViewTextBoxColumn
            // 
            this.pCAFILEADMINNUMBERDataGridViewTextBoxColumn.DataPropertyName = "PCA_FILE_ADMIN_NUMBER";
            this.pCAFILEADMINNUMBERDataGridViewTextBoxColumn.HeaderText = "PCA_FILE_ADMIN_NUMBER";
            this.pCAFILEADMINNUMBERDataGridViewTextBoxColumn.Name = "pCAFILEADMINNUMBERDataGridViewTextBoxColumn";
            this.pCAFILEADMINNUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            this.pCAFILEADMINNUMBERDataGridViewTextBoxColumn.Visible = false;
            // 
            // tEMPPAYOUTLINEDataGridViewTextBoxColumn
            // 
            this.tEMPPAYOUTLINEDataGridViewTextBoxColumn.DataPropertyName = "TEMP_PAY_OUTLINE";
            this.tEMPPAYOUTLINEDataGridViewTextBoxColumn.HeaderText = "TEMP_PAY_OUTLINE";
            this.tEMPPAYOUTLINEDataGridViewTextBoxColumn.Name = "tEMPPAYOUTLINEDataGridViewTextBoxColumn";
            this.tEMPPAYOUTLINEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tEMPPAYOUTLINEDataGridViewTextBoxColumn.Visible = false;
            // 
            // bANKCDDataGridViewTextBoxColumn
            // 
            this.bANKCDDataGridViewTextBoxColumn.DataPropertyName = "BANK_CD";
            this.bANKCDDataGridViewTextBoxColumn.HeaderText = "BANK_CD";
            this.bANKCDDataGridViewTextBoxColumn.Name = "bANKCDDataGridViewTextBoxColumn";
            this.bANKCDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bANKCDDataGridViewTextBoxColumn.Visible = false;
            // 
            // oFFICECDDataGridViewTextBoxColumn
            // 
            this.oFFICECDDataGridViewTextBoxColumn.DataPropertyName = "OFFICE_CD";
            this.oFFICECDDataGridViewTextBoxColumn.HeaderText = "OFFICE_CD";
            this.oFFICECDDataGridViewTextBoxColumn.Name = "oFFICECDDataGridViewTextBoxColumn";
            this.oFFICECDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oFFICECDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCCOUNTTYPEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_TYPE";
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.HeaderText = "ACCOUNT_TYPE";
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.Name = "aCCOUNTTYPEDataGridViewTextBoxColumn";
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCCOUNTHOLDERKANADataGridViewTextBoxColumn
            // 
            this.aCCOUNTHOLDERKANADataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_HOLDER_KANA";
            this.aCCOUNTHOLDERKANADataGridViewTextBoxColumn.HeaderText = "ACCOUNT_HOLDER_KANA";
            this.aCCOUNTHOLDERKANADataGridViewTextBoxColumn.Name = "aCCOUNTHOLDERKANADataGridViewTextBoxColumn";
            this.aCCOUNTHOLDERKANADataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCOUNTHOLDERKANADataGridViewTextBoxColumn.Visible = false;
            // 
            // aCCOUNTNUMBERDataGridViewTextBoxColumn
            // 
            this.aCCOUNTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_NUMBER";
            this.aCCOUNTNUMBERDataGridViewTextBoxColumn.HeaderText = "ACCOUNT_NUMBER";
            this.aCCOUNTNUMBERDataGridViewTextBoxColumn.Name = "aCCOUNTNUMBERDataGridViewTextBoxColumn";
            this.aCCOUNTNUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCOUNTNUMBERDataGridViewTextBoxColumn.Visible = false;
            // 
            // rECNUMBERDataGridViewTextBoxColumn
            // 
            this.rECNUMBERDataGridViewTextBoxColumn.DataPropertyName = "REC_NUMBER";
            this.rECNUMBERDataGridViewTextBoxColumn.HeaderText = "REC_NUMBER";
            this.rECNUMBERDataGridViewTextBoxColumn.Name = "rECNUMBERDataGridViewTextBoxColumn";
            this.rECNUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            this.rECNUMBERDataGridViewTextBoxColumn.Visible = false;
            // 
            // dELETEFLGDataGridViewTextBoxColumn
            // 
            this.dELETEFLGDataGridViewTextBoxColumn.DataPropertyName = "DELETE_FLG";
            this.dELETEFLGDataGridViewTextBoxColumn.HeaderText = "DELETE_FLG";
            this.dELETEFLGDataGridViewTextBoxColumn.Name = "dELETEFLGDataGridViewTextBoxColumn";
            this.dELETEFLGDataGridViewTextBoxColumn.ReadOnly = true;
            this.dELETEFLGDataGridViewTextBoxColumn.Visible = false;
            // 
            // mANUALUPDATEDataGridViewTextBoxColumn
            // 
            this.mANUALUPDATEDataGridViewTextBoxColumn.DataPropertyName = "MANUAL_UPDATE";
            this.mANUALUPDATEDataGridViewTextBoxColumn.HeaderText = "MANUAL_UPDATE";
            this.mANUALUPDATEDataGridViewTextBoxColumn.Name = "mANUALUPDATEDataGridViewTextBoxColumn";
            this.mANUALUPDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mANUALUPDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // aDMINNUMBERDataGridViewTextBoxColumn
            // 
            this.aDMINNUMBERDataGridViewTextBoxColumn.DataPropertyName = "ADMIN_NUMBER";
            this.aDMINNUMBERDataGridViewTextBoxColumn.HeaderText = "ADMIN_NUMBER";
            this.aDMINNUMBERDataGridViewTextBoxColumn.Name = "aDMINNUMBERDataGridViewTextBoxColumn";
            this.aDMINNUMBERDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDMINNUMBERDataGridViewTextBoxColumn.Visible = false;
            // 
            // sYSTEMUPDATEDataGridViewTextBoxColumn
            // 
            this.sYSTEMUPDATEDataGridViewTextBoxColumn.DataPropertyName = "SYSTEM_UPDATE";
            this.sYSTEMUPDATEDataGridViewTextBoxColumn.HeaderText = "SYSTEM_UPDATE";
            this.sYSTEMUPDATEDataGridViewTextBoxColumn.Name = "sYSTEMUPDATEDataGridViewTextBoxColumn";
            this.sYSTEMUPDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sYSTEMUPDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // bILLIDDataGridViewTextBoxColumn
            // 
            this.bILLIDDataGridViewTextBoxColumn.DataPropertyName = "BILL_ID";
            this.bILLIDDataGridViewTextBoxColumn.HeaderText = "BILL_ID";
            this.bILLIDDataGridViewTextBoxColumn.Name = "bILLIDDataGridViewTextBoxColumn";
            this.bILLIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bILLIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // banknameDataGridViewTextBoxColumn
            // 
            this.banknameDataGridViewTextBoxColumn.DataPropertyName = "bank_name";
            this.banknameDataGridViewTextBoxColumn.HeaderText = "bank_name";
            this.banknameDataGridViewTextBoxColumn.Name = "banknameDataGridViewTextBoxColumn";
            this.banknameDataGridViewTextBoxColumn.ReadOnly = true;
            this.banknameDataGridViewTextBoxColumn.Visible = false;
            // 
            // branchnameDataGridViewTextBoxColumn
            // 
            this.branchnameDataGridViewTextBoxColumn.DataPropertyName = "branch_name";
            this.branchnameDataGridViewTextBoxColumn.HeaderText = "branch_name";
            this.branchnameDataGridViewTextBoxColumn.Name = "branchnameDataGridViewTextBoxColumn";
            this.branchnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchnameDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmSeaTempDest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 225);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSeaTempDest";
            this.Text = "仮払先検索";
            this.Load += new System.EventHandler(this.frmSeaTempDest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gADATEMPPAYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource gADATEMPPAYBindingSource;
        private JBADBDataSet jBADBDataSet;
        private JBADBDataSetTableAdapters.GADA_TEMP_PAYTableAdapter gADA_TEMP_PAYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQUESTPERSONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMPPAYNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUSINESSCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUSINESSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMPPAYPURPOSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMPPAYPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMPPAYDAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMPPAYTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROGRESSSTATUSCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMPPAYOUTPUTDANDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMPPAYADMINNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCAFILEOUTPUTDANDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCAFILEADMINNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEMPPAYOUTLINEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANKCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFFICECDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTHOLDERKANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dELETEFLGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANUALUPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sYSTEMUPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchnameDataGridViewTextBoxColumn;
    }
}