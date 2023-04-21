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
                int DD = Convert.ToInt32(TbNumberA.Text);
                int MM = Convert.ToInt32(TbNumberB.Text);
                switch (MM)
                {
                    case 1:
                        if (DD == 31)
                        {
                            DD = 1;
                            MM = 2;
                        }
                        else
                        {
                            ++DD;
                        }
                        break;
                    case 2:
                        if (DD == 28)
                        {
                            DD = 1;
                            MM = 3;
                        }
                        else if (DD == 29)
                        {
                            DD = 1;
                            MM = 3;
                        }
                        else
                        {
                            ++DD;
                        }
                        break;
                    case 3:
                        if (DD == 31)
                        {
                            DD = 1;
                            MM = 4;
                        }
                        else
                        {
                            ++DD;
                        }
                        break;
                    case 4:
                        if (DD == 30)
                        {
                            DD = 1;
                            MM = 5;
                        }
                        else
                        {
                            ++DD;
                        }
                        break;
                    case 5:
                        if (DD == 31)
                        {
                            DD = 1;
                            MM = 6;
                        }
                        else
                        {
                            ++DD;
                        }
                        break;
                    case 6:
                        if (DD == 30)
                        {
                            DD = 1;
                            MM = 7;
                        }
                        else
                        {
                            ++DD;
                        }
                        break;
                    case 7:
                        if (DD == 31)
                        {
                            DD = 1;
                            MM = 8;
                        }
                        else
                        {
                            ++DD;
                        }
                        break;
                    case 8:
                        if (DD == 31)
                        {
                            DD = 1;
                            MM = 9;
                        }
                        else
                        {
                            ++DD;
                        }
                        break;
                    case 9:
                        if (DD == 30)
                        {
                            DD = 1;
                            MM = 10;
                        }
                        else
                        {
                            ++DD;
                        }
                        break;
                    case 10:
                        if (DD == 31)
                        {
                            DD = 1;
                            MM = 11;
                        }
                        else
                        {
                            ++DD;
                        }
                        break;
                    case 11:
                        if (DD == 30)
                        {
                            DD = 1;
                            MM = 12;
                        }
                        else
                        {
                            ++DD;
                        }
                        break;
                    case 12:
                        if (DD == 31)
                        {
                            DD = 1;
                            MM = 1;
                        }
                        else
                        {
                            ++DD;
                        }
                        break;
                }


                TextBlockAnswer.Text = $"Следующая дата: {DD}.{MM}";
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
