using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVCApp.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public double EmployeeSalary { get; set; }


        //public override string ToString()
        //{
        //    return $"<p> The Name:{EmployeeName}</p> <p> The Address:{EmployeeAddress}</p><p> The Salary:{EmployeeSalary}</p>";
        //}
    }
}
