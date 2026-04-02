namespace TravelAgency
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // TabControl
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCountries;
        private System.Windows.Forms.TabPage tabPageTrips;
        private System.Windows.Forms.TabPage tabPageTourists;
        private System.Windows.Forms.TabPage tabPageBookings;
        private System.Windows.Forms.TabPage tabPageProcedures;

        // Countries controls
        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.TextBox txtCountryCapital;
        private System.Windows.Forms.TextBox txtCountryCurrency;
        private System.Windows.Forms.TextBox txtCountryInfo;
        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.Button btnDeleteCountry;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblCountryCapital;
        private System.Windows.Forms.Label lblCountryCurrency;
        private System.Windows.Forms.Label lblCountryInfo;

        // Trips controls
        private System.Windows.Forms.DataGridView dataGridViewTrips;
        private System.Windows.Forms.TextBox txtTripName;
        private System.Windows.Forms.TextBox txtTripCity;
        private System.Windows.Forms.TextBox txtTripPrice;
        private System.Windows.Forms.ComboBox cmbTripCountry;
        private System.Windows.Forms.DateTimePicker dtpTripStart;
        private System.Windows.Forms.DateTimePicker dtpTripEnd;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.Button btnDeleteTrip;
        private System.Windows.Forms.Label lblTripName;
        private System.Windows.Forms.Label lblTripCountry;
        private System.Windows.Forms.Label lblTripCity;
        private System.Windows.Forms.Label lblTripStart;
        private System.Windows.Forms.Label lblTripEnd;
        private System.Windows.Forms.Label lblTripPrice;

        // Tourists controls
        private System.Windows.Forms.DataGridView dataGridViewTourists;
        private System.Windows.Forms.TextBox txtTouristName;
        private System.Windows.Forms.TextBox txtTouristPhone;
        private System.Windows.Forms.TextBox txtTouristEmail;
        private System.Windows.Forms.TextBox txtTouristPassport;
        private System.Windows.Forms.Button btnAddTourist;
        private System.Windows.Forms.Button btnDeleteTourist;
        private System.Windows.Forms.Label lblTouristName;
        private System.Windows.Forms.Label lblTouristPhone;
        private System.Windows.Forms.Label lblTouristEmail;
        private System.Windows.Forms.Label lblTouristPassport;

        // Bookings controls
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.ComboBox cmbBookingTrip;
        private System.Windows.Forms.ComboBox cmbBookingTourist;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnFilterByTourist;
        private System.Windows.Forms.Button btnFilterByTrip;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Label lblBookingTrip;
        private System.Windows.Forms.Label lblBookingTourist;
        private System.Windows.Forms.Label lblBookingDate;

        // Procedures controls
        private System.Windows.Forms.Button btnProc1;
        private System.Windows.Forms.Button btnProc2;
        private System.Windows.Forms.Button btnProc3;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCountries = new System.Windows.Forms.TabPage();
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.txtCountryCapital = new System.Windows.Forms.TextBox();
            this.txtCountryCurrency = new System.Windows.Forms.TextBox();
            this.txtCountryInfo = new System.Windows.Forms.TextBox();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.btnDeleteCountry = new System.Windows.Forms.Button();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblCountryCapital = new System.Windows.Forms.Label();
            this.lblCountryCurrency = new System.Windows.Forms.Label();
            this.lblCountryInfo = new System.Windows.Forms.Label();
            this.tabPageTrips = new System.Windows.Forms.TabPage();
            this.dataGridViewTrips = new System.Windows.Forms.DataGridView();
            this.txtTripName = new System.Windows.Forms.TextBox();
            this.txtTripCity = new System.Windows.Forms.TextBox();
            this.txtTripPrice = new System.Windows.Forms.TextBox();
            this.cmbTripCountry = new System.Windows.Forms.ComboBox();
            this.dtpTripStart = new System.Windows.Forms.DateTimePicker();
            this.dtpTripEnd = new System.Windows.Forms.DateTimePicker();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.btnDeleteTrip = new System.Windows.Forms.Button();
            this.lblTripName = new System.Windows.Forms.Label();
            this.lblTripCountry = new System.Windows.Forms.Label();
            this.lblTripCity = new System.Windows.Forms.Label();
            this.lblTripStart = new System.Windows.Forms.Label();
            this.lblTripEnd = new System.Windows.Forms.Label();
            this.lblTripPrice = new System.Windows.Forms.Label();
            this.tabPageTourists = new System.Windows.Forms.TabPage();
            this.dataGridViewTourists = new System.Windows.Forms.DataGridView();
            this.txtTouristName = new System.Windows.Forms.TextBox();
            this.txtTouristPhone = new System.Windows.Forms.TextBox();
            this.txtTouristEmail = new System.Windows.Forms.TextBox();
            this.txtTouristPassport = new System.Windows.Forms.TextBox();
            this.btnAddTourist = new System.Windows.Forms.Button();
            this.btnDeleteTourist = new System.Windows.Forms.Button();
            this.lblTouristName = new System.Windows.Forms.Label();
            this.lblTouristPhone = new System.Windows.Forms.Label();
            this.lblTouristEmail = new System.Windows.Forms.Label();
            this.lblTouristPassport = new System.Windows.Forms.Label();
            this.tabPageBookings = new System.Windows.Forms.TabPage();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.cmbBookingTrip = new System.Windows.Forms.ComboBox();
            this.cmbBookingTourist = new System.Windows.Forms.ComboBox();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnFilterByTourist = new System.Windows.Forms.Button();
            this.btnFilterByTrip = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.lblBookingTrip = new System.Windows.Forms.Label();
            this.lblBookingTourist = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.tabPageProcedures = new System.Windows.Forms.TabPage();
            this.btnProc1 = new System.Windows.Forms.Button();
            this.btnProc2 = new System.Windows.Forms.Button();
            this.btnProc3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.tabPageTrips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrips)).BeginInit();
            this.tabPageTourists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourists)).BeginInit();
            this.tabPageBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.tabPageProcedures.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCountries);
            this.tabControl1.Controls.Add(this.tabPageTrips);
            this.tabControl1.Controls.Add(this.tabPageTourists);
            this.tabControl1.Controls.Add(this.tabPageBookings);
            this.tabControl1.Controls.Add(this.tabPageProcedures);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1800, 1077);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageCountries
            // 
            this.tabPageCountries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tabPageCountries.Controls.Add(this.dataGridViewCountries);
            this.tabPageCountries.Controls.Add(this.txtCountryName);
            this.tabPageCountries.Controls.Add(this.txtCountryCapital);
            this.tabPageCountries.Controls.Add(this.txtCountryCurrency);
            this.tabPageCountries.Controls.Add(this.txtCountryInfo);
            this.tabPageCountries.Controls.Add(this.btnAddCountry);
            this.tabPageCountries.Controls.Add(this.btnDeleteCountry);
            this.tabPageCountries.Controls.Add(this.lblCountryName);
            this.tabPageCountries.Controls.Add(this.lblCountryCapital);
            this.tabPageCountries.Controls.Add(this.lblCountryCurrency);
            this.tabPageCountries.Controls.Add(this.lblCountryInfo);
            this.tabPageCountries.Location = new System.Drawing.Point(4, 37);
            this.tabPageCountries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageCountries.Name = "tabPageCountries";
            this.tabPageCountries.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.tabPageCountries.Size = new System.Drawing.Size(1792, 1036);
            this.tabPageCountries.TabIndex = 0;
            this.tabPageCountries.Text = "🌍 Страны";
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Location = new System.Drawing.Point(20, 200);
            this.dataGridViewCountries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.RowHeadersWidth = 62;
            this.dataGridViewCountries.Size = new System.Drawing.Size(1740, 723);
            this.dataGridViewCountries.TabIndex = 0;
            // 
            // txtCountryName
            // 
            this.txtCountryName.BackColor = System.Drawing.Color.White;
            this.txtCountryName.Location = new System.Drawing.Point(210, 18);
            this.txtCountryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(373, 34);
            this.txtCountryName.TabIndex = 1;
            // 
            // txtCountryCapital
            // 
            this.txtCountryCapital.BackColor = System.Drawing.Color.White;
            this.txtCountryCapital.Location = new System.Drawing.Point(210, 65);
            this.txtCountryCapital.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCountryCapital.Name = "txtCountryCapital";
            this.txtCountryCapital.Size = new System.Drawing.Size(373, 34);
            this.txtCountryCapital.TabIndex = 2;
            // 
            // txtCountryCurrency
            // 
            this.txtCountryCurrency.BackColor = System.Drawing.Color.White;
            this.txtCountryCurrency.Location = new System.Drawing.Point(210, 111);
            this.txtCountryCurrency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCountryCurrency.Name = "txtCountryCurrency";
            this.txtCountryCurrency.Size = new System.Drawing.Size(373, 34);
            this.txtCountryCurrency.TabIndex = 3;
            // 
            // txtCountryInfo
            // 
            this.txtCountryInfo.BackColor = System.Drawing.Color.White;
            this.txtCountryInfo.Location = new System.Drawing.Point(210, 157);
            this.txtCountryInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCountryInfo.Name = "txtCountryInfo";
            this.txtCountryInfo.Size = new System.Drawing.Size(373, 34);
            this.txtCountryInfo.TabIndex = 4;
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.btnAddCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCountry.ForeColor = System.Drawing.Color.White;
            this.btnAddCountry.Location = new System.Drawing.Point(615, 15);
            this.btnAddCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(180, 54);
            this.btnAddCountry.TabIndex = 0;
            this.btnAddCountry.Text = "➕ Добавить";
            this.btnAddCountry.UseVisualStyleBackColor = false;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCountry.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCountry.Location = new System.Drawing.Point(810, 15);
            this.btnDeleteCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(180, 54);
            this.btnDeleteCountry.TabIndex = 1;
            this.btnDeleteCountry.Text = "🗑️ Удалить";
            this.btnDeleteCountry.UseVisualStyleBackColor = false;
            this.btnDeleteCountry.Click += new System.EventHandler(this.btnDeleteCountry_Click);
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCountryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblCountryName.Location = new System.Drawing.Point(20, 23);
            this.lblCountryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(174, 28);
            this.lblCountryName.TabIndex = 5;
            this.lblCountryName.Text = "Название страны:";
            // 
            // lblCountryCapital
            // 
            this.lblCountryCapital.AutoSize = true;
            this.lblCountryCapital.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCountryCapital.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblCountryCapital.Location = new System.Drawing.Point(20, 69);
            this.lblCountryCapital.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountryCapital.Name = "lblCountryCapital";
            this.lblCountryCapital.Size = new System.Drawing.Size(93, 28);
            this.lblCountryCapital.TabIndex = 6;
            this.lblCountryCapital.Text = "Столица:";
            // 
            // lblCountryCurrency
            // 
            this.lblCountryCurrency.AutoSize = true;
            this.lblCountryCurrency.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCountryCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblCountryCurrency.Location = new System.Drawing.Point(20, 115);
            this.lblCountryCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountryCurrency.Name = "lblCountryCurrency";
            this.lblCountryCurrency.Size = new System.Drawing.Size(82, 28);
            this.lblCountryCurrency.TabIndex = 7;
            this.lblCountryCurrency.Text = "Валюта:";
            // 
            // lblCountryInfo
            // 
            this.lblCountryInfo.AutoSize = true;
            this.lblCountryInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCountryInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblCountryInfo.Location = new System.Drawing.Point(20, 162);
            this.lblCountryInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountryInfo.Name = "lblCountryInfo";
            this.lblCountryInfo.Size = new System.Drawing.Size(139, 28);
            this.lblCountryInfo.TabIndex = 8;
            this.lblCountryInfo.Text = "Информация:";
            // 
            // tabPageTrips
            // 
            this.tabPageTrips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tabPageTrips.Controls.Add(this.dataGridViewTrips);
            this.tabPageTrips.Controls.Add(this.txtTripName);
            this.tabPageTrips.Controls.Add(this.txtTripCity);
            this.tabPageTrips.Controls.Add(this.txtTripPrice);
            this.tabPageTrips.Controls.Add(this.cmbTripCountry);
            this.tabPageTrips.Controls.Add(this.dtpTripStart);
            this.tabPageTrips.Controls.Add(this.dtpTripEnd);
            this.tabPageTrips.Controls.Add(this.btnAddTrip);
            this.tabPageTrips.Controls.Add(this.btnDeleteTrip);
            this.tabPageTrips.Controls.Add(this.lblTripName);
            this.tabPageTrips.Controls.Add(this.lblTripCountry);
            this.tabPageTrips.Controls.Add(this.lblTripCity);
            this.tabPageTrips.Controls.Add(this.lblTripStart);
            this.tabPageTrips.Controls.Add(this.lblTripEnd);
            this.tabPageTrips.Controls.Add(this.lblTripPrice);
            this.tabPageTrips.Location = new System.Drawing.Point(4, 37);
            this.tabPageTrips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageTrips.Name = "tabPageTrips";
            this.tabPageTrips.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.tabPageTrips.Size = new System.Drawing.Size(1792, 1036);
            this.tabPageTrips.TabIndex = 1;
            this.tabPageTrips.Text = "✈️ Путешествия";
            // 
            // dataGridViewTrips
            // 
            this.dataGridViewTrips.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrips.Location = new System.Drawing.Point(20, 262);
            this.dataGridViewTrips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewTrips.Name = "dataGridViewTrips";
            this.dataGridViewTrips.RowHeadersWidth = 62;
            this.dataGridViewTrips.Size = new System.Drawing.Size(1740, 662);
            this.dataGridViewTrips.TabIndex = 0;
            // 
            // txtTripName
            // 
            this.txtTripName.BackColor = System.Drawing.Color.White;
            this.txtTripName.Location = new System.Drawing.Point(225, 18);
            this.txtTripName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTripName.Name = "txtTripName";
            this.txtTripName.Size = new System.Drawing.Size(373, 34);
            this.txtTripName.TabIndex = 1;
            // 
            // txtTripCity
            // 
            this.txtTripCity.BackColor = System.Drawing.Color.White;
            this.txtTripCity.Location = new System.Drawing.Point(225, 111);
            this.txtTripCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTripCity.Name = "txtTripCity";
            this.txtTripCity.Size = new System.Drawing.Size(373, 34);
            this.txtTripCity.TabIndex = 2;
            // 
            // txtTripPrice
            // 
            this.txtTripPrice.BackColor = System.Drawing.Color.White;
            this.txtTripPrice.Location = new System.Drawing.Point(225, 249);
            this.txtTripPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTripPrice.Name = "txtTripPrice";
            this.txtTripPrice.Size = new System.Drawing.Size(373, 34);
            this.txtTripPrice.TabIndex = 3;
            // 
            // cmbTripCountry
            // 
            this.cmbTripCountry.BackColor = System.Drawing.Color.White;
            this.cmbTripCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTripCountry.Location = new System.Drawing.Point(225, 65);
            this.cmbTripCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTripCountry.Name = "cmbTripCountry";
            this.cmbTripCountry.Size = new System.Drawing.Size(373, 36);
            this.cmbTripCountry.TabIndex = 4;
            // 
            // dtpTripStart
            // 
            this.dtpTripStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTripStart.Location = new System.Drawing.Point(225, 157);
            this.dtpTripStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTripStart.Name = "dtpTripStart";
            this.dtpTripStart.Size = new System.Drawing.Size(373, 34);
            this.dtpTripStart.TabIndex = 5;
            // 
            // dtpTripEnd
            // 
            this.dtpTripEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTripEnd.Location = new System.Drawing.Point(225, 203);
            this.dtpTripEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTripEnd.Name = "dtpTripEnd";
            this.dtpTripEnd.Size = new System.Drawing.Size(373, 34);
            this.dtpTripEnd.TabIndex = 6;
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.btnAddTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddTrip.ForeColor = System.Drawing.Color.White;
            this.btnAddTrip.Location = new System.Drawing.Point(630, 15);
            this.btnAddTrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(180, 54);
            this.btnAddTrip.TabIndex = 0;
            this.btnAddTrip.Text = "➕ Добавить";
            this.btnAddTrip.UseVisualStyleBackColor = false;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // btnDeleteTrip
            // 
            this.btnDeleteTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTrip.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTrip.Location = new System.Drawing.Point(825, 15);
            this.btnDeleteTrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteTrip.Name = "btnDeleteTrip";
            this.btnDeleteTrip.Size = new System.Drawing.Size(180, 54);
            this.btnDeleteTrip.TabIndex = 1;
            this.btnDeleteTrip.Text = "🗑️ Удалить";
            this.btnDeleteTrip.UseVisualStyleBackColor = false;
            this.btnDeleteTrip.Click += new System.EventHandler(this.btnDeleteTrip_Click);
            // 
            // lblTripName
            // 
            this.lblTripName.AutoSize = true;
            this.lblTripName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTripName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTripName.Location = new System.Drawing.Point(20, 23);
            this.lblTripName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTripName.Name = "lblTripName";
            this.lblTripName.Size = new System.Drawing.Size(149, 28);
            this.lblTripName.TabIndex = 7;
            this.lblTripName.Text = "Название тура:";
            // 
            // lblTripCountry
            // 
            this.lblTripCountry.AutoSize = true;
            this.lblTripCountry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTripCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTripCountry.Location = new System.Drawing.Point(20, 69);
            this.lblTripCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTripCountry.Name = "lblTripCountry";
            this.lblTripCountry.Size = new System.Drawing.Size(80, 28);
            this.lblTripCountry.TabIndex = 8;
            this.lblTripCountry.Text = "Страна:";
            // 
            // lblTripCity
            // 
            this.lblTripCity.AutoSize = true;
            this.lblTripCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTripCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTripCity.Location = new System.Drawing.Point(20, 115);
            this.lblTripCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTripCity.Name = "lblTripCity";
            this.lblTripCity.Size = new System.Drawing.Size(72, 28);
            this.lblTripCity.TabIndex = 9;
            this.lblTripCity.Text = "Город:";
            // 
            // lblTripStart
            // 
            this.lblTripStart.AutoSize = true;
            this.lblTripStart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTripStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTripStart.Location = new System.Drawing.Point(20, 162);
            this.lblTripStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTripStart.Name = "lblTripStart";
            this.lblTripStart.Size = new System.Drawing.Size(127, 28);
            this.lblTripStart.TabIndex = 10;
            this.lblTripStart.Text = "Дата начала:";
            // 
            // lblTripEnd
            // 
            this.lblTripEnd.AutoSize = true;
            this.lblTripEnd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTripEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTripEnd.Location = new System.Drawing.Point(20, 208);
            this.lblTripEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTripEnd.Name = "lblTripEnd";
            this.lblTripEnd.Size = new System.Drawing.Size(164, 28);
            this.lblTripEnd.TabIndex = 11;
            this.lblTripEnd.Text = "Дата окончания:";
            // 
            // lblTripPrice
            // 
            this.lblTripPrice.AutoSize = true;
            this.lblTripPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTripPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTripPrice.Location = new System.Drawing.Point(20, 254);
            this.lblTripPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTripPrice.Name = "lblTripPrice";
            this.lblTripPrice.Size = new System.Drawing.Size(113, 28);
            this.lblTripPrice.TabIndex = 12;
            this.lblTripPrice.Text = "Стоимость:";
            // 
            // tabPageTourists
            // 
            this.tabPageTourists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tabPageTourists.Controls.Add(this.dataGridViewTourists);
            this.tabPageTourists.Controls.Add(this.txtTouristName);
            this.tabPageTourists.Controls.Add(this.txtTouristPhone);
            this.tabPageTourists.Controls.Add(this.txtTouristEmail);
            this.tabPageTourists.Controls.Add(this.txtTouristPassport);
            this.tabPageTourists.Controls.Add(this.btnAddTourist);
            this.tabPageTourists.Controls.Add(this.btnDeleteTourist);
            this.tabPageTourists.Controls.Add(this.lblTouristName);
            this.tabPageTourists.Controls.Add(this.lblTouristPhone);
            this.tabPageTourists.Controls.Add(this.lblTouristEmail);
            this.tabPageTourists.Controls.Add(this.lblTouristPassport);
            this.tabPageTourists.Location = new System.Drawing.Point(4, 37);
            this.tabPageTourists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageTourists.Name = "tabPageTourists";
            this.tabPageTourists.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.tabPageTourists.Size = new System.Drawing.Size(1792, 1036);
            this.tabPageTourists.TabIndex = 2;
            this.tabPageTourists.Text = "🧳 Туристы";
            // 
            // dataGridViewTourists
            // 
            this.dataGridViewTourists.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTourists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTourists.Location = new System.Drawing.Point(20, 200);
            this.dataGridViewTourists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewTourists.Name = "dataGridViewTourists";
            this.dataGridViewTourists.RowHeadersWidth = 62;
            this.dataGridViewTourists.Size = new System.Drawing.Size(1740, 723);
            this.dataGridViewTourists.TabIndex = 0;
            // 
            // txtTouristName
            // 
            this.txtTouristName.BackColor = System.Drawing.Color.White;
            this.txtTouristName.Location = new System.Drawing.Point(225, 18);
            this.txtTouristName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTouristName.Name = "txtTouristName";
            this.txtTouristName.Size = new System.Drawing.Size(373, 34);
            this.txtTouristName.TabIndex = 1;
            // 
            // txtTouristPhone
            // 
            this.txtTouristPhone.BackColor = System.Drawing.Color.White;
            this.txtTouristPhone.Location = new System.Drawing.Point(225, 65);
            this.txtTouristPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTouristPhone.Name = "txtTouristPhone";
            this.txtTouristPhone.Size = new System.Drawing.Size(373, 34);
            this.txtTouristPhone.TabIndex = 2;
            // 
            // txtTouristEmail
            // 
            this.txtTouristEmail.BackColor = System.Drawing.Color.White;
            this.txtTouristEmail.Location = new System.Drawing.Point(225, 111);
            this.txtTouristEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTouristEmail.Name = "txtTouristEmail";
            this.txtTouristEmail.Size = new System.Drawing.Size(373, 34);
            this.txtTouristEmail.TabIndex = 3;
            // 
            // txtTouristPassport
            // 
            this.txtTouristPassport.BackColor = System.Drawing.Color.White;
            this.txtTouristPassport.Location = new System.Drawing.Point(225, 157);
            this.txtTouristPassport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTouristPassport.Name = "txtTouristPassport";
            this.txtTouristPassport.Size = new System.Drawing.Size(373, 34);
            this.txtTouristPassport.TabIndex = 4;
            // 
            // btnAddTourist
            // 
            this.btnAddTourist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.btnAddTourist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTourist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddTourist.ForeColor = System.Drawing.Color.White;
            this.btnAddTourist.Location = new System.Drawing.Point(630, 15);
            this.btnAddTourist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTourist.Name = "btnAddTourist";
            this.btnAddTourist.Size = new System.Drawing.Size(180, 54);
            this.btnAddTourist.TabIndex = 0;
            this.btnAddTourist.Text = "➕ Добавить";
            this.btnAddTourist.UseVisualStyleBackColor = false;
            this.btnAddTourist.Click += new System.EventHandler(this.btnAddTourist_Click);
            // 
            // btnDeleteTourist
            // 
            this.btnDeleteTourist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteTourist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTourist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTourist.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTourist.Location = new System.Drawing.Point(825, 15);
            this.btnDeleteTourist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteTourist.Name = "btnDeleteTourist";
            this.btnDeleteTourist.Size = new System.Drawing.Size(180, 54);
            this.btnDeleteTourist.TabIndex = 1;
            this.btnDeleteTourist.Text = "🗑️ Удалить";
            this.btnDeleteTourist.UseVisualStyleBackColor = false;
            this.btnDeleteTourist.Click += new System.EventHandler(this.btnDeleteTourist_Click);
            // 
            // lblTouristName
            // 
            this.lblTouristName.AutoSize = true;
            this.lblTouristName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTouristName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTouristName.Location = new System.Drawing.Point(20, 23);
            this.lblTouristName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTouristName.Name = "lblTouristName";
            this.lblTouristName.Size = new System.Drawing.Size(61, 28);
            this.lblTouristName.TabIndex = 5;
            this.lblTouristName.Text = "ФИО:";
            // 
            // lblTouristPhone
            // 
            this.lblTouristPhone.AutoSize = true;
            this.lblTouristPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTouristPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTouristPhone.Location = new System.Drawing.Point(20, 69);
            this.lblTouristPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTouristPhone.Name = "lblTouristPhone";
            this.lblTouristPhone.Size = new System.Drawing.Size(95, 28);
            this.lblTouristPhone.TabIndex = 6;
            this.lblTouristPhone.Text = "Телефон:";
            // 
            // lblTouristEmail
            // 
            this.lblTouristEmail.AutoSize = true;
            this.lblTouristEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTouristEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTouristEmail.Location = new System.Drawing.Point(20, 115);
            this.lblTouristEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTouristEmail.Name = "lblTouristEmail";
            this.lblTouristEmail.Size = new System.Drawing.Size(63, 28);
            this.lblTouristEmail.TabIndex = 7;
            this.lblTouristEmail.Text = "Email:";
            // 
            // lblTouristPassport
            // 
            this.lblTouristPassport.AutoSize = true;
            this.lblTouristPassport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTouristPassport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTouristPassport.Location = new System.Drawing.Point(20, 162);
            this.lblTouristPassport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTouristPassport.Name = "lblTouristPassport";
            this.lblTouristPassport.Size = new System.Drawing.Size(203, 28);
            this.lblTouristPassport.TabIndex = 8;
            this.lblTouristPassport.Text = "Паспортные данные:";
            // 
            // tabPageBookings
            // 
            this.tabPageBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tabPageBookings.Controls.Add(this.dataGridViewBookings);
            this.tabPageBookings.Controls.Add(this.cmbBookingTrip);
            this.tabPageBookings.Controls.Add(this.cmbBookingTourist);
            this.tabPageBookings.Controls.Add(this.dtpBookingDate);
            this.tabPageBookings.Controls.Add(this.btnAddBooking);
            this.tabPageBookings.Controls.Add(this.btnDeleteBooking);
            this.tabPageBookings.Controls.Add(this.btnFilterByTourist);
            this.tabPageBookings.Controls.Add(this.btnFilterByTrip);
            this.tabPageBookings.Controls.Add(this.btnClearFilter);
            this.tabPageBookings.Controls.Add(this.lblBookingTrip);
            this.tabPageBookings.Controls.Add(this.lblBookingTourist);
            this.tabPageBookings.Controls.Add(this.lblBookingDate);
            this.tabPageBookings.Location = new System.Drawing.Point(4, 37);
            this.tabPageBookings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageBookings.Name = "tabPageBookings";
            this.tabPageBookings.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.tabPageBookings.Size = new System.Drawing.Size(1792, 1036);
            this.tabPageBookings.TabIndex = 3;
            this.tabPageBookings.Text = "📅 Бронирование";
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(20, 200);
            this.dataGridViewBookings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.RowHeadersWidth = 62;
            this.dataGridViewBookings.Size = new System.Drawing.Size(1740, 677);
            this.dataGridViewBookings.TabIndex = 0;
            // 
            // cmbBookingTrip
            // 
            this.cmbBookingTrip.BackColor = System.Drawing.Color.White;
            this.cmbBookingTrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingTrip.Location = new System.Drawing.Point(225, 18);
            this.cmbBookingTrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBookingTrip.Name = "cmbBookingTrip";
            this.cmbBookingTrip.Size = new System.Drawing.Size(373, 36);
            this.cmbBookingTrip.TabIndex = 1;
            // 
            // cmbBookingTourist
            // 
            this.cmbBookingTourist.BackColor = System.Drawing.Color.White;
            this.cmbBookingTourist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingTourist.Location = new System.Drawing.Point(225, 65);
            this.cmbBookingTourist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBookingTourist.Name = "cmbBookingTourist";
            this.cmbBookingTourist.Size = new System.Drawing.Size(373, 36);
            this.cmbBookingTourist.TabIndex = 2;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingDate.Location = new System.Drawing.Point(225, 111);
            this.dtpBookingDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(373, 34);
            this.dtpBookingDate.TabIndex = 3;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.btnAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddBooking.ForeColor = System.Drawing.Color.White;
            this.btnAddBooking.Location = new System.Drawing.Point(630, 15);
            this.btnAddBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(180, 54);
            this.btnAddBooking.TabIndex = 0;
            this.btnAddBooking.Text = "➕ Добавить";
            this.btnAddBooking.UseVisualStyleBackColor = false;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteBooking.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBooking.Location = new System.Drawing.Point(825, 15);
            this.btnDeleteBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(180, 54);
            this.btnDeleteBooking.TabIndex = 1;
            this.btnDeleteBooking.Text = "🗑️ Удалить";
            this.btnDeleteBooking.UseVisualStyleBackColor = false;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // btnFilterByTourist
            // 
            this.btnFilterByTourist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.btnFilterByTourist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterByTourist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilterByTourist.ForeColor = System.Drawing.Color.White;
            this.btnFilterByTourist.Location = new System.Drawing.Point(630, 85);
            this.btnFilterByTourist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilterByTourist.Name = "btnFilterByTourist";
            this.btnFilterByTourist.Size = new System.Drawing.Size(225, 54);
            this.btnFilterByTourist.TabIndex = 2;
            this.btnFilterByTourist.Text = "🔍 По туристу";
            this.btnFilterByTourist.UseVisualStyleBackColor = false;
            this.btnFilterByTourist.Click += new System.EventHandler(this.btnFilterByTourist_Click);
            // 
            // btnFilterByTrip
            // 
            this.btnFilterByTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.btnFilterByTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterByTrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilterByTrip.ForeColor = System.Drawing.Color.White;
            this.btnFilterByTrip.Location = new System.Drawing.Point(870, 85);
            this.btnFilterByTrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilterByTrip.Name = "btnFilterByTrip";
            this.btnFilterByTrip.Size = new System.Drawing.Size(225, 54);
            this.btnFilterByTrip.TabIndex = 3;
            this.btnFilterByTrip.Text = "🔍 По туру";
            this.btnFilterByTrip.UseVisualStyleBackColor = false;
            this.btnFilterByTrip.Click += new System.EventHandler(this.btnFilterByTrip_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(1110, 85);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(225, 54);
            this.btnClearFilter.TabIndex = 4;
            this.btnClearFilter.Text = "🔄 Сбросить";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // lblBookingTrip
            // 
            this.lblBookingTrip.AutoSize = true;
            this.lblBookingTrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBookingTrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblBookingTrip.Location = new System.Drawing.Point(20, 23);
            this.lblBookingTrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingTrip.Name = "lblBookingTrip";
            this.lblBookingTrip.Size = new System.Drawing.Size(48, 28);
            this.lblBookingTrip.TabIndex = 5;
            this.lblBookingTrip.Text = "Тур:";
            // 
            // lblBookingTourist
            // 
            this.lblBookingTourist.AutoSize = true;
            this.lblBookingTourist.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBookingTourist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblBookingTourist.Location = new System.Drawing.Point(20, 69);
            this.lblBookingTourist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingTourist.Name = "lblBookingTourist";
            this.lblBookingTourist.Size = new System.Drawing.Size(77, 28);
            this.lblBookingTourist.TabIndex = 6;
            this.lblBookingTourist.Text = "Турист:";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBookingDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblBookingDate.Location = new System.Drawing.Point(20, 115);
            this.lblBookingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(202, 28);
            this.lblBookingDate.TabIndex = 7;
            this.lblBookingDate.Text = "Дата бронирования:";
            // 
            // tabPageProcedures
            // 
            this.tabPageProcedures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tabPageProcedures.Controls.Add(this.btnProc1);
            this.tabPageProcedures.Controls.Add(this.btnProc2);
            this.tabPageProcedures.Controls.Add(this.btnProc3);
            this.tabPageProcedures.Location = new System.Drawing.Point(4, 37);
            this.tabPageProcedures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageProcedures.Name = "tabPageProcedures";
            this.tabPageProcedures.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.tabPageProcedures.Size = new System.Drawing.Size(1792, 1036);
            this.tabPageProcedures.TabIndex = 4;
            this.tabPageProcedures.Text = "⚙️ Процедуры";
            // 
            // btnProc1
            // 
            this.btnProc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.btnProc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProc1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnProc1.ForeColor = System.Drawing.Color.White;
            this.btnProc1.Location = new System.Drawing.Point(75, 77);
            this.btnProc1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProc1.Name = "btnProc1";
            this.btnProc1.Size = new System.Drawing.Size(525, 123);
            this.btnProc1.TabIndex = 0;
            this.btnProc1.Text = "📊 Подсчет бронирований туриста";
            this.btnProc1.UseVisualStyleBackColor = false;
            this.btnProc1.Click += new System.EventHandler(this.btnProc1_Click);
            // 
            // btnProc2
            // 
            this.btnProc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.btnProc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProc2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnProc2.ForeColor = System.Drawing.Color.White;
            this.btnProc2.Location = new System.Drawing.Point(75, 231);
            this.btnProc2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProc2.Name = "btnProc2";
            this.btnProc2.Size = new System.Drawing.Size(525, 123);
            this.btnProc2.TabIndex = 1;
            this.btnProc2.Text = "🔍 Поиск туров по стране";
            this.btnProc2.UseVisualStyleBackColor = false;
            this.btnProc2.Click += new System.EventHandler(this.btnProc2_Click);
            // 
            // btnProc3
            // 
            this.btnProc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.btnProc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProc3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnProc3.ForeColor = System.Drawing.Color.White;
            this.btnProc3.Location = new System.Drawing.Point(75, 385);
            this.btnProc3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProc3.Name = "btnProc3";
            this.btnProc3.Size = new System.Drawing.Size(525, 123);
            this.btnProc3.TabIndex = 2;
            this.btnProc3.Text = "📈 Статистика по странам";
            this.btnProc3.UseVisualStyleBackColor = false;
            this.btnProc3.Click += new System.EventHandler(this.btnProc3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1800, 1077);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🏝️ Туристическое агентство";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCountries.ResumeLayout(false);
            this.tabPageCountries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.tabPageTrips.ResumeLayout(false);
            this.tabPageTrips.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrips)).EndInit();
            this.tabPageTourists.ResumeLayout(false);
            this.tabPageTourists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourists)).EndInit();
            this.tabPageBookings.ResumeLayout(false);
            this.tabPageBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.tabPageProcedures.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}