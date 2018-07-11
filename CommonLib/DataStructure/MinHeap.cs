using System;
namespace CommonLib.DataStructure
{
    public class MinHeap : AbstractHeap
    {
        #region constructors
        public MinHeap() : base()
        {
        }
        #endregion

        #region internal methods
        public override void heapifyDown()
        {
            int index = 0;
            while (hasLeftChild(index))
            {
                int smallerChildIndex = getLeftChildIndex(index);
                if (hasRightChild(index) && rightChild(index) < leftChild(index))
                {
                    smallerChildIndex = getRightChildIndex(index);
                }

                if (Nodes[smallerChildIndex] < Nodes[index])
                    swap(index, smallerChildIndex);
                else
                    break;
                index = smallerChildIndex;
            }
        }
        public override void heapifyUp()
        {
            int index = Size - 1;

            while (hasParent(index) && parent(index) > Nodes[index])
            {
                swap(index, getParentIndex(index));
                index = getParentIndex(index);
            }
        }
        #endregion
    }
}
