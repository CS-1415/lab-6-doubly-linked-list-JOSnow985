namespace Lab06;

public class DoublyLinkedList<T> : IDoubleEndedCollection<T> 
{
    private DNode<T>? _head = null;
    private DNode<T>? _tail = null;
    public int Length { get; private set; } = 0;
    // Throwing an exception if we try to get First or Last on an empty list, not sure if this is correct.
    public T First => _head == null ? default! : _head.Value;
    public T Last => _tail == null ? default! : _tail.Value;

    public void AddLast(T value)
    {
        DNode<T> newNode = new(value);

        // If our list is empty, newNode is now both head and tail
        if (Length == 0)
        {
            _head = newNode;
            _tail = newNode;
        }
        // Not empty, our previous tail's new next is newNode, newNode's previous is current tail, new tail is newNode
        else
        {
            _tail!.Next = newNode;      // If our list isn't empty, _tail shouldn't be null
            newNode.Previous = _tail;
            _tail = newNode;
        }
        Length++;
    }
    public void AddFirst(T value)
    {
        DNode<T> node = new(value);
        if (Length == 0)
        {
            _head = node;
            _tail = node;
        }
        else
        {
            _head!.Previous = node;
            node.Next = _head;
            _head = node;
        }
        Length++;
    }
    public void RemoveFirst()
    {
        
    }     
    public void RemoveLast()
    {

    }
              
    public void InsertAfter(DNode<T> node, T value)
    {

    }
    public void RemoveByValue(T value)
    {
        
    }
    public void ReverseList()
    {
        
    }
}
