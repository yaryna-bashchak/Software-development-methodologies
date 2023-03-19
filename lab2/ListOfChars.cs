using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2;
public class DoublyLinkedList
{
    private Node? head = null;
    private Node? tail = null;
    private int count { get; set; }

    public DoublyLinkedList()
    {
        count = 0;
    }

    public DoublyLinkedList(Node head, Node tail, int count)
    {
        this.head = head;
        this.tail = tail;
        this.count = count;
    }

    public void show()
    {
        Console.WriteLine(items);
    }

    public int length()
    {
        return count;
    }

    public void append(char item)
    {
        var node = new Node(item);

        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            node.prev = tail;
            tail = node;
        }

        count++;
    }

    private void CheckIndex(int index)
    {
        if (index < 0 || index > count)
        {
            throw new ArgumentOutOfRangeException("index");
        }
    }

    {
        {
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

    public char get(int index)
    {
        CheckIndex(index);
        return items[index];
    }

    public ListOfChars clone()
    {
        return new ListOfChars(items, count);
    }

    public void reverse()
    {
        int i = 0;
        int j = count - 1;

        while (i < j)
        {
            char temp = items[i];
            items[i] = items[j];
            items[j] = temp;

            i++;
            j--;
        }
    }

    public int findFirst(char item)
    {
        return Array.IndexOf(items, item);
    }

    public int findLast(char item)
    {
        return Array.LastIndexOf(items, item);
    }

    public void clear()
    {
        Array.Clear(items);
        count = 0;
    }

    public void extend(ListOfChars list)
    {
        var newArray = new char[count + list.items.Length];
        items.CopyTo(newArray, 0);
        list.items.CopyTo(newArray, count);

        items = newArray;
        count += list.count;
    }
}
