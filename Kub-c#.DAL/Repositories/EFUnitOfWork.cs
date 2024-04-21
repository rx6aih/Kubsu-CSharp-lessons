using Kub_c_.DAL.Entities;
using Kub_c_.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kub_c_.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private Context db;
        private ClientRepository clientRepository;
        private ProductRepository productRepository;
        private FuturaRepository futuraRepository;
        private FuturasInfoRepository futurasInfoRepository;

        public EFUnitOfWork()
        {
            db=new Context();
        }

        public IRepository<Client> Clients
        {
            get
            {
                if (clientRepository == null)
                    clientRepository = new ClientRepository(db);
                return clientRepository;
            }
        }

        public IRepository<Product> Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
        }

        public IRepository<Futura> Futuras
        {
            get
            {
                if(futuraRepository == null)
					futuraRepository = new FuturaRepository(db);
                return futuraRepository;
            }
        }

        public IRepository<FuturaInfo> FuturasInfo
        {
            get
            {
                if(futurasInfoRepository == null)
                    futurasInfoRepository = new FuturasInfoRepository(db);
                return futurasInfoRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing) 
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
