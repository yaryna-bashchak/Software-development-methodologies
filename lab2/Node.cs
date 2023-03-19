using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab2;
public class Node
{
    public char value;
    public Node? prev = null;
    public Node? next = null;

    public Node (char item)
    {
        value = item;
    }
}
