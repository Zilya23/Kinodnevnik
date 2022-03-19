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

namespace Kinodnevnik
{
    /// <summary>
    /// Логика взаимодействия для DiaryPage.xaml
    /// </summary>
    public partial class DiaryPage : Page
    {
        public DiaryPage()
        {
            InitializeComponent();
        }

        private void btn_Main_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void btn_Collect_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CollectionPage());
        }
    }
}
