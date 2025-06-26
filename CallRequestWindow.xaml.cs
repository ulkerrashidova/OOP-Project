public partial class CallRequestWindow : Window
  {
      public CallRequestWindow()
      {
          InitializeComponent();
      }

      private void SubmitCall_Click(object sender, RoutedEventArgs e)
      {
          string name = NameBox.Text;
          string phone = PhoneBox.Text;

          string pattern = @"^\+38\(0\d{2}\)-\d{7}$";

          if (string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(phone, pattern))
          {
              MessageBox.Show("Будь ласка, введіть коректні ім’я та номер телефону\nФормат: +38(0XX)-XXXXXXX",
                              "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
              return;
          }

          MessageBox.Show($"Дякуємо, {name}! Наш оператор зв’яжеться з вами за номером {phone}.",
                          "Запит прийнято", MessageBoxButton.OK, MessageBoxImage.Information);

          this.Close();
      }
  }
