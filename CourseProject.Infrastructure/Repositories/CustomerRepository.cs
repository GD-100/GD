using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject.Domain.Interfaces;
using CourseProject.Domain.Models;

namespace CourseProject.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = new();

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await Task.FromResult(_customers);
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            return await Task.FromResult(customer);
        }

        public async Task AddAsync(Customer customer)
        {
            _customers.Add(customer);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Customer customer)
        {
            var existing = _customers.FirstOrDefault(c => c.Id == customer.Id);
            if (existing != null)
            {
                existing.FirstName = customer.FirstName;
                existing.LastName = customer.LastName;
                existing.Email = customer.Email;
            }
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                _customers.Remove(customer);
            }
            await Task.CompletedTask;
        }
    }
}
