namespace JBA_BizSupport
{
    partial class frmSeaPaymentDest
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CLIENT_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENT_ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTZIPCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTBUILDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORPOINDIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESIDENCEFLGDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tRANSFEREEBANKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANSFEREEOFFICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTHOLDERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTHOLDERKANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTTELNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTFAXNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mYNUMBERNECESSARYFLGDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mYNUMBERREQUESTFLGDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mYNUMBERRECEIPTFLGDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dELETEFLGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANUALUPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYSTEMUPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMACLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jBADBDataSet = new JBA_BizSupport.JBADBDataSet();
            this.gAMA_CLIENTTableAdapter = new JBA_BizSupport.JBADBDataSetTableAdapters.GAMA_CLIENTTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMACLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(419, 188);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "閉じる";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 8);
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
            this.textBox1.Size = new System.Drawing.Size(187, 19);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "支払先：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "設定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.CLIENT_CD,
            this.CLIENT_NAME,
            this.CLIENT_ADDRESS,
            this.cLIENTCDDataGridViewTextBoxColumn,
            this.cLIENTNAMEDataGridViewTextBoxColumn,
            this.cLIENTZIPCDDataGridViewTextBoxColumn,
            this.cLIENTADDRESSDataGridViewTextBoxColumn,
            this.cLIENTBUILDNAMEDataGridViewTextBoxColumn,
            this.cORPOINDIIDDataGridViewTextBoxColumn,
            this.rESIDENCEFLGDataGridViewCheckBoxColumn,
            this.tRANSFEREEBANKDataGridViewTextBoxColumn,
            this.tRANSFEREEOFFICEDataGridViewTextBoxColumn,
            this.aCCOUNTTYPEDataGridViewTextBoxColumn,
            this.aCCOUNTHOLDERNAMEDataGridViewTextBoxColumn,
            this.aCCOUNTHOLDERKANADataGridViewTextBoxColumn,
            this.aCCOUNTNUMBERDataGridViewTextBoxColumn,
            this.cLIENTTELNODataGridViewTextBoxColumn,
            this.cLIENTFAXNODataGridViewTextBoxColumn,
            this.mYNUMBERNECESSARYFLGDataGridViewCheckBoxColumn,
            this.mYNUMBERREQUESTFLGDataGridViewCheckBoxColumn,
            this.mYNUMBERRECEIPTFLGDataGridViewCheckBoxColumn,
            this.dELETEFLGDataGridViewTextBoxColumn,
            this.mANUALUPDATEDataGridViewTextBoxColumn,
            this.aDMINNUMBERDataGridViewTextBoxColumn,
            this.sYSTEMUPDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gAMACLIENTBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(28, 42);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(509, 137);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // CLIENT_CD
            // 
            this.CLIENT_CD.DataPropertyName = "CLIENT_CD";
            this.CLIENT_CD.HeaderText = "支払先CODE";
            this.CLIENT_CD.Name = "CLIENT_CD";
            this.CLIENT_CD.ReadOnly = true;
            // 
            // CLIENT_NAME
            // 
            this.CLIENT_NAME.DataPropertyName = "CLIENT_NAME";
            this.CLIENT_NAME.HeaderText = "支払先";
            this.CLIENT_NAME.Name = "CLIENT_NAME";
            this.CLIENT_NAME.ReadOnly = true;
            // 
            // CLIENT_ADDRESS
            // 
            this.CLIENT_ADDRESS.DataPropertyName = "CLIENT_ADDRESS";
            this.CLIENT_ADDRESS.FillWeight = 300F;
            this.CLIENT_ADDRESS.HeaderText = "住所";
            this.CLIENT_ADDRESS.Name = "CLIENT_ADDRESS";
            this.CLIENT_ADDRESS.ReadOnly = true;
            // 
            // cLIENTCDDataGridViewTextBoxColumn
            // 
            this.cLIENTCDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_CD";
            this.cLIENTCDDataGridViewTextBoxColumn.HeaderText = "CLIENT_CD";
            this.cLIENTCDDataGridViewTextBoxColumn.Name = "cLIENTCDDataGridViewTextBoxColumn";
            this.cLIENTCDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTCDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTNAMEDataGridViewTextBoxColumn
            // 
            this.cLIENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_NAME";
            this.cLIENTNAMEDataGridViewTextBoxColumn.HeaderText = "CLIENT_NAME";
            this.cLIENTNAMEDataGridViewTextBoxColumn.Name = "cLIENTNAMEDataGridViewTextBoxColumn";
            this.cLIENTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTNAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTZIPCDDataGridViewTextBoxColumn
            // 
            this.cLIENTZIPCDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ZIP_CD";
            this.cLIENTZIPCDDataGridViewTextBoxColumn.HeaderText = "CLIENT_ZIP_CD";
            this.cLIENTZIPCDDataGridViewTextBoxColumn.Name = "cLIENTZIPCDDataGridViewTextBoxColumn";
            this.cLIENTZIPCDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTZIPCDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTADDRESSDataGridViewTextBoxColumn
            // 
            this.cLIENTADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ADDRESS";
            this.cLIENTADDRESSDataGridViewTextBoxColumn.HeaderText = "CLIENT_ADDRESS";
            this.cLIENTADDRESSDataGridViewTextBoxColumn.Name = "cLIENTADDRESSDataGridViewTextBoxColumn";
            this.cLIENTADDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTADDRESSDataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTBUILDNAMEDataGridViewTextBoxColumn
            // 
            this.cLIENTBUILDNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_BUILD_NAME";
            this.cLIENTBUILDNAMEDataGridViewTextBoxColumn.HeaderText = "CLIENT_BUILD_NAME";
            this.cLIENTBUILDNAMEDataGridViewTextBoxColumn.Name = "cLIENTBUILDNAMEDataGridViewTextBoxColumn";
            this.cLIENTBUILDNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTBUILDNAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cORPOINDIIDDataGridViewTextBoxColumn
            // 
            this.cORPOINDIIDDataGridViewTextBoxColumn.DataPropertyName = "CORPO_INDI_ID";
            this.cORPOINDIIDDataGridViewTextBoxColumn.HeaderText = "CORPO_INDI_ID";
            this.cORPOINDIIDDataGridViewTextBoxColumn.Name = "cORPOINDIIDDataGridViewTextBoxColumn";
            this.cORPOINDIIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cORPOINDIIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // rESIDENCEFLGDataGridViewCheckBoxColumn
            // 
            this.rESIDENCEFLGDataGridViewCheckBoxColumn.DataPropertyName = "RESIDENCE_FLG";
            this.rESIDENCEFLGDataGridViewCheckBoxColumn.HeaderText = "RESIDENCE_FLG";
            this.rESIDENCEFLGDataGridViewCheckBoxColumn.Name = "rESIDENCEFLGDataGridViewCheckBoxColumn";
            this.rESIDENCEFLGDataGridViewCheckBoxColumn.ReadOnly = true;
            this.rESIDENCEFLGDataGridViewCheckBoxColumn.Visible = false;
            // 
            // tRANSFEREEBANKDataGridViewTextBoxColumn
            // 
            this.tRANSFEREEBANKDataGridViewTextBoxColumn.DataPropertyName = "TRANSFEREE_BANK";
            this.tRANSFEREEBANKDataGridViewTextBoxColumn.HeaderText = "TRANSFEREE_BANK";
            this.tRANSFEREEBANKDataGridViewTextBoxColumn.Name = "tRANSFEREEBANKDataGridViewTextBoxColumn";
            this.tRANSFEREEBANKDataGridViewTextBoxColumn.ReadOnly = true;
            this.tRANSFEREEBANKDataGridViewTextBoxColumn.Visible = false;
            // 
            // tRANSFEREEOFFICEDataGridViewTextBoxColumn
            // 
            this.tRANSFEREEOFFICEDataGridViewTextBoxColumn.DataPropertyName = "TRANSFEREE_OFFICE";
            this.tRANSFEREEOFFICEDataGridViewTextBoxColumn.HeaderText = "TRANSFEREE_OFFICE";
            this.tRANSFEREEOFFICEDataGridViewTextBoxColumn.Name = "tRANSFEREEOFFICEDataGridViewTextBoxColumn";
            this.tRANSFEREEOFFICEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tRANSFEREEOFFICEDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCCOUNTTYPEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_TYPE";
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.HeaderText = "ACCOUNT_TYPE";
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.Name = "aCCOUNTTYPEDataGridViewTextBoxColumn";
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCOUNTTYPEDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCCOUNTHOLDERNAMEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTHOLDERNAMEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_HOLDER_NAME";
            this.aCCOUNTHOLDERNAMEDataGridViewTextBoxColumn.HeaderText = "ACCOUNT_HOLDER_NAME";
            this.aCCOUNTHOLDERNAMEDataGridViewTextBoxColumn.Name = "aCCOUNTHOLDERNAMEDataGridViewTextBoxColumn";
            this.aCCOUNTHOLDERNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCOUNTHOLDERNAMEDataGridViewTextBoxColumn.Visible = false;
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
            // cLIENTTELNODataGridViewTextBoxColumn
            // 
            this.cLIENTTELNODataGridViewTextBoxColumn.DataPropertyName = "CLIENT_TEL_NO";
            this.cLIENTTELNODataGridViewTextBoxColumn.HeaderText = "CLIENT_TEL_NO";
            this.cLIENTTELNODataGridViewTextBoxColumn.Name = "cLIENTTELNODataGridViewTextBoxColumn";
            this.cLIENTTELNODataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTTELNODataGridViewTextBoxColumn.Visible = false;
            // 
            // cLIENTFAXNODataGridViewTextBoxColumn
            // 
            this.cLIENTFAXNODataGridViewTextBoxColumn.DataPropertyName = "CLIENT_FAX_NO";
            this.cLIENTFAXNODataGridViewTextBoxColumn.HeaderText = "CLIENT_FAX_NO";
            this.cLIENTFAXNODataGridViewTextBoxColumn.Name = "cLIENTFAXNODataGridViewTextBoxColumn";
            this.cLIENTFAXNODataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTFAXNODataGridViewTextBoxColumn.Visible = false;
            // 
            // mYNUMBERNECESSARYFLGDataGridViewCheckBoxColumn
            // 
            this.mYNUMBERNECESSARYFLGDataGridViewCheckBoxColumn.DataPropertyName = "MYNUMBER_NECESSARY_FLG";
            this.mYNUMBERNECESSARYFLGDataGridViewCheckBoxColumn.HeaderText = "MYNUMBER_NECESSARY_FLG";
            this.mYNUMBERNECESSARYFLGDataGridViewCheckBoxColumn.Name = "mYNUMBERNECESSARYFLGDataGridViewCheckBoxColumn";
            this.mYNUMBERNECESSARYFLGDataGridViewCheckBoxColumn.ReadOnly = true;
            this.mYNUMBERNECESSARYFLGDataGridViewCheckBoxColumn.Visible = false;
            // 
            // mYNUMBERREQUESTFLGDataGridViewCheckBoxColumn
            // 
            this.mYNUMBERREQUESTFLGDataGridViewCheckBoxColumn.DataPropertyName = "MYNUMBER_REQUEST_FLG";
            this.mYNUMBERREQUESTFLGDataGridViewCheckBoxColumn.HeaderText = "MYNUMBER_REQUEST_FLG";
            this.mYNUMBERREQUESTFLGDataGridViewCheckBoxColumn.Name = "mYNUMBERREQUESTFLGDataGridViewCheckBoxColumn";
            this.mYNUMBERREQUESTFLGDataGridViewCheckBoxColumn.ReadOnly = true;
            this.mYNUMBERREQUESTFLGDataGridViewCheckBoxColumn.Visible = false;
            // 
            // mYNUMBERRECEIPTFLGDataGridViewCheckBoxColumn
            // 
            this.mYNUMBERRECEIPTFLGDataGridViewCheckBoxColumn.DataPropertyName = "MYNUMBER_RECEIPT_FLG";
            this.mYNUMBERRECEIPTFLGDataGridViewCheckBoxColumn.HeaderText = "MYNUMBER_RECEIPT_FLG";
            this.mYNUMBERRECEIPTFLGDataGridViewCheckBoxColumn.Name = "mYNUMBERRECEIPTFLGDataGridViewCheckBoxColumn";
            this.mYNUMBERRECEIPTFLGDataGridViewCheckBoxColumn.ReadOnly = true;
            this.mYNUMBERRECEIPTFLGDataGridViewCheckBoxColumn.Visible = false;
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
            // gAMACLIENTBindingSource
            // 
            this.gAMACLIENTBindingSource.DataMember = "GAMA_CLIENT";
            this.gAMACLIENTBindingSource.DataSource = this.jBADBDataSet;
            // 
            // jBADBDataSet
            // 
            this.jBADBDataSet.DataSetName = "JBADBDataSet";
            this.jBADBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gAMA_CLIENTTableAdapter
            // 
            this.gAMA_CLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "件数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "データ件数：";
            // 
            // frmSeaPaymentDest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 225);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSeaPaymentDest";
            this.Text = "支払先選択";
            this.Load += new System.EventHandler(this.frmSeaPaymentDest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMACLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private JBADBDataSet jBADBDataSet;
        private System.Windows.Forms.BindingSource gAMACLIENTBindingSource;
        private JBADBDataSetTableAdapters.GAMA_CLIENTTableAdapter gAMA_CLIENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENT_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENT_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENT_ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTZIPCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTBUILDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORPOINDIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rESIDENCEFLGDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANSFEREEBANKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANSFEREEOFFICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTHOLDERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTHOLDERKANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTTELNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTFAXNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mYNUMBERNECESSARYFLGDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mYNUMBERREQUESTFLGDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mYNUMBERRECEIPTFLGDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dELETEFLGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANUALUPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sYSTEMUPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}