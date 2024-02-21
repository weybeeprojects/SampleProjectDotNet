using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SampleDAL.DbModels;
using SampleDAL.Repository;
using SampleBLL.Interfaces;

namespace SampleBLL.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IDBRepository<Category> _categoryRepo;

        public CategoryService(IDBRepository<Category> categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _categoryRepo.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _categoryRepo.GetAllAsync();
        }

        public async Task<Category> AddAsync(Category entity)
        {
            return await _categoryRepo.AddAsync(entity);  
        }

        public async Task AddRangeAsync(IEnumerable<Category> entities)
        {
            await _categoryRepo.AddRangeAsync(entities);
        }

        public async Task UpdateAsync(Category entity)
        {
            await _categoryRepo.UpdateAsync(entity);
        }

        public void Remove(Category entity)
        {
            _categoryRepo.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Category> entities)
        {
            _categoryRepo.RemoveRange(entities);
        }
    }

}
