static void Main()
{
    int[] numbers = { 1, 2, 3, 4, 5 };
    int result;

    // O(1) complexity example: Accessing the first element of the array
    result = GetFirstElement(numbers);
    Console.WriteLine("Result: GetFirstElement" + result);
    // O(n) complexity example: Finding the sum of all elements in the array
    result = GetSum(numbers);
    Console.WriteLine("Result: GetSum" + result);
    // O(n^2) complexity example: Bubble Sort
    BubbleSort(numbers);
    Console.WriteLine("Sorted Array: " + string.Join(", ", numbers));
    // Find the minimum element in the array
    int minElement = FindMinElement(numbers);
    Console.WriteLine("Minimum Element: " + minElement);
}

static int GetFirstElement(int[] arr)
{
    // This algorithm has constant time complexity O(1)
    return arr[0];
}

static int GetSum(int[] arr)
{
    // This algorithm has linear time complexity O(n)
    int sum = 0;
    foreach (int num in arr)
    {
        sum += num;
    }
    return sum;
}

static int FindMinElement(int[] arr)
{
    // Initialize the minimum element with the first element of the array
    int minElement = arr[0];

    // Iterate through the array to find the minimum element
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minElement)
        {
            // Update the minimum element if a smaller element is found
            minElement = arr[i];
        }
    }

    return minElement;
}

static void BubbleSort(int[] arr)
{
    // This algorithm has quadratic time complexity O(n^2)
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                // Swap arr[j] and arr[j + 1]
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}