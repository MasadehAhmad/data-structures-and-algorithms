using Data_Structures.Data_structures.Quick_Sort;
using Xunit;
namespace TestProject1
{
    public class Quick_Sort_Test
    {
        [Fact]
        public void NormalValuesTest()
        {
            int[] array = { 8, 4, 23, 42, 16, 15 };
            int[] result = { 4, 8, 15, 16, 23, 42 };
            QuickSort.QuickSortMethod(array, 0, array.Length - 1);
            Assert.Equal(array, result);
        }

        [Fact]
        public void DuplicatesTest()
        {
            int[] array = { 4, 4, 23, 42, 16, 15 };
            int[] result = { 4, 4, 15, 16, 23, 42 };
            QuickSort.QuickSortMethod(array, 0, array.Length - 1);
            Assert.Equal(array, result);
        }

        [Fact]
        public void PositiveNegativeValuesTest()
        {
            int[] array = { 8, -4, 23, 42, 16, 15 };
            int[] result = { -4, 8, 15, 16, 23, 42 };
            QuickSort.QuickSortMethod(array, 0, array.Length - 1);
            Assert.Equal(array, result);
        }

        [Fact]
        public void NegativeValuesTest()
        {
            int[] array = { -8, -4, -23, -42, -16, -15 };
            int[] result = { -42, -23, -16, -15, -8, -4 };
            QuickSort.QuickSortMethod(array, 0, array.Length - 1);
            Assert.Equal(array, result);
        }
    }
}
