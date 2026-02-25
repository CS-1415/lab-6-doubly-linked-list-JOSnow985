namespace Lab06.Tests;

public class OneAtFrontTests
{
    DoublyLinkedList<int> testList;
    
    // Initializes a list with one item added to the front
    [SetUp]
    public void Setup()
    {
        testList = new();
        testList.AddFirst(42);
    }

    [Test]
    public void SingleAddLastTest()
    {
        testList.AddLast(6);
        Assert.Multiple(() =>
        {
            Assert.That(testList.Length, Is.EqualTo(2));
            Assert.That(testList.First, Is.EqualTo(42));
            Assert.That(testList.Last, Is.EqualTo(6));
        });
    }
    [Test]
    public void SingleAddFirstTest()
    {
        testList.AddFirst(32);
        Assert.Multiple(() =>
        {
            Assert.That(testList.Length, Is.EqualTo(2));
            Assert.That(testList.First, Is.EqualTo(32));
            Assert.That(testList.Last, Is.EqualTo(42));
        });
    }
    [Test]
    public void SingleRemoveLastTest()
    {
        testList.RemoveLast();
        Assert.Multiple(() =>
        {
            Assert.That(testList.Length, Is.EqualTo(0));
            Assert.That(testList.First, Is.EqualTo(null));
            Assert.That(testList.Last, Is.EqualTo(null));
        });
    }
    [Test]
    public void SingleRemoveFirstTest()
    {
        testList.RemoveFirst();
        Assert.Multiple(() =>
        {
            Assert.That(testList.Length, Is.EqualTo(0));
            Assert.That(testList.First, Is.EqualTo(null));
            Assert.That(testList.Last, Is.EqualTo(null));
        });
    }
}