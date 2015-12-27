using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Debit
{
    public partial class MainForm : Form
    {
        private double _balanse;

        public MainForm()
        {
            InitializeComponent();

            _balanse = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MoneyEntry me = new MoneyEntry();

            double income;
            double.TryParse(textBoxAmount.Text, out income);

            me.Amount = income;
            me.EntryDate = dtpDate.Value;
            me.Category = textBoxKategory.Text;
            me.Description = textBoxDescription.Text;

            AddEntry(me);
            Update();
            ClearFields();
        }

        private void Update()
        {
            _balanse = 0;

            foreach (DataGridViewRow row in dataGridViewEntries.Rows)
            {
                double income;
                double.TryParse((row.Cells[1].Value ?? "0").ToString(), out income);
                _balanse += income;
            }

            textBoxBalanse.Text = _balanse.ToString();
        }

        private void AddEntry(MoneyEntry me)
        { 
            dataGridViewEntries.Rows.Add(me.IsDebit ? "Доход":"Расход",
                me.Amount,
                me.EntryDate.ToShortDateString(),
                me.Description,
                me.Category);
        }

        private void ClearFields() 
        {
            textBoxAmount.Text = textBoxDescription.Text = textBoxKategory.Text = "";
            dtpDate.Value = DateTime.Now;
        }

        private void dataGridViewEntries_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double income;
            if (e.ColumnIndex == 1 && dataGridViewEntries.Rows.Count > 0)
            {

                double.TryParse((dataGridViewEntries[e.ColumnIndex, e.RowIndex].Value ?? "0").ToString(), out income);
                dataGridViewEntries[0, e.RowIndex].Value = (income < 0) ? "Расход" : "Расход";
                Update();
            }
        }
    }
}
