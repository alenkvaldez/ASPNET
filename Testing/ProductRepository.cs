﻿using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace Testing
{
	public class ProductRepository : IProductRepository
	{
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
		{
			_conn = conn;
		}

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("Select * From Products");
        }
    }
}
