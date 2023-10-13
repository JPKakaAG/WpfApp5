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
using System.Text.RegularExpressions;

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

        private void btnExit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInfo_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил лучший разработчик: Девяткин Вадим Евгеньевич\r\nПрактическая №5\r\nСоздать класс Pair (пара четных чисел). Создать необходимые методы и свойства.Определить метод перемножения пар(а, b) * (с, d) = (а * c, b * d).Создать перегруженный метод для удвоения пары чисел.");
        }

        private void btnDa_click(object sender, RoutedEventArgs e)
        {
            string result1 = tbA.Text.Replace(" ", "");
            string result2 = tbB.Text.Replace(" ", "");
            if (int.TryParse(result1, out int A) && int.TryParse(result2, out int B))
            {
                string userInput1 = tbA.Text;
                string userInput2 = tbB.Text;
                string[] numbersArray1 = userInput1.Split(' ');
                string[] numbersArray2 = userInput2.Split(' ');

                if (numbersArray1.Length == 2 && numbersArray2.Length == 2)
                {
                    int.TryParse(numbersArray1[0], out int a);
                    int.TryParse(numbersArray1[1], out int b);
                    int.TryParse(numbersArray2[0], out int c);
                    int.TryParse(numbersArray2[1], out int d);

                    Pair pair1 = new Pair(a, b);
                    Pair pair2 = new Pair(c, d);
                    Pair multipliedPair = pair1.Multiply(pair2);
                    tbRes1.Text = ($"Перемножениe пар {a}*{c}, {b}*{d} = {multipliedPair.First}, {multipliedPair.Second}");

                    pair1.Double();
                    tbRes2.Text = ($"Удвоение первой(A) пары чисел ({pair1.First}, {pair1.Second})");
                }
                else
                {
                    MessageBox.Show("Введите по 2 числа через пробел например: 1 2");
                }
            }
            else
            {
                MessageBox.Show("Введите числа");
            }
        }
    }
}
