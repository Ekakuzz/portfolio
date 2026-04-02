using System;
using System.Windows.Forms;
using PurchaseApp.PurchaseDBDataSetTableAdapters;

namespace PurchaseApp
{
    public partial class FormЗакупка : Form
    {
        private PurchaseDBDataSet dataSet;
        private Закупка_товараTableAdapter adapter;
        private BindingSource bindingSource;

        public FormЗакупка()
        {
            InitializeComponent();
        }

        private void FormЗакупка_Load(object sender, EventArgs e)
        {
            this.Text = "Журнал закупок";
            this.BackColor = System.Drawing.Color.FromArgb(235, 245, 225);

            dataSet = new PurchaseDBDataSet();
            adapter = new Закупка_товараTableAdapter();
            adapter.Fill(dataSet.Закупка_товара);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Закупка_товара;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;

            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(225, 240, 215);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(66, 102, 49);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            buttonОбновить.BackColor = System.Drawing.Color.FromArgb(0, 153, 0);
            buttonОбновить.ForeColor = System.Drawing.Color.White;
            buttonОбновить.FlatStyle = FlatStyle.Flat;
            buttonОбновить.FlatAppearance.BorderSize = 0;

            buttonФильтрПоПоставщику.BackColor = System.Drawing.Color.FromArgb(66, 102, 49);
            buttonФильтрПоКатегории.BackColor = System.Drawing.Color.FromArgb(86, 122, 69);
            buttonСнятьФильтр.BackColor = System.Drawing.Color.FromArgb(146, 82, 72);

            buttonФильтрПоПоставщику.ForeColor = System.Drawing.Color.White;
            buttonФильтрПоКатегории.ForeColor = System.Drawing.Color.White;
            buttonСнятьФильтр.ForeColor = System.Drawing.Color.White;

            buttonФильтрПоПоставщику.FlatStyle = FlatStyle.Flat;
            buttonФильтрПоКатегории.FlatStyle = FlatStyle.Flat;
            buttonСнятьФильтр.FlatStyle = FlatStyle.Flat;

            buttonФильтрПоПоставщику.FlatAppearance.BorderSize = 0;
            buttonФильтрПоКатегории.FlatAppearance.BorderSize = 0;
            buttonСнятьФильтр.FlatAppearance.BorderSize = 0;

            buttonФильтрПоПоставщику.Text = "Фильтр по поставщику";
            buttonФильтрПоКатегории.Text = "Фильтр по категории";
            buttonСнятьФильтр.Text = "Снять фильтр";
        }

        private void buttonОбновить_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource.EndEdit();
            this.adapter.Update(this.dataSet.Закупка_товара);
            MessageBox.Show("Данные обновлены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonФильтрПоПоставщику_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                var value = dataGridView1.Rows[rowIndex].Cells["Код_поставщика"].Value;
                if (value != null)
                {
                    bindingSource.Filter = "Код_поставщика = " + value;
                }
            }
        }

        private void buttonФильтрПоКатегории_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                var value = dataGridView1.Rows[rowIndex].Cells["Код_категории"].Value;
                if (value != null)
                {
                    bindingSource.Filter = "Код_категории = " + value;
                }
            }
        }

        private void buttonСнятьФильтр_Click(object sender, EventArgs e)
        {
            bindingSource.Filter = "";
        }
    }
}