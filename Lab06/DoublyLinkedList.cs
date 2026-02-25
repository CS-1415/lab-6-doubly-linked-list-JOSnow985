namespace Lab06;

public class DoublyLinkedList<T> : IDoubleEndedCollection<T> 
{
    private DNode<T>? _head = null;
    private DNode<T>? _tail = null;
    public int Length { get; } = 0;
    public T First { get; }
    public T Last { get; }

    // TODO: implement the methods of the interface
    public void AddLast(T value)
    {
        
    }
    public void AddFirst(T value)
    {
        
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
