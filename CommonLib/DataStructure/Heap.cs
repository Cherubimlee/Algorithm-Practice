using System;
using System.Collections;

namespace CommonLib.DataStructure
{
    public abstract class AbstractHeap
    {
        #region internal properties
        private int Capacity { get; set; }
        public int Size { get; internal set; }
        internal int[] Nodes { get; set; }
        #endregion

        #region constructors
        public AbstractHeap()
        {
            Capacity = 100;
            Size = 0;
            Nodes = new int[Capacity];
        }
        #endregion

        #region helperMethods
        internal void EnlargeIfNeeded()
        {
            if (Size == Capacity)
            {
                Capacity = 2 * Capacity;
                Array.Copy(Nodes, Nodes, Capacity);
            }
        }

        internal int getLeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }

        internal bool hasLeftChild(int parentIndex)
        {
            return getLeftChildIndex(parentIndex) < Size;
        }

        internal int leftChild(int index)
        {
            return Nodes[getLeftChildIndex(index)];
        }

        public int getRightChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 2;
        }

        internal bool hasRightChild(int parentIndex)
        {
            return getRightChildIndex(parentIndex) < Size;
        }

        internal int rightChild(int index)
        {
            return Nodes[getRightChildIndex(index)];
        }

        internal int getParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        internal bool hasParent(int childIndex)
        {
            return getParentIndex(childIndex) >= 0;
        }

        internal int parent(int index)
        {
            return Nodes[getParentIndex(index)];
        }

        internal void swap(int index1, int index2)
        {
            int temp = Nodes[index1];
            Nodes[index1] = Nodes[index2];
            Nodes[index2] = temp;
        }

        #endregion

        #region available public methods

        /// <summary>
        /// Gets the minimum element at the root of the tree
        /// </summary>
        /// <returns>Int value of minimum element</returns>
        /// <exception cref="">InvalidOperationException when heap is empty</exception>
        public int peek()
        {
            if (Size == 0)
                throw new InvalidOperationException("Heap is empty");

            return Nodes[0];
        }

        /// <summary>
        /// Removes the minimum element at the root of the tree
        /// </summary>
        /// <returns>Int value of minimum element</returns>
        /// <exception cref="">InvalidOperationException when heap is empty</exception>
        public int pop()
        {
            if (Size == 0)
                throw new InvalidOperationException("Heap is empty");

            int item = Nodes[0];
            Nodes[0] = Nodes[Size - 1];
            Size--;
            heapifyDown();
            return item;
        }

        /// <summary>
        /// Add a new item to heap, enlarging the array if needed
        /// </summary>
        /// <returns>void</returns>
        public void add(int item)
        {
            EnlargeIfNeeded();
            Nodes[Size] = item;
            Size++;
            heapifyUp();
        }

        public System.Collections.Generic.IEnumerable<int> GetEnumerable()
        {
            for (int i = 0; i < Size; i++)
                yield return Nodes[i];
        }

        #endregion

        #region abstract methods
        public abstract void heapifyUp();
        public abstract void heapifyDown();
        #endregion
    }
}
