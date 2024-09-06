using System;
using POOExercisesInheritances.DataAccess;

namespace POOExercisesInheritances.BusinessLogic
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"The {base.Age} Years Old {base.Name} Barks");
        }

        public Dog(string name, int age) : base(name, age)
        {

        }
    }
}
