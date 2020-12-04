using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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
using System.Collections.ObjectModel;
using Microsoft.Win32;
using Manager.model;


namespace Manager
{
    /// <summary>
    /// Logika interakcji dla klasy TeamPage.xaml
    /// </summary>
    public partial class TeamPage : Page
    {
        public TeamPage()
        {
            InitializeComponent();
            Polish_Radio_Button.IsChecked = true;
            NameTextBox.Text = "Name";
            SurnameTextBox.Text = "Surname";
        }

        public void UpdateView()
        {
            MainWindow.TeamPage.dataGrid.ItemsSource = Game.MyTeam.Players;
            
        }

        private void Button_get_random_Click(object sender, RoutedEventArgs e)
        {
            string str = "";
            if (Polish_Radio_Button.IsChecked == true)str = "pl";
            if (English_Radio_Button.IsChecked == true) str = "en";
            if (German_Radio_Button.IsChecked == true) str = "de";
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            Game.MyTeam.Players.Add(new Player(name, surname, Utilities.get_random_number(100), str));
            UpdateView();
        }
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Game.MyTeam.Players = new ObservableCollection<Player>();
            UpdateView();
        }
        
        private void generate_Click(object sender, RoutedEventArgs e)
        {
            var random = new Random();
            for (var num = 1; num < 21; num++)
            {
                Game.MyTeam.Players.Add(Utilities.getRandomPlayer(random));

            }
            UpdateView();
        }
    }
}
