namespace Quick.Sort
{
    public class QuickSort
    {
        private readonly int[] _orgin;

        public int[] GetSorted
        {
            get { return _orgin; }
        }

        public QuickSort(int[] origin)
        {
            _orgin = origin;
            Sort(0, _orgin.Length - 1);
        }

        private void Sort(int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                var pivot = Partition(leftIndex, rightIndex);
                Sort(leftIndex, pivot - 1);
                Sort(pivot + 1, rightIndex);
            }
        }

        private int Partition(int leftIndex, int rightIndex)
        {
            var pivot = _orgin[rightIndex];
            var sortedIndex = leftIndex - 1;
            for (var i = leftIndex; i < rightIndex; i++)
            {
                if (_orgin[i] < pivot)
                {
                    Swap(ref _orgin[i], ref _orgin[++sortedIndex]);
                }
            }
            Swap(ref _orgin[sortedIndex + 1], ref _orgin[rightIndex]);
            return ++sortedIndex;
        }

        private void Swap(ref int first, ref int second)
        {
            first = first + second;
            second = first - second;
            first = first - second;
        }
    }
}
