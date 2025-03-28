namespace dsa.Arrays;

/// <summary>
/// the worst and average time complexity is O(n2)
/// </summary>
internal class InsertionSort
{
    public static void Sort(int[] numbers)
    {
        for (int i = 1; i < numbers.Length; i++)
        {
            int j = i;
            while (j > 0 && numbers[j] < numbers[j - 1])
            {
                (numbers[j], numbers[j - 1]) = (numbers[j - 1], numbers[j]);
                j--;
            }
        }
    }
}