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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            dateManipulation();
        }

        private void dateCard()
        {
            DateTime selectedDate = datePicker.SelectedDate.Value;
            int daysInMonth = DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month);

            for (int i = 1; i <= 31; i++)
            {
                var Card = (dayCard)FindName("d" + i);
                Card.dayNum.Text = i.ToString();
                Card.Visibility = Visibility.Visible;
                if (i > daysInMonth)
                {
                    Card.Visibility = Visibility.Hidden;
                }
            }
        }

        private void dateManipulation()
        {
            datePicker.SelectedDate = SaveDate.date;

            hidingPage.head = head;
            hidingPage.body = body;

            hidingPage.frame = mainPage;

            dateManipulation2();
        }

        private void imgLoad()
        {
            if (savesDATE.date != null)
            {
                foreach (var date in savesDATE.date)
                {
                    if (date.month == SaveDate.date.ToString("MMMM") && date.year == SaveDate.date.ToString("yyyy"))
                    {
                        var Card = (dayCard)FindName("d" + date.day);
                        if (Card.dayNum.Text == date.day)
                        {
                            Card.iimg.Source = date.img.Source;
                            Card.iimg.Height = 50;
                            Card.iimg.Width = 50;
                        }
                    }
                }
            }
        }
        private void dateManipulation2()
        {
            dateCard();
            imgLoad();

            if (datePicker.SelectedDate != null)
            {
                SaveDate.setDate(datePicker.SelectedDate.Value);
            }

            DateTime selectedDate = datePicker.SelectedDate.Value;
            string monthAndYear = selectedDate.ToString("MMMM, yyyy");
            monthName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(monthAndYear);
        }

        private void dateManipulation3(DateTime date)
        {
            datePicker.SelectedDate = date;

            string monthAndYear = date.ToString("MMMM, yyyy");
            monthName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(monthAndYear);
        }

        private void datePicker_selectedDate(object sender, SelectionChangedEventArgs e)
        {
            dateManipulation2();
        }

        private void lastMonth_Click(object sender, RoutedEventArgs e)
        {
            if (datePicker.SelectedDate != null)
            {
                DateTime date = datePicker.SelectedDate.Value;
                date = date.AddMonths(-1);

                dateManipulation3(date);
                dateManipulation2();
            }
        }

        private void nextMonth_Click(object sender, RoutedEventArgs e)
        {
            if (datePicker.SelectedDate != null)
            {
                DateTime date = datePicker.SelectedDate.Value;
                date = date.AddMonths(+1);

                dateManipulation3(date);
                dateManipulation2();
            }
        }
    }
}
