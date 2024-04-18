namespace Collections
{
    public class MyLinkedList
    {
        public Node Head;


        public void AddLast(int value)
        {
            if (Head != null)
            {
                Node temp = new Node();
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Data = value;

                Console.WriteLine("next elave olundu");
            }
            else
            {
                Head = new Node();
                Head.Data = value;
                Console.WriteLine("Head yarandi");
            }
        }

    }
}
