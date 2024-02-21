using SampleDAL.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBLL.Interfaces;
public interface ICategoryService
{
    Task<Category> GetByIdAsync(int id);
    Task<IEnumerable<Category>> GetAllAsync();
    Task<Category> AddAsync(Category entity);
    Task AddRangeAsync(IEnumerable<Category> entities);
    Task UpdateAsync(Category entity);
    void Remove(Category entity);
    void RemoveRange(IEnumerable<Category> entities);
}

