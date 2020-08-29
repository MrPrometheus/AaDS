namespace AlgorithmsDataStructuresLibrary.TypeOfSort132
{
    public class SortInt : ITypeSort<int>
    {
        public void Sort(ref int[] items, int item, int size)
        {
            int stopIndex = 0;
            for (int i = 0; i < size; i++)
            {
                if (items[i] < item) stopIndex = i + 1;
                else break;
            }

            for (int i = size; i > stopIndex; i--)
            {
                items[i] = items[i - 1];
            }
            
            items[stopIndex] = item;
        }
    }
}