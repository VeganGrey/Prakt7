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
        Pair para = new Pair();
        Pair para2 = new Pair();
        Pair para3 = new Pair();
        Rational para4 = new Rational();
        Rational para5 = new Rational();
        Pair paranov = new Pair();
        Rational parano1 = new Rational();

        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void Proverka(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para.Pair1 = p1; para.Pair2 = p2;
            if (para) Itog.Text = "Числа равны";
            else Itog.Text = "Числа неравны";
        }

        private void Proizv(object sender, RoutedEventArgs e) //Проба
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para.Pair1 = p1; para.Pair2 = p2;
            Itog.Text = Convert.ToString(para.Peremnozh());
        }

        private void Вычитание2Пар(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para.Pair1 = p1; para.Pair2 = p2;
            Int32.TryParse(pair3.Text, out int p3); Int32.TryParse(pair4.Text, out int p4);
            para2.Pair1 = p3; para2.Pair2 = p4;
            paranov = para - para2;
            Itog.Text = Convert.ToString($"{paranov.Pair1};{paranov.Pair2}");
        }

        private void Вычитание3Пар(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para.Pair1 = p1; para.Pair2 = p2;
            Int32.TryParse(pair3.Text, out int p3); Int32.TryParse(pair4.Text, out int p4);
            para2.Pair1 = p3; para2.Pair2 = p4;
            Int32.TryParse(pair5.Text, out int p5); Int32.TryParse(pair6.Text, out int p6);
            para3.Pair1 = p5; para3.Pair2 = p6;
            paranov = para.Vichit(para2, para3);
            Itog.Text = $"{paranov.Pair1};{paranov.Pair2}";
        }

        private void Spravka(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Калитин Сергей ИСП-31, Вариант 13\n Задание:\n Использовать базовый класс Pair (пара целых чисел). Разработать операции)"+
                "определения равенства/неравенства чисел true/false. Разработать операции вычитания пар по формуле (а, b) - (с, d) = (а - c, b - d).");
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
            pair5.Clear();
            pair6.Clear();
        }

        private void Сложение(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para4.Pair1 = p1; para4.Pair2 = p2;
            Int32.TryParse(pair3.Text, out int p3); Int32.TryParse(pair4.Text, out int p4);
            para5.Pair1 = p3; para5.Pair2 = p4;
            parano1 = para4 + para5;
            Itog.Text = $"{parano1.Pair1};{parano1.Pair2}";
        }

        private void ВычитаниеНов(object sender,RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para4.Pair1 = p1; para4.Pair2 = p2;
            Int32.TryParse(pair3.Text, out int p3); Int32.TryParse(pair4.Text, out int p4);
            para5.Pair1 = p3; para5.Pair2 = p4;
            parano1 = para4 - para5;
            Itog.Text = $"{parano1.Pair1};{parano1.Pair2}";
        }

        private void Деление(object sender,RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para4.Pair1 = p1; para4.Pair2 = p2;
            Int32.TryParse(pair3.Text, out int p3); Int32.TryParse(pair4.Text, out int p4);
            para5.Pair1 = p3; para5.Pair2 = p4;
            parano1 = para4 / para5;
            Itog.Text = $"{parano1.Pair1};{parano1.Pair2}";
        }
    }
}

