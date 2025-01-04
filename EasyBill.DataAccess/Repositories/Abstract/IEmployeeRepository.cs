using EasyBill.DataAccess.Repositories.Abstract.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Abstract
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeesByRole(string role);
    }
}
