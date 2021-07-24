using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagementProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management Problem");
            List<Person> list = new List<Person>();

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PersonDetails.AddPerson(list);
                    break;

                case 2:
                    PersonDetails.AddPerson(list);
                    PersonDetails.RetrieveTopTwoRecordsLessThan60(list);
                    break;

                default:
                    break;
            }
    }
}
