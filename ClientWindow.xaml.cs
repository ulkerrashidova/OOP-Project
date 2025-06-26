public partial class ClientWindow : Window
    {
        private string _email;

        public ClientWindow(string email)
        {
            InitializeComponent();
            _email = email;
            EmailLabel.Text = _email;
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void BookAppointment_Click(object sender, RoutedEventArgs e)
        {
            var appointmentWindow = new AppointmentWindow();
            appointmentWindow.ShowDialog();
        }

        private void ViewServices_Click(object sender, RoutedEventArgs e)
        {
            var servicesWindow = new ServicesWindow();
            servicesWindow.ShowDialog(); 
        }

       private void RequestCall_Click(object sender, RoutedEventArgs e)
        {
            var callWindow = new CallRequestWindow();
            callWindow.ShowDialog();
        }

    }
