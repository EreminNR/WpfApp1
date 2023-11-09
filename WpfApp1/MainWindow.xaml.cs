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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == String.Empty || Password.Password == String.Empty)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                using (SFabricaEntities sFabricaEntities = new SFabricaEntities())
                {
                    AppUser user = sFabricaEntities.AppUser.FirstOrDefault(u => u.Login == Login.Text && u.Password == Password.Password);

                    if (user == null)
                    {
                        MessageBox.Show("Пользователь не найден");
                    }
                    else
                    {
                        if (user.Role == 1)
                        {
                            var NewForm = new Заказчик();
                            NewForm.Show();
                            this.Close();
                        }
                        else if (user.Role == 2)
                        {
                            var NewForm = new Менеджер();
                            NewForm.Show();
                            this.Close();
                        }
                        else if (user.Role == 3)
                        {
                            var NewForm = new Кладовщик();
                            NewForm.Show();
                            this.Close();
                        }
                        else if (user.Role == 4)
                        {
                            var NewForm = new Директор();
                            NewForm.Show();
                            this.Close();
                        }


                    }
                }
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var NewForm = new Reg();
            NewForm.Show();
            this.Close();
        }
    }
}
