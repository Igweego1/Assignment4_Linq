using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment4_Linq
{
    internal class Program
    {
        static void Main()
        {
            var employeelist = Employee.GetEmployee();


            //Age Greater than 25
            var age = employeelist.Where(x => x.Age > 25)
                                  .OrderByDescending(x => x.Age);
                                  
           

            foreach (var item in age)
            {
                Console.WriteLine($"Name: {item.Name}   Age: {item.Age}");
            }

            Console.WriteLine();

            // Data for Female Candidates
            var allFemale = employeelist.Where(x => x.Gender == Gender.Female);


            foreach (var item in allFemale)
            {
                Console.WriteLine($"Name:{item.Name}   Gender:{item.Gender}");
            }


            Console.WriteLine();

            // Data of Age 20, 30 or 35 
            var allCandidates = employeelist.Where(x => x.Age == 20 || (x.Age == 30) || (x.Age == 35))
                                               .OrderBy(x => x.Age);
            foreach (var item in allCandidates)
            {
                Console.WriteLine($"Name: {item.Name}   Age: {item.Age}");
            }

            Console.WriteLine();

            // ID between 1 to 8

            var allID = employeelist.Where(x => x.ID <= 8 && x.Gender == Gender.Female);

            foreach (var item in allID)
            {
                Console.WriteLine($"Name: {item.Name}    Gender: {item.Gender}     ID: {item.ID}");
            }
        }
    }
}
