using Data_Structures.Data_structures.stack_queue_animal_shelter;
using Xunit;

namespace TestProject1
{
    public class AnimalShelterTest
    {
        [Fact]
        public void FirstMatch()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "dog" });
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "cat" });
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "dog" });
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "cat" });
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "fish" });
            Assert.Equal("dog", shelter.Dequeue("dog").type);

        }
        [Fact]
        public void nullTest()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "dog" });
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "cat" });
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "dog" });
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "cat" });
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "fish" });
            Assert.Null(shelter.Dequeue("fish"));

        }
        [Fact]
        public void happyPath()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "dog" });
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "dog" });
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "cat" });
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "dog" });
            shelter.Enqueue(new Animal { name = "popy", age = 2, type = "fish" });
            Assert.Equal("cat", shelter.Dequeue("cat").type);

        }
    }
}
