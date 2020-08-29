namespace AlgorithmsDataStructuresLibrary.TypeOfSort132
{
    public class SortString : ITypeSort<string>
    {
        public void Sort(ref string[] items, string item, int size)
        {
            int stopIndex = 0;
            for (int i = 0; i < size; i++)
            {
                int minLength = items[i].Length < item.Length ? items[i].Length : item.Length;

                for (int j = 0; j < minLength; j++)
                {
                    if (items[i][j] <= item[j])
                    {
                        if(item.Length >= items[i].Length)
                        {
                            stopIndex = i + 1;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
            for (int i = size; i > stopIndex; i--)
            {
                items[i] = items[i - 1];
            }
            
            items[stopIndex] = item;
        }
    }
}