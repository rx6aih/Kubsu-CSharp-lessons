using Kub_c_.DAL.Entities;
using Kub_c_.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kub_c_.DAL.Repositories
{
	public class FuturaRepository : IRepository<Futura>
	{
		private Context db;
		public FuturaRepository(Context db) 
		{
			this.db = db;
		}
		public IEnumerable<Futura> GetAll()
		{
			return db.Futuras;
		}
		public void Create(Futura futura)
		{
			db.Futuras.Add(futura);
		}

		public Futura Get(int id)
		{
			return db.Futuras.Find(id);
		}

		public void Update(Futura futura)
		{
			db.Entry(futura).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			Futura futura = db.Futuras.Find(id);
			if (futura != null)
			{
				db.Futuras.Remove(futura);
			}
		}

		public IEnumerable<Futura> Find(Func<Futura, bool> predicate)
		{
			return db.Futuras.Where(predicate).ToList();
		}

	}
}
