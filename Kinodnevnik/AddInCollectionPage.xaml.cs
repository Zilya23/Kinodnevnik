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
    /// Логика взаимодействия для AddInCollectionPage.xaml
    /// </summary>
    public partial class AddInCollectionPage : Page
    {
        public AddInCollectionPage()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            AddCollectionWindow addColl = new AddCollectionWindow();
            addColl.Show();
        }
    }
}
