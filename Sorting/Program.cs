namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort(notSortedYet);
            Console.WriteLine(string.Join(", ", notSortedYet));
        }

        public static List<int> notSortedYet = [1, 7, 2, -5, -15, 16, 3];
        

        public static List<int> BubbleSort(List<int> listToSort)
        {
            for(int i = 0; i < listToSort.Count; i++)
            {
                bool changed = false;
                for (int j = 0; j < listToSort.Count - i - 1; j++)
                {
                    if (listToSort[j] > listToSort[j + 1])
                    {
                        int temp = listToSort[j];   
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;   
                        changed = true;
                    }
                }
                if (!changed) return listToSort;
            }
            return listToSort;
            
        }


    }
}
