# Quick sort
QuickSort is a Divide and Conquer algorithm. It works by breaking an array (partition) into smaller ones and swapping (exchanging) the smaller ones, depending on a comparison with the 'pivot' element picked.

# Pseudo Code
```
ALGORITHM QuickSort(arr, left, right)
    if left < right
        // Partition the array by setting the position of the pivot value
        DEFINE position <-- Partition(arr, left, right)
        // Sort the left
        QuickSort(arr, left, position - 1)
        // Sort the right
        QuickSort(arr, position + 1, right)

ALGORITHM Partition(arr, left, right)
    // set a pivot value as a point of reference
    DEFINE pivot <-- arr[right]
    // create a variable to track the largest index of numbers lower than the defined pivot
    DEFINE low <-- left - 1
    for i <- left to right do
        if arr[i] <= pivot
            low++
            Swap(arr, i, low)

     // place the value of the pivot location in the middle.
     // all numbers smaller than the pivot are on the left, larger on the right.
     Swap(arr, right, low + 1)
    // return the pivot index point
     return low + 1

ALGORITHM Swap(arr, i, low)
    DEFINE temp;
    temp <-- arr[i]
    arr[i] <-- arr[low]
    arr[low] <-- temp
```
# C# Code
```
 public static void QuickSortMethod(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);
                QuickSortMethod(arr, left, position - 1);
                QuickSortMethod(arr, position + 1, right);
            }
        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);
            return low + 1;
        }

        public static void Swap(int[] arr, int i, int low)
        {
            int temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
```
# Complexity
Worst Case Complexity - In quick sort, worst case occurs when the pivot element is either greatest or smallest element. Suppose, if the pivot element is always the last element of the array, the worst case would occur when the given array is sorted already in ascending or descending order. The worst-case time complexity of quicksort is O(n2).

# Example
![](QS.png)
1. Select any splitting value, say L. The splitting value is also known as Pivot.
2. Divide the stack of papers into two. A-L and M-Z. It is not necessary that the piles should be equal.
3. Repeat the above two steps with the A-L pile, splitting it into its significant two halves. And M-Z pile, split into its halves. The process is repeated until the piles are small enough to be sorted easily.
4. Ultimately, the smaller piles can be placed one on top of the other to produce a fully sorted and ordered set of papers.
5. The approach used here is reduction at each split to get to the single-element array.
6. At every split, the pile was divided and then the same approach was used for the smaller piles by using the method of recursion.

Technically, quick sort follows the below steps:
- Step 1 − Make any element as pivot
- Step 2 − Partition the array on the basis of pivot
- Step 3 − Apply quick sort on left partition recursively
- Step 4 − Apply quick sort on right partition recursively