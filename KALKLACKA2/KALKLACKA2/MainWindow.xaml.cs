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

namespace KALKLACKA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double cislo1 = 0;
        double cislo2 = 0;
        string operace = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void klik0(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10);
                tb.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10);
                tb.Text = cislo2.ToString();
            }
        }

        private void carka(object sender, RoutedEventArgs e)
        {

        }

        private void pi(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 3.14;
                tb.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 3.14;
                tb.Text = cislo2.ToString();
            }
        }

        private void klik1(object sender, RoutedEventArgs e)
        {
           if (operace == "")
           {
            cislo1 = (cislo1 * 10) + 1;
            tb.Text = cislo1.ToString();
           }
           else
            {
                cislo2 = (cislo2 * 10) + 1;
                tb.Text = cislo2.ToString();
            }

        }

        private void klik2(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 2;
                tb.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 2;
                tb.Text = cislo2.ToString();
            }
        }

        private void klik3(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 3;
                tb.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 3;
                tb.Text = cislo2.ToString();
            }
        }

        private void klik4(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 4;
                tb.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 4;
                tb.Text = cislo2.ToString();
            }
        }

        private void klik5(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 5;
                tb.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 5;
                tb.Text = cislo2.ToString();
            }
        }

        private void klik6(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 6;
                tb.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 6;
                tb.Text = cislo2.ToString();
            }
        }

        private void klik7(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 7;
                tb.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 7;
                tb.Text = cislo2.ToString();
            }
        }

        private void klik8(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 8;
                tb.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 8;
                tb.Text = cislo2.ToString();
            }
        }

        private void klik9(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 9;
                tb.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 9;
                tb.Text = cislo2.ToString();
            }
        }

        private void celypryc(object sender, RoutedEventArgs e)
        {
            cislo1 = 0;
            cislo2 = 0;
            operace = "";
            tb.Text = "0";
        }

        private void jednopryc(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 / 10);
                tb.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 / 10);
                tb.Text = cislo2.ToString();
            }
        }

        private void krat(object sender, RoutedEventArgs e)
        {
            operace = "*";
            tb.Text = "0";
        }

        private void deleno(object sender, RoutedEventArgs e)
        {
            operace = "/";
            tb.Text = "0";
        }

        private void minus(object sender, RoutedEventArgs e)
        {
            operace = "-";
            tb.Text = "0";
        }

        private void plus(object sender, RoutedEventArgs e)
        {
            operace = "+";
            tb.Text = "0";
        }

        private void rovnase(object sender, RoutedEventArgs e)
        {
            switch (operace)
            {
                case "+":
                    tb.Text = (cislo1 + cislo2).ToString();
                    break;
                case "-":
                    tb.Text = (cislo1 - cislo2).ToString();
                    break;
                case "*":
                    tb.Text = (cislo1 * cislo2).ToString();
                    break;
                case "/":
                    tb.Text = (cislo1 / cislo2).ToString();
                    break;

            }
        }

        private void procento(object sender, RoutedEventArgs e)
        {

        }
        
        private void odmocnina(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * cislo1 * cislo1) + 0;
                tb.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * cislo2 * cislo2) + 0;
                tb.Text = cislo2.ToString();
            }
        }

        private void nadruhou(object sender, RoutedEventArgs e)
        {
            if (operace == "")
           {
            cislo1 = (cislo1 * cislo1) + 0;
            tb.Text = cislo1.ToString();
           }
           else
            {
                cislo2 = (cislo2 * cislo2) + 0;
                tb.Text = cislo2.ToString();
            }
        }

    }

}
