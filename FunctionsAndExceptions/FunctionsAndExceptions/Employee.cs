using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsAndExceptions
{
    class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }

        public void ValidateEmployeeCode(int empCode, string empName)
        {
            if (EmpCode <= 0)
            {
                throw new InvalidEmployeeCode();
            }
            else
            {
                this.EmpCode = empCode;
                this.EmpName = empName;
            }
        }

        public string Display()
        {
            return $"Code={this.EmpCode}\nName={this.EmpName}";
        }
    }
}
