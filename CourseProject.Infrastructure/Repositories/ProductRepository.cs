using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject.Domain.Interfaces;
using CourseProject.Domain.Models;

namespace CourseProject.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new();

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await Task.FromResult(_products);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return await Task.FromResult(product);
        }

        public async Task AddAsync(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Product product)
        {
            var existing = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
                existing.Stock = product.Stock;
            }
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
            await Task.CompletedTask;
        }
    }
}
