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

namespace WpfApp5
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

                string description = ""; // строка-описание, которую нужно вывести

                switch (number)
                {
                    case 10:
                        description = "десять учебных заданий";
                        break;
                    case 11:
                        description = "одинадцать учебных заданий";
                        break;
                    case 12:
                        description = "двенадцать учебных заданий";
                        break;
                    case 13:
                        description = "тринадцать учебных заданий";
                        break;
                    case 14:
                        description = "четырнадцать учебных заданий";
                        break;
                    case 15:
                        description = "пятнадцать учебных заданий";
                        break;
                    case 16:
                        description = "шестнадцать учебных заданий";
                        break;
                    case 17:
                        description = "семнадцать учебных заданий";
                        break;
                    case 18:
                        description = "восемнадцать учебных заданий";
                        break;
                    case 19:
                        description = "девятнадцать учебных заданий";
                        break;
                    case 20:
                        description = "двадцать учебных заданий";
                        break;
                    case 21:
                        description = "двадцать одно учебное задание";
                        break;
                    case 22:
                        description = "двадцать два учебных задания";
                        break;
                    case 23:
                        description = "двадцать три учебных задания";
                        break;
                    case 24:
                        description = "двадцать четыре учебных задания";
                        break;
                    case 25:
                        description = "двадцать пять учебных заданий";
                        break;
                    case 26:
                        description = "двадцать шесть учебных заданий";
                        break;
                    case 27:
                        description = "двадцать семь учебных заданий";
                        break;
                    case 28:
                        description = "двадцать восемь учебных заданий";
                        break;
                    case 29:
                        description = "двадцать девять учебных заданий";
                        break;
                    case 30:
                        description = "тридцать учебных заданий";
                        break;
                    case 31:
                        description = "тридцать одно учебное задание";
                        break;
                    case 32:
                        description = "тридцать два учебных задания";
                        break;
                    case 33:
                        description = "тридцать три учебных задания";
                        break;
                    case 34:
                        description = "тридцать четыре учебных задания";
                        break;
                    case 35:
                        description = "тридцать пять учебных заданий";
                        break;
                    case 36:
                        description = "тридцать шесть учебных заданий";
                        break;
                    case 37:
                        description = "тридцать семь учебных заданий";
                        break;
                    case 38:
                        description = "тридцать восемь учебных заданий";
                        break;
                    case 39:
                        description = "тридцать девять учебных заданий";
                        break;
                    case 40:
                        description = "сорок учебных заданий";
                        break;
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
