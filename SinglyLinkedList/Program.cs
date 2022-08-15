namespace SinglyLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // creating single linked list obj
            var list = new SinglyLinkedList<int>();

            // Adding elements
            list.Add(42);
            list.Add(1);
            list.Add(17);
            list.Add(5);
            list.Add(-69);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            list.Delete(17);

            // after
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}