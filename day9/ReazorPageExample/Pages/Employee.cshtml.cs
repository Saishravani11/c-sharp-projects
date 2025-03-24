using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExample.Model;

namespace RazorExample.Pages
{
    public class EmployeeModel : PageModel
    {

        public List<EmployeeData> Employees { get; set; }

        public void OnGet()
        {
            List<EmployeeData> employees = new List<EmployeeData>();

            EmployeeData emp1 = new EmployeeData(1, "John", "Male", "xyz");
            EmployeeData emp2 = new EmployeeData(2, "Niti", "Female", "xyz");
            EmployeeData emp3 = new EmployeeData(3, "John", "Male", "xyz");
            EmployeeData emp4 = new EmployeeData(4, "John", "Male", "xyz");

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);

            Employees = employees;



        }
    }
}

