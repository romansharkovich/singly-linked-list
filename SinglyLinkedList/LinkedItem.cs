namespace SinglyLinkedList
{
    /// <summary>
    /// A class that describes an item in a linked list.
    /// </summary>
    /// <typeparam name="T"> type </typeparam>
    public class LinkedItem<T>
    {
        /// <summary>
        /// Saved list data
        /// </summary>
        public T ListData { get; set; }

        /// <summary>
        /// next item of linked list
        /// </summary>
        public LinkedItem<T> Next { get; set; }

        /// <summary>
        /// Creating new instance of linked list
        /// </summary>
        /// <param name="data"> saved data </param>
        public LinkedItem(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            ListData = data;
        }

        /// <summary>
        /// Convert object to string
        /// </summary>
        /// <returns> Saved data </returns>
        public override string ToString()
        {
            return ListData.ToString();
        }
    }
}
