using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2;
public class ListOfChars
{
    private char[] items;
    private int count;

    public ListOfChars()
    {
        items = new char[5];
        count = 0;
    }

    {

    public int length()
    {
        return count;
    }

    public void append(char item)
    {
        CheckLength();
        items[count] = item;
        count++;
    }

    private void CheckLength()
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }
    }
        {
        }

        {
        }
    }
}
