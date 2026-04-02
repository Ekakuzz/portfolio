using System;
using System.Drawing;
using System.Windows.Forms;

namespace PixelPaw
{
    public partial class Form1 : Form
    {
        private int instrumentSize = 5; 
        private Color instrumentColor = Color.Black; 
        private string instrumentType = "pencil"; 

        private bool isDrawing = false;
        private Point lastPoint;
        private Bitmap canvasBitmap;
        private Graphics canvasGraphics;
        private string currentFilePath = "";

        private bool isCroppingMode = false;
        private Point cropStartPoint;
        private Point cropEndPoint;
        private Rectangle cropRectangle;
        private bool isSelectingCrop = false;

        public Form1()
        {
            InitializeComponent();
            InitializeCanvas();

            this.Load += Form1_Load;

            this.pictureBoxCanvas.MouseDown += pictureBoxCanvas_MouseDown;
            this.pictureBoxCanvas.MouseMove += pictureBoxCanvas_MouseMove;
            this.pictureBoxCanvas.MouseUp += pictureBoxCanvas_MouseUp;

            this.создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            this.открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            this.сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            this.закрытьToolStripMenuItem.Click += закрытьToolStripMenuItem_Click;
            this.оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;

            this.кадрироватьToolStripMenuItem.Click += кадрироватьToolStripMenuItem_Click;
            this.повернутьToolStripMenuItem.Click += повернутьToolStripMenuItem_Click;

            this.trackBarSize.Scroll += trackBarSize_Scroll;

            this.btnColor.Click += btnColor_Click;

            this.btnPencil.Click += btnPencil_Click;
            this.btnEraser.Click += btnEraser_Click;

            ApplyCustomStyles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeCanvas();

            trackBarSize.Value = instrumentSize;
            lblSize.Text = $"Размер: {instrumentSize}";
            btnColor.BackColor = instrumentColor;
            btnPencil_Click(sender, e); 
        }

        private void ApplyCustomStyles()
        {
            this.BackColor = Color.FromArgb(255, 240, 245);
            menuStrip1.BackColor = Color.FromArgb(255, 228, 225);
            menuStrip1.ForeColor = Color.FromArgb(139, 69, 19);
        }

        private void InitializeCanvas()
        {
            if (pictureBoxCanvas.Width > 0 && pictureBoxCanvas.Height > 0)
            {
                canvasBitmap = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
                canvasGraphics = Graphics.FromImage(canvasBitmap);
                canvasGraphics.Clear(Color.White);
                canvasGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                pictureBoxCanvas.Image = canvasBitmap;
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvasGraphics.Clear(Color.White);
            pictureBoxCanvas.Invalidate();
            currentFilePath = "";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image loadedImage = Image.FromFile(openDialog.FileName);
                    canvasBitmap = new Bitmap(loadedImage, pictureBoxCanvas.Width, pictureBoxCanvas.Height);
                    canvasGraphics = Graphics.FromImage(canvasBitmap);
                    pictureBoxCanvas.Image = canvasBitmap;
                    currentFilePath = openDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось загрузить изображение: " + ex.Message);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            saveDialog.Title = "Сохранить рисунок";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    canvasBitmap.Save(saveDialog.FileName);
                    currentFilePath = saveDialog.FileName;
                    MessageBox.Show("Файл сохранен!", "PixelPaw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка сохранения: " + ex.Message);
                }
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Сохранить изменения перед выходом?",
                "PixelPaw",
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

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "\"PixelPaw\"\n" +
                           "Кузьмичева Екатерина\n" +
                           "Группа: Ип3-23\n\n" +
                           "🐾";

            MessageBox.Show(message, "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void кадрироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isCroppingMode)
            {
                isCroppingMode = true;
                MessageBox.Show("Выделите область для кадрирования:\n" +
                               "1. Нажмите и удерживайте левую кнопку мыши в начальной точке\n" +
                               "2. Перетащите до конечной точки\n" +
                               "3. Отпустите кнопку мыши для кадрирования",
                               "Режим кадрирования",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            else
            {
                isCroppingMode = false;
                cropRectangle = Rectangle.Empty;
                pictureBoxCanvas.Invalidate();
            }
        }

        private void PerformCrop(Rectangle cropRect)
        {
            if (cropRect.Width > 0 && cropRect.Height > 0)
            {
                try
                {
                    Bitmap croppedBitmap = new Bitmap(cropRect.Width, cropRect.Height);

                    using (Graphics g = Graphics.FromImage(croppedBitmap))
                    {
                        g.DrawImage(canvasBitmap, 0, 0, cropRect, GraphicsUnit.Pixel);
                    }

                    canvasBitmap = croppedBitmap;
                    canvasGraphics = Graphics.FromImage(canvasBitmap);
                    pictureBoxCanvas.Image = canvasBitmap;

                    isCroppingMode = false;
                    cropRectangle = Rectangle.Empty;

                    MessageBox.Show("Изображение успешно обрезано!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при кадрировании: " + ex.Message);
                }
            }
        }

        private void повернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap rotatedBitmap = new Bitmap(canvasBitmap.Height, canvasBitmap.Width);

                using (Graphics g = Graphics.FromImage(rotatedBitmap))
                {
                    g.TranslateTransform(rotatedBitmap.Width / 2f, rotatedBitmap.Height / 2f);
                    g.RotateTransform(90); 
                    g.TranslateTransform(-canvasBitmap.Width / 2f, -canvasBitmap.Height / 2f);

                    g.DrawImage(canvasBitmap, 0, 0);
                }

                canvasBitmap = rotatedBitmap;
                canvasGraphics = Graphics.FromImage(canvasBitmap);
                pictureBoxCanvas.Image = canvasBitmap;

                pictureBoxCanvas.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при повороте: " + ex.Message);
            }
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            instrumentSize = trackBarSize.Value;
            lblSize.Text = $"Размер: {instrumentSize}";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                instrumentColor = colorDialog1.Color;
                btnColor.BackColor = instrumentColor;
            }
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            instrumentType = "pencil";
            btnPencil.BackColor = Color.LightPink;
            btnEraser.BackColor = Color.FromArgb(255, 182, 193);
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            instrumentType = "eraser";
            btnEraser.BackColor = Color.LightPink;
            btnPencil.BackColor = Color.FromArgb(255, 182, 193);
        }

        private void pictureBoxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (isCroppingMode && e.Button == MouseButtons.Left)
            {
                isSelectingCrop = true;
                cropStartPoint = e.Location;
                cropEndPoint = e.Location;
                cropRectangle = Rectangle.Empty;
            }
            else if (e.Button == MouseButtons.Left && !isCroppingMode)
            {
                isDrawing = true;
                lastPoint = e.Location;
                DrawPoint(e.Location);
            }
        }

        private void pictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelectingCrop && isCroppingMode)
            {
                cropEndPoint = e.Location;

                int x = Math.Min(cropStartPoint.X, cropEndPoint.X);
                int y = Math.Min(cropStartPoint.Y, cropEndPoint.Y);
                int width = Math.Abs(cropEndPoint.X - cropStartPoint.X);
                int height = Math.Abs(cropEndPoint.Y - cropStartPoint.Y);

                cropRectangle = new Rectangle(x, y, width, height);

                pictureBoxCanvas.Invalidate();
            }
            else if (isDrawing && !isCroppingMode)
            {
                DrawLine(lastPoint, e.Location);
                lastPoint = e.Location;
                pictureBoxCanvas.Invalidate();
            }
        }

        private void pictureBoxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isSelectingCrop && isCroppingMode)
            {
                isSelectingCrop = false;

                if (cropRectangle.Width > 0 && cropRectangle.Height > 0)
                {
                    PerformCrop(cropRectangle);
                }
                else
                {
                    MessageBox.Show("Область кадрирования слишком мала!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    isCroppingMode = false;
                    cropRectangle = Rectangle.Empty;
                    pictureBoxCanvas.Invalidate();
                }
            }
            else if (isDrawing)
            {
                isDrawing = false;
            }
        }

        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (isCroppingMode && cropRectangle != Rectangle.Empty)
            {
                using (Brush darkBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0)))
                {
                    e.Graphics.FillRectangle(darkBrush, pictureBoxCanvas.ClientRectangle);
                }

                using (Pen pen = new Pen(Color.White, 2))
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    e.Graphics.DrawRectangle(pen, cropRectangle);
                }

                string sizeText = $"{cropRectangle.Width} x {cropRectangle.Height}";
                using (Font font = new Font("Segoe UI", 10, FontStyle.Bold))
                using (Brush textBrush = new SolidBrush(Color.White))
                {
                    Point textPoint = new Point(
                        cropRectangle.Right + 5,
                        cropRectangle.Bottom + 5
                    );

                    if (textPoint.X + 70 > pictureBoxCanvas.Width)
                        textPoint.X = cropRectangle.Left - 75;
                    if (textPoint.Y + 20 > pictureBoxCanvas.Height)
                        textPoint.Y = cropRectangle.Top - 25;

                    e.Graphics.DrawString(sizeText, font, textBrush, textPoint);
                }
            }
        }

        private void DrawLine(Point start, Point end)
        {
            if (instrumentType == "eraser")
            {
                using (Pen pen = new Pen(Color.White, instrumentSize))
                {
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    canvasGraphics.DrawLine(pen, start, end);
                }
            }
            else
            {
                using (Pen pen = new Pen(instrumentColor, instrumentSize))
                {
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    canvasGraphics.DrawLine(pen, start, end);
                }
            }
        }

        private void DrawPoint(Point location)
        {
            if (instrumentType == "eraser")
            {
                using (Brush brush = new SolidBrush(Color.White))
                {
                    float halfSize = instrumentSize / 2f;
                    canvasGraphics.FillEllipse(brush,
                        location.X - halfSize,
                        location.Y - halfSize,
                        instrumentSize,
                        instrumentSize);
                }
            }
            else
            {
                using (Brush brush = new SolidBrush(instrumentColor))
                {
                    float halfSize = instrumentSize / 2f;
                    canvasGraphics.FillEllipse(brush,
                        location.X - halfSize,
                        location.Y - halfSize,
                        instrumentSize,
                        instrumentSize);
                }
            }
        }
    }
}