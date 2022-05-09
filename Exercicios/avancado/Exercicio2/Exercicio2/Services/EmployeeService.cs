using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Services
{
    internal class EmployeeService
    {
        public static double SumOfSalaryThatStartsWithM(List<Employee> list)
        {
            double result = list
                .Where(x => x.Name[0] == 'M')
                .Sum(x => x.Salary);
            return result;
        }

        public static IEnumerable<string> ListOfEmailsWithSalaryHigher(List<Employee> list, double salary)
        {
            IEnumerable<string> result = list
                .Where(x => x.Salary > salary)
                .OrderBy(x => x.Email)
                .Select(x => x.Email);
            return result;
        }
    }
}