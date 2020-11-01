using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Manager
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        Page HomePage = new HomePage();
        Page TeamPage = new TeamPage();
        Page CompetitionPage = new CompetitionPage();

        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(HomePage);
        }

        private void Home_Checked(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(HomePage);
        }

        private void Team_Checked(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(TeamPage);
        }

        private void Competition_Checked(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(CompetitionPage);
        }
    }
}
