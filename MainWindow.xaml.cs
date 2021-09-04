﻿using System;
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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RowDefinition row = new RowDefinition();
            row.Height = new GridLength(1, GridUnitType.Star);
            //dobavit' stroku v matrix1
            Matrix1.RowDefinitions.Add(row);
            Matrix1.Height = Matrix1.Height + 40;

            for (int i = 0; i < Matrix1.ColumnDefinitions.Count; i++)
            {
                TextBox t1 = new TextBox();
                t1.Margin = new Thickness(2);

                Grid.SetRow(t1, Matrix1.RowDefinitions.Count - 1);
                Grid.SetColumn(t1, i);

                Matrix1.Children.Add(t1);

            }
            FillRandom(Matrix1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ColumnDefinition column = new ColumnDefinition();
            column.Width = new GridLength(1, GridUnitType.Star);
            //dobavit' stolbec v matrix1
            Matrix1.ColumnDefinitions.Add(column);
            Matrix1.Width = Matrix1.Width + 40;

            for (int i = 0; i < Matrix1.RowDefinitions.Count; i++)
            {
                TextBox t1 = new TextBox();
                t1.Margin = new Thickness(2);

                Grid.SetRow(t1, i);
                Grid.SetColumn(t1, Matrix1.ColumnDefinitions.Count - 1);

                Matrix1.Children.Add(t1);
            }

            FillRandom(Matrix1);

        }
        void FillRandom(Grid grid)
        {
            Random r = new Random();
            for (int i = 0; i < grid.Children.Count; i++)
            {
                UIElement e = grid.Children[i];
                if (e is TextBox)
                {
                    ((TextBox)e).Text = "" + r.Next(-50, 50);
                }
            }
        }

        int GetMatrixValue(Grid grid, int row, int column)
        {
            for (int i = 0; i < grid.Children.Count; i++)
            {
                UIElement e = grid.Children[i];
                if (Grid.GetRow(e) == row && Grid.GetColumn(e) == column) ;
                {
                    if (e is TextBox)
                    {
                        try
                        {
                            return int.Parse(((TextBox)e).Text);
                        }
                        catch (Exception ex) { return 0; }
                    }
                    return 0;
                }
            }
            return 0;
        }

        TextBox GetTextBox(Grid grid, int row, int column)
        {
            for (int i=0; i< grid.Children.Count; i++)
            {
                UIElement e = grid.Children[i];
                if (Grid.GetRow(e) == row && Grid.GetColumn(e) == column);
                {
                    if (e is TextBox)
                    {
                        return (TextBox)e;
                    }

                    return null;
                }
            }

            return null;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RowDefinition row = new RowDefinition();
            row.Height = new GridLength(1, GridUnitType.Star);
            //dobavit' stroku v matrix1
            Matrix2.RowDefinitions.Add(row);
            Matrix2.Height = Matrix2.Height + 40;

            for (int i = 0; i < Matrix2.ColumnDefinitions.Count; i++)
            {
                TextBox t1 = new TextBox();
                t1.Margin = new Thickness(2);

                Grid.SetRow(t1, Matrix2.RowDefinitions.Count - 1);
                Grid.SetColumn(t1, i);

                Matrix2.Children.Add(t1);

            }
            FillRandom(Matrix2);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ColumnDefinition column = new ColumnDefinition();
            column.Width = new GridLength(1, GridUnitType.Star);
            //dobavit' stolbec v matrix1
            Matrix2.ColumnDefinitions.Add(column);
            Matrix2.Width = Matrix2.Width + 40;

            for (int i = 0; i < Matrix2.RowDefinitions.Count; i++)
            {
                TextBox t1 = new TextBox();
                t1.Margin = new Thickness(2);

                Grid.SetRow(t1, i);
                Grid.SetColumn(t1, Matrix2.ColumnDefinitions.Count - 1);

                Matrix2.Children.Add(t1);
            }

            FillRandom(Matrix2);

        }

        void FillRandom1(Grid grid)
        {
            Random r = new Random();
            for (int i = 0; i < grid.Children.Count; i++)
            {
                UIElement e = grid.Children[i];
                if (e is TextBox)
                {
                    ((TextBox)e).Text = "" + r.Next(-50, 50);
                }
            }
        }

        int GetMatrix1Value(Grid grid, int row, int column)
        {
            for (int i = 0; i < grid.Children.Count; i++)
            {
                UIElement e = grid.Children[i];
                if (Grid.GetRow(e) == row && Grid.GetColumn(e) == column) ;
                {
                    if (e is TextBox)
                    {
                        try
                        {
                            return int.Parse(((TextBox)e).Text);
                        }
                        catch (Exception ex) { return 0; }
                    }
                    return 0;
                }
            }
            return 0;
        }

        TextBox GetTextBox1(Grid grid, int row, int column)
        {
            for (int i = 0; i < grid.Children.Count; i++)
            {
                UIElement e = grid.Children[i];
                if (Grid.GetRow(e) == row && Grid.GetColumn(e) == column) ;
                {
                    if (e is TextBox)
                    {
                        return (TextBox)e;
                    }

                    return null;
                }
            }

            return null;
        }
        private void AddRow(Grid m)
        {
            // Создать новую строку для Grid
            RowDefinition row = new RowDefinition();
            // Задать высоту строки 1*
            row.Height = new GridLength(1, GridUnitType.Star);
            // Добавить созданную строку в Grid
            m.RowDefinitions.Add(row);
            // Увеличить высоту Grid'а с учетом добавленной строки
            m.Height = m.Height + 40;
            // Циклом заполнить каждую ячейку новой строки текстовыми полями
            for (int i = 0; i < m.ColumnDefinitions.Count; i++)
            {
                TextBox t1 = new TextBox();
                t1.Margin = new Thickness(2);

                Grid.SetRow(t1, m.RowDefinitions.Count - 1);
                Grid.SetColumn(t1, i);

                m.Children.Add(t1);
            }
            FillRandom(m);
        }
        private void AddColumn(Grid m)
        {
            ColumnDefinition column = new ColumnDefinition();
            column.Width = new GridLength(1, GridUnitType.Star);
            // Добавить строку в матрицу 1

            m.ColumnDefinitions.Add(column);
            m.Width = m.Width + 40;

            for (int i = 0; i < m.RowDefinitions.Count; i++)
            {
                TextBox t1 = new TextBox();
                t1.Margin = new Thickness(2);

                Grid.SetRow(t1, i);
                Grid.SetColumn(t1, m.ColumnDefinitions.Count - 1);

                m.Children.Add(t1);
            }

            FillRandom(m);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (Matrix1.ColumnDefinitions.Count == Matrix2.ColumnDefinitions.Count &&
                Matrix1.RowDefinitions.Count == Matrix2.RowDefinitions.Count)
            {
                for (int row = 0; row < Matrix1.RowDefinitions.Count; row++)
                {
                    for (int column = 0; column < Matrix1.ColumnDefinitions.Count; column++)
                    {
                        TextBox textBox = GetTextBox(Matrix1, row, column);
                        if (textBox != null)
                        {
                            textBox.Text = "" +
                                (GetMatrixValue(Matrix1, row, column) + GetMatrixValue(Matrix2, row, column));
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Для сложения матриц необходимо, чтобы количество строк и стобцов совпадали");
            }
        }
    }
}      
        



