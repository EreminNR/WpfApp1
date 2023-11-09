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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ОстаткиКлад.xaml
    /// </summary>
    public partial class ОстаткиКлад : Window
    {
        public ОстаткиКлад()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            SFabricaEntities db = new SFabricaEntities();
            DataGrid.ItemsSource = db.Izdeliya.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            var NewForm = new Кладовщик();
            NewForm.Show();
            this.Close();
        }
    }
}