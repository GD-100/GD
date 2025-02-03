using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CourseProject.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseProject.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
