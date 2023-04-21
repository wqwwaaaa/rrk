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

namespace WpfApp8
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
                int a = Convert.ToInt32(TbNumberA.Text);
                int b = Convert.ToInt32(TbNumberB.Text);
                int nod = 0;
                switch (b)
                {
                    case 0:
                        nod = a;
                        break;
                    default:
                        while (b != 0)
                        {
                            int temp = b;
                            b = a % b;
                            a = temp;
                        }
                        nod = a;
                        break;
                }
                TextBlockAnswer.Text = $"НОД {a} и {b} равен: {nod}";
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
