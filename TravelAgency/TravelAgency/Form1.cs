using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace TravelAgency
{
    public partial class Form1 : Form
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TravelDB.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();

            string path = Path.Combine(Application.StartupPath, "TravelDB.mdf");
            if (File.Exists(path))
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", Application.StartupPath);
            }
            else
            {
                string debugPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TravelDB.mdf");
                if (File.Exists(debugPath))
                {
                    AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
                }
            }

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    LoadCountries();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД:\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabPageCountries)
                    LoadCountries();
                else if (tabControl1.SelectedTab == tabPageTrips)
                    LoadTrips();
                else if (tabControl1.SelectedTab == tabPageTourists)
                    LoadTourists();
                else if (tabControl1.SelectedTab == tabPageBookings)
                    LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message);
            }
        }

        // ========== СТРАНЫ ==========
        private void LoadCountries()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Страны ORDER BY Название";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewCountries.DataSource = dt;

                if (dataGridViewCountries.Columns.Contains("Id"))
                    dataGridViewCountries.Columns["Id"].HeaderText = "Код";
                if (dataGridViewCountries.Columns.Contains("Название"))
                    dataGridViewCountries.Columns["Название"].HeaderText = "Страна";
                if (dataGridViewCountries.Columns.Contains("Столица"))
                    dataGridViewCountries.Columns["Столица"].HeaderText = "Столица";
                if (dataGridViewCountries.Columns.Contains("Валюта"))
                    dataGridViewCountries.Columns["Валюта"].HeaderText = "Валюта";
                if (dataGridViewCountries.Columns.Contains("Информация"))
                    dataGridViewCountries.Columns["Информация"].HeaderText = "Информация";
            }
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "INSERT INTO Страны (Название, Столица, Валюта, Информация) VALUES (@name, @capital, @currency, @info)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtCountryName.Text);
                    cmd.Parameters.AddWithValue("@capital", txtCountryCapital.Text);
                    cmd.Parameters.AddWithValue("@currency", txtCountryCurrency.Text);
                    cmd.Parameters.AddWithValue("@info", txtCountryInfo.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Страна добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCountryName.Clear();
                    txtCountryCapital.Clear();
                    txtCountryCurrency.Clear();
                    txtCountryInfo.Clear();

                    LoadCountries();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            if (dataGridViewCountries.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для удаления!");
                return;
            }

            DialogResult result = MessageBox.Show("Удалить запись?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dataGridViewCountries.CurrentRow.Cells["Id"].Value;

                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        string query = "DELETE FROM Страны WHERE Id = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Запись удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadCountries();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        // ========== ПУТЕШЕСТВИЯ ==========
        private void LoadTrips()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT Путешествия.*, Страны.Название AS Страна 
                               FROM Путешествия 
                               LEFT JOIN Страны ON Путешествия.СтранаId = Страны.Id 
                               ORDER BY Путешествия.ДатаНачала";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewTrips.DataSource = dt;

                LoadCountriesCombo();
            }
        }

        private void LoadCountriesCombo()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT Id, Название FROM Страны ORDER BY Название";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbTripCountry.DataSource = dt;
                cmbTripCountry.DisplayMember = "Название";
                cmbTripCountry.ValueMember = "Id";
            }
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"INSERT INTO Путешествия (НазваниеТура, СтранаId, Город, ДатаНачала, ДатаОкончания, Стоимость) 
                                   VALUES (@name, @countryId, @city, @start, @end, @price)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtTripName.Text);
                    cmd.Parameters.AddWithValue("@countryId", cmbTripCountry.SelectedValue);
                    cmd.Parameters.AddWithValue("@city", txtTripCity.Text);
                    cmd.Parameters.AddWithValue("@start", dtpTripStart.Value);
                    cmd.Parameters.AddWithValue("@end", dtpTripEnd.Value);
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtTripPrice.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Тур добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtTripName.Clear();
                    txtTripCity.Clear();
                    txtTripPrice.Clear();

                    LoadTrips();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnDeleteTrip_Click(object sender, EventArgs e)
        {
            if (dataGridViewTrips.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для удаления!");
                return;
            }

            DialogResult result = MessageBox.Show("Удалить запись?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dataGridViewTrips.CurrentRow.Cells["Id"].Value;

                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        string query = "DELETE FROM Путешествия WHERE Id = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Запись удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadTrips();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        // ========== ТУРИСТЫ ==========
        private void LoadTourists()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Туристы ORDER BY ФИО";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewTourists.DataSource = dt;

                if (dataGridViewTourists.Columns.Contains("Id"))
                    dataGridViewTourists.Columns["Id"].HeaderText = "Код";
                if (dataGridViewTourists.Columns.Contains("ФИО"))
                    dataGridViewTourists.Columns["ФИО"].HeaderText = "ФИО туриста";
                if (dataGridViewTourists.Columns.Contains("Телефон"))
                    dataGridViewTourists.Columns["Телефон"].HeaderText = "Телефон";
                if (dataGridViewTourists.Columns.Contains("Email"))
                    dataGridViewTourists.Columns["Email"].HeaderText = "Email";
                if (dataGridViewTourists.Columns.Contains("ПаспортныеДанные"))
                    dataGridViewTourists.Columns["ПаспортныеДанные"].HeaderText = "Паспортные данные";
            }
        }

        private void btnAddTourist_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"INSERT INTO Туристы (ФИО, Телефон, Email, ПаспортныеДанные) 
                                   VALUES (@name, @phone, @email, @passport)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtTouristName.Text);
                    cmd.Parameters.AddWithValue("@phone", txtTouristPhone.Text);
                    cmd.Parameters.AddWithValue("@email", txtTouristEmail.Text);
                    cmd.Parameters.AddWithValue("@passport", txtTouristPassport.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Турист добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtTouristName.Clear();
                    txtTouristPhone.Clear();
                    txtTouristEmail.Clear();
                    txtTouristPassport.Clear();

                    LoadTourists();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnDeleteTourist_Click(object sender, EventArgs e)
        {
            if (dataGridViewTourists.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для удаления!");
                return;
            }

            DialogResult result = MessageBox.Show("Удалить запись?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dataGridViewTourists.CurrentRow.Cells["Id"].Value;

                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        string query = "DELETE FROM Туристы WHERE Id = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Запись удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadTourists();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        // ========== БРОНИРОВАНИЕ ==========
        private void LoadBookings()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT Бронирование.*, 
                               Путешествия.НазваниеТура AS Тур,
                               Туристы.ФИО AS Турист,
                               Страны.Название AS Страна
                               FROM Бронирование 
                               LEFT JOIN Путешествия ON Бронирование.ПутешествиеId = Путешествия.Id
                               LEFT JOIN Туристы ON Бронирование.ТуристId = Туристы.Id
                               LEFT JOIN Страны ON Путешествия.СтранаId = Страны.Id
                               ORDER BY Бронирование.ДатаБронирования DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBookings.DataSource = dt;

                LoadTripsForBookings();
                LoadTouristsForBookings();
            }
        }

        private void LoadTripsForBookings()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT Путешествия.Id, Путешествия.НазваниеТура + ' (' + Страны.Название + ')' AS Название 
                               FROM Путешествия 
                               LEFT JOIN Страны ON Путешествия.СтранаId = Страны.Id
                               ORDER BY Путешествия.ДатаНачала";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBookingTrip.DataSource = dt;
                cmbBookingTrip.DisplayMember = "Название";
                cmbBookingTrip.ValueMember = "Id";
            }
        }

        private void LoadTouristsForBookings()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT Id, ФИО FROM Туристы ORDER BY ФИО";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBookingTourist.DataSource = dt;
                cmbBookingTourist.DisplayMember = "ФИО";
                cmbBookingTourist.ValueMember = "Id";
            }
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"INSERT INTO Бронирование (ПутешествиеId, ТуристId, ДатаБронирования) 
                                   VALUES (@tripId, @touristId, @date)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@tripId", cmbBookingTrip.SelectedValue);
                    cmd.Parameters.AddWithValue("@touristId", cmbBookingTourist.SelectedValue);
                    cmd.Parameters.AddWithValue("@date", dtpBookingDate.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Бронирование добавлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBookings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для удаления!");
                return;
            }

            DialogResult result = MessageBox.Show("Удалить запись?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dataGridViewBookings.CurrentRow.Cells["Id"].Value;

                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        string query = "DELETE FROM Бронирование WHERE Id = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Запись удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadBookings();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления: " + ex.Message);
                }
            }
        }

        // ========== ФИЛЬТРЫ ==========
        private void btnFilterByTourist_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBookings.CurrentRow == null)
                {
                    MessageBox.Show("Выберите запись!");
                    return;
                }

                int туристId = (int)dataGridViewBookings.CurrentRow.Cells["ТуристId"].Value;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"SELECT Бронирование.*, 
                                   Путешествия.НазваниеТура AS Тур,
                                   Туристы.ФИО AS Турист,
                                   Страны.Название AS Страна
                                   FROM Бронирование 
                                   LEFT JOIN Путешествия ON Бронирование.ПутешествиеId = Путешествия.Id
                                   LEFT JOIN Туристы ON Бронирование.ТуристId = Туристы.Id
                                   LEFT JOIN Страны ON Путешествия.СтранаId = Страны.Id
                                   WHERE Бронирование.ТуристId = @id
                                   ORDER BY Бронирование.ДатаБронирования DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", туристId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewBookings.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnFilterByTrip_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBookings.CurrentRow == null)
                {
                    MessageBox.Show("Выберите запись!");
                    return;
                }

                int путешествиеId = (int)dataGridViewBookings.CurrentRow.Cells["ПутешествиеId"].Value;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = @"SELECT Бронирование.*, 
                                   Путешествия.НазваниеТура AS Тур,
                                   Туристы.ФИО AS Турист,
                                   Страны.Название AS Страна
                                   FROM Бронирование 
                                   LEFT JOIN Путешествия ON Бронирование.ПутешествиеId = Путешествия.Id
                                   LEFT JOIN Туристы ON Бронирование.ТуристId = Туристы.Id
                                   LEFT JOIN Страны ON Путешествия.СтранаId = Страны.Id
                                   WHERE Бронирование.ПутешествиеId = @id
                                   ORDER BY Бронирование.ДатаБронирования DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", путешествиеId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewBookings.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }

        // ========== ПРОЦЕДУРЫ ==========
        private void btnProc1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTourists.CurrentRow == null)
                {
                    MessageBox.Show("Выберите туриста в таблице!");
                    tabControl1.SelectedTab = tabPageTourists;
                    return;
                }

                int touristId = (int)dataGridViewTourists.CurrentRow.Cells["Id"].Value;
                string touristName = dataGridViewTourists.CurrentRow.Cells["ФИО"].Value.ToString();

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("ПодсчетБронированийПоТуристу", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ТуристId", touristId);

                        SqlParameter output = new SqlParameter("@Количество", SqlDbType.Int);
                        output.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(output);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Турист: {touristName}\nКоличество бронирований: {output.Value}",
                            "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnProc2_Click(object sender, EventArgs e)
        {
            Form inputForm = new Form();
            inputForm.Text = "Поиск по стране";
            inputForm.Size = new System.Drawing.Size(350, 150);
            inputForm.StartPosition = FormStartPosition.CenterParent;
            inputForm.BackColor = Color.FromArgb(224, 242, 241);
            inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputForm.MaximizeBox = false;
            inputForm.MinimizeBox = false;

            Label lbl = new Label();
            lbl.Text = "Введите название страны:";
            lbl.Location = new System.Drawing.Point(10, 15);
            lbl.Size = new System.Drawing.Size(300, 20);
            lbl.ForeColor = Color.FromArgb(0, 105, 92);

            TextBox txt = new TextBox();
            txt.Location = new System.Drawing.Point(10, 40);
            txt.Size = new System.Drawing.Size(300, 20);

            Button btnOk = new Button();
            btnOk.Text = "Поиск";
            btnOk.Location = new System.Drawing.Point(120, 70);
            btnOk.Size = new System.Drawing.Size(90, 30);
            btnOk.BackColor = Color.FromArgb(255, 183, 77);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = Color.White;
            btnOk.DialogResult = DialogResult.OK;

            inputForm.Controls.Add(lbl);
            inputForm.Controls.Add(txt);
            inputForm.Controls.Add(btnOk);

            if (inputForm.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(txt.Text))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        using (SqlCommand cmd = new SqlCommand("ПоискТуровПоСтране", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@НазваниеСтраны", txt.Text);

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            FormResult f = new FormResult();
                            f.dataGridView1.DataSource = dt;
                            f.Text = "Результаты поиска";
                            f.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void btnProc3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("СтатистикаПоСтранам", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        FormResult f = new FormResult();
                        f.dataGridView1.DataSource = dt;
                        f.Text = "Статистика по странам";
                        f.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}