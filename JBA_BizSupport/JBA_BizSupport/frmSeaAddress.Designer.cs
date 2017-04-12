namespace JBA_BizSupport
{
    partial class frmSeaAddress
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ZIP_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jBADBDataSet = new JBA_BizSupport.JBADBDataSet();
            this.gAMAADDRESSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMA_ADDRESSTableAdapter = new JBA_BizSupport.JBADBDataSetTableAdapters.GAMA_ADDRESSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMAADDRESSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(225, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 27);
            this.button6.TabIndex = 2;
            this.button6.Text = "閉じる";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = "郵便番号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "000-0000";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZIP_CODE,
            this.expr1DataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.gAMAADDRESSBindingSource;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(16, 34);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 21;
            this.dataGridView3.Size = new System.Drawing.Size(319, 128);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentDoubleClick);
            this.dataGridView3.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.DataGridView3_CellToolTipTextNeeded);
            this.dataGridView3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView3_KeyDown);
            // 
            // ZIP_CODE
            // 
            this.ZIP_CODE.DataPropertyName = "ZIP_CODE";
            this.ZIP_CODE.HeaderText = "ZIP_CODE";
            this.ZIP_CODE.Name = "ZIP_CODE";
            this.ZIP_CODE.ReadOnly = true;
            this.ZIP_CODE.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "設定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "件数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 12);
            this.label5.TabIndex = 38;
            this.label5.Text = "データ件数：";
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "住所";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jBADBDataSet
            // 
            this.jBADBDataSet.DataSetName = "JBADBDataSet";
            this.jBADBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gAMAADDRESSBindingSource
            // 
            this.gAMAADDRESSBindingSource.DataMember = "GAMA_ADDRESS";
            this.gAMAADDRESSBindingSource.DataSource = this.jBADBDataSet;
            // 
            // gAMA_ADDRESSTableAdapter
            // 
            this.gAMA_ADDRESSTableAdapter.ClearBeforeFill = true;
            // 
            // frmSeaAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 211);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmSeaAddress";
            this.Text = "住所検索";
            this.Load += new System.EventHandler(this.frmSeaAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMAADDRESSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private JBADBDataSet jBADBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZIP_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource gAMAADDRESSBindingSource;
        private JBADBDataSetTableAdapters.GAMA_ADDRESSTableAdapter gAMA_ADDRESSTableAdapter;
    }
}