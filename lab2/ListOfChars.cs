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

    private void CheckIndex(int index)
    {
        if (index < 0 || index > count - 1)
        {
            throw new ArgumentOutOfRangeException("index");
        }
    }

    private void CheckLength()
    {
        if (count == items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }
    }

    public void insert(char item, int index)
    {
        CheckIndex(index);
        CheckLength();

        for (int i = count; i > index; i--)
        {
            items[i] = items[i - 1];
        }

        items[index] = item;
        count++;
    }

    public char delete(int index)
    {
        CheckIndex(index);
        char deletedItem = items[index];
        count--;

        for (int i = index; i < count; i++)
        {
            items[i] = items[i + 1];
        }

        items[count] = ' ';
        return deletedItem;
    }

    public void deleteAll(char item)
    {
        for (int i = count - 1; i >= 0; i--)
        {
            if (items[i] == item)
            {
                delete(i);
            }
        } 
    }
}
