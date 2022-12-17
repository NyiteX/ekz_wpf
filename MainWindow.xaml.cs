using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Policy;
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
        int step = 1,step2 = 1;
        Ellipse active_figure;
        Ellipse removed_figure = new Ellipse();
        Ellipse removed_figure2 = new Ellipse();
        string path = "";
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

                if (el_row == Grid.GetRow(yellow_1) && el_col == Grid.GetColumn(yellow_1) && yellow_1.Visibility == Visibility.Visible) { /*removed_figure = yellow_1;*/ return yellow_1; }
                if (el_row == Grid.GetRow(yellow_2) && el_col == Grid.GetColumn(yellow_2) && yellow_2.Visibility == Visibility.Visible) { /*removed_figure = yellow_2;*/ return yellow_2; }
                if (el_row == Grid.GetRow(yellow_3) && el_col == Grid.GetColumn(yellow_3) && yellow_3.Visibility == Visibility.Visible) { /*removed_figure = yellow_3;*/ return yellow_3; }
                if (el_row == Grid.GetRow(yellow_4) && el_col == Grid.GetColumn(yellow_4) && yellow_4.Visibility == Visibility.Visible) { /*removed_figure = yellow_4;*/ return yellow_4; }
                if (el_row == Grid.GetRow(yellow_5) && el_col == Grid.GetColumn(yellow_5) && yellow_5.Visibility == Visibility.Visible) { /*removed_figure = yellow_5;*/ return yellow_5; }
                if (el_row == Grid.GetRow(yellow_6) && el_col == Grid.GetColumn(yellow_6) && yellow_6.Visibility == Visibility.Visible) { /*removed_figure = yellow_6;*/ return yellow_6; }
                if (el_row == Grid.GetRow(yellow_7) && el_col == Grid.GetColumn(yellow_7) && yellow_7.Visibility == Visibility.Visible) { /*removed_figure = yellow_7;*/ return yellow_7; }
                if (el_row == Grid.GetRow(yellow_8) && el_col == Grid.GetColumn(yellow_8) && yellow_8.Visibility == Visibility.Visible) { /*removed_figure = yellow_8;*/ return yellow_8; }
                if (el_row == Grid.GetRow(yellow_9) && el_col == Grid.GetColumn(yellow_9) && yellow_9.Visibility == Visibility.Visible) { /*removed_figure = yellow_9;*/ return yellow_9; }
                if (el_row == Grid.GetRow(yellow_10) && el_col == Grid.GetColumn(yellow_10) && yellow_10.Visibility == Visibility.Visible) { /*removed_figure = yellow_10;*/ return yellow_10; }
                if (el_row == Grid.GetRow(yellow_11) && el_col == Grid.GetColumn(yellow_11) && yellow_11.Visibility == Visibility.Visible) { /*removed_figure = yellow_11;*/ return yellow_11; }
                if (el_row == Grid.GetRow(yellow_12) && el_col == Grid.GetColumn(yellow_12) && yellow_12.Visibility == Visibility.Visible) { /*removed_figure = yellow_12;*/ return yellow_12; }
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

                if (el_row == Grid.GetRow(brown_1) && el_col == Grid.GetColumn(brown_1) && brown_1.Visibility == Visibility.Visible) { /*removed_figure = brown_1; */return brown_1; }
                if (el_row == Grid.GetRow(brown_2) && el_col == Grid.GetColumn(brown_2) && brown_2.Visibility == Visibility.Visible) { /*removed_figure = brown_2;*/ return brown_2; }
                if (el_row == Grid.GetRow(brown_3) && el_col == Grid.GetColumn(brown_3) && brown_3.Visibility == Visibility.Visible) { /*removed_figure = brown_3;*/ return brown_3; }
                if (el_row == Grid.GetRow(brown_4) && el_col == Grid.GetColumn(brown_4) && brown_4.Visibility == Visibility.Visible) { /*removed_figure = brown_4;*/ return brown_4; }
                if (el_row == Grid.GetRow(brown_5) && el_col == Grid.GetColumn(brown_5) && brown_5.Visibility == Visibility.Visible) { /*removed_figure = brown_5;*/ return brown_5; }
                if (el_row == Grid.GetRow(brown_6) && el_col == Grid.GetColumn(brown_6) && brown_6.Visibility == Visibility.Visible) { /*removed_figure = brown_6;*/ return brown_6; }
                if (el_row == Grid.GetRow(brown_7) && el_col == Grid.GetColumn(brown_7) && brown_7.Visibility == Visibility.Visible) { /*removed_figure = brown_7;*/ return brown_7; }
                if (el_row == Grid.GetRow(brown_8) && el_col == Grid.GetColumn(brown_8) && brown_8.Visibility == Visibility.Visible) { /*removed_figure = brown_8;*/ return brown_8; }
                if (el_row == Grid.GetRow(brown_9) && el_col == Grid.GetColumn(brown_9) && brown_9.Visibility == Visibility.Visible) { /*removed_figure = brown_9;*/ return brown_9; }
                if (el_row == Grid.GetRow(brown_10) && el_col == Grid.GetColumn(brown_10) && brown_10.Visibility == Visibility.Visible) { /*removed_figure = brown_10;*/ return brown_10; }
                if (el_row == Grid.GetRow(brown_11) && el_col == Grid.GetColumn(brown_11) && brown_11.Visibility == Visibility.Visible) { /*removed_figure = brown_11;*/ return brown_11; }
                if (el_row == Grid.GetRow(brown_12) && el_col == Grid.GetColumn(brown_12) && brown_12.Visibility == Visibility.Visible) { /*removed_figure = brown_12;*/ return brown_12; }
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
                    if (row - step > 0 && column + step < 9) //right
                    {
                        Grid.SetRow(while_1, row - step);
                        Grid.SetColumn(while_1, column + step);
                        tmp = Collision_check(while_1);                        
                        if (tmp != null)
                        {                          
                            if (Grid.GetRow(tmp) == 0)
                            {                               
                                while_1.Visibility = Visibility.Visible;
                            }
                            else
                            {
                                removed_figure2 = tmp;
                                step = 2;
                            }
                        }
                    }
                    if (row - step2 > 0 && column - step2 > 0) //left
                    {
                        Grid.SetRow(white_2, row - step2);
                        Grid.SetColumn(white_2, column - step2);
                        tmp = Collision_check(white_2);
                        
                        if (tmp != null)
                        {
                            
                            if (Grid.GetRow(tmp) == 0)
                            {                                
                                white_2.Visibility = Visibility.Visible;                              
                            }
                            else
                            {
                                removed_figure = tmp;
                                step2 = 2;
                            }
                        }
                    }
                }
                else
                {
                    if (row + step < 9 && column - step > 0) //left
                    {
                        Grid.SetRow(while_1, row + step);
                        Grid.SetColumn(while_1, column - step);
                        tmp = Collision_check(while_1);
                        
                        if (tmp != null)
                        {
                            
                            if (Grid.GetRow(tmp) == 0)
                            {                              
                                while_1.Visibility = Visibility.Visible;
                            }
                            else
                            {
                                removed_figure2 = tmp;
                                step = 2;
                            }
                        }
                    }
                    if (row + step2 < 9 && column + step2 < 9) //right
                    {
                        Grid.SetRow(white_2, row + step2);
                        Grid.SetColumn(white_2, column + step2);
                        tmp = Collision_check(white_2);                       
                        if (tmp != null)
                        {
                            
                            if (Grid.GetRow(tmp) == 0)
                            {                              
                                white_2.Visibility = Visibility.Visible;
                            }
                            else
                            {
                                removed_figure = tmp;
                                step2 = 2;                               
                            }
                        }
                    }
                }
                this.Title = path;
                return true;
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
            return false;
        }
        public void Move_figure(Ellipse ellipse)
        {     
            //White_path(Grid.GetRow(ellipse),Grid.GetColumn(ellipse));
            int row_new = Grid.GetRow(ellipse) - step;
            int column_new = Grid.GetColumn(ellipse) + step;
            if (path == "left")
                column_new = Grid.GetColumn(ellipse) - step;
            else removed_figure = removed_figure2;

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

                Grid.SetRow(removed_figure, 0);
                Grid.SetColumn(removed_figure, 0);
                removed_figure.Visibility= Visibility.Hidden;
            }
            step = 1;
            step2 = 1;
        }
        private void brown_1_MouseUp(object sender, MouseButtonEventArgs e)
        {            
            if (!yellow_figure)
            {
                if(while_1.Visibility == Visibility.Visible || white_2.Visibility == Visibility.Visible)
                {
                    step= 1;
                    step2= 1;
                }
                while_1.Visibility = Visibility.Hidden;
                white_2.Visibility = Visibility.Hidden;
                active_figure = isActive_figure_brown();
                int kol = 2;
                while (kol > 0)
                {
                    White_path(Grid.GetRow(active_figure), Grid.GetColumn(active_figure));
                    kol--;
                }
            }
        }

        private void yellow_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (yellow_figure)
            {
                if(while_1.Visibility == Visibility.Visible || white_2.Visibility == Visibility.Visible)
                {
                    step= 1;
                    step2= 1;
                }
                while_1.Visibility = Visibility.Hidden;
                white_2.Visibility = Visibility.Hidden;
                active_figure = isActive_figure_yellow();
                int kol = 2;
                while (kol > 0)
                {
                    White_path(Grid.GetRow(active_figure), Grid.GetColumn(active_figure));
                    kol--;
                }
            }
        }

        private void while_1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (while_1.Visibility == Visibility.Visible)
            {
                path = "right";
                if (!yellow_figure)
                {
                    Move_figure(active_figure);                   
                }
                else
                {
                    Move_figure(active_figure);
                }
            }
        }

        private void white_2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (white_2.Visibility == Visibility.Visible)
            {
                path = "left";
                step = step2;
                if (!yellow_figure)
                {
                    Move_figure(active_figure);
                }
                else
                {
                    Move_figure(active_figure);
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