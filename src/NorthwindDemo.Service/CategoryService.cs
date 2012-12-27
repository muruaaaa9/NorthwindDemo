using System;
using System.Collections.Generic;
using NorthwindDemo.Data;
using NorthwindDemo.Service.Datacontract;
using NorthwindowDemo.DomainModel.Models;

namespace NorthwindDemo.Service
{
    public class CategoryService : ICategory
    {
        private IRepository<Category> _categoryRepository;

        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var allCategories = _categoryRepository.GetAll();
            return allCategories;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
