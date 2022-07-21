using System.Collections;

namespace DataStructure
{
    public class LinkedList<T>: IEnumerable<T>
    {
        public LinkedListNode<T> head = null;
        private int count { get; set; }

        public int AddToTail(T new_data)
        {

            LinkedListNode<T> new_node = new LinkedListNode<T>(new_data);
            if (head == null)
            {
                head = new LinkedListNode<T>(new_data);
                head.Next = null;
            }
            else
            {
                LinkedListNode<T> current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }


                current.Next = new_node;
                new_node.Next = null;
                
            }
            return ++count;
        }

        public void DeleteNode(T key)
        {

            LinkedListNode<T> temp = head;
            LinkedListNode<T> prev = null;


            if (temp != null && temp.Data.Equals(key))
            {

                head = temp.Next;
                return;
            }


            while (temp != null && temp.Data.Equals(key))
            {
                prev = temp;
                temp = temp.Next;
            }


            if (temp == null)
                return;


            prev.Next = temp.Next;
            --count;
        }

        public bool Check(LinkedListNode<T> head, T item)
        {

            LinkedListNode<T> current = head;
            while (current != null)
            {
                if (item.Equals(current.Data))
                {

                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public int ItemIndex(LinkedListNode<T> head, T item)
        {
            int count = 1;

            LinkedListNode<T> current = head;
            while (current != null)
            {

                if (item.Equals(current.Data))
                {

                    return count;
                }
                count++;
                current = current.Next;
            }

            return -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> tempNode = head;
            Console.WriteLine("\nDisplay Linked List");
            while (tempNode != null)
            {

                yield return tempNode.Data;
                tempNode = tempNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
