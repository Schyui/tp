using EmployeeInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{

    class PartTimeEmployee : IEmployee
    {
        public string first_name;
        public string last_name;
        public string department;
        public string job_title;
        public double basic_salary;
        public PartTimeEmployee(string FName, string LName, string dept, string job)
        {
            this.first_name = FName;
            this.last_name = LName;
            this.department = dept;
            this.job_title = job;
        }

        public string FirstName{
            get{return first_name; }
            set{first_name = value;}
        }
        public string LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string JobTitle
        {
            get { return job_title; }
            set { job_title = value; }
        }
        public double BasicSalary
        {
            get { return basic_salary; }
            set { basic_salary = value; }
        }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            this.basic_salary = hoursWorked * ratePerHour;
        }
        public double getSalary()
        {
            return basic_salary;
        }
    }
}