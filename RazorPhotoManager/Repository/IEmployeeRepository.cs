using RazorPhotoManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPhotoManager.Repository
{
    interface IEmployeeRepository
    {
        ICollection<Employee> GetEmployees();
    }

    public class MockEmployeeRepository : IEmployeeRepository
    {
        public ICollection<Employee> GetEmployees()
        {
            var emps = new List<Employee>()
            {
                new Employee { Id=1, Name="Mary", Department="IT", Email="mary@mary.net", Photo="mary.png"},
                new Employee { Id=1, Name="Daniel", Department="HR", Email="daniel@daniel.net", Photo="daniel.png"},
                new Employee { Id=1, Name="Gustavo", Department="Marketing", Email="gustavo@gustavo.net", Photo="gustavo.png"},
                new Employee { Id=1, Name="Okoro", Department="Sales", Email="okoro@okoro.net", Photo="okoro.png"},
                new Employee { Id = 11, Name = "Peter", Department = "Accounting", Email = "peter@peter.net", Photo = "peter.png" }
            };
            return emps;
        }
    }
}
