using System;
using Web_API.Entities;

namespace Web_API
{
    public class DataContaxt
    {
        
        public List< Employee> EventListE {get;set;}
        public List<Salary> EventListS { get; set; }
        public List<Workhours> EventListW { get; set; }
        public DataContaxt()
        {
            EventListE = new List<Employee> { new Employee { Id = 0, firstname = "lea", lastname = "benisty", age = 20 } };
            EventListS = new List<Salary> { new Salary { Id = 0,Month = 05,Year = 2021,Basesalary = 1000, Bouns = 50, Finalesalary = 8000 } };
            EventListW = new List<Workhours> { new Workhours { Id = 0, Month = 07, Year = 2022, Day = 5, HoursDay = 8 } };
        }


    }
}
