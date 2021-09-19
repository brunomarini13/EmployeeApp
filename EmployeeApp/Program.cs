using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Bruno", 22, 456, 100, "8484848");
            emp.GiveBonus(1000);
            emp.Age++;
            emp.DisplayStats();
            emp.Name = "Bruninho";
            string test = emp.Name;
            Console.WriteLine("Employee is named: {0}", emp.Name);
            Console.ReadLine();
            

        }
    }
}
