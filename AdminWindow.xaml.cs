public partial class AdminWindow : Window
 {
     private string _email;

     public AdminWindow(string email)
     {
         InitializeComponent();
         _email = email;
     }
     private void CheckButton_Click(object sender, RoutedEventArgs e)
     {
         var date = DatePicker.SelectedDate;
         if (!date.HasValue)
         {
             MessageBox.Show("Оберіть дату", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
             return;
         }

         // Створення списку доступних дат прийомів на наступному тижні
         DateTime today = DateTime.Today;
         DateTime nextMonday = today.AddDays(((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7);

         List<DateTime> availableDates = new List<DateTime>
 {
     nextMonday.AddDays(1), // вівторок
     nextMonday.AddDays(3), // четвер
     nextMonday.AddDays(5)  // субота
 };

         bool has = availableDates.Any(d => d.Date == date.Value.Date);

         ResultLabel.Text = has
             ? $"Прийом на {date.Value:d} Є."
             : $"Прийому на {date.Value:d} немає.";
     }

     private void LogoutButton_Click(object sender, RoutedEventArgs e)
     {
         new MainWindow().Show();
         this.Close();
     }
 }
