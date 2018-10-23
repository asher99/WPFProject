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
using Flowers_BL;
using Flowers_BE;

namespace Flower_pl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BL_func flower_BL;
        public MainWindow()
        {
            flower_BL = new BL_func();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Flower> mylist = new List<Flower>();
            foreach (Flower item in flower_BL.sub_list(textBoxFlower.Name))
            {
                mylist.Add(item);
            }
            new Flower_list(mylist).ShowDialog();
        }
    }
}
