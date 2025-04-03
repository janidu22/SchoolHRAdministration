using HRAdministrationAPI;
using HRAdminstrationAPI;
using System.Security.Cryptography.X509Certificates;

namespace SchoolHRAdministration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalSalary = 0;
            List<IEmployee> employees = new List<IEmployee>();
            
            SeedData(employees);
            foreach (var employee in employees)
            {
              totalSalary += employee.Salary;
            }

            Console.WriteLine($"Total Anual Salary: ${totalSalary}");
            Console.ReadLine();
        }
        
        public static void SeedData(List<IEmployee> employees)
        {
            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "john",
                LastName = "smith",
                Salary = 40000
            };

            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "jenny",
                LastName = "will",
                Salary = 45000
            };
            employees.Add(teacher2);

            IEmployee teacher3 = new Teacher
            {
                Id = 3,
                FirstName = "Kendal",
                LastName = "jim",
                Salary = 50000
            };

            employees.Add(teacher3);


            IEmployee HeadOfDepartment1 = new HeadOfDepartment
            {
                Id = 4,
                FirstName = "demian",
                LastName = "williams",
                Salary = 65000
            };
            employees.Add(HeadOfDepartment1);

            IEmployee HeadOfDepartment2 = new HeadOfDepartment
            {
                Id = 5,
                FirstName = "Kiara",
                LastName = "jim",
                Salary = 750000
            };
            employees.Add(HeadOfDepartment2);

            IEmployee DeputyHeadMaster = new DeputyHeadMaster
            {
                Id = 6,
                FirstName = "kobby",
                LastName = "blake",
                Salary = 87000
            };

            employees.Add(DeputyHeadMaster);

            IEmployee HeadMaster = new HeadMaster
            {
                Id = 6,
                FirstName = "aimie",
                LastName = "patrick",
                Salary = 87000
            };

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

}
