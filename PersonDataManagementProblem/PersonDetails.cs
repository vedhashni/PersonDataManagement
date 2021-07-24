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
    public class PersonDetails
    {
        public static void AddPerson(List<Person> list)
        {
           
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

        public static bool RetrieveTopTwoRecordsLessThan60(List<Person> list)
        {
            
            try
            {
                if (list.Count >= 0)
                {
                    var ageResult1 = list.FindAll(a => a.age < 60).OrderBy(b => b.age).Take(2).ToList();
                    IterateThroughList(ageResult1);
                    return true;
                }
                else if (list.Count < 0)
                {
                    Console.WriteLine("No data present in list");
                    return false;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }

        public static bool RetrieveTeenageRecords(List<Person> list)
        {
            
            try
            {

                if (list.Count >= 0)
                {
                    var ageResult2 = list.FindAll(a => a.age > 13 && a.age < 18);

                    if (ageResult2.Count != 0)
                    {
                        IterateThroughList(ageResult2);
                        return true;
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine("No data present in list");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool CalculateAverageAge(List<Person> list)
        {
            
            try
            {
                AddPerson(list);
                if (list.Count > 0)
                {
                    double avgAge = list.Average(a => a.age);
                    Console.WriteLine("Average age value is : {0} ", avgAge);
                    return true;
                }
                else
                {
                    Console.WriteLine("No data present in list");
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public static bool SearchingSpecificName(List<Person> list, string Name)
        {
            try
            {
                AddPerson(list);
                var person = list.Find(a => a.name.Equals(Name));
                if (person != null)
                {
                    Console.WriteLine("\n-----Found the person--------\n");
                    Console.WriteLine("SSN : {0} Name : {1} Address : {2} Age : {3}  ", person.SSN, person.name, person.address, person.age);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool SkipRecordLessThan60(List<Person> list)
        {
            try
            {
                AddPerson(list);
                var skipRecord = list.FindAll(a => a.age > 60);
                if (skipRecord != null)
                {
                    Console.WriteLine("\n-----Record which age is greater than 60-----");
                    IterateThroughList(skipRecord);
                    return true;
                }
                else
                {
                    Console.WriteLine("No data available ");
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool RemoveSpecificName(List<Person> list, string Name)
        {
            try
            {
                AddPerson(list);
                if (list.Count > 0)
                {
                    var removeName = list.RemoveAll(x => x.name.Contains(Name));
                    Console.WriteLine("\n------Removed Id is : {0} ---", removeName);
                    Console.WriteLine("\n-------After removing the record from list-----------\n");
                    IterateThroughList(list);
                    return true;
                }
                else
                {
                    Console.WriteLine("No data present in list");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
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
