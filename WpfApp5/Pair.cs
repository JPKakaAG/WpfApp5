using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class Pair
    {
        public int First { get; set; }
        public int Second { get; set; }

        /// <summary>
        /// Конструктор, принимающий значения для обоих чисел в паре
        /// </summary>
        /// <param name="first"> первое число</param>
        /// <param name="second"> второе число</param>

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }

        /// <summary>
        /// Метод для умножения пары на другую пару чисел
        /// </summary>
        /// <param name="other"> числа из второй пары</param>
        /// <returns>возвращает результат перемножения пар</returns>
        public Pair Multiply(Pair other)
        {
            int multipliedFirst = First * other.First;
            int multipliedSecond = Second * other.Second;
            return new Pair(multipliedFirst, multipliedSecond);
        }

        /// <summary>
        /// Метод для удвоения значений пары
        /// </summary>
        public void Double()
        {
            First *= 2;
            Second *= 2;
        }
    }
}
