namespace homewoek2;


class Program
{
    static void insertionSortRecursive(int[] arr, int n)
    {
        if (n <= 1)
            return;

        insertionSortRecursive(arr, n - 1);

        int last = arr[n - 1];
        int j = n - 2;

        while (j >= 0 && arr[j] > last)
        {
            arr[j + 1] = arr[j];
            j--;
        }

        arr[j + 1] = last;
    }

    static void Main()
    {
        int[] arr = { 5, 9, 1, 15, 7, 19, 3 };

        insertionSortRecursive(arr, arr.Length);

        foreach (int n in arr)
        {
            Console.WriteLine(n);
        }
    }
}