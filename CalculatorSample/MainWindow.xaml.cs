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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private enum Operation { PLUS,MINUS,MULIPLY,DIVIDE,NO_OP}
        private double input1,
                       input2,
                        result;
        private Operation operation;
        public MainWindow()
        {
            InitializeComponent(); //konstruktor suzdava obektite sprqmo xaml file-a opisanieto
            operation = Operation.NO_OP;
        }


        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TxtInputBox.Text, out input1))
            {
                TxtInputBox.Text = "0";
                switch ((string)((Button)sender).Content)
                {
                    case "+":
                        operation = Operation.PLUS;
                        break;
                    case "-":
                        operation = Operation.MINUS;
                        break;
                    case "*":
                        operation = Operation.MULIPLY;
                        break;
                    case "/":
                        operation = Operation.DIVIDE;
                        break;
                    default:
                        operation = Operation.NO_OP;
                        break;
                }
            }
            else
            {
                MessageBox.Show($"{TxtInputBox.Text} Wrong number input. Correct.");

            }
        }


        private void BtnOff_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0); // komanda za zatvarqne na i osvobojdavane na pametta
        }

   
        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TxtInputBox.Text, out input2))
            {
                switch (operation)
                {
                    case Operation.PLUS:
                        result = input1 + input2;
                        break;
                    case Operation.MINUS:
                        result = input1 - input2;
                        break;
                    case Operation.MULIPLY:
                        result = input1 * input2;
                        break;
                    case Operation.DIVIDE:
                        result = input1 / input2;
                        break;
                    case Operation.NO_OP:
                        break;
                        
                }                            
                TxtInputBox.Text = "" +result;
                operation = Operation.NO_OP;
            }
            else
            {
                MessageBox.Show($"{TxtInputBox.Text} Wrong number input. Correct.");

            }

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            string entry =(string) ((Button) sender).Content;
            if (TxtInputBox.Text == "0")
            {
                TxtInputBox.Text = entry;
            }
            else
            {
                if (TxtInputBox.Text.Contains(",") && entry == ",") return;
                {
                    TxtInputBox.Text += entry;
                }
                
            }
        }
    }
}
