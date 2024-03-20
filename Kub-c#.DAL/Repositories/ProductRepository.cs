using Kub_c_.DAL.Interfaces;
using Kub_c_.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kub_c_;
using Microsoft.EntityFrameworkCore;

namespace Kub_c_.DAL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private Context db;
        public ProductRepository(Context db)
        {
            this.db = db;
        }
        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }
        public void Create(Product product)
        {
            db.Products.Add(product);
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public void Update(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Product product = db.Products.Find(id);
            if (product != null)
            {
                db.Products.Remove(product);
            }
        }

        public IEnumerable<Product> Find(Func<Product, bool> predicate)
        {
            return db.Products.Where(predicate).ToList();
        }

    }
}
