using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt6
{
    internal class Pair
    {
        /// <summary>
        /// Класс для пар чисел и операций сравнения и вычитания
        /// </summary>
        public int Pair1 { get; set; }
        public int Pair2 { get; set; }
        /// <summary>
        /// Метод для Проверки чисел первой пары на равенство
        /// </summary>
        /// <returns>Логическое значение "верно" или "неверно"</returns>
        /// 
        public Pair()
        {
            Pair1 = 0;
            Pair2 = 0;
        }
        /// <summary>
        /// Перегруженный оператор true/false для счетчика true
        /// </summary>
        /// <param name="para1">Объект класса из которого будут браться значения для сравнения</param>
        /// <returns>Логическое "Правда"</returns>
        public static bool operator true(Pair para1)
        {
            if (para1.Pair1 == para1.Pair2) return true;
            else return false;
        }
        /// <summary>
        /// Перегруженный оператор true/false для счетчика false
        /// </summary>
        /// <param name="para1">Объект класса из которого будут браться значения</param>
        /// <returns>Логическое "Неправда"</returns>
        public static bool operator false(Pair para1)
        {
            return para1.Pair1 != para1.Pair2;
        }
        /// <summary>
        /// Метод для нахождения произведния чисел в первой паре
        /// </summary>
        /// <returns>Произведение первого числа пары на второе</returns>
        public int Peremnozh()
        {
            return Pair1 * Pair2;
        }
        /// <summary>
        /// Перегруженный бинарный оператор "Вычитание" 
        /// </summary>
        /// <param name="para1">Первый объект класса(Первая пара чисел)</param>
        /// <param name="para2">Второй объект класса(Вторая пара чисел)</param>
        /// <returns>Новый объект класса со значениями</returns>
         public static Pair operator -(Pair para1,Pair para2)
        {
            Pair result = new Pair();
            result.Pair1 = para1.Pair1 - para2.Pair1;
            result.Pair2 = para1.Pair2 - para2.Pair2;
            return result;
        }
        /// <summary>
        /// Метод для вычитания трех пар чисел
        /// </summary>
        /// <param name="para2">Второй объект класса(Вторая пара чисел)</param>
        /// <param name="para3">Третий объект класса(Третья пара чисел)</param>
        /// <returns>Новый объект класса(новая пара чисел)</returns>
        public Pair Vichit(Pair para2,Pair para3)
        {
            Pair result = new Pair();
            result.Pair1 = Pair1 - para2.Pair1 - para3.Pair1;
            result.Pair2 = Pair2 - para2.Pair2 - para3.Pair2;
            return result;
        }
    }
}
