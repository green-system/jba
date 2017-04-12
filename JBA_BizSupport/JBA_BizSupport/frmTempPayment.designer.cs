namespace JBA_BizSupport
{
    partial class frmTempPayment
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.REQUEST_PERSON_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMP_PAY_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUSINESS_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUSINESS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMP_PAY_PURPOSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMP_PAY_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMP_PAY_DAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENT_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMP_PAY_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROGRESS_STATUS_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMP_PAY_OUTPUT_DANDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMP_PAY_ADMIN_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_FILE_OUTPUT_DANDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCA_FILE_ADMIN_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMP_PAY_OUTLINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANK_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OFFICE_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNT_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNT_HOLDER_KANA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCOUNT_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REC_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE_FLG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANUAL_UPDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADMIN_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYSTEM_UPDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENT_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress = new JBA_BizSupport.DataGridViewProgressColumn();
            this.BILL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gADATEMPPAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jBADBDataSet = new JBA_BizSupport.JBADBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.dataGridViewProgressColumn1 = new JBA_BizSupport.DataGridViewProgressColumn();
            this.gADA_TEMP_PAYTableAdapter = new JBA_BizSupport.JBADBDataSetTableAdapters.GADA_TEMP_PAYTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gADATEMPPAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "目的：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "新規作成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "検索";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox1.Location = new System.Drawing.Point(61, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 19);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "検索条件：";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(1, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 16);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "全ての仮払";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(87, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 16);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "未精算の仮払";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(190, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 16);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "振込の仮払";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(282, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(81, 16);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "現金の仮払";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(805, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "メニューへ戻る";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 687);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "■費用計上管理システム（仮払い先一覧）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(869, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "件数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(802, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "データ件数：";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(805, 637);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 30);
            this.button4.TabIndex = 11;
            this.button4.Text = "選択";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REQUEST_PERSON_NAME,
            this.TEMP_PAY_NUMBER,
            this.BUSINESS_CD,
            this.BUSINESS_NAME,
            this.TEMP_PAY_PURPOSE,
            this.TEMP_PAY_PRICE,
            this.TEMP_PAY_DAY,
            this.CLIENT_CD,
            this.TEMP_PAY_TYPE,
            this.PROGRESS_STATUS_CD,
            this.TEMP_PAY_OUTPUT_DANDT,
            this.TEMP_PAY_ADMIN_NUMBER,
            this.PCA_FILE_OUTPUT_DANDT,
            this.PCA_FILE_ADMIN_NUMBER,
            this.TEMP_PAY_OUTLINE,
            this.BANK_CD,
            this.OFFICE_CD,
            this.ACCOUNT_TYPE,
            this.ACCOUNT_HOLDER_KANA,
            this.ACCOUNT_NUMBER,
            this.REC_NUMBER,
            this.DELETE_FLG,
            this.MANUAL_UPDATE,
            this.ADMIN_NUMBER,
            this.SYSTEM_UPDATE,
            this.CLIENT_NAME,
            this.Progress,
            this.BILL_ID,
            this.bank_name,
            this.branch_name});
            this.dataGridView1.DataSource = this.gADATEMPPAYBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(26, 86);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(889, 532);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // REQUEST_PERSON_NAME
            // 
            this.REQUEST_PERSON_NAME.DataPropertyName = "REQUEST_PERSON_NAME";
            this.REQUEST_PERSON_NAME.FillWeight = 55F;
            this.REQUEST_PERSON_NAME.HeaderText = "依頼者";
            this.REQUEST_PERSON_NAME.Name = "REQUEST_PERSON_NAME";
            this.REQUEST_PERSON_NAME.ReadOnly = true;
            // 
            // TEMP_PAY_NUMBER
            // 
            this.TEMP_PAY_NUMBER.DataPropertyName = "TEMP_PAY_NUMBER";
            this.TEMP_PAY_NUMBER.FillWeight = 80F;
            this.TEMP_PAY_NUMBER.HeaderText = "仮払番号";
            this.TEMP_PAY_NUMBER.Name = "TEMP_PAY_NUMBER";
            this.TEMP_PAY_NUMBER.ReadOnly = true;
            // 
            // BUSINESS_CD
            // 
            this.BUSINESS_CD.DataPropertyName = "BUSINESS_CD";
            this.BUSINESS_CD.FillWeight = 43.27447F;
            this.BUSINESS_CD.HeaderText = "事業コード";
            this.BUSINESS_CD.Name = "BUSINESS_CD";
            this.BUSINESS_CD.ReadOnly = true;
            // 
            // BUSINESS_NAME
            // 
            this.BUSINESS_NAME.DataPropertyName = "BUSINESS_NAME";
            this.BUSINESS_NAME.FillWeight = 54.09309F;
            this.BUSINESS_NAME.HeaderText = "事業名";
            this.BUSINESS_NAME.Name = "BUSINESS_NAME";
            this.BUSINESS_NAME.ReadOnly = true;
            // 
            // TEMP_PAY_PURPOSE
            // 
            this.TEMP_PAY_PURPOSE.DataPropertyName = "TEMP_PAY_PURPOSE";
            this.TEMP_PAY_PURPOSE.FillWeight = 54.09309F;
            this.TEMP_PAY_PURPOSE.HeaderText = "目的";
            this.TEMP_PAY_PURPOSE.Name = "TEMP_PAY_PURPOSE";
            this.TEMP_PAY_PURPOSE.ReadOnly = true;
            // 
            // TEMP_PAY_PRICE
            // 
            this.TEMP_PAY_PRICE.DataPropertyName = "TEMP_PAY_PRICE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.TEMP_PAY_PRICE.DefaultCellStyle = dataGridViewCellStyle2;
            this.TEMP_PAY_PRICE.FillWeight = 37.86516F;
            this.TEMP_PAY_PRICE.HeaderText = "金額";
            this.TEMP_PAY_PRICE.Name = "TEMP_PAY_PRICE";
            this.TEMP_PAY_PRICE.ReadOnly = true;
            // 
            // TEMP_PAY_DAY
            // 
            this.TEMP_PAY_DAY.DataPropertyName = "TEMP_PAY_DAY";
            this.TEMP_PAY_DAY.FillWeight = 48.68378F;
            this.TEMP_PAY_DAY.HeaderText = "仮払日付";
            this.TEMP_PAY_DAY.Name = "TEMP_PAY_DAY";
            this.TEMP_PAY_DAY.ReadOnly = true;
            // 
            // CLIENT_CD
            // 
            this.CLIENT_CD.DataPropertyName = "CLIENT_CD";
            this.CLIENT_CD.FillWeight = 45F;
            this.CLIENT_CD.HeaderText = "支払先CODE";
            this.CLIENT_CD.Name = "CLIENT_CD";
            this.CLIENT_CD.ReadOnly = true;
            // 
            // TEMP_PAY_TYPE
            // 
            this.TEMP_PAY_TYPE.DataPropertyName = "TEMP_PAY_TYPE";
            this.TEMP_PAY_TYPE.HeaderText = "TEMP_PAY_TYPE";
            this.TEMP_PAY_TYPE.Name = "TEMP_PAY_TYPE";
            this.TEMP_PAY_TYPE.ReadOnly = true;
            this.TEMP_PAY_TYPE.Visible = false;
            // 
            // PROGRESS_STATUS_CD
            // 
            this.PROGRESS_STATUS_CD.DataPropertyName = "PROGRESS_STATUS_CD";
            this.PROGRESS_STATUS_CD.HeaderText = "PROGRESS_STATUS_CD";
            this.PROGRESS_STATUS_CD.Name = "PROGRESS_STATUS_CD";
            this.PROGRESS_STATUS_CD.ReadOnly = true;
            this.PROGRESS_STATUS_CD.Visible = false;
            // 
            // TEMP_PAY_OUTPUT_DANDT
            // 
            this.TEMP_PAY_OUTPUT_DANDT.DataPropertyName = "TEMP_PAY_OUTPUT_DANDT";
            this.TEMP_PAY_OUTPUT_DANDT.HeaderText = "TEMP_PAY_OUTPUT_DANDT";
            this.TEMP_PAY_OUTPUT_DANDT.Name = "TEMP_PAY_OUTPUT_DANDT";
            this.TEMP_PAY_OUTPUT_DANDT.ReadOnly = true;
            this.TEMP_PAY_OUTPUT_DANDT.Visible = false;
            // 
            // TEMP_PAY_ADMIN_NUMBER
            // 
            this.TEMP_PAY_ADMIN_NUMBER.DataPropertyName = "TEMP_PAY_ADMIN_NUMBER";
            this.TEMP_PAY_ADMIN_NUMBER.HeaderText = "TEMP_PAY_ADMIN_NUMBER";
            this.TEMP_PAY_ADMIN_NUMBER.Name = "TEMP_PAY_ADMIN_NUMBER";
            this.TEMP_PAY_ADMIN_NUMBER.ReadOnly = true;
            this.TEMP_PAY_ADMIN_NUMBER.Visible = false;
            // 
            // PCA_FILE_OUTPUT_DANDT
            // 
            this.PCA_FILE_OUTPUT_DANDT.DataPropertyName = "PCA_FILE_OUTPUT_DANDT";
            this.PCA_FILE_OUTPUT_DANDT.HeaderText = "PCA_FILE_OUTPUT_DANDT";
            this.PCA_FILE_OUTPUT_DANDT.Name = "PCA_FILE_OUTPUT_DANDT";
            this.PCA_FILE_OUTPUT_DANDT.ReadOnly = true;
            this.PCA_FILE_OUTPUT_DANDT.Visible = false;
            // 
            // PCA_FILE_ADMIN_NUMBER
            // 
            this.PCA_FILE_ADMIN_NUMBER.DataPropertyName = "PCA_FILE_ADMIN_NUMBER";
            this.PCA_FILE_ADMIN_NUMBER.HeaderText = "PCA_FILE_ADMIN_NUMBER";
            this.PCA_FILE_ADMIN_NUMBER.Name = "PCA_FILE_ADMIN_NUMBER";
            this.PCA_FILE_ADMIN_NUMBER.ReadOnly = true;
            this.PCA_FILE_ADMIN_NUMBER.Visible = false;
            // 
            // TEMP_PAY_OUTLINE
            // 
            this.TEMP_PAY_OUTLINE.DataPropertyName = "TEMP_PAY_OUTLINE";
            this.TEMP_PAY_OUTLINE.HeaderText = "TEMP_PAY_OUTLINE";
            this.TEMP_PAY_OUTLINE.Name = "TEMP_PAY_OUTLINE";
            this.TEMP_PAY_OUTLINE.ReadOnly = true;
            this.TEMP_PAY_OUTLINE.Visible = false;
            // 
            // BANK_CD
            // 
            this.BANK_CD.DataPropertyName = "BANK_CD";
            this.BANK_CD.HeaderText = "BANK_CD";
            this.BANK_CD.Name = "BANK_CD";
            this.BANK_CD.ReadOnly = true;
            this.BANK_CD.Visible = false;
            // 
            // OFFICE_CD
            // 
            this.OFFICE_CD.DataPropertyName = "OFFICE_CD";
            this.OFFICE_CD.HeaderText = "OFFICE_CD";
            this.OFFICE_CD.Name = "OFFICE_CD";
            this.OFFICE_CD.ReadOnly = true;
            this.OFFICE_CD.Visible = false;
            // 
            // ACCOUNT_TYPE
            // 
            this.ACCOUNT_TYPE.DataPropertyName = "ACCOUNT_TYPE";
            this.ACCOUNT_TYPE.HeaderText = "ACCOUNT_TYPE";
            this.ACCOUNT_TYPE.Name = "ACCOUNT_TYPE";
            this.ACCOUNT_TYPE.ReadOnly = true;
            this.ACCOUNT_TYPE.Visible = false;
            // 
            // ACCOUNT_HOLDER_KANA
            // 
            this.ACCOUNT_HOLDER_KANA.DataPropertyName = "ACCOUNT_HOLDER_KANA";
            this.ACCOUNT_HOLDER_KANA.HeaderText = "ACCOUNT_HOLDER_KANA";
            this.ACCOUNT_HOLDER_KANA.Name = "ACCOUNT_HOLDER_KANA";
            this.ACCOUNT_HOLDER_KANA.ReadOnly = true;
            this.ACCOUNT_HOLDER_KANA.Visible = false;
            // 
            // ACCOUNT_NUMBER
            // 
            this.ACCOUNT_NUMBER.DataPropertyName = "ACCOUNT_NUMBER";
            this.ACCOUNT_NUMBER.HeaderText = "ACCOUNT_NUMBER";
            this.ACCOUNT_NUMBER.Name = "ACCOUNT_NUMBER";
            this.ACCOUNT_NUMBER.ReadOnly = true;
            this.ACCOUNT_NUMBER.Visible = false;
            // 
            // REC_NUMBER
            // 
            this.REC_NUMBER.DataPropertyName = "REC_NUMBER";
            this.REC_NUMBER.HeaderText = "REC_NUMBER";
            this.REC_NUMBER.Name = "REC_NUMBER";
            this.REC_NUMBER.ReadOnly = true;
            this.REC_NUMBER.Visible = false;
            // 
            // DELETE_FLG
            // 
            this.DELETE_FLG.DataPropertyName = "DELETE_FLG";
            this.DELETE_FLG.HeaderText = "DELETE_FLG";
            this.DELETE_FLG.Name = "DELETE_FLG";
            this.DELETE_FLG.ReadOnly = true;
            this.DELETE_FLG.Visible = false;
            // 
            // MANUAL_UPDATE
            // 
            this.MANUAL_UPDATE.DataPropertyName = "MANUAL_UPDATE";
            this.MANUAL_UPDATE.HeaderText = "MANUAL_UPDATE";
            this.MANUAL_UPDATE.Name = "MANUAL_UPDATE";
            this.MANUAL_UPDATE.ReadOnly = true;
            this.MANUAL_UPDATE.Visible = false;
            // 
            // ADMIN_NUMBER
            // 
            this.ADMIN_NUMBER.DataPropertyName = "ADMIN_NUMBER";
            this.ADMIN_NUMBER.HeaderText = "ADMIN_NUMBER";
            this.ADMIN_NUMBER.Name = "ADMIN_NUMBER";
            this.ADMIN_NUMBER.ReadOnly = true;
            this.ADMIN_NUMBER.Visible = false;
            // 
            // SYSTEM_UPDATE
            // 
            this.SYSTEM_UPDATE.DataPropertyName = "SYSTEM_UPDATE";
            this.SYSTEM_UPDATE.HeaderText = "SYSTEM_UPDATE";
            this.SYSTEM_UPDATE.Name = "SYSTEM_UPDATE";
            this.SYSTEM_UPDATE.ReadOnly = true;
            this.SYSTEM_UPDATE.Visible = false;
            // 
            // CLIENT_NAME
            // 
            this.CLIENT_NAME.DataPropertyName = "CLIENT_NAME";
            this.CLIENT_NAME.FillWeight = 54.09309F;
            this.CLIENT_NAME.HeaderText = "支払先";
            this.CLIENT_NAME.Name = "CLIENT_NAME";
            this.CLIENT_NAME.ReadOnly = true;
            // 
            // Progress
            // 
            this.Progress.DataPropertyName = "PROGRESS_STATUS_CD";
            this.Progress.HeaderText = "進捗状況";
            this.Progress.Name = "Progress";
            this.Progress.ProgressBarColor = System.Drawing.Color.Lime;
            this.Progress.ReadOnly = true;
            // 
            // BILL_ID
            // 
            this.BILL_ID.DataPropertyName = "BILL_ID";
            this.BILL_ID.HeaderText = "BILL_ID";
            this.BILL_ID.Name = "BILL_ID";
            this.BILL_ID.ReadOnly = true;
            this.BILL_ID.Visible = false;
            // 
            // bank_name
            // 
            this.bank_name.DataPropertyName = "bank_name";
            this.bank_name.HeaderText = "bank_name";
            this.bank_name.Name = "bank_name";
            this.bank_name.ReadOnly = true;
            this.bank_name.Visible = false;
            // 
            // branch_name
            // 
            this.branch_name.DataPropertyName = "branch_name";
            this.branch_name.HeaderText = "branch_name";
            this.branch_name.Name = "branch_name";
            this.branch_name.ReadOnly = true;
            this.branch_name.Visible = false;
            // 
            // gADATEMPPAYBindingSource
            // 
            this.gADATEMPPAYBindingSource.DataMember = "GADA_TEMP_PAY";
            this.gADATEMPPAYBindingSource.DataSource = this.jBADBDataSet;
            // 
            // jBADBDataSet
            // 
            this.jBADBDataSet.DataSetName = "JBADBDataSet";
            this.jBADBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Location = new System.Drawing.Point(83, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 19);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(369, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(71, 16);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "一時保存";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProgressColumn1
            // 
            this.dataGridViewProgressColumn1.DataPropertyName = "PROGRESS_STATUS_CD";
            this.dataGridViewProgressColumn1.HeaderText = "仮払 ⇒ PCA ⇒ 精算";
            this.dataGridViewProgressColumn1.Name = "dataGridViewProgressColumn1";
            this.dataGridViewProgressColumn1.ProgressBarColor = System.Drawing.Color.Lime;
            this.dataGridViewProgressColumn1.Width = 156;
            // 
            // gADA_TEMP_PAYTableAdapter
            // 
            this.gADA_TEMP_PAYTableAdapter.ClearBeforeFill = true;
            // 
            // frmTempPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 719);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTempPayment";
            this.Text = "業務支援システム";
            this.Load += new System.EventHandler(this.frmTempPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gADATEMPPAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private JBADBDataSet jBADBDataSet;
        private System.Windows.Forms.BindingSource gADATEMPPAYBindingSource;
        private JBADBDataSetTableAdapters.GADA_TEMP_PAYTableAdapter gADA_TEMP_PAYTableAdapter;
        private DataGridViewProgressColumn dataGridViewProgressColumn1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQUEST_PERSON_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMP_PAY_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUSINESS_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUSINESS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMP_PAY_PURPOSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMP_PAY_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMP_PAY_DAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENT_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMP_PAY_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROGRESS_STATUS_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMP_PAY_OUTPUT_DANDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMP_PAY_ADMIN_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_FILE_OUTPUT_DANDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCA_FILE_ADMIN_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMP_PAY_OUTLINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANK_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn OFFICE_CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNT_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNT_HOLDER_KANA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCOUNT_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn REC_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DELETE_FLG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANUAL_UPDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADMIN_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYSTEM_UPDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENT_NAME;
        private DataGridViewProgressColumn Progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn BILL_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

