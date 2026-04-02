using System;
using System.Windows.Forms;
using PurchaseApp.PurchaseDBDataSetTableAdapters;

namespace PurchaseApp
{
    public partial class FormТовар : Form
    {
        private PurchaseDBDataSet dataSet;
        private ТоварTableAdapter adapter;
        private BindingSource bindingSource;

        public FormТовар()
        {
            InitializeComponent();
        }

        private void FormТовар_Load(object sender, EventArgs e)
        {
            this.Text = "Справочник товаров";
            this.BackColor = System.Drawing.Color.FromArgb(235, 245, 225);

            dataSet = new PurchaseDBDataSet();
            adapter = new ТоварTableAdapter();
            adapter.Fill(dataSet.Товар);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Товар;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;

            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(225, 240, 215);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(66, 102, 49);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            buttonОбновить.BackColor = System.Drawing.Color.FromArgb(66, 102, 49);
            buttonОбновить.ForeColor = System.Drawing.Color.White;
            buttonОбновить.FlatStyle = FlatStyle.Flat;
            buttonОбновить.FlatAppearance.BorderSize = 0;
        }

        private void buttonОбновить_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource.EndEdit();
            this.adapter.Update(this.dataSet.Товар);
            MessageBox.Show("Данные обновлены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}