using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt6
{
    internal class Rational : Pair
    {
        /// <summary>
        /// Перегруженный оператор для сложения двух пар чисел
        /// </summary>
        /// <param name="para1">Первый объект класса для сложения</param>
        /// <param name="para2">Второй объект класса для сложения</param>
        /// <returns>Возвращаемый объект с новыми занчениями </returns>
        public static Rational operator +(Rational para1,Rational para2)
        {
            Rational res = new Rational();
            res.Pair1 = para1.Pair1 * para2.Pair2 + para1.Pair2 * para2.Pair1;
            res.Pair2 = para1.Pair2 * para2.Pair2;
            return res;
       }
        /// <summary>
        /// Перегруженный оператор деления двух пар чисел 
        /// </summary>
        /// <param name="para1">Первый объект класса для деления</param>
        /// <param name="para2">Второй объект класса для деления</param>
        /// <returns>Возвращаемый объект класса с новыми значениями</returns>
        public static Rational operator /(Rational para1,Rational para2)
        {
            Rational res = new Rational();
            res.Pair1 = para1.Pair1 * para2.Pair2;
            res.Pair2 = para1.Pair2 * para2.Pair1;
            return res;
        }
        /// <summary>
        /// Перегруженный оператор вычитания двух пар чисел 
        /// </summary>
        /// <param name="para1">Первый объект класса для вычитания</param>
        /// <param name="para2">Второй объект класса для вычитания</param>
        /// <returns></returns>
        public static Rational operator -(Rational para1,Rational para2)
        {
            Rational res = new Rational();
            res.Pair1 = para1.Pair1 * para2.Pair2 - para1.Pair2 * para2.Pair1;
            res.Pair2 = para1.Pair2 * para2.Pair2;
            return res;
        }
    }
}
