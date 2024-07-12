using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Common
{

    public class Employee
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public char Gender { get; set; }
        public char gender
        {
            get => Gender;
            set
            {
                if (value != 'M' && value != 'F')
                {
                    throw new ArgumentException("Gender must be either 'M' (Male) or 'F' (Female).");
                }
                Gender = value;
            }
        }


        public Employee() { }

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, DateTime hireDate, char gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }


        public override string ToString()
        {
            
            string formattedSalary = string.Format("{0:C}", Salary);

 
            string employeeInfo = $"ID: {ID}\n" + $"Name: {Name}\n" + $"Security Level: {SecurityLevel}\n" +  $"Salary: {formattedSalary}\n" + $"Hire Date: {HireDate.ToShortDateString()}\n" + $"Gender: {Gender}";

            return employeeInfo;
        }


        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Security Level: {SecurityLevel}");
            Console.WriteLine($"Salary: {Salary:C}");
            Console.WriteLine($"Hire Date: {HireDate.ToShortDateString()}");
            Console.WriteLine($"Gender: {Gender}");
        }



    } 








}
