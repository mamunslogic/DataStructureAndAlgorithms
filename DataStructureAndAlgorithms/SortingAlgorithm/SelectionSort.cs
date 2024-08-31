// SELECTION SORT
namespace DataStructureAndAlgorithms.SortingAlgorithm
{
    internal class SelectionSort
    {
        private void DoSort(int[] numbers)
        {
            int lastMinNumberIndex = 0;
            int temp;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[lastMinNumberIndex])
                    {
                        lastMinNumberIndex = j;
                    }
                }

                if (lastMinNumberIndex != i)
                {
                    temp = numbers[i];
                    numbers[i] = numbers[lastMinNumberIndex];
                    numbers[lastMinNumberIndex] = temp;
                }
            }
        }

        internal void DisplaySelectionSort(int[] numbers)
        {
            Console.WriteLine("Lets do a SELECTION SORT!\n");

            Console.WriteLine("Before Sorting the numbers were:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]}");
            }

            DoSort(numbers);

            Console.WriteLine("\nAfter Sorting the numbers are:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]}");
            }
        }
    }
}
