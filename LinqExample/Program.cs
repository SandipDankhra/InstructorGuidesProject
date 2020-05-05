using System;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Employee> Employees = new List<Employee>() {
                new Employee() { EmployeeId = 1, FirstName = "John",LastName = "Abraham",Salary = 1000000,JoinDate="01-JAN-12 12.00.00 AM",Department="Banking"} ,
                new Employee() { EmployeeId = 2, FirstName = "Michael ",LastName = "Clarke",Salary = 800000,JoinDate="01-JAN-12 12.00.00 AM",Department="Insurance"} ,
                new Employee() { EmployeeId = 3, FirstName = "Roy",LastName = "Thomes",Salary = 700000,JoinDate="01-FEB-13 12.00.00 AM",Department="Banking"} ,
                new Employee() { EmployeeId = 4, FirstName = " Tom",LastName = "Jose",Salary = 600000,JoinDate="01-FEB-13 12.00.00 AM",Department="Insurance"} ,
                new Employee() { EmployeeId = 5, FirstName = " Jerry",LastName = "Pinto",Salary = 650000,JoinDate="01-FEB-13 12.00.00 AM",Department="Insurance"} ,
                new Employee() { EmployeeId = 6, FirstName = " Philip",LastName = "Mathew",Salary = 750000,JoinDate="01-JAN-13 12.00.00 AM",Department="Service"} ,
                new Employee() { EmployeeId = 7, FirstName = "TestName1",LastName = "123",Salary = 650000,JoinDate="01-JAN-13 12.00.00 AM",Department="Service"} ,
                new Employee() { EmployeeId = 8, FirstName = "TestName2",LastName = "Lname%",Salary = 600000,JoinDate="01-FEB-13 12.00.00 AM",Department="Insurance"} ,

            };
            //Using Mathos syntax

            List<Employee> emp = Employees.ToList();

            foreach (Employee e in emp)
            {
                Console.WriteLine(e.EmployeeId + ", " + e.FirstName + ", " + e.LastName + ", " + e.Salary + ", " + e.JoinDate + ", " + e.Department);
            }

            foreach (Employee e in emp)
            {
                Console.WriteLine(e.EmployeeId + ", " + e.FirstName + ", " + e.LastName);
            }

            foreach (Employee e in emp)
            {
                Console.WriteLine(e.EmployeeId + ", " + e.FirstName.ToLower());
            }

            foreach (Employee e in emp)
            {
                Console.WriteLine(e.EmployeeId + ", " + e.FirstName.ToUpper());
            }

            var Emp = Employees.Select(e => e.Department).Distinct();
            foreach (var e in emp)
            {

                Console.WriteLine(e);
            }

            foreach (Employee e in emp)
            {

                Console.WriteLine(e.FirstName.Substring(0, 3));
            }

            var empres = Employees.Where(e => e.FirstName.ToLower().Contains("o"));

            foreach (var e in empres)
            {
                Console.WriteLine(e.FirstName);
                Console.WriteLine(e.FirstName.ToLower().IndexOf("o"));

            }

            foreach (var e in empres)
            {
                Console.WriteLine(e.FirstName.TrimEnd());
            }

            foreach (var e in empres)
            {
                Console.WriteLine(e.FirstName.TrimStart());
            }

            foreach (Employee e in emp)
            {
                Console.WriteLine(e.FirstName);
                Console.WriteLine(e.FirstName.Length);
            }

            foreach (Employee e in emp)
            {
                Console.WriteLine(e.FirstName.ToLower().Replace("o", "$"));
            }

            foreach (Employee e in emp)
            {
                var em = string.Join("_", e.FirstName, e.LastName);
                Console.WriteLine(em);
            }

            Console.WriteLine("Assending order");

            IEnumerable<string> empASC = Employees.OrderBy(e => e.FirstName).Select(e => e.FirstName);
            foreach (string e in empASC)
            {

                Console.WriteLine(e);

            }

            IEnumerable<string> empDEC = Employees.OrderByDescending(e => e.FirstName).Select(e => e.FirstName);
            foreach (string e in empDEC)
            {

                Console.WriteLine(e);

            }

            IEnumerable<Employee> nAsD = from s in Employees
                                         orderby s.Salary descending
                                         select s;
            foreach (Employee e in nAsD)
            {
                Console.WriteLine(e.FirstName + " " + e.Salary);
            }

            IEnumerable<string> fname = Employees.Where(e => e.FirstName == "John").Select(e => e.FirstName);
            foreach (var e in fname)
            {
                Console.WriteLine(e);
            }
            IEnumerable<string> name = Employees.Where(e => e.FirstName == "John"|| e.FirstName == "Roy").Select(e => e.FirstName);
            foreach (var e in name)
            {
                Console.WriteLine(e);
            }
         IEnumerable<string> nn = Employees.Where(e => e.FirstName != "John"|| e.FirstName != "Roy").Select(e => e.FirstName);
            foreach (var e in nn)
            {
                Console.WriteLine(e);
            }

            var res = from e in Employees
                       where e.FirstName.StartsWith("J")
                       select e;
            foreach (var e in res)
            {
                Console.WriteLine(e.FirstName);
            }

            foreach (var e in res)
            {
                Console.WriteLine(e.FirstName);
            }

            var fend = from e in Employees
                       where e.FirstName.EndsWith("n")
                       select e;
            foreach (var e in fend)
            {
                Console.WriteLine(e.FirstName);
            }

            var FLend = from e in Employees
                       where e.FirstName.EndsWith("n") && e.FirstName.Length == 4
                       select e;
            foreach (var e in FLend)
            {
                Console.WriteLine(e.FirstName);
            }
            Console.WriteLine("Salary  is greater than 600000");
            var sal = from e in Employees
                       where e.Salary > 600000
                       select e;
            foreach (var e in sal)
            {
                Console.WriteLine(e.FirstName);
                Console.WriteLine(e.Salary);
            }

            var Sal = from e in Employees
                       where e.Salary < 800000
                       select e;
            foreach (var e in Sal)
            {
                Console.WriteLine(e.FirstName);
                Console.WriteLine(e.Salary);
            }
   
            var SS = from e in Employees
                       where e.Salary > 500000 && e.Salary < 800000
                       select e ;
            foreach (var e in SS)
            {
                Console.WriteLine(e.FirstName);
                Console.WriteLine(e.Salary);
            }

            var Res = from e in Employees
                       where e.FirstName == "John" || e.FirstName == "Michael "
                       select e;
            foreach (var e in Res)
            {
                Console.WriteLine(e.FirstName + "-" + e.LastName + "-" + e.Salary + "-" + e.JoinDate + "-" + e.Department);
            }

            var rEMP = from e in Employees
                        select e;
            foreach (var e in rEMP)
            {
                DateTime dt = Convert.ToDateTime(e.JoinDate);

                string date = dt.ToString("mm-MM-yyyy");

                DateTime dtnew = Convert.ToDateTime(date);
                if (dt.Year == 2013)
                    Console.WriteLine(dtnew + ", " + e.FirstName);
            }

            Console.ReadKey();

        }


        public class Employee
        {
            public int EmployeeId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Salary { get; set; }
            public string JoinDate { get; set; }
            public string Department { get; set; }
        }
    }
}
