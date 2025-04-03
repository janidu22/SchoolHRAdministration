using HRAdministrationAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminstrationAPI
{
    public class EmployeeBase : IEmployee
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public  required string LastName { get; set; }

        public virtual decimal Salary { get; set; }
    }
}
