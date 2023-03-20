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
}
