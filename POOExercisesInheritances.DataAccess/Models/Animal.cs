using System;

namespace POOExercisesInheritances.DataAccess
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
