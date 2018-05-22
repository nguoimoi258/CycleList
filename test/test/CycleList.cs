using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

    public class CycleList<T>
    {
        private Node<T> currentNode = null;
        private static int lenght = 0;

        public void getAll()
        {
            for(int i = 0; i < lenght; i++)
            {
                Console.Write(currentNode.data + ", ");
                currentNode = currentNode.Next;
            }
        }

        public void AddNext(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = data;
            

            if (lenght == 0)
            {
                currentNode = newNode;
                currentNode.Next = currentNode;

            }
            else if(lenght == 1)
            {
                currentNode.Next = newNode;
                newNode.Next = currentNode;
                currentNode = newNode;
            }
            else 
            {
                Node<T> nextNode = currentNode.Next;
                currentNode.Next = newNode;
                newNode.Next = nextNode;
                currentNode = newNode;
            }

            lenght++;
        }

        // Remove next node of node which node.data = data
        public void RemoveNext(object data)
        {
            for(int i=0; i < lenght; i++)
            {
                Node<T> nextNode = currentNode.Next;

                if (currentNode.data.Equals(data))
                {
                    Node<T> nextNodeRemove = nextNode.Next;
                    currentNode.Next = nextNodeRemove;
                    currentNode = nextNodeRemove;
                    lenght--;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
        }
    }
}
