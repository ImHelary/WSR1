using System.Windows;

namespace WSR1
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWin mainWin = new MainWin();
            mainWin.Show();

            this.Close();

        }
    }
}
