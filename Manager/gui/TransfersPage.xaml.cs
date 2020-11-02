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
using System.Resources;

namespace Manager
{
    /// <summary>
    /// Logika interakcji dla klasy TransfersPage.xaml
    /// </summary>
    public partial class TransfersPage : Page
    {
        public TransfersPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            using (var text = new StreamReader(Properties.Resources.ResourceManager.GetString("a")))
            {
                var line = text.ReadLine();
                test_label.Content = line;
            }
        }
    }
}
