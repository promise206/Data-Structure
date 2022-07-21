using System.Collections;

namespace DataStructure
{
    class QueueUsingLinkedList<T>: IEnumerable<T>
    {
        public LinkedListNode<T> front;
        public LinkedListNode<T> rear;
        private int count { get; set; }

        public QueueUsingLinkedList()
        {
            this.front = null;
            this.rear = null;
            count = 0;
        }
        

        public bool IsEmpty()
        {
            return this.front == null;
        }


        public void enqueue(T key)
        {


            LinkedListNode<T> temp = new LinkedListNode<T>(key);


            if (this.rear == null)
            {
                this.front = temp;
                this.rear = temp;
                count++;
                return;
            }


            this.rear.Next = temp;
            this.rear = temp;
            count++;

        }


        public void dequeue()
        {

            if (IsEmpty())
            {
                return;
            }


            LinkedListNode<T> temp = this.front;
            this.front = this.front.Next;
            count--;


            if (this.front == null)
                this.rear = null;

            
        }

        public int Size()
        {
            return count;
      
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> temp = front;
            Console.WriteLine("\nDisplay Items in the Queue");
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
