using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagementProblem
{
    /// <summary>
    /// UC1 - Adding Person Details
    /// </summary>
    class PersonDetails
    {
        public static void AddPerson(List<Person> list)
        {
            Console.WriteLine("\n-----------Adding person details to list----------\n");
            try
            {
                if (list.Count >= 0)
                {
                    list.Add(new Person() { SSN = 1, name = "Vedhashni", address = "Chennai", age = 21 });
                    list.Add(new Person() { SSN = 2, name = "Karthiga", address = "Coimbatore", age = 39 });
                    list.Add(new Person() { SSN = 3, name = "Pritheesh", address = "Vellore", age = 18 });
                    list.Add(new Person() { SSN = 4, name = "Ashok", address = "Trichy", age = 14 });
                    list.Add(new Person() { SSN = 5, name = "Karan", address = "Madurai", age = 25 });
                }
                else if (list.Count == 0)
                {
                    Console.WriteLine("No details are added");
                }

                IterateThroughList(list);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void IterateThroughList(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine("SSN : {0} Name : {1} Address : {2} Age : {3}  ", person.SSN, person.name, person.address, person.age);
            }
        }
    }
}
