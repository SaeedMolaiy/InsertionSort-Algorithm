namespace InsertionSort
{
    internal static class InsertionSort
    {
        public static void InsertionSortAlgorithm(int[] arr)
        {
            var n = arr.Length;

            for (var i = 1; i < n; i++)
            {
                var currentElement = arr[i];
                var j = i - 1;

                // Move elements of arr[0..i-1] that are greater than currentElement
                // one position ahead of their current position
                while (j >= 0 && arr[j] > currentElement)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = currentElement;
            }
        }
    }
}