using Data_Structures.Data_structures.Sorting.Merge_Sort;
using Xunit;

namespace TestProject1
{
    public class Merge_Sort_Test
    {
        [Fact]
        public void NormalValuesTest()
        {
            int[] array = { 8, 4, 23, 42, 16, 15 };
            int[] result = { 4, 8, 15, 16, 23, 42 };
            MergeSort.MergesortMethod(array);
            Assert.Equal(array, result);
        }

        [Fact]
        public void DuplicatesTest()
        {
            int[] array = { 4, 4, 23, 42, 16, 15 };
            int[] result = { 4, 4, 15, 16, 23, 42 };
            MergeSort.MergesortMethod(array);
            Assert.Equal(array, result);
        }

        [Fact]
        public void PositiveNegativeValuesTest()
        {
            int[] array = { 8, -4, 23, 42, 16, 15 };
            int[] result = { -4, 8, 15, 16, 23, 42 };
            MergeSort.MergesortMethod(array);
            Assert.Equal(array, result);
        }

        [Fact]
        public void NegativeValuesTest()
        {
            int[] array = { -8, -4, -23, -42, -16, -15 };
            int[] result = { -42, -23, -16, -15, -8, -4 };
            MergeSort.MergesortMethod(array);
            Assert.Equal(array, result);
        }
    }
}
