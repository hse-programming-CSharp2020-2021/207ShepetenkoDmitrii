using System;

namespace Task4
{
    class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return $"{Data}";
        }
    }

    class LinkedKist 
    {
        Node head;
        Node tail;
        public int Count { get; set; }
        public void Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
                head = n;
            else
                tail.Next = n;
            tail = n;
            Count++;
        }
        public void AddFirst(int data)
        {
            Node node = new Node(data);
            node.Next = head;
            head = node;
            if (Count == 0)
                tail = head;
            Count++;
        }
        public void Clear()
        {
            Count = 0;
            head = null;
            tail = null;
        }
        public bool Contains(int data)
        {
            Node curr = head;
            while (curr != null)
            {
                if (curr.Data == data)
                    return true;
                else
                    curr = curr.Next;
            }
            return false;
        }
        public void Print()
        {
            Node curr = head;
            int i = 1;
            while (curr != null)
            {
                Console.WriteLine($"{i} - {curr.Data}");
                curr = curr.Next;
                i++;
            }
        }
        public Node Max()
        {
            if (head == null)
                return null;
            Node max = head;
            Node curr = head;
            while (curr != null)
            {
                if (curr.Data > max.Data)
                    max = curr;
                curr = curr.Next;
            }
            return max;
        }

        public Node Min()
        {
            if (head == null)
                return null;
            Node min = head;
            Node curr = head;
            while (curr != null)
            {
                if (curr.Data < min.Data)
                    min = curr;
                curr = curr.Next;
            }
            return min;
        }

        public Node Middle()
        {
            if (head == null)
                return null;
            int ind = Count / 2 + 1;
            int currind = 1;
            Node curr = head;
            while (curr != null) 
            {
                if (ind == currind)
                    return curr;
                curr = curr.Next;
                currind++;
            }
            // 1 2 3 4 5 6 7 -> 4
            // 1 2 3 4 5 6 -> 4
            return null;
        }

        public bool Remove(int data)
        {
            // 1 2 3 4 5 6 7 8 5, 5 -> 1 2 3 4 6 7 8 5
            // если список пуст, если список из 1 элемента, если удаляемый элемент стоит в середине, в конце, в начале
            if(Count==0)
                return false;
            if (head.Data == data)
            {
                head = head.Next;
                Count--;
                return true;
            }
            Node curr = head.Next;
            Node prev = head;
            while (curr != null)
            {
                if (curr.Data == data)
                {
                    if (curr == tail)
                    {                        
                        tail = prev;
                        prev.Next = null;
                        Count--;
                        return true;
                    }
                    else
                    {
                        prev.Next = curr.Next;
                        Count--;
                        return true;
                    }
                }
                prev = curr;
                curr = curr.Next;
            }
            return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            LinkedKist l = new LinkedKist();
            for(int i=0;i<9;i++)
                l.Add(i);            
            l.Remove(1);
            l.Print();
            Console.WriteLine(l.Middle());
        }
    }
}
