using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
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
        bool yellow_figure = false;
        int step = 1;
        Ellipse active_figure;
        public MainWindow()
        {
            InitializeComponent();
            
            Ini();
            this.DataContext = shipList;
        }

        public void Ini()
        {
            for (int i = 1; i <= 3; i++)
            {
                if (i % 2 != 0)
                    for (int u = 2; u <= 8; u += 2)
                        shipList.Add(new Ship(i, u));
                else
                    for (int u = 1; u <= 8; u += 2)
                        shipList.Add(new Ship(i, u));
            }

            for (int i = 6; i <= 8; i++)
            {
                if (i % 2 != 0)
                    for (int u = 2; u <= 8; u += 2)
                        shipList.Add(new Ship(i, u));
                else
                    for (int u = 1; u <= 8; u += 2)
                        shipList.Add(new Ship(i, u));
            }
        }
        public Ellipse isActive_figure_brown()
        {
            if (brown_1.IsMouseOver) return brown_1;
            else if (brown_2.IsMouseOver) return brown_2;
            else if (brown_3.IsMouseOver) return brown_3;
            else if (brown_4.IsMouseOver) return brown_4;
            else if (brown_5.IsMouseOver) return brown_5;
            else if (brown_6.IsMouseOver) return brown_6;
            else if (brown_7.IsMouseOver) return brown_7;
            else if (brown_8.IsMouseOver) return brown_8;
            else if (brown_9.IsMouseOver) return brown_9;
            else if (brown_10.IsMouseOver) return brown_10;
            else if (brown_11.IsMouseOver) return brown_11;
            else if (brown_12.IsMouseOver) return brown_12;
            else return null;
        }
        public Ellipse isActive_figure_yellow()
        {
            if (yellow_1.IsMouseOver) return yellow_1;
            else if (yellow_2.IsMouseOver) return yellow_2;
            else if (yellow_3.IsMouseOver) return yellow_3;
            else if (yellow_4.IsMouseOver) return yellow_4;
            else if (yellow_5.IsMouseOver) return yellow_5;
            else if (yellow_6.IsMouseOver) return yellow_6;
            else if (yellow_7.IsMouseOver) return yellow_7;
            else if (yellow_8.IsMouseOver) return yellow_8;
            else if (yellow_9.IsMouseOver) return yellow_9;
            else if (yellow_10.IsMouseOver) return yellow_10;
            else if (yellow_11.IsMouseOver) return yellow_11;
            else if (yellow_12.IsMouseOver) return yellow_12;
            else return null;
        }
        public bool White_path(int row, int column)
        {
            try
            {
                if (!yellow_figure)
                {
                    Grid.SetRow(while_1, row - step);
                    Grid.SetColumn(while_1, column + step);
                    Grid.SetRow(white_2, row - step);
                    Grid.SetColumn(white_2, column - step);                                    
                }
                else
                {
                    Grid.SetRow(while_1, row + step);
                    Grid.SetColumn(while_1, column - step);
                    Grid.SetRow(white_2, row + step);
                    Grid.SetColumn(white_2, column + step);
                }
                while_1.Visibility = Visibility.Visible;
                white_2.Visibility = Visibility.Visible;
                return true;
            }
            catch(Exception E) { MessageBox.Show(E.Message); }
            return false;
        }
        public void Move_figure(Ellipse ellipse,string path)
        {           
            int row_new = Grid.GetRow(ellipse) - step;
            int column_new = Grid.GetColumn(ellipse) + step;
            if(path == "left")
                column_new = Grid.GetColumn(ellipse) - step;
            if (yellow_figure)
            {
                row_new = Grid.GetRow(ellipse) + step;
                column_new = Grid.GetColumn(ellipse) - step;
                if (path == "left")
                    column_new = Grid.GetColumn(ellipse) + step;
            }

            while_1.Visibility = Visibility.Hidden;
            white_2.Visibility = Visibility.Hidden;
            if (row_new >= 1 && row_new <= 8 && column_new >= 1 && column_new <= 8)
            {
                Grid.SetRow(ellipse, row_new);
                Grid.SetColumn(ellipse, column_new);
            }           
        }
        private void brown_1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            active_figure = isActive_figure_brown();
            if (!yellow_figure)
                White_path(Grid.GetRow(active_figure), Grid.GetColumn(active_figure));
        }

        private void yellow_MouseUp(object sender, MouseButtonEventArgs e)
        {
            active_figure = isActive_figure_yellow();
            if (yellow_figure)
                White_path(Grid.GetRow(active_figure), Grid.GetColumn(active_figure));
        }

        private void while_1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (while_1.Visibility == Visibility.Visible)
            {
                if (!yellow_figure)
                {
                    Move_figure(active_figure, "right");
                    yellow_figure = true;
                }
                else
                {
                    Move_figure(active_figure, "right");
                    yellow_figure = false;
                }
            }
        }

        private void white_2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (white_2.Visibility == Visibility.Visible)
            {
                if (!yellow_figure)
                {
                    Move_figure(active_figure, "left");
                    yellow_figure = true;
                }
                else
                {
                    Move_figure(active_figure, "left");
                    yellow_figure = false;
                }
            }           
        }
    }


    public class Ship
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Ship() { }
        public Ship(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
