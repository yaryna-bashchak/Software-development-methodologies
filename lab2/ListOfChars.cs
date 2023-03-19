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

    public DoublyLinkedList(DoublyLinkedList list)
    {
        var current = list.head;

        while (current != null)
        {
            this.append(current.value);
            current = current.next;
        }
    }

    public void show()
    {
        var current = head;

        while (current != null)
        {
            Console.Write(current.value);
            current = current.next;
        }

        Console.WriteLine();
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

    public void insert(char item, int index)
    {
        CheckIndex(index);
        var node = new Node(item);
        
        if (index == 0)
        {
            node.next = head;
            head.prev = node;
            head = node;
        }
        else if (index == count)
        {
            append(item);
        }
        else
        {
            var current = head;

            for (int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }

            node.prev = current;
            node.next = current.next;
            current.next.prev = node;
            current.next = node;
        }

        count++;
    }

    public char delete(int index)
    {
        CheckIndex(index);

        char deletedItem;

        if (count == 1)
        {
            deletedItem = head.value;
            head = null;
            tail = null;
        }
        else if (index == 0)
        {
            deletedItem = head.value;
            head = head.next;
            head.prev = null;
        }
        else if (index == count - 1)
        {
            deletedItem = tail.value;
            tail = tail.prev;
            tail.next = null;
        }
        else
        {
            var current = head;

            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }

            deletedItem = current.value;
            current.prev.next = current.next;
            current.next.prev = current.prev;
        }

        count--;
        return deletedItem;
    }

    public void deleteAll(char item)
    {
        var current = head;

        while (current != null)
        {
            if (current.value == item)
            {
                if (current == head)
                {
                    head = head.next;
                    if (head != null)
                    {
                        head.prev = null;
                    }
                }
                else if (current == tail)
                {
                    tail = tail.prev;
                    if (tail != null)
                    {
                        tail.next = null;
                    }
                }
                else
                {
                    current.prev.next = current.next;
                    current.next.prev = current.prev;
                }

                count--;
            }

            current = current.next;
        }
    }

    public char get(int index)
    {
        CheckIndex(index);
        var current = head;

        for (int i = 0; i < index; i++)
        {
            current = current.next;
        }

        return current.value;
    }

    public DoublyLinkedList clone()
    {
        return new DoublyLinkedList(this);
    }

    public void reverse()
    {
        Node? temp = null;
        var current = head;
        tail = head;

        while (current != null)
        {
            temp = current.prev;
            current.prev = current.next;
            current.next = temp;
            current = current.prev;
        }

        if (temp != null)
        {
            head = temp.prev;
        }
    }

    public int findFirst(char item)
    {
        var current = head;
        int index = 0;

        while (current != null)
        {
            if (current.value == item)
            {
                return index;
            }

            current = current.next;
            index++;
        }

        return -1;
    }

    public int findLast(char item)
    {
        var current = tail;
        int index = count - 1;

        while (current != null)
        {
            if (current.value == item)
            {
                return index;
            }

            current = current.prev;
            index--;
        }

        return -1;
    }

    public void clear()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void extend(DoublyLinkedList list)
    {
        if (list.count == 0)
        {
            return;
        }

        if (this.count == 0)
        {
            this.head = list.head;
            this.tail = list.tail;
            this.count = list.count;
            return;
        }

        this.tail.next = list.head;
        list.head.prev = this.tail;
        this.tail = list.tail;
        this.count += list.count;
    }
}
