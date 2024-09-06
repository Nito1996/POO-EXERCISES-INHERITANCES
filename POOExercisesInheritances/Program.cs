using POOExercisesInheritances.BusinessLogic.Services;

namespace POOExercisesInheritances
{
    public class Program
    {
        static void Main()
        {
            DataService list = new DataService();
            list.MainList().Add(new DataAccess.Animal("Alcon", 25));
            list.MainList().Add(new BusinessLogic.Dog("Chiguagua", 15));
            list.MainList().Add(new BusinessLogic.Cat("Garfield", 10));
            foreach (var animal in list.MainList())
            {
                animal.MakeSound();
            }
        }
    }
}
