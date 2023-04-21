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

namespace WpfApp61
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
                int num = Convert.ToInt32(TbNumberA.Text);
                double val = Convert.ToDouble(TbNumberB.Text);
                double a, R1, R2, S;
                switch (num)
                {
                    case 1:
                        a = val;
                        R1 = a * Math.Sqrt(3) / 4;
                        R2 = 2 * R1;
                        S = a * a * Math.Sqrt(3) / 4;
                        TextBlockAnswer.Text = $"Радиус вписанной окружности: {R1}\nРадиус описанной окружности: {R2}\nПлощадь треугольника: {S}";
                        break;
                    case 2:
                        R1 = val;
                        a = 4 * R1 / Math.Sqrt(3);
                        R2 = 2 * R1;
                        S = a * a * Math.Sqrt(3) / 4;
                        TextBlockAnswer.Text = $"Сторона треугольника: {a}\nРадиус описанной окружности: {R2}\nПлощадь треугольника: {S}";
                        break;
                    case 3:
                        R2 = val;
                        R1 = R2 / 2;
                        a = 4 * R1 / Math.Sqrt(3);
                        S = a * a * Math.Sqrt(3) / 4;
                        Console.WriteLine($"Сторона треугольника: {a}");
                        Console.WriteLine($"Радиус вписанной окружности: {R1}");
                        Console.WriteLine($"Площадь треугольника: {S}");
                        TextBlockAnswer.Text = $"Сторона треугольника: {a}\nРадиус Bписанной окружности: {R1}\nПлощадь треугольника: {S}";
                        break;
                    case 4:
                        S = val;
                        a = Math.Sqrt(S * 4 / Math.Sqrt(3));
                        R1 = a * Math.Sqrt(3) / 4;
                        R2 = 2 * R1;
                        Console.WriteLine($"Сторона треугольника: {a}");
                        Console.WriteLine($"Радиус вписанной окружности: {R1}");
                        Console.WriteLine($"Радиус описанной окружности: {R2}");
                        TextBlockAnswer.Text = $"Сторона треугольника: {a}\nРадиус Bписанной окружности: {R1}\nРадиус описанной окружности: {R2}";
                        break;
                    default:
                        Console.WriteLine("Неверный номер элемента!");
                        break;
                }
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
