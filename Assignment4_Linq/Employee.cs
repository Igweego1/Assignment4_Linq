using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Linq
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Gender Gender { get; set; }
        public double Salary { get; set; }


        public static List<Employee> GetEmployee()
        {
            return new List<Employee>
            {
                new Employee { ID = 1, Name = "Amarachi", Age = 10, Gender = Gender.Female, Salary = 1000.00},
                new Employee { ID = 2, Name = "Bimbo", Age = 15, Gender = Gender.Male, Salary = 1500.00},
                new Employee { ID = 3, Name = "Charles", Age = 30, Gender = Gender.Male, Salary = 3000.00},
                new Employee { ID = 4, Name = "Ebuka", Age = 28, Gender = Gender.Male, Salary = 2500.00},
                new Employee { ID = 5, Name = "Shola", Age = 45, Gender = Gender.Male, Salary = 2000.00},
                new Employee { ID = 6, Name = "Francis", Age = 35, Gender = Gender.Male, Salary = 4000.00},
                new Employee { ID = 7, Name = "James", Age = 25, Gender = Gender.Male, Salary = 5000.00},
                new Employee { ID = 8, Name = "Giftie", Age = 20, Gender = Gender.Female, Salary = 3500.00},
                new Employee { ID = 9, Name = "Muoyo", Age = 40, Gender = Gender.Female, Salary = 6000.00},
                new Employee { ID = 10, Name = "zikora", Age = 19, Gender = Gender.Female, Salary = 7000.00},

            };
        }
    }

   
    public enum Gender
    {
        Male,
        Female,
    }
}
