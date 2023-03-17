using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2
{
    public class ListOfChars
    {
        private char[] items;

        public ListOfChars()
        {
            items = new char[];
        }

        public int length()
        {
            return items.Length;
        }
    }
}
