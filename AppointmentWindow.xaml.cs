public partial class AppointmentWindow : Window
 {
     public AppointmentWindow()
     {
         InitializeComponent();

         PayLaterRadio.Checked += PaymentOptionChanged;
         OnlinePayRadio.Checked += PaymentOptionChanged;
     }

     private void PaymentOptionChanged(object sender, RoutedEventArgs e)
     {
         if (OnlinePayRadio.IsChecked == true)
             OnlinePaymentPanel.Visibility = Visibility.Visible;
         else
             OnlinePaymentPanel.Visibility = Visibility.Collapsed;
     }

     private void ConfirmAppointment_Click(object sender, RoutedEventArgs e)
     {
         string firstName = FirstNameBox.Text.Trim();
         string lastName = LastNameBox.Text.Trim();
         DateTime? selectedDate = DatePicker.SelectedDate;
         string doctor = (DoctorCombo.SelectedItem as ComboBoxItem)?.Content.ToString();

         if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName)
              !selectedDate.HasValue  selectedDate <= DateTime.Now || string.IsNullOrWhiteSpace(doctor))
         {
             MessageBox.Show("Будь ласка, заповніть усі поля коректно.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
             return;
         }

         if (OnlinePayRadio.IsChecked == true)
         {
             if (!ValidateCardDetails())
             {
                 MessageBox.Show("Будь ласка, введіть коректні дані картки.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                 return;
             }

             MessageBox.Show($"Оплата пройшла успішно!\nВи записані до {doctor} на {selectedDate:dd.MM.yyyy}.", "Успіх", MessageBoxButton.OK, MessageBoxImage.Information);
         }
         else
         {
             MessageBox.Show($"Ви записані до {doctor} на {selectedDate:dd.MM.yyyy}.\nОплата після прийому.", "Успіх", MessageBoxButton.OK, MessageBoxImage.Information);
         }

         this.Close();
     }

     private bool ValidateCardDetails()
     {
         string cardNumber = CardNumberBox.Text.Trim();
         string expiry = ExpiryBox.Text.Trim();
         string cvc = CvcBox.Text.Trim();

         if (cardNumber.Length != 16 || !cardNumber.All(char.IsDigit))
             return false;

         if (!Regex.IsMatch(expiry, @"^(0[1-9]|1[0-2])\/\d{2}$")) // MM/YY
             return false;

         if (cvc.Length != 3 || !cvc.All(char.IsDigit))
             return false;

         return true;
     }
 }
