using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace App2
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        double num1, num2;
        public void addNum(int a)
        {
            if (expression.Text.Count() == 1 && expression.Text == 0.ToString())
                expression.Text = a.ToString();
            else
                expression.Text = (expression.Text + a).ToString();
        }
        private void one_Click(object sender, RoutedEventArgs e)
        {
            addNum(1);
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            addNum(2);
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            addNum(3);
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            addNum(4);
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            addNum(5);
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            addNum(6);
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            addNum(7);
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            addNum(8);
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            addNum(9);
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            addNum(0);
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            if (expression.Text.Count() > 1)
                expression.Text = expression.Text.Remove(expression.Text.Count() - 1);
            else
                expression.Text = 0.ToString();
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            expression.Text = expression.Text + '.';
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            num1 =Convert.ToDouble( expression.Text);
            expression.Text = "0";
            Input.Text = num1.ToString() + '+';
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            expression.Text = "0";
        }

        private void clearAll_Click(object sender, RoutedEventArgs e)
        {
            expression.Text = "0";
            num1 = 0;
        }

        private void record_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1));
        }

        private void count_Click(object sender, RoutedEventArgs e)
        {
            num2 = Convert.ToDouble(expression.Text);
            expression.Text = (num1 + num2).ToString();
            Input.Text = "";

        }
    }
}
