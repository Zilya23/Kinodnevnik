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
    /// Логика взаимодействия для CollectionPage.xaml
    /// </summary>
    public partial class CollectionPage : Page
    {
        public CollectionPage()
        {
            InitializeComponent();
        }

        private void btn_Main_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void btn_Diary_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DiaryPage());
        }
    }
}
