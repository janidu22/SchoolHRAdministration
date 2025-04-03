using HRAdministrationAPI;
using HRAdminstrationAPI;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SchoolHRAdministration
{
    public enum EmployeeType
    {
        Teacher,
        HeadOfDepartment,
        DeputyHeadMaster,
        HeadMaster

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalary = 0;
            List<IEmployee> employees = new List<IEmployee>();
            
            SeedData(employees);
            Console.WriteLine($"Total Anual Salary: ${employees.Sum(emp => emp.Salary)}");
            Console.ReadLine();
        }
        
        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher = EmployeeFactory.getEmployeeInstance(EmployeeType.Teacher,1,"janidu", "yapa",20000M);
            employees.Add(teacher);
           
            IEmployee HeadOfDepartment = EmployeeFactory.getEmployeeInstance(EmployeeType.Teacher, 2, "Kanidu", "yapa", 30000M);
            employees.Add(HeadOfDepartment);
           
            IEmployee DeputyHeadMaster = EmployeeFactory.getEmployeeInstance(EmployeeType.Teacher, 3, "Kanidu", "yapa", 40000M);
            employees.Add(DeputyHeadMaster);
           
            IEmployee HeadMaster = EmployeeFactory.getEmployeeInstance(EmployeeType.Teacher, 4, "Navidu", "yapa", 60000M);
            employees.Add(HeadMaster);
        }
    }

    public class Teacher : EmployeeBase
    {
        public override decimal Salary
        {
            get => base.Salary + (base.Salary * 0.02M); 
        }
    }
    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary
        {
            get => base.Salary + (base.Salary * 0.03M);
        }
    }

    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary
        {
            get => base.Salary + (base.Salary * 0.05M);
        }
    }

    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary
        {
            get => base.Salary + (base.Salary * 0.06M);
        }
    }



    public static class EmployeeFactory
    {
        public static IEmployee getEmployeeInstance(EmployeeType employeeType, int id, string firstname, string lastname, decimal salary)
        {
            IEmployee employee = null;

            switch (employeeType) 
            {
                case EmployeeType.Teacher:
                     employee = FactoryPatterns<IEmployee,Teacher>.GetInstance();
                    break;
                case EmployeeType.HeadOfDepartment:
                    employee = FactoryPatterns<IEmployee, HeadOfDepartment>.GetInstance();
                    break;
                case EmployeeType.DeputyHeadMaster:
                    employee = FactoryPatterns<IEmployee, DeputyHeadMaster>.GetInstance();
                    break;
                case EmployeeType.HeadMaster:
                    employee = FactoryPatterns<IEmployee, HeadMaster>.GetInstance();
                    break;
                default:
                    break;

            }
            if(employee != null)
            {
                employee.Id = id;
                employee.FirstName = firstname;
                employee.LastName = lastname;
                employee.Salary = salary;
            }
            else
            {
                throw new NullReferenceException();
            }
            return employee;
        }
    }



}
