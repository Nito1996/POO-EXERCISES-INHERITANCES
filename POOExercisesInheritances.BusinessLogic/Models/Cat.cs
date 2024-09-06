using System;
using POOExercisesInheritances.DataAccess;

namespace POOExercisesInheritances.BusinessLogic
{
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"The {base.Age} Years Old {base.Name} Meows");
        }
        public Cat(string name, int age) : base(name, age)
        {

        }
    }
}
