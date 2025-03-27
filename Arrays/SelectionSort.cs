namespace dsa.Arrays;

/// <summary>
/// the worst and the average time complexity is O(n2)
/// </summary>
internal class SelectionSort
{
    public static void Sort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int minIndex = i;
            int minValue = numbers[i];

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < minValue)
                {
                    minIndex = j;
                    minValue = numbers[j];
                }
            }
            (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
        }
    }
}
