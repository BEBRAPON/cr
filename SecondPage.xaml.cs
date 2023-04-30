using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
            options();
            
            dateMan();

        }

        private void options()
        {

            o1.discription.Text = "Завтрак";
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri("/zav.png", UriKind.Relative);
            bitmapImage.EndInit();
            o1.img.Source = bitmapImage;
            savePath.path1 = o1.img.Source.ToString();

            o2.discription.Text = "Полдник";
            BitmapImage bitmapImage2 = new BitmapImage();
            bitmapImage2.BeginInit();
            bitmapImage2.UriSource = new Uri("/poldnik.png", UriKind.Relative);
            bitmapImage2.EndInit();
            o2.img.Source = bitmapImage2;
            savePath.path2 = o2.img.Source.ToString();

            o3.discription.Text = "Обед";
            BitmapImage bitmapImage3 = new BitmapImage();
            bitmapImage3.BeginInit();
            bitmapImage3.UriSource = new Uri("/Obed.png", UriKind.Relative);
            bitmapImage3.EndInit();
            o3.img.Source = bitmapImage3;
            savePath.path3 = o3.img.Source.ToString();

            o4.discription.Text = "Ужин";
            BitmapImage bitmapImage4 = new BitmapImage();
            bitmapImage4.BeginInit();
            bitmapImage4.UriSource = new Uri("/yzin.png", UriKind.Relative);
            bitmapImage4.EndInit();
            o4.img.Source = bitmapImage4;
            savePath.path4 = o4.img.Source.ToString();

        }

        private void dateMan()
        {
            string month = SaveDate.date.ToString("MMMM");
            string year = SaveDate.date.ToString("yyyy");

            antoherSaveData.month = month;
            antoherSaveData.year = year;

            check(month, year);

            selectedDate.Text = SaveDate.dayNum.ToString() + ", " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(month) + " " + year;
        }

        private void check(string month, string year)
        {
            if (savesDATE.date != null)
            {
                for (int index = 0; index < savesDATE.date.Count; index++)
                {
                    var item = savesDATE.date[index];
                    if (month == item.month && year == item.year && SaveDate.dayNum == item.day)
                    {
                        for (int i = 1; i < 5; i++)
                        {
                            var ch = (choiceOption)FindName("o" + i);

                            string path = ch.img.Source.ToString();
                            string path2 = item.img.Source.ToString();

                            if (path == path2)
                            {
                                ch.check.IsChecked = true;
                            }
                        }
                    }
                }
            }
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            secondPage.Content = new MainPage();

            head.Visibility = Visibility.Collapsed;
            body.Visibility = Visibility.Collapsed;
            foot.Visibility = Visibility.Collapsed;
        }
    }
}
