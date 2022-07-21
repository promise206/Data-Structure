using DataStructure;

DataStructure.LinkedList<int> llist = new DataStructure.LinkedList<int>();
llist.AddToTail(2);
llist.AddToTail(6);
llist.AddToTail(3);
llist.AddToTail(4);
Console.WriteLine("List Size: " + llist.AddToTail(12));

Console.WriteLine("Item Index: " + llist.ItemIndex(llist.head, 2));

foreach(int i in llist)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n*****************************************************************");


StackUsingLinkedList<int> stack = new StackUsingLinkedList<int>();
stack.Push(4);
stack.Push(50);
stack.Push(100);
stack.Push(200);

stack.Pop();
//int size = stack.Size();
Console.WriteLine("Size of Stack: " + stack.Count());

foreach (int i in stack)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n*****************************************************************");

QueueUsingLinkedList<int> queue = new QueueUsingLinkedList<int>();
queue.enqueue(1);
queue.enqueue(90);
queue.enqueue(30);
queue.enqueue(40);
queue.enqueue(55);

queue.dequeue();

Console.WriteLine("Front: " + queue.front.Data);

Console.WriteLine("Size of Queue: "+queue.Size());

foreach (int i in queue)
{
    Console.WriteLine(i);
}



