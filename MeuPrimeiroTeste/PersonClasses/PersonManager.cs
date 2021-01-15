using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroTeste.PersonClasses
{
    public class PersonManager
    {
        public Person CreatePerson(string first, string last, bool isSupervisor)
        {
            Person ret = null;

            if (!string.IsNullOrEmpty(first))
            {
                if (isSupervisor)
                    ret = new Supervisor();
                else
                    ret = new Employe();

                ret.FirstName = first;
                ret.LastName = last;
            }

            return ret;
        }

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { FirstName = "Deivide", LastName = "Silva" });
            people.Add(new Person() { FirstName = "Julia", LastName = "Gabriella" });
            people.Add(new Person() { FirstName = "July", LastName = "Lopes" });

            return people;
        }
    }
}
