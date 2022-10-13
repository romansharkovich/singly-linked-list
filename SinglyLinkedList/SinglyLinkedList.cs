using System.Collections;

namespace SinglyLinkedList
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// 1st head element of linked list
        /// </summary>
        private LinkedItem<T> _head = null;

        /// <summary>
        /// last tail element of the linked list
        /// </summary>
        private LinkedItem<T> _tail = null;

        /// <summary>
        /// counter of number of items in list
        /// </summary>
        private int _count = 0;

        /// <summary>
        /// number of list items
        /// </summary>
        public int Count
        {
            get => _count;
        }

        /// <summary>
        /// Add data to linked list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            // Create new intem of single linked list
            var item = new LinkedItem<T>(data);

            // If single linked lis is empty add element to begin,
            // else this element will add as next to nearest element.
            if (_head == null)
            {
                _head = item;
            }
            else
            {
                _tail.Next = item;
            }

            // Setup element as the last
            _tail = item;

            // Increment counter
            _count++;
        }

        /// <summary>
        /// Delete data from linked list
        /// </summary>
        /// <param name="data"> data to delete </param>
        public void Delete(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            // The currently viewed list item.
            var current = _head;

            // The previous element in the list, before viewed item.
            LinkedItem<T> previous = null;

            while (current != null)
            {
                if (current.ListData.Equals(data)) {
                    if (previous != null) {
                        previous.Next = current.Next;

                        if (current.Next == null)
                            _tail = previous;
                    } else {                        
                        _head = _head.Next;

                        if (_head == null)
                            _tail = null;
                    }

                    _count--;
                    break;
                }

                previous = current;
                current = current.Next;
            }
        }

        /// <summary>
        /// Clear linked list
        /// </summary>
        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        /// <summary>
        /// Return enumerator which iterates all elements
        /// </summary>
        /// <returns> An enumerator that can be used to iterate over the collection. </returns>
        public IEnumerator<T> GetEnumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.ListData;
                current = current.Next;
            }
        }

        /// <summary>
        /// Return an enumerator that has iterated through the linked list.
        /// </summary>
        /// <returns> IEnumerator object </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
