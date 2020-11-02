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
        public static HomePage HomePage = new HomePage();
        public static TeamPage TeamPage = new TeamPage();
        public static CompetitionPage CompetitionPage = new CompetitionPage();
        public static TransfersPage TransfersPage = new TransfersPage();

        public MainWindow()
        {
            InitializeComponent();
            HomePage_RadioButton.IsChecked = true;
        }

        public void UpdateView()
        {
            turn_Label.Content = model.Game.turn;

            TeamPage.UpdateView();
        }

        private void UpdateTurn(object sender)
        {
            
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
        private void Transfers_Checked(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(TransfersPage);
        }

        private void SaveGame_Click(object sender, RoutedEventArgs e)
        {
            model.Game.SaveGame();
        }
        private void LoadGame_Click(object sender, RoutedEventArgs e)
        {
            model.Game.LoadGame();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            model.Game.NextRound();
        }
    }
}
