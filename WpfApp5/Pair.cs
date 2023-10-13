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

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }

        public Pair Multiply(Pair other)
        {
            int multipliedFirst = First * other.First;
            int multipliedSecond = Second * other.Second;
            return new Pair(multipliedFirst, multipliedSecond);
        }

        public void Double()
        {
            First *= 2;
            Second *= 2;
        }
    }
}
