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

namespace ekz_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Ship> shipList = new List<Ship>();
        public MainWindow()
        {
            InitializeComponent();
            
            Ini();
            this.DataContext = shipList;
        }

        public void Ini()
        {
            shipList.Add(new Ship(1, 2));
            shipList.Add(new Ship(1, 4));
            shipList.Add(new Ship(1, 6));
            shipList.Add(new Ship(1, 8));
            shipList.Add(new Ship(2, 1));
            shipList.Add(new Ship(2, 3));
            shipList.Add(new Ship(2, 5));
            shipList.Add(new Ship(2, 7));
            shipList.Add(new Ship(3, 2));
            shipList.Add(new Ship(3, 4));
            shipList.Add(new Ship(3, 6));
            shipList.Add(new Ship(3, 8));
        }

    }


    public class Ship
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }

        public Ship() { }
        public Ship(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
