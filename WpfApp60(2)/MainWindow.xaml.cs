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

namespace WpfApp60
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
                int N = Convert.ToInt32(TbNumberA.Text);
                int M = Convert.ToInt32(TbNumberB.Text);

                string rankName = "";
                string suitName = "";

                switch (N)
                {
                    case 6:
                        rankName = "шестерка";
                        break;
                    case 7:
                        rankName = "семерка";
                        break;
                    case 8:
                        rankName = "восьмерка";
                        break;
                    case 9:
                        rankName = "девятка";
                        break;
                    case 10:
                        rankName = "десятка";
                        break;
                    case 11:
                        rankName = "валет";
                        break;
                    case 12:
                        rankName = "дама";
                        break;
                    case 13:
                        rankName = "король";
                        break;
                    case 14:
                        rankName = "туз";
                        break;
                }

                switch (M)
                {
                    case 1:
                        suitName = "пик";
                        break;
                    case 2:
                        suitName = "треф";
                        break;
                    case 3:
                        suitName = "бубен";
                        break;
                    case 4:
                        suitName = "червь";
                        break;
                }

                TextBlockAnswer.Text = $"{rankName} {suitName}";

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
