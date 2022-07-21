using System.Collections;

namespace DataStructure
{
    public class StackUsingLinkedList<T>: IEnumerable<T>
    {


        LinkedListNode<T> top;
        private int count { get; set; }


        public StackUsingLinkedList()
        {
            this.top = null;
            count = 0;
        }


        public bool IsEmpty()
        {
            return top == null;
        }


        public void Push(T item)
        {

            LinkedListNode<T> temp = new LinkedListNode<T>(item);


            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }


            temp.Data = item;


            temp.Next = top;


            top = temp;
            count++;
        }



        public void Pop()
        {

            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }


            top = (top).Next;
            count--;
        }

        public object Peek()
        {

            if (!IsEmpty())
            {
                return top.Data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            
        }

        public int Size()
        {
            return count;
           /* LinkedListNode<T> current = top;

            while (current.Next != null)
            {

                current = current.Next;
                ++count;
            }
            return count;*/
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> temp = top;
            Console.WriteLine("\nDisplay Items in the Stack");
            while (temp != null)
            {

                yield return temp.Data;
                temp = temp.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
