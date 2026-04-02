using System;
using System.Windows.Forms;
using PurchaseApp.PurchaseDBDataSetTableAdapters;

namespace PurchaseApp
{
    public partial class FormПоставщик : Form
    {
        private PurchaseDBDataSet dataSet;
        private ПоставщикTableAdapter adapter;
        private BindingSource bindingSource;

        public FormПоставщик()
        {
            InitializeComponent();
        }

        private void FormПоставщик_Load(object sender, EventArgs e)
        {
            this.Text = "Справочник поставщиков";
            this.BackColor = System.Drawing.Color.FromArgb(235, 245, 225);

            dataSet = new PurchaseDBDataSet();
            adapter = new ПоставщикTableAdapter();
            adapter.Fill(dataSet.Поставщик);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataSet.Поставщик;

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
            this.adapter.Update(this.dataSet.Поставщик);
            MessageBox.Show("Данные обновлены", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}