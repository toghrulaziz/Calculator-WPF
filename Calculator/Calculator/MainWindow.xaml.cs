using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstNum = 0;
        string? operation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_num_Click(object sender, RoutedEventArgs e)
        {
            lbl_result.Content += (sender as Button)?.Content.ToString();
        }

        private void btn_ce_Click(object sender, RoutedEventArgs e)
        {
            lbl_result.Content = null;
        }

        private void btn_backspace_Click(object sender, RoutedEventArgs e)
        {
            if (lbl_result?.Content?.ToString()?.Length > 0)
            {
                lbl_result.Content = lbl_result?.Content?.ToString()?.Remove(lbl_result.Content.ToString().Length - 1, 1);
            }
        }

        private void btn_divide_Click(object sender, RoutedEventArgs e)
        {
            firstNum = Convert.ToDouble(lbl_result.Content);
            operation = "/";
            lbl_result.Content = "";
        }

        private void btn_multiplt_Click(object sender, RoutedEventArgs e)
        {
            firstNum = Convert.ToDouble(lbl_result.Content);
            operation = "*";
            lbl_result.Content = "";
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            firstNum = Convert.ToDouble(lbl_result.Content);
            operation = "-";
            lbl_result.Content = "";
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            firstNum = Convert.ToDouble(lbl_result.Content);
            operation = "+";
            lbl_result.Content = "";
        }

        private void btn_percent_Click(object sender, RoutedEventArgs e)
        {
            firstNum = Convert.ToDouble(lbl_result.Content);
            operation = "%";
            lbl_result.Content = "";
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            double secondNum, result;


            secondNum = Convert.ToDouble(lbl_result.Content);

            if (operation == "+")
            {
                result = firstNum + secondNum;
                lbl_result.Content = Convert.ToString(result);
                firstNum = result;
            }
            if (operation == "-")
            {
                result = firstNum - secondNum;
                lbl_result.Content = Convert.ToString(result);
                firstNum = result;
            }
            if (operation == "*")
            {
                result = firstNum * secondNum;
                lbl_result.Content = Convert.ToString(result);
                firstNum = result;
            }
            if (operation == "/")
            {
                result = firstNum / secondNum;
                lbl_result.Content = Convert.ToString(result);
                firstNum = result;
            }
            if (operation == "%")
            {
                result = firstNum * secondNum / 100;
                lbl_result.Content = Convert.ToString(result);
                firstNum = result;
            }
        }

        private void btn_square_Click(object sender, RoutedEventArgs e)
        {
            double num = Convert.ToDouble(lbl_result.Content);
            double square = Math.Pow(num,2);
            lbl_result.Content = Convert.ToString(square);
        }

        private void btn_onedivide_Click(object sender, RoutedEventArgs e)
        {
            double res;
            double num = Convert.ToDouble(lbl_result.Content);
            res = 1 / num;
            lbl_result.Content = Convert.ToString(res);
        }

        private void btn_squareroot_Click(object sender, RoutedEventArgs e)
        {
            double num = Convert.ToDouble(lbl_result.Content);
            double squareroot = Math.Sqrt(num);
            lbl_result.Content = Convert.ToString(squareroot);
        }

        private void btn_negativepositive_Click(object sender, RoutedEventArgs e)
        {
            double num = Convert.ToDouble(lbl_result.Content);
            double negative = -num;
            lbl_result.Content = Convert.ToString(negative);
        }

        private void btn_comma_Click(object sender, RoutedEventArgs e)
        {
            lbl_result.Content += ",";
        }
    }
}
