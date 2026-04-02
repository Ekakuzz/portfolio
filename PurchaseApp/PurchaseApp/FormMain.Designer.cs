namespace PurchaseApp
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonДолжность;
        private System.Windows.Forms.Button buttonКатегория;
        private System.Windows.Forms.Button buttonПоставщик;
        private System.Windows.Forms.Button buttonСотрудник;
        private System.Windows.Forms.Button buttonТовар;
        private System.Windows.Forms.Button buttonЗакупка;
        private System.Windows.Forms.Button buttonРеализация;
        private System.Windows.Forms.Button buttonВыход;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonДолжность = new System.Windows.Forms.Button();
            this.buttonКатегория = new System.Windows.Forms.Button();
            this.buttonПоставщик = new System.Windows.Forms.Button();
            this.buttonСотрудник = new System.Windows.Forms.Button();
            this.buttonТовар = new System.Windows.Forms.Button();
            this.buttonЗакупка = new System.Windows.Forms.Button();
            this.buttonРеализация = new System.Windows.Forms.Button();
            this.buttonВыход = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.Location = new System.Drawing.Point(22, 25);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(405, 50);
            this.labelHeader.TabIndex = 0;
            // 
            // buttonДолжность
            // 
            this.buttonДолжность.Location = new System.Drawing.Point(22, 100);
            this.buttonДолжность.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonДолжность.Name = "buttonДолжность";
            this.buttonДолжность.Size = new System.Drawing.Size(405, 62);
            this.buttonДолжность.TabIndex = 1;
            this.buttonДолжность.Click += new System.EventHandler(this.buttonДолжность_Click);
            // 
            // buttonКатегория
            // 
            this.buttonКатегория.Location = new System.Drawing.Point(22, 175);
            this.buttonКатегория.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonКатегория.Name = "buttonКатегория";
            this.buttonКатегория.Size = new System.Drawing.Size(405, 62);
            this.buttonКатегория.TabIndex = 2;
            this.buttonКатегория.Click += new System.EventHandler(this.buttonКатегория_Click);
            // 
            // buttonПоставщик
            // 
            this.buttonПоставщик.Location = new System.Drawing.Point(22, 250);
            this.buttonПоставщик.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonПоставщик.Name = "buttonПоставщик";
            this.buttonПоставщик.Size = new System.Drawing.Size(405, 62);
            this.buttonПоставщик.TabIndex = 3;
            this.buttonПоставщик.Click += new System.EventHandler(this.buttonПоставщик_Click);
            // 
            // buttonСотрудник
            // 
            this.buttonСотрудник.Location = new System.Drawing.Point(22, 325);
            this.buttonСотрудник.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonСотрудник.Name = "buttonСотрудник";
            this.buttonСотрудник.Size = new System.Drawing.Size(405, 62);
            this.buttonСотрудник.TabIndex = 4;
            this.buttonСотрудник.Click += new System.EventHandler(this.buttonСотрудник_Click);
            // 
            // buttonТовар
            // 
            this.buttonТовар.Location = new System.Drawing.Point(22, 400);
            this.buttonТовар.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonТовар.Name = "buttonТовар";
            this.buttonТовар.Size = new System.Drawing.Size(405, 62);
            this.buttonТовар.TabIndex = 5;
            this.buttonТовар.Click += new System.EventHandler(this.buttonТовар_Click);
            // 
            // buttonЗакупка
            // 
            this.buttonЗакупка.Location = new System.Drawing.Point(22, 475);
            this.buttonЗакупка.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonЗакупка.Name = "buttonЗакупка";
            this.buttonЗакупка.Size = new System.Drawing.Size(405, 62);
            this.buttonЗакупка.TabIndex = 6;
            this.buttonЗакупка.Click += new System.EventHandler(this.buttonЗакупка_Click);
            // 
            // buttonРеализация
            // 
            this.buttonРеализация.Location = new System.Drawing.Point(22, 550);
            this.buttonРеализация.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonРеализация.Name = "buttonРеализация";
            this.buttonРеализация.Size = new System.Drawing.Size(405, 62);
            this.buttonРеализация.TabIndex = 7;
            this.buttonРеализация.Click += new System.EventHandler(this.buttonРеализация_Click);
            // 
            // buttonВыход
            // 
            this.buttonВыход.Location = new System.Drawing.Point(22, 625);
            this.buttonВыход.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonВыход.Name = "buttonВыход";
            this.buttonВыход.Size = new System.Drawing.Size(405, 62);
            this.buttonВыход.TabIndex = 8;
            this.buttonВыход.Click += new System.EventHandler(this.buttonВыход_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 725);
            this.Controls.Add(this.buttonВыход);
            this.Controls.Add(this.buttonРеализация);
            this.Controls.Add(this.buttonЗакупка);
            this.Controls.Add(this.buttonТовар);
            this.Controls.Add(this.buttonСотрудник);
            this.Controls.Add(this.buttonПоставщик);
            this.Controls.Add(this.buttonКатегория);
            this.Controls.Add(this.buttonДолжность);
            this.Controls.Add(this.labelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }
    }
}