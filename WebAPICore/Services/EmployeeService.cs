using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.IServices;
using WebAPICore.Models;


namespace WebAPICore.Services
{
    public class EmployeeService:IEmployeeService
    {

        APICoreDBContext dbContext;
        public EmployeeService(APICoreDBContext _db)
        {
            dbContext = _db;
        }



        public IEnumerable<Employee> GetEmployee()
        {
            var employee = dbContext.Employees.ToList();
            return employee;
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = dbContext.Employees.FirstOrDefault(x => x.Id == id);
            return employee;
        }
    }
}
