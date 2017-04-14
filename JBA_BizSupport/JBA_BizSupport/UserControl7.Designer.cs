namespace JBA_BizSupport
{
    partial class UserControl7
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl7));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gAMAHIMOKUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jBADBDataSet = new JBA_BizSupport.JBADBDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gAMA_HIMOKUTableAdapter = new JBA_BizSupport.JBADBDataSetTableAdapters.GAMA_HIMOKUTableAdapter();
            this.pCA_DATA_DETAILTableAdapter = new JBA_BizSupport.JBADBDataSetTableAdapters.PCA_DATA_DETAILTableAdapter();
            this.pCADATADETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.himokuname1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.himokuname2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BORROWED_SUBJECT_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BORROWED_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEND_SUBJECT_CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEND_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DummyForScrolBar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMAHIMOKUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCADATADETAILBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(11, 7);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(277, 35);
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(7, 34);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(813, 57);
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(159, 197);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(182, 30);
            this.button10.TabIndex = 14;
            this.button10.Text = "PCA受渡仕訳データ作成";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(19, 197);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(131, 30);
            this.button9.TabIndex = 13;
            this.button9.Text = "仕訳データ生成";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.BORROWED_SUBJECT_CD,
            this.himokuname1,
            this.BORROWED_PRICE,
            this.LEND_SUBJECT_CD,
            this.himokuname2,
            this.LEND_PRICE,
            this.DummyForScrolBar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(19, 90);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(795, 73);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.VisibleChanged += new System.EventHandler(this.dataGridView1_VisibleChanged);
            // 
            // gAMAHIMOKUBindingSource
            // 
            this.gAMAHIMOKUBindingSource.DataMember = "GAMA_HIMOKU";
            this.gAMAHIMOKUBindingSource.DataSource = this.jBADBDataSet;
            // 
            // jBADBDataSet
            // 
            this.jBADBDataSet.DataSetName = "JBADBDataSet";
            this.jBADBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(299, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(130, 19);
            this.textBox1.TabIndex = 24;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Location = new System.Drawing.Point(684, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(130, 19);
            this.textBox2.TabIndex = 24;
            this.textBox2.TabStop = false;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "PCA_DATA_NUMBER";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // gAMA_HIMOKUTableAdapter
            // 
            this.gAMA_HIMOKUTableAdapter.ClearBeforeFill = true;
            // 
            // pCA_DATA_DETAILTableAdapter
            // 
            this.pCA_DATA_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // pCADATADETAILBindingSource
            // 
            this.pCADATADETAILBindingSource.DataMember = "PCA_DATA_DETAIL";
            this.pCADATADETAILBindingSource.DataSource = this.jBADBDataSet;
            // 
            // himokuname1
            // 
            this.himokuname1.DataSource = this.gAMAHIMOKUBindingSource;
            this.himokuname1.DisplayMember = "HIMOKU_NAME";
            this.himokuname1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.himokuname1.FillWeight = 128F;
            this.himokuname1.HeaderText = "科目名";
            this.himokuname1.MinimumWidth = 128;
            this.himokuname1.Name = "himokuname1";
            this.himokuname1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.himokuname1.ValueMember = "HIMOKU_CD";
            // 
            // himokuname2
            // 
            this.himokuname2.DataSource = this.gAMAHIMOKUBindingSource;
            this.himokuname2.DisplayMember = "HIMOKU_NAME";
            this.himokuname2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.himokuname2.FillWeight = 128F;
            this.himokuname2.HeaderText = "科目名";
            this.himokuname2.MinimumWidth = 128;
            this.himokuname2.Name = "himokuname2";
            this.himokuname2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.himokuname2.ValueMember = "HIMOKU_CD";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.FillWeight = 25F;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 25;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 128F;
            this.dataGridViewTextBoxColumn2.HeaderText = "科目CODE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 128;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 128;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn3.FillWeight = 127F;
            this.dataGridViewTextBoxColumn3.HeaderText = "金額";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 9;
            this.dataGridViewTextBoxColumn3.MinimumWidth = 127;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 128;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 128F;
            this.dataGridViewTextBoxColumn4.HeaderText = "科目CODE";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 128;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 128;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn5.FillWeight = 127F;
            this.dataGridViewTextBoxColumn5.HeaderText = "金額";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 9;
            this.dataGridViewTextBoxColumn5.MinimumWidth = 127;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 127;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn6.FillWeight = 18F;
            this.dataGridViewTextBoxColumn6.HeaderText = "スクロールバー用ダミー列";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 18;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 18;
            // 
            // No
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.No.DefaultCellStyle = dataGridViewCellStyle1;
            this.No.FillWeight = 25F;
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 25;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BORROWED_SUBJECT_CD
            // 
            this.BORROWED_SUBJECT_CD.FillWeight = 128F;
            this.BORROWED_SUBJECT_CD.HeaderText = "科目CODE";
            this.BORROWED_SUBJECT_CD.MinimumWidth = 128;
            this.BORROWED_SUBJECT_CD.Name = "BORROWED_SUBJECT_CD";
            this.BORROWED_SUBJECT_CD.ReadOnly = true;
            this.BORROWED_SUBJECT_CD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BORROWED_PRICE
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.BORROWED_PRICE.DefaultCellStyle = dataGridViewCellStyle2;
            this.BORROWED_PRICE.FillWeight = 127F;
            this.BORROWED_PRICE.HeaderText = "金額";
            this.BORROWED_PRICE.MaxInputLength = 9;
            this.BORROWED_PRICE.MinimumWidth = 127;
            this.BORROWED_PRICE.Name = "BORROWED_PRICE";
            this.BORROWED_PRICE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LEND_SUBJECT_CD
            // 
            this.LEND_SUBJECT_CD.FillWeight = 128F;
            this.LEND_SUBJECT_CD.HeaderText = "科目CODE";
            this.LEND_SUBJECT_CD.MinimumWidth = 128;
            this.LEND_SUBJECT_CD.Name = "LEND_SUBJECT_CD";
            this.LEND_SUBJECT_CD.ReadOnly = true;
            this.LEND_SUBJECT_CD.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // LEND_PRICE
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.LEND_PRICE.DefaultCellStyle = dataGridViewCellStyle3;
            this.LEND_PRICE.FillWeight = 127F;
            this.LEND_PRICE.HeaderText = "金額";
            this.LEND_PRICE.MaxInputLength = 9;
            this.LEND_PRICE.MinimumWidth = 127;
            this.LEND_PRICE.Name = "LEND_PRICE";
            this.LEND_PRICE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DummyForScrolBar
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.DummyForScrolBar.DefaultCellStyle = dataGridViewCellStyle4;
            this.DummyForScrolBar.FillWeight = 18F;
            this.DummyForScrolBar.HeaderText = "スクロールバー用ダミー列";
            this.DummyForScrolBar.MinimumWidth = 18;
            this.DummyForScrolBar.Name = "DummyForScrolBar";
            this.DummyForScrolBar.ReadOnly = true;
            this.DummyForScrolBar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DummyForScrolBar.Visible = false;
            // 
            // UserControl7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Name = "UserControl7";
            this.Size = new System.Drawing.Size(837, 241);
            this.Load += new System.EventHandler(this.UserControl7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gAMAHIMOKUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jBADBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCADATADETAILBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource gAMAHIMOKUBindingSource;
        private JBADBDataSet jBADBDataSet;
        private JBADBDataSetTableAdapters.GAMA_HIMOKUTableAdapter gAMA_HIMOKUTableAdapter;
        private JBADBDataSetTableAdapters.PCA_DATA_DETAILTableAdapter pCA_DATA_DETAILTableAdapter;
        private System.Windows.Forms.BindingSource pCADATADETAILBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn BORROWED_SUBJECT_CD;
        private System.Windows.Forms.DataGridViewComboBoxColumn himokuname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BORROWED_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEND_SUBJECT_CD;
        private System.Windows.Forms.DataGridViewComboBoxColumn himokuname2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEND_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DummyForScrolBar;
    }
}
