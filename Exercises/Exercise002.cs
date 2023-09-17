using System;
using Exercises.Models;
namespace Exercises
{
    public class Exercise002
    {
        // 👉 Remember to delete all unnecessary comments (like this one) when you're done! 

        public bool IsFromManchester(Person person)
        {
            if (person == null)
            {
                return false;
            }
            if (person.City == "Manchester")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            if (person == null)
            {
                return false;
            }
            if (person.Age >= ageLimit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
