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


            this.dataGrid2.ItemsSource = data_list.list;
        }

        public class DataObject
        {
            public string imię { get; set; }
            public string nazwisko { get; set; }
            public int umiejętność { get; set; }
            public string narodowość { get; set; }
        }
        static class data_list
        {
            public static ObservableCollection<DataObject> list = new ObservableCollection<DataObject>();
        }

        private void Button_get_random_Click(object sender, RoutedEventArgs e)
        {
            string str = "";
            if (Polish_Radio_Button.IsChecked == true)
            {
                str = "pl";
            }
            if (English_Radio_Button.IsChecked == true)
            {
                str = "en";
            }
            if (German_Radio_Button.IsChecked == true)
            {
                str = "de";
            }

            try
            {
                using (var text = new StreamReader("../../data/" + str + "/names.txt"))
                {
                    var rand = new Random();
                    int ran = rand.Next(101);
                    for (var a = 1; a < ran; a++)
                    {
                        var line = text.ReadLine();
                        name.Text = line;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                name.Text = ex.Message;
            }
            try
            {
                using (var text = new StreamReader("../../data/" + str + "/surnames.txt"))
                {
                    var rand = new Random();
                    int ran = rand.Next(1001);
                    for (var a = 1; a < ran; a++)
                    {
                        var line = text.ReadLine();
                        surname.Text = line;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                surname.Text = ex.Message;

            }

        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            int ran = rand.Next(100);
            data_list.list.Add(new DataObject()
            {
                imię = name.Text,
                nazwisko = surname.Text,
                umiejętność = ran
            });
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            string jsonString;
            jsonString = JsonSerializer.Serialize(data_list.list);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json file (*.json)|*.json|All files (*.*)|*.*";
            //saveFileDialog.InitialDirectory = @"c:\temp\";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, jsonString);
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";
            //saveFileDialog.InitialDirectory = @"c:\temp\";
            if (openFileDialog.ShowDialog() == true)
            {
                string text = File.ReadAllText(openFileDialog.FileName);
                var a = JsonSerializer.Deserialize<ObservableCollection<DataObject>>(text);
                data_list.list = a;
                this.dataGrid2.ItemsSource = data_list.list;

            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            data_list.list = new ObservableCollection<DataObject>();
            this.dataGrid2.ItemsSource = data_list.list;
        }
        
        private void generate_Click(object sender, RoutedEventArgs e)
        {
        var random = new Random();
            for (var num = 1; num <21; num++)
            {

                int random_nationality_number = random.Next(4);
                string str;
                if (random_nationality_number == 1)
                {
                    str = "pl";
                }
                else if (random_nationality_number == 2)
                {
                    str = "en";
                }
                else
                {
                    str = "de";
                }
                string actual_name = "";
                string actual_surname = "";
                try
                {
                    using (var text = new StreamReader("../../data/" + str + "/names.txt"))
                    {
    
                        int ran = random.Next(101);
                        for (var a = 1; a < ran+2; a++)
                        {
                            string line = text.ReadLine();
                            actual_name = line;
                        }
                        
                    }
                }
                catch (FileNotFoundException ex)
                {
                    actual_name = ex.Message;

                }
                try
                {
                    using (var text = new StreamReader("../../data/" + str + "/surnames.txt"))
                    {
                        int ran = random.Next(1001);
                        for (var a = 1; a < ran+2; a++)
                        {
                            var line = text.ReadLine();
                            actual_surname = line;
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    actual_surname = ex.Message;

                }
                
                int random_skill_number = random.Next(100);
                data_list.list.Add(new DataObject()

                {
                    imię = actual_name,
                    nazwisko = actual_surname,
                    umiejętność = random_skill_number,
                    narodowość = str
                });
            }
        }
    }
}
