using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DmiConsulting.Eshop.Core.Entities;
using DmiConsulting.Eshop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DmiConsulting.Eshop.Infrastructure
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(DataContext context)
            : base(context) { }

        public override async Task<Product> GetByIdAsync(int id)
        {
            var product = await Context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);

            return product;
        }

        public override async Task<IReadOnlyList<Product>> ListAllAsync()
        {
            var products = await Context.Products.Select(p => new Product() {Id = p.Id, Name = p.Name, Price = p.Price})
                .ToListAsync();

            return products;
        }
    }
}
