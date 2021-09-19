using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        // Field data.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;

        // Properties
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name lenght exceeds 15 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }

        public int ID
        {
            get { return empID; }
            set
            {
                if (value > 0)
                    empID = value;
            }
        }

        public float Pay
        {
            get { return currPay; }
            set
            {
                if (value > 1000f)
                    currPay = value;
                else
                    currPay = 1000f;
            }
        }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public string SSN
        {
            get { return empSSN; }
        }

        // Constructors.
        public Employee() { }
        public Employee(string name, int id, float pay, string ssn)
        : this(name, 0, id, pay, ssn) { }
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
            empSSN = ssn;
        }

        // Methods.
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("Social security number: {0}", SSN);
        }
    }
}
