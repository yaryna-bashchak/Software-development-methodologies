namespace lab2;

public static class Program
{
    static void Main(string[] args)
    {
        var list = new ListOfChars();
        list.append('H');
        list.append('i');
        list.append('!');
        list.append('!');
        list.append('!');

        Console.Write("list1: ");
        list.show(); // output: Hi!!!
        Console.WriteLine(list.length()); // output: 5

        list.delete(1);
        list.insert('e', 1);
        list.insert('l', 2);
        list.insert(list.get(2), 3);
        list.insert('o', 4);

        Console.Write("list1: ");
        list.show(); // output: Hello!!!
        Console.WriteLine(list.length()); // output: 8

        var list2 = list.clone();
        list.deleteAll('!');

        Console.Write("list1: ");
        list.show(); // output: Hello
        Console.Write("list2: ");
        list2.show(); // output: Hello!!!

        list2.clear();
        list2.append('d');
        list2.append('l');
        list2.append('r');
        list2.append('o');
        list2.append('w');
        list2.append(' ');

        Console.Write("list2: ");
        list2.show(); // output:  dlrow
        list2.reverse();
        Console.Write("list2: ");
        list2.show(); // output: world 

        list.extend(list2);
        list.append('!');
        
        Console.Write("list1: ");
        list.show(); // output: Hello world!

        Console.WriteLine(list.findFirst('l')); // output: 2
        Console.WriteLine(list.findLast('l')); // output: 9
    }
}
