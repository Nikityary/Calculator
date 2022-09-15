using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = new Button();
            string str = (string)((Button)e.OriginalSource).Content;
            switch (str) 
            {
                case "C":
            Label0.Content = "";
             break;

                case "=":
            string s = Label0.Content.ToString();
                    switch (str) 
                    {
                        case "+":
                    s = s.Remove(s.Length - 1);
                    Label0.Content = s;
                            break;
                        case "-":
                    s = s.Remove(s.Length - 1);
                    Label0.Content = s;
                            break;
                        case "/":
                    s = s.Remove(s.Length - 1);
                    Label0.Content = s;
                            break;
                        case "*":
                    s = s.Remove(s.Length - 1);
                    Label0.Content = s;
                            break;
                    }
                string value = new DataTable().Compute(Label0.Content.ToString(), null).ToString();
                    Label0.Content = value;
                    break;
                case "+":
                    Label0.Content += str;
                    break;
                case "-":
                    Label0.Content += str;
                    break;
                case "*":
                    Label0.Content += str;
                    break;
                case "/":
                    Label0.Content += str;
                    break;
                case "1":
                    Label0.Content += str;
                    break;
                case "2":
                    Label0.Content += str;
                    break;
                case "3":
                    Label0.Content += str;
                    break;
                case "4":
                    Label0.Content += str;
                    break;
                case "5":
                    Label0.Content += str;
                    break;
                case "6":
                    Label0.Content += str;
                    break;
                case "7":
                    Label0.Content += str;
                    break;
                case "8":
                    Label0.Content += str;
                    break;
                case "9":
                    Label0.Content += str;
                    break;
                case "0":
                    Label0.Content += str;
                    break;
            }

        }
    }
}
