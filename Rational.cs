using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt6
{
    internal class Rational : Pair
    {
       public static Rational operator +(Rational para1,Rational para2)
        {
            Rational res = new Rational();
            res.Pair1 = para1.Pair1 * para2.Pair2 + para1.Pair2 * para2.Pair1;
            res.Pair2 = para1.Pair2 * para2.Pair2;
            return res;
       }

        public static Rational operator /(Rational para1,Rational para2)
        {
            Rational res = new Rational();
            res.Pair1 = para1.Pair1 * para2.Pair2;
            res.Pair2 = para1.Pair2 * para2.Pair1;
            return res;
        }

        public static Rational operator -(Rational para1,Rational para2)
        {
            Rational res = new Rational();
            res.Pair1 = para1.Pair1 * para2.Pair2 - para1.Pair2 * para2.Pair1;
            res.Pair2 = para1.Pair2 * para2.Pair2;
            return res;
        }
    }
}
