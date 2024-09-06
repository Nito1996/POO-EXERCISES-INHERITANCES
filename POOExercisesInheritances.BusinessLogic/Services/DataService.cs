using System.Collections.Generic;
using POOExercisesInheritances.DataAccess;
using POOExercisesInheritances.DataAccess.Models;

namespace POOExercisesInheritances.BusinessLogic.Services
{
    public class DataService
    {
        public List<Animal> MainList()
        {
            return Data.animalList;
        }
    }
}
