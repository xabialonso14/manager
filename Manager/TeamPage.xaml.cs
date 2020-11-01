using System;
using System.IO;
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
using System.Collections.ObjectModel;

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
            //data_list.list.Add(new DataObject() { A = "imie", B = "nazwisko", C = "umiejetnosc" });

            //Resources.Add("players", data_list.list) ;
            this.dataGrid2.ItemsSource = data_list.list;
        }

        public class DataObject
        {
            public string imie { get; set; }
            public string nazwisko { get; set; }
            public int umiejetnosc { get; set; }
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
                imie = name.Text,
                nazwisko = surname.Text,
                umiejetnosc = ran
            });
            //this.dataGrid2.ItemsSource = data_list.list;
            //surname.Text = data_list.a;
            //list.Add(new DataObject() { A = 6, B = 7, C = 5 });
        }
    }
}
