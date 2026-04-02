using System;
using System.Windows.Forms;

namespace PurchaseApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = "База данных 'Закупка товара' - Вариант 4";
            this.BackColor = System.Drawing.Color.FromArgb(27, 55, 37);

            labelHeader.Text = "УПРАВЛЕНИЕ ЗАКУПКАМИ";
            labelHeader.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            labelHeader.ForeColor = System.Drawing.Color.FromArgb(220, 237, 193);
            labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            buttonДолжность.Text = "Должности";
            buttonКатегория.Text = "Категории товаров";
            buttonПоставщик.Text = "Поставщики";
            buttonСотрудник.Text = "Сотрудники";
            buttonТовар.Text = "Товары";
            buttonЗакупка.Text = "Закупки";
            buttonРеализация.Text = "Реализация";
            buttonВыход.Text = "Выход";

            buttonДолжность.BackColor = System.Drawing.Color.FromArgb(66, 102, 49);
            buttonКатегория.BackColor = System.Drawing.Color.FromArgb(76, 112, 59);
            buttonПоставщик.BackColor = System.Drawing.Color.FromArgb(86, 122, 69);
            buttonСотрудник.BackColor = System.Drawing.Color.FromArgb(96, 132, 79);
            buttonТовар.BackColor = System.Drawing.Color.FromArgb(106, 142, 89);
            buttonЗакупка.BackColor = System.Drawing.Color.FromArgb(116, 152, 99);
            buttonРеализация.BackColor = System.Drawing.Color.FromArgb(126, 162, 109);
            buttonВыход.BackColor = System.Drawing.Color.FromArgb(146, 82, 72);

            foreach (Button btn in new[] {
                buttonДолжность, buttonКатегория, buttonПоставщик,
                buttonСотрудник, buttonТовар, buttonЗакупка,
                buttonРеализация, buttonВыход })
            {
                btn.ForeColor = System.Drawing.Color.FromArgb(245, 245, 220);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
                btn.Height = 50;
                btn.Cursor = Cursors.Hand;
            }
        }

        private void buttonДолжность_Click(object sender, EventArgs e)
        {
            FormДолжность f = new FormДолжность();
            f.Show();
        }

        private void buttonКатегория_Click(object sender, EventArgs e)
        {
            FormКатегория f = new FormКатегория();
            f.Show();
        }

        private void buttonПоставщик_Click(object sender, EventArgs e)
        {
            FormПоставщик f = new FormПоставщик();
            f.Show();
        }

        private void buttonСотрудник_Click(object sender, EventArgs e)
        {
            FormСотрудник f = new FormСотрудник();
            f.Show();
        }

        private void buttonТовар_Click(object sender, EventArgs e)
        {
            FormТовар f = new FormТовар();
            f.Show();
        }

        private void buttonЗакупка_Click(object sender, EventArgs e)
        {
            FormЗакупка f = new FormЗакупка();
            f.Show();
        }

        private void buttonРеализация_Click(object sender, EventArgs e)
        {
            FormРеализация f = new FormРеализация();
            f.Show();
        }

        private void buttonВыход_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}