using System;
using System.Linq;
using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace HelloPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonGame_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Game.xaml", UriKind.RelativeOrAbsolute));
        }

        private void buttonVideo_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Video.xaml", UriKind.RelativeOrAbsolute));
        }

        private void buttonAbout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/YourLastAboutDialog;component/AboutPage.xaml", UriKind.Relative));
        }
    }
}