using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionOOPS
{
    public class Employee
    {
       public String FirstName = "FN";
        public String LastName = "LN";

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class PartTimeEmployee : Employee
    {
        public void printFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Part Time");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public void printFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Full Time");
        }
    }
    public class TemporaryEmployee : Employee
    {
        public void printFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Temporary");
        }
    }
    public class program
    {
        public static void Main()
         {
            Employee[] employees = new Employee[4];

             employees[0] = new Employee();
             employees[1] = new PartTimeEmployee();
             employees[2] = new FullTimeEmployee();
             employees[3] = new TemporaryEmployee();

        foreach (Employee e in employees)
        {
            e.PrintFullName();
        }
     }
    }
   
}
