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
    public class ClientRepository : IRepository<Client>
    {
        private Context db;
        public ClientRepository(Context db)
        {
            this.db = db;
        }
        public IEnumerable<Client> GetAll() 
        {
            return db.Clients;
        }
        public void Create(Client client)
        {
            db.Clients.Add(client);
        }

        public Client Get(int id)
        {
            return db.Clients.Find(id);
        }

        public void Update(Client client)
        {
            db.Entry(client).State=EntityState.Modified;
        }

        public void Delete(int id)
        {
            Client client = db.Clients.Find(id);
            if(client != null)
            {
                db.Clients.Remove(client);
            }
        }
            
        public IEnumerable<Client> Find(Func<Client, bool> predicate)
        {
            return db.Clients.Where(predicate).ToList();
        }

    }
}
