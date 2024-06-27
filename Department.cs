

using _25._06._2024Task2.Exceptions;

namespace _25._06._2024Task2
{
    internal class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }

        public  Employee[] Employees;
        public Employee this[int index]
        {
            get { return Employees[index]; }
            set { Employees[index] = value; }
        }
        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
        }
        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length+1);
            Employees[Employees.Length - 1] = employee;
            if( Employees.Length> EmployeeLimit)
            {
                throw new CapacityLimitException("Employee limit has been reached.");
            }
        }
       
    }
}
