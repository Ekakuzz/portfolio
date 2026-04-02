using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace EventPlanner
{
    public class EventItem
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Place { get; set; }
    }

    public partial class MainWindow : Window
    {
        private ObservableCollection<EventItem> events;

        public MainWindow()
        {
            InitializeComponent();

            events = new ObservableCollection<EventItem>();
            events.Add(new EventItem { Name = "Встреча с друзьями", Date = "27.02.2026", Time = "19:00", Place = "Кафе" });
            events.Add(new EventItem { Name = "Сходить в магазин", Date = "28.02.2026", Time = "12:00", Place = "Супермаркет" });

            EventsControl.ItemsSource = events;
            AddBtn.Click += AddBtn_Click;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = NameInput.Text;
            if (string.IsNullOrWhiteSpace(name)) name = "Без названия";

            string date = DateInput.SelectedDate.HasValue
                ? DateInput.SelectedDate.Value.ToString("dd.MM.yyyy")
                : DateTime.Now.ToString("dd.MM.yyyy");

            string time = TimeInput.Text;
            if (string.IsNullOrWhiteSpace(time)) time = "12:00";

            string place = PlaceInput.Text;
            if (string.IsNullOrWhiteSpace(place)) place = "Не указано";

            events.Add(new EventItem { Name = name, Date = date, Time = time, Place = place });

            NameInput.Text = "";
            TimeInput.Text = "18:00";
            PlaceInput.Text = "Дом";
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                string name = button.Tag?.ToString();
                if (!string.IsNullOrEmpty(name))
                {
                    var item = events.FirstOrDefault(x => x.Name == name);
                    if (item != null)
                    {
                        NameInput.Text = item.Name;
                        // Здесь можно добавить редактирование
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                string name = button.Tag?.ToString();
                if (!string.IsNullOrEmpty(name))
                {
                    var item = events.FirstOrDefault(x => x.Name == name);
                    if (item != null)
                    {
                        events.Remove(item);
                    }
                }
            }
        }
    }
}