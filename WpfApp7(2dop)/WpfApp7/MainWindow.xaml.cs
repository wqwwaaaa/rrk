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
        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int number = Convert.ToInt32(TbNumberA.Text);

                string description = "";

                int hundreds = number / 100;
                switch (hundreds)
                {
                    case 1: description += "сто "; break;
                    case 2: description += "двести "; break;
                    case 3: description += "триста "; break;
                    case 4: description += "четыреста "; break;
                    case 5: description += "пятьсот "; break;
                    case 6: description += "шестьсот "; break;
                    case 7: description += "семьсот "; break;
                    case 8: description += "восемьсот "; break;
                    case 9: description += "девятьсот "; break;
                }

                int tens = (number / 10) % 10;
                switch (tens)
                {
                    case 1:
                        switch (number % 100)
                        {
                            case 10: description += "десять "; break;
                            case 11: description += "одиннадцать "; break;
                            case 12: description += "двенадцать "; break;
                            case 13: description += "тринадцать "; break;
                            case 14: description += "четырнадцать "; break;
                            case 15: description += "пятнадцать "; break;
                            case 16: description += "шестнадцать "; break;
                            case 17: description += "семнадцать "; break;
                            case 18: description += "восемнадцать "; break;
                            case 19: description += "девятнадцать "; break;
                        }
                        break;

                    case 2: description += "двадцать "; break;
                    case 3: description += "тридцать "; break;
                    case 4: description += "сорок "; break;
                    case 5: description += "пятьдесят "; break;
                    case 6: description += "шестьдесят "; break;
                    case 7: description += "семьдесят "; break;
                    case 8: description += "восемьдесят "; break;
                    case 9: description += "девяносто "; break;
                }

                int ones = number % 10;
                if (tens != 1)
                {
                    switch (ones)
                    {
                        case 1: description += "один "; break;
                        case 2: description += "два "; break;
                        case 3: description += "три "; break;
                        case 4: description += "четыре "; break;
                        case 5: description += "пять "; break;
                        case 6: description += "шесть "; break;
                        case 7: description += "семь "; break;
                        case 8: description += "восемь "; break;
                        case 9: description += "девять "; break;
                    }
                }

                TextBlockAnswer.Text = description;
            }

            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
