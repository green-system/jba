namespace JBA_BizSupport
{
    partial class frmSeaBusinessName
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bUSINESSCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUSINESSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bILLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELETEFLGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANUALUPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDMINNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYSTEMUPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMABUSINESSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jBADBDataSet = new JBA_BizSupport.JBADBDataSet();
            this.gAMA_BUSINESSTableAdapter = new JBA_BizSupport.JBADBDataSetTableAdapters.GAMA_BUSINESSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMABUSINESSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "事業名：";
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox1.Location = new System.Drawing.Point(72, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 19);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(418, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "閉じる";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 191);
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
            this.bUSINESSCDDataGridViewTextBoxColumn,
            this.bUSINESSNAMEDataGridViewTextBoxColumn,
            this.bILLIDDataGridViewTextBoxColumn,
            this.dELETEFLGDataGridViewTextBoxColumn,
            this.mANUALUPDATEDataGridViewTextBoxColumn,
            this.aDMINNUMBERDataGridViewTextBoxColumn,
            this.sYSTEMUPDATEDataGridViewTextBoxColumn,
            this.BillID});
            this.dataGridView1.DataSource = this.gAMABUSINESSBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(30, 47);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(507, 129);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "BillID";
            this.BillID.FillWeight = 50F;
            this.BillID.HeaderText = "会計区分";
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "件数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "データ件数：";
            // 
            // bUSINESSCDDataGridViewTextBoxColumn
            // 
            this.bUSINESSCDDataGridViewTextBoxColumn.DataPropertyName = "BUSINESS_CD";
            this.bUSINESSCDDataGridViewTextBoxColumn.FillWeight = 50F;
            this.bUSINESSCDDataGridViewTextBoxColumn.HeaderText = "事業コード";
            this.bUSINESSCDDataGridViewTextBoxColumn.Name = "bUSINESSCDDataGridViewTextBoxColumn";
            this.bUSINESSCDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bUSINESSNAMEDataGridViewTextBoxColumn
            // 
            this.bUSINESSNAMEDataGridViewTextBoxColumn.DataPropertyName = "BUSINESS_NAME";
            this.bUSINESSNAMEDataGridViewTextBoxColumn.FillWeight = 150F;
            this.bUSINESSNAMEDataGridViewTextBoxColumn.HeaderText = "事業名称";
            this.bUSINESSNAMEDataGridViewTextBoxColumn.Name = "bUSINESSNAMEDataGridViewTextBoxColumn";
            this.bUSINESSNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bILLIDDataGridViewTextBoxColumn
            // 
            this.bILLIDDataGridViewTextBoxColumn.DataPropertyName = "BILL_ID";
            this.bILLIDDataGridViewTextBoxColumn.HeaderText = "BILL_ID";
            this.bILLIDDataGridViewTextBoxColumn.Name = "bILLIDDataGridViewTextBoxColumn";
            this.bILLIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bILLIDDataGridViewTextBoxColumn.Visible = false;
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
            // gAMABUSINESSBindingSource
            // 
            this.gAMABUSINESSBindingSource.DataMember = "GAMA_BUSINESS";
            this.gAMABUSINESSBindingSource.DataSource = this.jBADBDataSet;
            // 
            // jBADBDataSet
            // 
            this.jBADBDataSet.DataSetName = "JBADBDataSet";
            this.jBADBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gAMA_BUSINESSTableAdapter
            // 
            this.gAMA_BUSINESSTableAdapter.ClearBeforeFill = true;
            // 
            // frmSeaBusinessName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 234);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSeaBusinessName";
            this.Text = "事業名検索";
            this.Load += new System.EventHandler(this.frmSeaBusinessName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMABUSINESSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private JBADBDataSet jBADBDataSet;
        private System.Windows.Forms.BindingSource gAMABUSINESSBindingSource;
        private JBADBDataSetTableAdapters.GAMA_BUSINESSTableAdapter gAMA_BUSINESSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUSINESSCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUSINESSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dELETEFLGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANUALUPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDMINNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sYSTEMUPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}