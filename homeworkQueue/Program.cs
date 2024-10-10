namespace homeworkQueue;

class Program
{

}

public class Queue<T>
{
    private List<T> elements;

    public Queue()
    {
        elements = new List<T>();
    }

    public bool isEmpty()
    {
        return elements.Count == 0;
    }

    public void Enqueue(T item)
    {
        elements.Add(item);
    }

    public T Dequeue()
    {
        if (isEmpty())
        {
            Console.WriteLine("Queue is empty! You can't dequeue");
        }

        T frontItem = elements[0];
        elements.RemoveAt(0);

        return frontItem;
    }

    public T Peek()
    {
        if (isEmpty())
        {
            Console.WriteLine("Queue is empty");
        }

        T frontElement = elements[0];

        return frontElement;
    }

    public int Size()
    {
        return elements.Count;
    }
}