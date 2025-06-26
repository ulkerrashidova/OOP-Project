public partial class MainWindow : Window
 {
     public MainWindow()
     {
         InitializeComponent();
     }
     private void NextButton_Click(object sender, RoutedEventArgs e)
     {
         string email = EmailTextBox.Text;
         string password = PasswordBox.Password;
         string role = ((ComboBoxItem)RoleCombo.SelectedItem).Content.ToString();

         if (string.IsNullOrWhiteSpace(email)  !email.Contains("@")  string.IsNullOrWhiteSpace(password))
         {
             MessageBox.Show("Невалідні дані. Перевірте введене.");
             return;
         }

         if (role == "Клієнт")
         {
             var clientWindow = new ClientWindow(email);
             clientWindow.Show();
             this.Close();
         }
         else if (role == "Адміністратор")
         {
             var adminWindow = new AdminWindow(email);
             adminWindow.Show();
             this.Close();
         }
     }
 }
