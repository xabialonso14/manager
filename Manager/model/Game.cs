using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;


namespace Manager.model
{
    class Game
    {
        public static int turn = 0;
        public static Team MyTeam = new Team();
        public static void SaveGame()
        {
            string jsonString;
            jsonString = JsonSerializer.Serialize(MyTeam.Players);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json file (*.json)|*.json|All files (*.*)|*.*";
            //saveFileDialog.InitialDirectory = @"c:\temp\";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, jsonString);
        }

        public static void LoadGame()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";
            //saveFileDialog.InitialDirectory = @"c:\temp\";
            if (openFileDialog.ShowDialog() == true)
            {
                string text = File.ReadAllText(openFileDialog.FileName);
                var a = JsonSerializer.Deserialize<ObservableCollection<Player>>(text);
                MyTeam.Players = a;

                ((MainWindow)Application.Current.MainWindow).UpdateView();
                //MainWindow.TeamPage.dataGrid2.ItemsSource = MyTeam.Players;

            }
        }

        public static void NextRound()
        {
            turn++;
        }
    }
}
