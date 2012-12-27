using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindDemo.Data.UOW;
using NorthwindowDemo.DomainModel.Models;

namespace NorthwindDemo.Data.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        private INorthwindContext _northwindContext;

        public CategoryRepository(UnitOfWork uow)
        {
            _northwindContext = uow.Context;
        }

        public IEnumerable<Category> GetAll()
        {
           return _northwindContext.Categories.ToList();
        }

       
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }

    
}
