﻿using Store.Core.Entities;
using Store.Core.Repositories_Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core
{
	public interface IUnitOfWork
	{
		Task<int> completeAsync();

		IGenericRepository<TEntity,TKey> Repository<TEntity,TKey>() where TEntity:BaseEntity<TKey> ;

	}
}
