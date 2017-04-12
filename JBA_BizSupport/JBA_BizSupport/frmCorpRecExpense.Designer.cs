using System;

namespace JBA_BizSupport
{
    partial class frmCorpRecExpense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DelBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.zIPCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jBADBDataSet = new JBA_BizSupport.JBADBDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.都道府県DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.市区郡町村 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.町域 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.都道府県 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.都道府県DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMAADDRESSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gAMA_ADDRESSTableAdapter = new JBA_BizSupport.JBADBDataSetTableAdapters.GAMA_ADDRESSTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMAADDRESSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 457);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "■費用計上管理システム（法人経費一覧）";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DelBtn,
            this.PersonName,
            this.Age,
            this.PayMethod});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(394, 75);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(439, 222);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DelBtn
            // 
            this.DelBtn.FillWeight = 44.18023F;
            this.DelBtn.HeaderText = "削除";
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PersonName
            // 
            this.PersonName.FillWeight = 203.0457F;
            this.PersonName.HeaderText = "名前";
            this.PersonName.Name = "PersonName";
            // 
            // Age
            // 
            this.Age.FillWeight = 81.97886F;
            this.Age.HeaderText = "年齢";
            this.Age.Name = "Age";
            // 
            // PayMethod
            // 
            this.PayMethod.FillWeight = 70.79522F;
            this.PayMethod.HeaderText = "仮払方法";
            this.PayMethod.Items.AddRange(new object[] {
            "振込",
            "現金"});
            this.PayMethod.Name = "PayMethod";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.maskedTextBox1.Location = new System.Drawing.Point(22, 46);
            this.maskedTextBox1.Mask = "000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(103, 19);
            this.maskedTextBox1.TabIndex = 9;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zIPCODEDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.gAMAADDRESSBindingSource;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(22, 74);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 21;
            this.dataGridView3.Size = new System.Drawing.Size(317, 336);
            this.dataGridView3.TabIndex = 8;
            // 
            // zIPCODEDataGridViewTextBoxColumn
            // 
            this.zIPCODEDataGridViewTextBoxColumn.DataPropertyName = "ZIP_CODE";
            this.zIPCODEDataGridViewTextBoxColumn.HeaderText = "ZIP_CODE";
            this.zIPCODEDataGridViewTextBoxColumn.Name = "zIPCODEDataGridViewTextBoxColumn";
            this.zIPCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.zIPCODEDataGridViewTextBoxColumn.Visible = false;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(805, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 19);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "○○○";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "検索";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(805, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "メニューへ戻る";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "案件名：";
            // 
            // 都道府県DataGridViewTextBoxColumn
            // 
            this.都道府県DataGridViewTextBoxColumn.DataPropertyName = "都道府県";
            this.都道府県DataGridViewTextBoxColumn.HeaderText = "都道府県";
            this.都道府県DataGridViewTextBoxColumn.Name = "都道府県DataGridViewTextBoxColumn";
            // 
            // 市区郡町村
            // 
            this.市区郡町村.DataPropertyName = "市区郡町村";
            this.市区郡町村.HeaderText = "市区郡町村";
            this.市区郡町村.Name = "市区郡町村";
            // 
            // 町域
            // 
            this.町域.DataPropertyName = "町域";
            this.町域.HeaderText = "町域";
            this.町域.Name = "町域";
            // 
            // 都道府県
            // 
            this.都道府県.DataPropertyName = "都道府県";
            this.都道府県.HeaderText = "都道府県";
            this.都道府県.Name = "都道府県";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "市区郡町村";
            this.dataGridViewTextBoxColumn1.HeaderText = "市区町村";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "町域";
            this.dataGridViewTextBoxColumn2.HeaderText = "町字";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // 都道府県DataGridViewTextBoxColumn1
            // 
            this.都道府県DataGridViewTextBoxColumn1.HeaderText = "住所";
            this.都道府県DataGridViewTextBoxColumn1.Name = "都道府県DataGridViewTextBoxColumn1";
            this.都道府県DataGridViewTextBoxColumn1.Width = 500;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "都道府県";
            this.dataGridViewTextBoxColumn3.HeaderText = "都道府県";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "市区郡町村";
            this.dataGridViewTextBoxColumn4.HeaderText = "市区郡町村";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "町域";
            this.dataGridViewTextBoxColumn5.HeaderText = "町域";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "都道府県";
            this.dataGridViewTextBoxColumn6.HeaderText = "都道府県";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "市区郡町村";
            this.dataGridViewTextBoxColumn7.HeaderText = "市区郡町村";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "町域";
            this.dataGridViewTextBoxColumn8.HeaderText = "町域";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
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
            // frmCorpRecExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 473);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCorpRecExpense";
            this.Text = "業務支援システム";
            this.Load += new System.EventHandler(this.frmCorpRecExpense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMAADDRESSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void dDVAADDRESSBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 都道府県DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 市区郡町村;
        private System.Windows.Forms.DataGridViewTextBoxColumn 町域;
        private System.Windows.Forms.DataGridViewTextBoxColumn 都道府県;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 都道府県DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn DelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewComboBoxColumn PayMethod;
        private JBADBDataSet jBADBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn zIPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gAMAADDRESSBindingSource;
        private JBADBDataSetTableAdapters.GAMA_ADDRESSTableAdapter gAMA_ADDRESSTableAdapter;
    }
}