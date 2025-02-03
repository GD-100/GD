using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CourseProject.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseProject.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task AddAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task DeleteAsync(int id);
    }
}
