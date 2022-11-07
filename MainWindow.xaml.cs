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

namespace Prakt6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rational para1 = new Rational();
        Rational para2 = new Rational();
        Rational parano1 = new Rational();

        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void Proverka(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para1.Pair1 = p1; para1.Pair2 = p2;
            if (para1) Itog.Text = "Числа равны";
            else Itog.Text = "Числа неравны";
        }
        private void Сложение(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para1.Pair1 = p1; para1.Pair2 = p2;
            Int32.TryParse(pair3.Text, out int p3); Int32.TryParse(pair4.Text, out int p4);
            para2.Pair1 = p3; para2.Pair2 = p4;
            parano1 = para1 + para2;
            Itog.Text = $"{parano1.Pair1};{parano1.Pair2}";
        }

        private void ВычитаниеНов(object sender,RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para1.Pair1 = p1; para1.Pair2 = p2;
            Int32.TryParse(pair3.Text, out int p3); Int32.TryParse(pair4.Text, out int p4);
            para1.Pair1 = p3; para2.Pair2 = p4;
            parano1 = para1 - para2;
            Itog.Text = $"{parano1.Pair1};{parano1.Pair2}";
        }

        private void Деление(object sender,RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para1.Pair1 = p1; para1.Pair2 = p2;
            Int32.TryParse(pair3.Text, out int p3); Int32.TryParse(pair4.Text, out int p4);
            para2.Pair1 = p3; para2.Pair2 = p4;
            parano1 = para1 / para2;
            Itog.Text = $"{parano1.Pair1};{parano1.Pair2}";
        }
        private void Spravka(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Калитин Сергей ИСП-31, Вариант 13\n Задание:\n Использовать базовый класс Pair (пара целых чисел). Создать производный класс Rational; определить новые операции сложения "+
                " (а, b) + (с, d) = (ad + be, bd) и деления (а, b)/ (с, d) = (ad, be); переопределить операцию вычитания (а, b) - (с, d) = (ad - be, bd).");
        }

        private void Quit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            Itog.Clear();
            pair1.Clear();
            pair2.Clear();
            pair3.Clear();
            pair4.Clear();
        }

    }
}

