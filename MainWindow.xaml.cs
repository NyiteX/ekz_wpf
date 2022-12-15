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
        public Ellipse Collision_check(Ellipse ellipse)
        {
            int el_row = Grid.GetRow(ellipse);
            int el_col = Grid.GetColumn(ellipse);
            if (!yellow_figure)
            {
                if (el_row == Grid.GetRow(brown_1) && el_col == Grid.GetColumn(brown_1) && brown_1.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(brown_2) && el_col == Grid.GetColumn(brown_2) && brown_2.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(brown_3) && el_col == Grid.GetColumn(brown_3) && brown_3.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(brown_4) && el_col == Grid.GetColumn(brown_4) && brown_4.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(brown_5) && el_col == Grid.GetColumn(brown_5) && brown_5.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(brown_6) && el_col == Grid.GetColumn(brown_6) && brown_6.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(brown_7) && el_col == Grid.GetColumn(brown_7) && brown_7.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(brown_8) && el_col == Grid.GetColumn(brown_8) && brown_8.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(brown_9) && el_col == Grid.GetColumn(brown_9) && brown_9.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(brown_10) && el_col == Grid.GetColumn(brown_10) && brown_10.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(brown_11) && el_col == Grid.GetColumn(brown_11) && brown_11.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(brown_12) && el_col == Grid.GetColumn(brown_12) && brown_12.Visibility == Visibility.Visible) return null;

                if (el_row == Grid.GetRow(yellow_1) && el_col == Grid.GetColumn(yellow_1) && yellow_1.Visibility == Visibility.Visible) return yellow_1;
                if (el_row == Grid.GetRow(yellow_2) && el_col == Grid.GetColumn(yellow_2) && yellow_2.Visibility == Visibility.Visible) return yellow_2;
                if (el_row == Grid.GetRow(yellow_3) && el_col == Grid.GetColumn(yellow_3) && yellow_3.Visibility == Visibility.Visible) return yellow_3;
                if (el_row == Grid.GetRow(yellow_4) && el_col == Grid.GetColumn(yellow_4) && yellow_4.Visibility == Visibility.Visible) return yellow_4;
                if (el_row == Grid.GetRow(yellow_5) && el_col == Grid.GetColumn(yellow_5) && yellow_5.Visibility == Visibility.Visible) return yellow_5;
                if (el_row == Grid.GetRow(yellow_6) && el_col == Grid.GetColumn(yellow_6) && yellow_6.Visibility == Visibility.Visible) return yellow_6;
                if (el_row == Grid.GetRow(yellow_7) && el_col == Grid.GetColumn(yellow_7) && yellow_7.Visibility == Visibility.Visible) return yellow_7;
                if (el_row == Grid.GetRow(yellow_8) && el_col == Grid.GetColumn(yellow_8) && yellow_8.Visibility == Visibility.Visible) return yellow_8;
                if (el_row == Grid.GetRow(yellow_9) && el_col == Grid.GetColumn(yellow_9) && yellow_9.Visibility == Visibility.Visible) return yellow_9;
                if (el_row == Grid.GetRow(yellow_10) && el_col == Grid.GetColumn(yellow_10) && yellow_10.Visibility == Visibility.Visible) return yellow_10;
                if (el_row == Grid.GetRow(yellow_11) && el_col == Grid.GetColumn(yellow_11) && yellow_11.Visibility == Visibility.Visible) return yellow_11;
                if (el_row == Grid.GetRow(yellow_12) && el_col == Grid.GetColumn(yellow_12) && yellow_12.Visibility == Visibility.Visible) return yellow_12;
            }
            else
            {
                if (el_row == Grid.GetRow(yellow_1) && el_col == Grid.GetColumn(yellow_1) && yellow_1.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(yellow_2) && el_col == Grid.GetColumn(yellow_2) && yellow_2.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(yellow_3) && el_col == Grid.GetColumn(yellow_3) && yellow_3.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(yellow_4) && el_col == Grid.GetColumn(yellow_4) && yellow_4.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(yellow_5) && el_col == Grid.GetColumn(yellow_5) && yellow_5.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(yellow_6) && el_col == Grid.GetColumn(yellow_6) && yellow_6.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(yellow_7) && el_col == Grid.GetColumn(yellow_7) && yellow_7.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(yellow_8) && el_col == Grid.GetColumn(yellow_8) && yellow_8.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(yellow_9) && el_col == Grid.GetColumn(yellow_9) && yellow_9.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(yellow_10) && el_col == Grid.GetColumn(yellow_10) && yellow_10.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(yellow_11) && el_col == Grid.GetColumn(yellow_11) && yellow_11.Visibility == Visibility.Visible) return null;
                if (el_row == Grid.GetRow(yellow_12) && el_col == Grid.GetColumn(yellow_12) && yellow_12.Visibility == Visibility.Visible) return null;

                if (el_row == Grid.GetRow(brown_1) && el_col == Grid.GetColumn(brown_1) && brown_1.Visibility == Visibility.Visible) return brown_1;
                if (el_row == Grid.GetRow(brown_2) && el_col == Grid.GetColumn(brown_2) && brown_2.Visibility == Visibility.Visible) return brown_2;
                if (el_row == Grid.GetRow(brown_3) && el_col == Grid.GetColumn(brown_3) && brown_3.Visibility == Visibility.Visible) return brown_3;
                if (el_row == Grid.GetRow(brown_4) && el_col == Grid.GetColumn(brown_4) && brown_4.Visibility == Visibility.Visible) return brown_4;
                if (el_row == Grid.GetRow(brown_5) && el_col == Grid.GetColumn(brown_5) && brown_5.Visibility == Visibility.Visible) return brown_5;
                if (el_row == Grid.GetRow(brown_6) && el_col == Grid.GetColumn(brown_6) && brown_6.Visibility == Visibility.Visible) return brown_6;
                if (el_row == Grid.GetRow(brown_7) && el_col == Grid.GetColumn(brown_7) && brown_7.Visibility == Visibility.Visible) return brown_7;
                if (el_row == Grid.GetRow(brown_8) && el_col == Grid.GetColumn(brown_8) && brown_8.Visibility == Visibility.Visible) return brown_8;
                if (el_row == Grid.GetRow(brown_9) && el_col == Grid.GetColumn(brown_9) && brown_9.Visibility == Visibility.Visible) return brown_9;
                if (el_row == Grid.GetRow(brown_10) && el_col == Grid.GetColumn(brown_10) && brown_10.Visibility == Visibility.Visible) return brown_10;
                if (el_row == Grid.GetRow(brown_11) && el_col == Grid.GetColumn(brown_11) && brown_11.Visibility == Visibility.Visible) return brown_11;
                if (el_row == Grid.GetRow(brown_12) && el_col == Grid.GetColumn(brown_12) && brown_12.Visibility == Visibility.Visible) return brown_12;
            }
            return new Ellipse();
        }
        public bool White_path(int row, int column)
        {
            try
            {
                Ellipse tmp = new Ellipse();
                if (!yellow_figure)
                {
                    if (row - step > 0 && column + step < 9)
                    {
                        Grid.SetRow(while_1, row - step);
                        Grid.SetColumn(while_1, column + step);
                        tmp = Collision_check(while_1);
                        if (tmp != null)
                        {
                            if (Grid.GetRow(tmp) == 0)
                            {
                                
                                while_1.Visibility = Visibility.Visible;
                                return true;
                            }
                            else
                            {
                                step = 2;
                                White_path(row, column);
                            }
                        }
                    }
                    if (row - step > 0 && column - step > 0)
                    {
                        Grid.SetRow(white_2, row - step);
                        Grid.SetColumn(white_2, column - step);
                        tmp = Collision_check(white_2);
                        if (tmp != null)
                        {
                            if (Grid.GetRow(tmp) == 0)
                            {
                                white_2.Visibility = Visibility.Visible;
                                return true;
                            }
                            else
                            {
                                step = 2;
                                White_path(row, column);
                            }
                        }
                    }
                }
                else
                {
                    if (row + step < 9 && column - step > 0)
                    {
                        Grid.SetRow(while_1, row + step);
                        Grid.SetColumn(while_1, column - step);
                        tmp = Collision_check(while_1);
                        if (tmp != null)
                        {
                            if (Grid.GetRow(tmp) == 0)
                            {
                                while_1.Visibility = Visibility.Visible;
                                return true;
                            }
                            else
                            {
                                step = 2;
                                White_path(row, column);
                            }
                        }
                    }
                    if (row + step < 9 && column + step < 9)
                    {
                        Grid.SetRow(white_2, row + step);
                        Grid.SetColumn(white_2, column + step);
                        tmp = Collision_check(white_2);
                        if (tmp != null)
                        {
                            if (Grid.GetRow(tmp) == 0)
                            {
                                white_2.Visibility = Visibility.Visible;
                                return true;
                            }
                            else
                            {
                                step = 2;
                                White_path(row, column);
                            }
                        }

                    }
                }
                return true;
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
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
                yellow_figure = false;
            }
            else yellow_figure = true;

            while_1.Visibility = Visibility.Hidden;
            white_2.Visibility = Visibility.Hidden;
            if (row_new >= 1 && row_new <= 8 && column_new >= 1 && column_new <= 8)
            {
                Grid.SetRow(ellipse, row_new);
                Grid.SetColumn(ellipse, column_new);
            }
            step = 1;
        }
        private void brown_1_MouseUp(object sender, MouseButtonEventArgs e)
        {            
            if (!yellow_figure)
            {
                while_1.Visibility = Visibility.Hidden;
                white_2.Visibility = Visibility.Hidden;
                active_figure = isActive_figure_brown();
                White_path(Grid.GetRow(active_figure), Grid.GetColumn(active_figure));
            }
        }

        private void yellow_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (yellow_figure)
            {
                while_1.Visibility = Visibility.Hidden;
                white_2.Visibility = Visibility.Hidden;
                active_figure = isActive_figure_yellow();
                White_path(Grid.GetRow(active_figure), Grid.GetColumn(active_figure));
            }
        }

        private void while_1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (while_1.Visibility == Visibility.Visible)
            {
                if (!yellow_figure)
                {
                    Move_figure(active_figure, "right");
                }
                else
                {
                    Move_figure(active_figure, "right");
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
                }
                else
                {
                    Move_figure(active_figure, "left");
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