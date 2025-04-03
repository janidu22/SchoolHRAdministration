using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdministrationAPI
{
  public interface IEmployee
    {
        int Id { get; set; }
        string FirstName { get; }
        string LastName { get; }
        decimal Salary { get; set; }
    }
}
