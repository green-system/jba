﻿using System;
using System.Windows.Forms;

namespace JBA_BizSupport
{
    public class CalendarColumn : DataGridViewColumn
    {
        public CalendarColumn()
            : base(new CalendarCell())
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get { return base.CellTemplate; }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                {
                    throw new InvalidCastException("Must be a CalendarCell");
                }
                base.CellTemplate = value;
            }
        }
    }

    public class CalendarCell : DataGridViewTextBoxCell
    {

        public CalendarCell()
            : base()
        {
            this.Style.Format = "d";
        }

        public override void InitializeEditingControl(int rowIndex, object
            initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            CalendarEditingControl ctl = DataGridView.EditingControl as CalendarEditingControl;
            if (this.Value == null || Value.ToString() == "")
            {//Nullもしくは空白なら今日を表示値にしてチェックボックスを外す
                ctl.Value = (DateTime)this.DefaultNewRowValue;
                ctl.Checked = false;
            }
            else
            {
                ctl.Value = (DateTime)this.Value;
                ctl.Checked = true;
            }
        }

        public override Type EditType { get { return typeof(CalendarEditingControl); } }

        public override Type ValueType
        {
            get { return typeof(DateTime); }
        }

        public override object DefaultNewRowValue
        {
            get { return DateTime.Now; }
        }

        protected override void OnKeyDown(KeyEventArgs e, int rowIndex)
        {
            base.OnKeyDown(e, rowIndex);

            if (e.KeyCode == Keys.Delete)
            {//DELETEキーでNULLにしてしまう方法の場合はセルの値にDBNull.Valueを入れる
                this.Value = DBNull.Value;
            }
        }
    }

    class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        DataGridView dataGridView;
        private bool valueChanged = false;
        int rowIndex;

        public CalendarEditingControl()
        {
            this.Format = DateTimePickerFormat.Short;

            //チェックボックスを表示することでNULLを選択する場合
            this.ShowCheckBox = true;
        }

        public object EditingControlFormattedValue
        {
            get
            {
                if (this.Checked)
                {
                    return this.Value; //チェックを入れてたら日付あり
                }
                else
                {
                    return null;//チェックを外してたらnull
                }
            }
            set
            {
                if (value is DateTime)
                {
                    this.Checked = false;//チェックをいれる
                    this.Value = DateTime.Now;
                }
                else if (value is String)
                {
                    this.Checked = true;
                    try
                    {
                        this.Value = DateTime.Parse((String)value);
                    }
                    catch
                    {
                        this.Value = DateTime.Now;
                    }
                }
                else
                {
                    this.Checked = false;//チェックボックスを外す
                    this.Value = DateTime.Now;
                }
            }
        }
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            //nullは空白表示に
            DateTime? value = (DateTime?)this.EditingControlFormattedValue;
            return value == null ? string.Empty : value.Value.ToShortDateString();
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex
        {
            get { return rowIndex; }
            set { rowIndex = value; }
        }

        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
            // No preparation needs to be done.
        }

        public bool RepositionEditingControlOnValueChange { get { return false; } }

        public DataGridView EditingControlDataGridView
        {
            get { return dataGridView; }
            set { dataGridView = value; }
        }

        public bool EditingControlValueChanged
        {
            get { return valueChanged; }
            set { valueChanged = value; }
        }

        public Cursor EditingPanelCursor { get { return base.Cursor; } }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            valueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
}
