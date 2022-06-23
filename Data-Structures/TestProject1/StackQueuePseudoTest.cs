using Data_Structures.Data_structures.stack_queue_pseudo;
using Xunit;

namespace TestProject1
{
    public class StackQueuePseudoTest
    {
        [Fact]
        public void Test1()
        {
            StackQueuePseudo sq = new StackQueuePseudo();
            sq.Enqueue(20);
            sq.Enqueue(15);
            sq.Enqueue(10);
            sq.Enqueue(5);
            Assert.Equal(20, sq.Dequeue());
            Assert.Equal(15, sq.Dequeue());
        }
    }
}
