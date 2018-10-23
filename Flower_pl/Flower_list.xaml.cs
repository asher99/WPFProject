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
using Flowers_BE;

namespace Flower_pl
{
    /// <summary>
    /// Interaction logic for Flower_list.xaml
    /// </summary>
    public partial class Flower_list : Window
    {
        public Flower_list(List<Flower> list)
        {
            foreach (Flower item in list)
            {
                datagridflowers.Items.Add(item);
            }
            InitializeComponent();
        }
    }
}
