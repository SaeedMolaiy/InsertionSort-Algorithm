int[] arr = { 12, 11, 13, 5, 6 };

Console.WriteLine("Original Array:");
PrintArray(arr);

InsertionSort.InsertionSort.InsertionSortAlgorithm(arr);

Console.WriteLine("\nSorted Array:");
PrintArray(arr);

static void PrintArray(IEnumerable<int> arr)
{
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}