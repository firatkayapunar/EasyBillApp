using EasyBill.DataAccess.Context;
using EasyBill.DataAccess.Repositories.Concrete.Base;
using EasyBill.Entities;

namespace EasyBill.DataAccess.Repositories.Abstract
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly EasyBillDBContext _context;

        public EmployeeRepository(EasyBillDBContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetEmployeesByRole(string role)
        {
            return _context.Employees.Where(e => e.Role == role).ToList();
        }
    }
}
