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
	public class FuturasInfoRepository : IRepository<FuturaInfo>
	{
		private Context db;
		public FuturasInfoRepository(Context db)
		{
			this.db = db;
		}
		public IEnumerable<FuturaInfo> GetAll()
		{
			return db.FuturasInfo;
		}
		public void Create(FuturaInfo futuraInfo)
		{
			db.FuturasInfo.Add(futuraInfo);
		}

		public FuturaInfo Get(int id)
		{
			return db.FuturasInfo.Find(id);
		}

		public void Update(FuturaInfo futuraInfo)
		{
			db.Entry(futuraInfo).State = EntityState.Modified;
		}

		public void Delete(int id)
		{
			FuturaInfo futuraInfo = db.FuturasInfo.Find(id);
			if (futuraInfo != null)
			{
				db.FuturasInfo.Remove(futuraInfo);
			}
		}

		public IEnumerable<FuturaInfo> Find(Func<FuturaInfo, bool> predicate)
		{
			return db.FuturasInfo.Where(predicate).ToList();
		}
	}
}
