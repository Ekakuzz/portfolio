using System;
using System.Windows.Forms;
using PurchaseApp.PurchaseDBDataSetTableAdapters;

namespace PurchaseApp
{
    public partial class FormКатегория : Form
    {
        private PurchaseDBDataSet dataSet;
        private Категория_товараTableAdapter adapter;
        private BindingSource bindingSource;

        public FormКатегория()
        {
            InitializeComponent();
        }

        private void FormКатегория_Load(object sender, EventArgs e)
        {
            this.Text = "Справочник категорий товаров";
            this.BackColor = System.Drawing.Color.FromArgb(235, 245, 225);

            dataSet = new PurchaseDBDataSet();
            adapter = new Категория_товараTableAdapter();
            adapter.Fill(dataSet.Категория_товара);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Категория_товара;

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
            this.adapter.Update(this.dataSet.Категория_товара);
            MessageBox.Show("Данные обновлены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}