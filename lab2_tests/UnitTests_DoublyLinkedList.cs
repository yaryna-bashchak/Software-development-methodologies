namespace lab2;

[TestFixture]
public class DoublyLinkedListTests
{
    [Test]
    public void Append_Get_Length()
    {
        var list = new DoublyLinkedList();
        list.append('a');
        list.append('b');
        list.append('c');
        list.append('d');
        list.append('e');

        Assert.AreEqual('a', list.head.value);
        Assert.AreEqual('e', list.tail.value);
        Assert.AreEqual(5, list.length());
        Assert.AreEqual('d', list.get(3));
    }

    [Test]
    public void Insert()
    {
        var list = new DoublyLinkedList();
        list.append('a');
        list.append('b');
        list.append('c');
        list.append('d');
        list.append('e');

        list.insert('T', 3);

        Assert.AreEqual(6, list.length());
        Assert.AreEqual('T', list.get(3));
        Assert.AreEqual('c', list.get(2));
        Assert.AreEqual('d', list.get(4));
    }

    [Test]
    public void Insert_IncorrectIndex()
    {
        var list = new DoublyLinkedList();
        list.append('a');
        list.append('b');
        list.append('c');
        list.append('d');
        list.append('e');

        Assert.Throws<ArgumentOutOfRangeException>(() => list.insert('T', -1));
    }

    [Test]
    public void Delete()
    {
        var list = new DoublyLinkedList();
        list.append('a');
        list.append('b');
        list.append('c');
        list.append('d');
        list.append('e');

        char deletedItem = list.delete(2);

        Assert.AreEqual(4, list.length());
        Assert.AreEqual('c', deletedItem);
        Assert.AreEqual('d', list.get(2));
        Assert.AreEqual('e', list.get(3));
    }

    [Test]
    public void Delete_IncorrectIndex()
    {
        var list = new DoublyLinkedList();
        list.append('a');
        list.append('b');
        list.append('c');
        list.append('d');
        list.append('e');

        Assert.Throws<ArgumentOutOfRangeException>(() => list.delete(5));
    }

    [Test]
    public void DeleteAll_SeveralMatches()
    {
        var list = new DoublyLinkedList();
        list.append('b');
        list.append('a');
        list.append('n');
        list.append('a');
        list.append('n');
        list.append('a');

        list.deleteAll('a');

        Assert.AreEqual(3, list.length());
        Assert.AreEqual('b', list.get(0));
        Assert.AreEqual('n', list.get(1));
        Assert.AreEqual('n', list.get(2));
    }

    [Test]
    public void Delete_NoMatches()
    {
        var list = new DoublyLinkedList();
        list.append('b');
        list.append('a');
        list.append('n');
        list.append('a');
        list.append('n');
        list.append('a');

        list.deleteAll('c');

        Assert.AreEqual(6, list.length());
        Assert.AreEqual('b', list.get(0));
        Assert.AreEqual('n', list.get(2));
        Assert.AreEqual('a', list.get(5));
    }

    [Test]
    public void Clone()
    {
        var list1 = new DoublyLinkedList();
        list1.append('b');
        list1.append('a');
        list1.append('n');
        list1.append('a');
        list1.append('n');
        list1.append('a');

        var list2 = list1.clone();
        list2.deleteAll('a');
        list2.append('!');

        Assert.AreEqual(6, list1.length());
        Assert.AreEqual(4, list2.length());
        Assert.AreEqual('b', list2.get(0));
        Assert.AreEqual('a', list1.get(1));
        Assert.AreEqual('n', list2.get(1));
        Assert.AreEqual('n', list2.get(2));
        Assert.AreEqual('!', list2.get(3));
    }

    [Test]
    public void Reverse()
    {
        var list = new DoublyLinkedList();
        list.append('h');
        list.append('e');
        list.append('l');
        list.append('l');
        list.append('o');

        list.reverse();

        Assert.AreEqual(5, list.length());
        Assert.AreEqual('o', list.head.value);
        Assert.AreEqual('h', list.tail.value);
        Assert.AreEqual('l', list.get(1));
        Assert.AreEqual('e', list.get(3));
    }

    [Test]
    public void FindFirstAndLast()
    {
        var list = new DoublyLinkedList();
        list.append('b');
        list.append('a');
        list.append('n');
        list.append('a');
        list.append('n');
        list.append('a');
        list.append('!');

        Assert.AreEqual(7, list.length());
        Assert.AreEqual(1, list.findFirst('a'));
        Assert.AreEqual(-1, list.findFirst('c'));
        Assert.AreEqual(5, list.findLast('a'));
        Assert.AreEqual(-1, list.findLast('c'));
    }

    [Test]
    public void Clear()
    {
        var list = new DoublyLinkedList();
        list.append('a');
        list.append('b');
        list.append('c');
        list.append('d');
        list.append('e');

        list.clear();

        Assert.AreEqual(0, list.length());
        Assert.AreEqual(null, list.head);
        Assert.AreEqual(null, list.tail);
    }

    [Test]
    public void Extend_TwoFullLists()
    {
        var list1 = new DoublyLinkedList();
        list1.append('h');
        list1.append('e');
        list1.append('l');
        list1.append('l');
        list1.append('o');

        var list2 = new DoublyLinkedList();
        list2.append(' ');
        list2.append('w');
        list2.append('o');
        list2.append('r');
        list2.append('l');
        list2.append('d');

        list1.extend(list2);

        Assert.AreEqual(11, list1.length());
        Assert.AreEqual('w', list1.get(6));
        Assert.AreEqual('d', list1.get(10));
        Assert.AreEqual('d', list1.tail.value);
    }

    [Test]
    public void Extend_EmptyList()
    {
        var list1 = new DoublyLinkedList();
        list1.append('h');
        list1.append('e');
        list1.append('l');
        list1.append('l');
        list1.append('o');

        var list2 = new DoublyLinkedList();
        var list3 = new DoublyLinkedList();

        var list_full = list1.clone();
        var list_empty = new DoublyLinkedList();

        list1.extend(list_empty); // Full + Empty
        list2.extend(list_full);  // Empty + Full
        list3.extend(list_empty); // Empty + Empty

        Assert.AreEqual(5, list1.length());
        Assert.AreEqual(5, list2.length());
        Assert.AreEqual(0, list3.length());
        Assert.AreEqual('h', list1.head.value);
        Assert.AreEqual('o', list1.tail.value);
        Assert.AreEqual('h', list2.head.value);
        Assert.AreEqual('o', list2.tail.value);
        Assert.AreEqual(null, list3.head);
        Assert.AreEqual(null, list3.tail);
    }
}
