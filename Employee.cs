using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets
{
    public class Employee
    {
        //Write your code here 
        private string empCode, empName;
        private double empSal;
        private char deptCode;
        private static int empCounter = 1000;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        public char DeptCode
        {
            get { return deptCode; }
            set { deptCode = value; }
        }
        public double EmpSal
        {
            get { return empSal; }
            set { empSal = value; }
        }

        public string EmpCode
        {
            get { return empCode; }
        }

        public Employee(string empName, double empSal, char deptCode)
        {
            this.empName = empName;
            this.empSal = empSal;
            this.deptCode = deptCode;
            empCounter++;
            this.empCode = generateEmployeeCode(deptCode);
        }
        public Employee(string empName, double empSal)
        {

            this.empName = empName;
            this.empSal = empSal;
            this.deptCode = 'A';
            empCounter++;
            this.empCode = generateEmployeeCode(deptCode);
        }

        private string generateEmployeeCode(char deptCode)
        {
            return empCounter + deptCode.ToString();
        }

        public string getEmployeeDetaills()
        {
            return "Code-" + empCode + ", Name-" + empName + ", Salary-" + empSal.ToString() + "Department-" + deptCode.ToString();
        }
    }


        internal class Employee
    {
        static void Main(string[] args)
        {
        }
    }
}
