namespace JBA_BizSupport
{
    partial class frmSearchBank
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bANKCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFFICECDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFFICEFLGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANKOROFFICENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANK_OR_OFFICE_KANA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMABANKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jBADBDataSet = new JBA_BizSupport.JBADBDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.gAMA_BANKTableAdapter = new JBA_BizSupport.JBADBDataSetTableAdapters.GAMA_BANKTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMABANKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(191, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "閉じる";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 4);
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
            this.textBox1.Location = new System.Drawing.Point(86, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 19);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "金融機関名：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 19);
            this.textBox2.TabIndex = 22;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "0005";
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(32, 19);
            this.textBox3.TabIndex = 22;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "三菱東京UFJ銀行";
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(32, 19);
            this.textBox4.TabIndex = 22;
            this.textBox4.TabStop = false;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(38, 190);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(32, 19);
            this.textBox5.TabIndex = 22;
            this.textBox5.TabStop = false;
            this.textBox5.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bANKCDDataGridViewTextBoxColumn,
            this.oFFICECDDataGridViewTextBoxColumn,
            this.oFFICEFLGDataGridViewTextBoxColumn,
            this.bANKOROFFICENAMEDataGridViewTextBoxColumn,
            this.BANK_OR_OFFICE_KANA});
            this.dataGridView1.DataSource = this.gAMABANKBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(22, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(279, 106);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dataGridView1_CellToolTipTextNeeded);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // bANKCDDataGridViewTextBoxColumn
            // 
            this.bANKCDDataGridViewTextBoxColumn.DataPropertyName = "BANK_CD";
            this.bANKCDDataGridViewTextBoxColumn.FillWeight = 50.76142F;
            this.bANKCDDataGridViewTextBoxColumn.HeaderText = "銀行CD";
            this.bANKCDDataGridViewTextBoxColumn.Name = "bANKCDDataGridViewTextBoxColumn";
            this.bANKCDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bANKCDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // oFFICECDDataGridViewTextBoxColumn
            // 
            this.oFFICECDDataGridViewTextBoxColumn.DataPropertyName = "OFFICE_CD";
            this.oFFICECDDataGridViewTextBoxColumn.HeaderText = "OFFICE_CD";
            this.oFFICECDDataGridViewTextBoxColumn.Name = "oFFICECDDataGridViewTextBoxColumn";
            this.oFFICECDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oFFICECDDataGridViewTextBoxColumn.Visible = false;
            // 
            // oFFICEFLGDataGridViewTextBoxColumn
            // 
            this.oFFICEFLGDataGridViewTextBoxColumn.DataPropertyName = "OFFICE_FLG";
            this.oFFICEFLGDataGridViewTextBoxColumn.HeaderText = "OFFICE_FLG";
            this.oFFICEFLGDataGridViewTextBoxColumn.Name = "oFFICEFLGDataGridViewTextBoxColumn";
            this.oFFICEFLGDataGridViewTextBoxColumn.ReadOnly = true;
            this.oFFICEFLGDataGridViewTextBoxColumn.Visible = false;
            // 
            // bANKOROFFICENAMEDataGridViewTextBoxColumn
            // 
            this.bANKOROFFICENAMEDataGridViewTextBoxColumn.DataPropertyName = "BANK_OR_OFFICE_NAME";
            this.bANKOROFFICENAMEDataGridViewTextBoxColumn.FillWeight = 149.2386F;
            this.bANKOROFFICENAMEDataGridViewTextBoxColumn.HeaderText = "銀行名";
            this.bANKOROFFICENAMEDataGridViewTextBoxColumn.Name = "bANKOROFFICENAMEDataGridViewTextBoxColumn";
            this.bANKOROFFICENAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BANK_OR_OFFICE_KANA
            // 
            this.BANK_OR_OFFICE_KANA.DataPropertyName = "BANK_OR_OFFICE_KANA";
            this.BANK_OR_OFFICE_KANA.HeaderText = "BANK_OR_OFFICE_KANA";
            this.BANK_OR_OFFICE_KANA.Name = "BANK_OR_OFFICE_KANA";
            this.BANK_OR_OFFICE_KANA.ReadOnly = true;
            this.BANK_OR_OFFICE_KANA.Visible = false;
            // 
            // gAMABANKBindingSource
            // 
            this.gAMABANKBindingSource.DataMember = "GAMA_BANK";
            this.gAMABANKBindingSource.DataSource = this.jBADBDataSet;
            // 
            // jBADBDataSet
            // 
            this.jBADBDataSet.DataSetName = "JBADBDataSet";
            this.jBADBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "支店選択";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gAMA_BANKTableAdapter
            // 
            this.gAMA_BANKTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "件数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "データ件数：";
            // 
            // frmSearchBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSearchBank";
            this.Text = "金融機関検索";
            this.Load += new System.EventHandler(this.frmSearchBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMABANKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gAMABANKBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANKCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFFICECDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFFICEFLGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bANKOROFFICENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANK_OR_OFFICE_KANA;
        private JBADBDataSet jBADBDataSet;
        private JBADBDataSetTableAdapters.GAMA_BANKTableAdapter gAMA_BANKTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}