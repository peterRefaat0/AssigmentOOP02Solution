using AssigmentOOP02.inheritance;
using Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;
namespace AssigmentOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //part01

            #region 1.Try all what we have learned in the lecture.

            PhoneBook Note = new PhoneBook(3);

            Note.AddPerson(0, "saad", 568);
            Note.AddPerson(1, "hassan", 987);
            Note.AddPerson(2, "Ahmed", 123);

            Note.SetNumber("peter", 55556);
            Console.WriteLine(Note.GetNumber("peter"));


            Note.SetNumber("saad", 5555);
            Console.WriteLine(Note.GetNumber("saad"));


            string name = "peter";
            Console.WriteLine(name[0]);


            for (int i = 1; i <Note.Size; i++)
            {
                Console.WriteLine(Note[i]);
            }



            Car C1; 

            C1 = new Car(20,"bmw",560);
             


            parent p1 = new parent(1,2);

            Console.WriteLine(p1.product());
            Console.WriteLine(p1.ToString());


            child c1 = new child(1 , 2 , 3);

            Console.WriteLine(c1.product());
            Console.WriteLine(c1.ToString());



            #endregion



            //part02
            #region 1.Design and implement a Class for the employees in a company:Employee is identified by an ID, Name, security level, salary, hire date and Gender.

            Employee employee1 = new Employee(101, "peter", SecurityLevel.Developer, 50000.00m, DateTime.Parse("2023-01-01"), 'm');


            employee1.DisplayEmployeeDetails();

            #endregion


            #region 2.Develop a Class to represent the Hiring Date Data:consisting of fields to hold the day, month and Years.

            HireDate hireDate = new HireDate(15, 7, 2020);

            Employee employee = new Employee(1, "peter", SecurityLevel.Developer, 75000, hireDate.ToDateTime(), 'M');

            employee1.DisplayEmployeeDetails();
            #endregion



            #region 3.We need to restrict the Gender field to be only M or F [Male or Female] 

            try
            {

                HireDate hiredate = new HireDate(15, 7, 2020);

                Employee employee2 = new Employee(1, "peter", SecurityLevel.Developer, 75000, hireDate.ToDateTime(), 'M');


                employee.DisplayEmployeeDetails();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }




            #endregion


            #region 4.Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
            try
            {

                HireDate hireDateInstance = new HireDate(15, 7, 2020);


                Employee employeeInstance = new Employee(1, "Ahmed", SecurityLevel.Developer, 90000, hireDateInstance.ToDateTime(), 'M');

                employeeInstance.DisplayEmployeeDetails();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


            #endregion


            #region 5.We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [ use String.Format Function]

            Employee employeee = new Employee(1, "saad", SecurityLevel.Developer, 80000, DateTime.Today, 'M');
            Console.WriteLine(employee.ToString());

            #endregion



            #region 6

            Employee[] EmpArr = new Employee[3];


            EmpArr[0] = new Employee(1, "DBA Employee", SecurityLevel.DBA, 85000, DateTime.Parse("2023-01-01"), 'M');
            EmpArr[1] = new Employee(2, "Guest Employee", SecurityLevel.Guest, 60000, DateTime.Parse("2023-02-15"), 'F');
            EmpArr[2] = new Employee(3, "Security Officer", SecurityLevel.SecurityOfficer, 100000, DateTime.Parse("2023-03-20"), 'M');


            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp.ToString());
                Console.WriteLine();
                }


                #endregion


            }
    }
}
