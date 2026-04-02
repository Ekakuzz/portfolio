using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PurrText
{
    public partial class Form1 : Form
    {
        private string currentFilePath = "";

        public Form1()
        {
            InitializeComponent();
            ApplyCustomStyles();
            SubscribeEvents();
            UpdateStatusStrip();
        }

        private void ApplyCustomStyles()
        {
            this.BackColor = Color.FromArgb(255, 240, 245);
            menuStrip1.BackColor = Color.FromArgb(255, 228, 225);
            menuStrip1.ForeColor = Color.FromArgb(139, 69, 19);

            statusStrip1.BackColor = Color.FromArgb(255, 228, 225);
            statusStrip1.ForeColor = Color.FromArgb(139, 69, 19);

            richTextBox1.BackColor = Color.FromArgb(255, 255, 240);
            richTextBox1.Font = new Font("Segoe UI", 11, FontStyle.Regular);
        }

        private void SubscribeEvents()
        {
            this.создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            this.открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            this.сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            this.закрытьToolStripMenuItem.Click += закрытьToolStripMenuItem_Click;

            this.шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
            this.цветToolStripMenuItem.Click += цветToolStripMenuItem_Click;
            this.жирныйToolStripMenuItem.Click += жирныйToolStripMenuItem_Click;
            this.курсивToolStripMenuItem.Click += курсивToolStripMenuItem_Click;
            this.подчеркнутьToolStripMenuItem.Click += подчеркнутьToolStripMenuItem_Click;

            this.шрифтToolStripMenuItem1.Click += шрифтToolStripMenuItem_Click;
            this.цветToolStripMenuItem1.Click += цветToolStripMenuItem_Click;
            this.жирныйToolStripMenuItem1.Click += жирныйToolStripMenuItem_Click;
            this.курсивToolStripMenuItem1.Click += курсивToolStripMenuItem_Click;
            this.подчеркнутьToolStripMenuItem1.Click += подчеркнутьToolStripMenuItem_Click;

            this.оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;

            this.richTextBox1.TextChanged += richTextBox1_TextChanged;
            this.richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            currentFilePath = "";
            this.Text = "PurrText - Новый документ";
            UpdateStatusStrip();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Текстовые файлы|*.txt|RTF файлы|*.rtf|Все файлы|*.*";
            openFileDialog1.Title = "Открыть файл";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string extension = Path.GetExtension(openFileDialog1.FileName).ToLower();

                    if (extension == ".rtf")
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName);
                    }
                    else
                    {
                        richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                    }

                    currentFilePath = openFileDialog1.FileName;
                    this.Text = $"PurrText - {Path.GetFileName(currentFilePath)}";
                    UpdateStatusStrip();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось открыть файл: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                сохранитьКак();
            }
            else
            {
                try
                {
                    string extension = Path.GetExtension(currentFilePath).ToLower();

                    if (extension == ".rtf")
                    {
                        richTextBox1.SaveFile(currentFilePath);
                    }
                    else
                    {
                        File.WriteAllText(currentFilePath, richTextBox1.Text);
                    }

                    MessageBox.Show("Файл сохранен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьКак()
        {
            saveFileDialog1.Filter = "RTF файлы|*.rtf|Текстовые файлы|*.txt|Все файлы|*.*";
            saveFileDialog1.Title = "Сохранить файл";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string extension = Path.GetExtension(saveFileDialog1.FileName).ToLower();

                    if (extension == ".rtf")
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName);
                    }
                    else
                    {
                        File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                    }

                    currentFilePath = saveFileDialog1.FileName;
                    this.Text = $"PurrText - {Path.GetFileName(currentFilePath)}";

                    MessageBox.Show("Файл сохранен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Сохранить изменения перед выходом?",
                "PurrText",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                сохранитьToolStripMenuItem_Click(sender, e);
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (richTextBox1.SelectionLength > 0)
            {
                fontDialog.Font = richTextBox1.SelectionFont;
            }
            else
            {
                fontDialog.Font = richTextBox1.Font;
            }

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void жирныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
            FontStyle newStyle = currentFont.Style;

            if (currentFont.Bold)
                newStyle &= ~FontStyle.Bold;
            else
                newStyle |= FontStyle.Bold;

            richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            жирныйToolStripMenuItem.Checked = !жирныйToolStripMenuItem.Checked;
            жирныйToolStripMenuItem1.Checked = жирныйToolStripMenuItem.Checked;
        }

        private void курсивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
            FontStyle newStyle = currentFont.Style;

            if (currentFont.Italic)
                newStyle &= ~FontStyle.Italic;
            else
                newStyle |= FontStyle.Italic;

            richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            курсивToolStripMenuItem.Checked = !курсивToolStripMenuItem.Checked;
            курсивToolStripMenuItem1.Checked = курсивToolStripMenuItem.Checked;
        }

        private void подчеркнутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
            FontStyle newStyle = currentFont.Style;

            if (currentFont.Underline)
                newStyle &= ~FontStyle.Underline;
            else
                newStyle |= FontStyle.Underline;

            richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            подчеркнутьToolStripMenuItem.Checked = !подчеркнутьToolStripMenuItem.Checked;
            подчеркнутьToolStripMenuItem1.Checked = подчеркнутьToolStripMenuItem.Checked;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Текстовый редактор \"PurrText\"\n" +
                           "Кузьмичева Екатерина\n" +
                           "🐱";

            MessageBox.Show(message, "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateStatusStrip();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateStatusStrip();
        }

        private void UpdateStatusStrip()
        {
            string text = richTextBox1.Text;

            int wordCount = 0;
            int charCount = text.Length;
            int selectedCharCount = richTextBox1.SelectionLength;

            if (!string.IsNullOrWhiteSpace(text))
            {
                wordCount = text.Split(new char[] { ' ', '\n', '\r', '\t' },
                    StringSplitOptions.RemoveEmptyEntries).Length;
            }

            toolStripStatusLabel1.Text = $"Слов: {wordCount}";
            toolStripStatusLabel2.Text = $"Символов: {charCount}";
            toolStripStatusLabel3.Text = $"Выделено: {selectedCharCount}";
        }
    }
}