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

namespace calc3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string outputValue = "";
        double temp = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent(); 
            Uri iconUri = new Uri("pack://siteoforigin:,,,/icon.ico"); this.Icon = BitmapFrame.Create(iconUri);
        }
        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            if(outputValue!= "")
            {
                temp = double.Parse(outputValue);
                Output.Text = "";
                outputValue = "";
            }
            operation = "plus";
        }
        private void BtnProcent_Click(object sender, RoutedEventArgs e)
        {
            if(outputValue!= "")
            {
                outputValue = (double.Parse(outputValue) / 100).ToString();
                Output.Text = outputValue;
            }
            
        }
        private void BtnModule_Click(object sender, RoutedEventArgs e)
        {
            if(outputValue!= "")
            {
                if (outputValue[0] == '-')
                {
                    outputValue = outputValue.Substring(1, outputValue.Length - 1);
                }
                else { outputValue = "-" + outputValue; }

                Output.Text = outputValue;
                
            }
            
        }
        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(outputValue))
            {
                double outputResult = 0;
                switch (operation)
                {
                    case "plus":
                        outputResult = temp + double.Parse(outputValue);
                        break;
                    case "minus":
                        outputResult = temp - double.Parse(outputValue);
                        break;
                    case "mult":
                        outputResult = temp * double.Parse(outputValue);
                        break;
                    case "div":
                        if (double.Parse(outputValue) == 0)
                        {
                            outputValue = "0";
                            MessageBox.Show("Error, dividing by 0", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                        }
                        else
                        {
                            outputResult = temp / double.Parse(outputValue);
                        }
                        break;
                    case "clear":
                        outputResult = 0;
                        outputValue = "";
                        break;
                    case "equal":
                        outputResult = double.Parse(outputValue);
                        break;
                  }
                operation = "equal";
                outputValue = outputResult.ToString();
                Output.Text = outputResult.ToString();
            }
            
        }
        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (outputValue != "")
            {
                temp = double.Parse(outputValue);
                Output.Text = "";
                outputValue = "";
            }
            operation = "minus";
        }
        private void BtnMult_Click(object sender, RoutedEventArgs e)
        {
            if (outputValue != "")
            {
                temp = double.Parse(outputValue);
                Output.Text = "";
                outputValue = "";
            }
            operation = "mult";
        }
        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (outputValue != "")
            {
                temp = double.Parse(outputValue);
                Output.Text = "";
                outputValue = "";
            }
            operation = "div";
        }
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            if (outputValue != "")
            {
                temp = double.Parse(outputValue);
                Output.Text = "";
                outputValue = "";
            }
            operation = "clear";
        }       
        private void BtnBackspace(object sender, RoutedEventArgs e)
        {
            if (outputValue != "")
            {
                
                    outputValue = outputValue.Substring(0, outputValue.Length - 1);
                    Output.Text = outputValue;
               
            }
            
        }
        private void BtnNum_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;
            switch (name)
            {
                case "Btn1":
                    outputValue += "1";
                    break;
                case "Btn2":
                    outputValue += "2";
                    break;
                case "Btn3":
                    outputValue += "3";
                    break;
                case "Btn4":
                    outputValue += "4";
                    break;
                case "Btn5":
                    outputValue += "5";
                    break;
                case "Btn6":
                    outputValue += "6";
                    break;
                case "Btn7":
                    outputValue += "7";
                    break;
                case "Btn8":
                    outputValue += "8";
                    break;
                case "Btn9":
                    outputValue += "9";
                    break;
                case "Btn0":
                    outputValue += "0";
                    break;
                case "BtnDot":
                    if (outputValue.Length > 0 && !outputValue.Contains(','))
                    {
                        outputValue += ",";
                    }
                    
                    break;
            }
            Output.Text = outputValue;

        }
    }
}
