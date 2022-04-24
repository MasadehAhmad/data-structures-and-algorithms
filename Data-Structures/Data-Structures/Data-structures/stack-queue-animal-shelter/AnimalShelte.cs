using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.stack_queue_animal_shelter
{


    public class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public string type { get; set; }
        
    }
 
    public class AnimalShelter
    {
        Queue<Animal> queue = new Queue<Animal>();

        public void Enqueue(Animal animal)
        {
            if (animal.type == "cat" || animal.type == "dog") queue.Enqueue(animal);
        }
       
        public Animal Dequeue(string pref)
        {
            Animal obj = null;
            Queue<Animal> temp = new Queue<Animal>();
            bool flag = true;
            while (queue.Count !=0)
            {
                if (queue.First().type == pref && flag)
                {
                    obj = queue.Dequeue();
                    flag = false;
                }
                temp.Enqueue(queue.Dequeue());
            }
                while (temp.Count != 0)
                {
                    queue.Enqueue(temp.Dequeue());
                }

            return obj;
        }

    }
}
