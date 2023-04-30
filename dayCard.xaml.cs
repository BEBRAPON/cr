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

namespace cal
{
    /// <summary>
    /// Логика взаимодействия для dayCard.xaml
    /// </summary>
    public partial class dayCard : UserControl
    {
        public dayCard()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveDate.dayNum = dayNum.Text;

            hidingPage.frame.Content = new SecondPage();

            hidingPage.head.Visibility = Visibility.Collapsed;
            hidingPage.body.Visibility = Visibility.Collapsed;
        }
    }
}
