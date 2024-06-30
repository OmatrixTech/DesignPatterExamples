using DesignPatterExamples.FactoryPattern;
using System.Windows;

namespace DesignPatterExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnFactoryPattern_Click(object sender, RoutedEventArgs e)
        {
            NotificationProcessFactory factory = new NotificationProcessFactory();

            // Send an Email Notification
            INotification emailNotification = factory.CreateNotification(NotificationType.Email);
            emailNotification.SendNotification();

            // Send an SMS Notification
            INotification smsNotification = factory.CreateNotification(NotificationType.SMS);
            smsNotification.SendNotification();

            // Send a Push Notification
            INotification pushNotification = factory.CreateNotification(NotificationType.Push);
            pushNotification.SendNotification();
        }
    }
}