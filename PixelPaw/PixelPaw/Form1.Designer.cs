namespace PixelPaw
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem кадрироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутьToolStripMenuItem;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.ColorDialog colorDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кадрироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.SuspendLayout();

            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.изображениеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";

            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");

            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            resources.ApplyResources(this.создатьToolStripMenuItem, "создатьToolStripMenuItem");

            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            resources.ApplyResources(this.открытьToolStripMenuItem, "открытьToolStripMenuItem");

            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            resources.ApplyResources(this.сохранитьToolStripMenuItem, "сохранитьToolStripMenuItem");

            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            resources.ApplyResources(this.закрытьToolStripMenuItem, "закрытьToolStripMenuItem");

            this.изображениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кадрироватьToolStripMenuItem,
            this.повернутьToolStripMenuItem});
            this.изображениеToolStripMenuItem.Name = "изображениеToolStripMenuItem";
            resources.ApplyResources(this.изображениеToolStripMenuItem, "изображениеToolStripMenuItem");

            this.кадрироватьToolStripMenuItem.Name = "кадрироватьToolStripMenuItem";
            resources.ApplyResources(this.кадрироватьToolStripMenuItem, "кадрироватьToolStripMenuItem");
            this.кадрироватьToolStripMenuItem.Text = "Кадрировать";

            this.повернутьToolStripMenuItem.Name = "повернутьToolStripMenuItem";
            resources.ApplyResources(this.повернутьToolStripMenuItem, "повернутьToolStripMenuItem");
            this.повернутьToolStripMenuItem.Text = "Повернуть";

            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");

            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.trackBarSize);
            this.panel1.Controls.Add(this.btnEraser);
            this.panel1.Controls.Add(this.btnPencil);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";

            this.btnColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(207)))));
            resources.ApplyResources(this.btnColor, "btnColor");
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Image = global::PixelPaw.Properties.Resources._87_85240;
            this.btnColor.Name = "btnColor";
            this.btnColor.UseVisualStyleBackColor = false;

            resources.ApplyResources(this.lblSize, "lblSize");
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(69)))), ((int)(((byte)(19)))));
            this.lblSize.Name = "lblSize";

            this.trackBarSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
            resources.ApplyResources(this.trackBarSize, "trackBarSize");
            this.trackBarSize.Maximum = 50;
            this.trackBarSize.Minimum = 1;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Value = 5;

            this.btnEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(199)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btnEraser, "btnEraser");
            this.btnEraser.Image = global::PixelPaw.Properties.Resources.study_education_eraser_icon_261869;
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.UseVisualStyleBackColor = false;

            this.btnPencil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(202)))));
            resources.ApplyResources(this.btnPencil, "btnPencil");
            this.btnPencil.Image = global::PixelPaw.Properties.Resources.icons8_pencil_32;
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.UseVisualStyleBackColor = false;

            this.pictureBoxCanvas.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBoxCanvas, "pictureBoxCanvas");
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.TabStop = false;

            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.pictureBoxCanvas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}