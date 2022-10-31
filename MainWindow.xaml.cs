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
        Rational para = new Rational();
        Rational para2 = new Rational();
        Rational paranov = new Rational();

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
        }

        private void Сложение(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para.Pair1 = p1; para.Pair2 = p2;
            Int32.TryParse(pair3.Text, out int p3); Int32.TryParse(pair4.Text, out int p4);
            para2.Pair1 = p3; para2.Pair2 = p4;
            paranov = para + para2;
            Itog.Text = $"{paranov.Pair1};{paranov.Pair2}";
        }

        private void ВычитаниеНов(object sender,RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para.Pair1 = p1; para.Pair2 = p2;
            Int32.TryParse(pair3.Text, out int p3); Int32.TryParse(pair4.Text, out int p4);
            para2.Pair1 = p3; para2.Pair2 = p4;
            paranov = para - para2;
            Itog.Text = $"{paranov.Pair1};{paranov.Pair2}";
        }

        private void Деление(object sender,RoutedEventArgs e)
        {
            Int32.TryParse(pair1.Text, out int p1); Int32.TryParse(pair2.Text, out int p2);
            para.Pair1 = p1; para.Pair2 = p2;
            Int32.TryParse(pair3.Text, out int p3); Int32.TryParse(pair4.Text, out int p4);
            para2.Pair1 = p3; para2.Pair2 = p4;
            paranov = para / para2;
            Itog.Text = $"{paranov.Pair1};{paranov.Pair2}";
        }
    }
}

