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
    /// Логика взаимодействия для choiceOption.xaml
    /// </summary>
    public partial class choiceOption : UserControl
    {
        public choiceOption()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, RoutedEventArgs e)
        {
            
            
            if (check.IsChecked == true)
            {   
                saves data = new saves(antoherSaveData.month, antoherSaveData.year, SaveDate.dayNum, img);
                savesDATE.date.Add(data);
            }
            else
            {
                List<saves> dd = new List<saves>();

                foreach (var item in savesDATE.date)
                {
                    string imagePath = img.Source.ToString();

                    if (item.img.Source.ToString() == imagePath)
                    {
                        dd.Add(item);
                    }
                }
                foreach (var item in dd)
                {
                    savesDATE.date.Remove(item);
                }
            }
        }
    }
}
