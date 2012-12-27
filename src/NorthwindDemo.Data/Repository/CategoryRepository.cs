using System;
using System.Collections.Generic;
using NorthwindowDemo.DomainModel.Models;

namespace NorthwindDemo.Data.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        public IEnumerable<Category> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }

    
}
