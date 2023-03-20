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

}
