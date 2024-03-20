using Kub_c_.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kub_c_.DAL.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {
        IRepository<Client> Clients { get; }

        IRepository<Product> Products {  get; }
    }
}
