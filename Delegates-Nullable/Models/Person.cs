using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates_Nullable.Models
{
    public class Person
    {
        public double Salary { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }



        public Person(double salary,string name,string surname,string address)
        {
            Salary = salary;
            Name = name;
            SurName = surname;
            Address = address;
        }
    }
}
