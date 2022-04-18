using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures.Data_structures.stack_queue_animal_shelter
{


    public class Dog
    {
        public string name { get; set; }
        public int age { get; set; }
        public bool Equals(string dog)
        {
            return true;
        }
    }
    public class Cat
    {
        public string name { get; set; }
        public int age { get; set; }
        public bool Equals(string cat)
        {
            return true;
        }
    }
    public class AnimalShelter
    {
        Queue<object> queue = new Queue<object>();

        public void Enqueue(Cat animal)
        {
            queue.Enqueue(animal);
        }
        public void Enqueue(Dog animal)
        {
            queue.Enqueue(animal);
        }
        public object Dequeue(string pref)
        {
            object obj = null;
            Queue<object> temp = new Queue<object>();
            bool flag = true;
            if (pref != "cat" || pref !="dog") return null;

            if (queue.First().Equals(pref)) return queue.Dequeue();
            else 
            {
                while (queue.Count!=0)
                {
                    temp.Enqueue(queue.Dequeue());
                    if (queue.First().Equals(pref) && flag)
                    {
                        obj = queue.Dequeue();
                        flag = false;
                    }
                }
                while (temp.Count != 0)
                {
                    queue.Enqueue(temp.Dequeue());
                }
            }
            return obj;
        }

    }
}
