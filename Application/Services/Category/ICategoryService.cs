using Application.Interface.Context;
using Common.Common;
using Common.Dto_s.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Category
{
    public interface ICategoryService
    {
        ResultDto CreateNewCategory(CategoriesDto dto);
        ResultDto<CategoriesDto> GetCategoryById(long CatId);
        ResultDto<List<CategoriesDto>> GetAllCategories();
    }
    public class CategoryService : ICategoryService
    {
        private readonly INiazRoozDBContext _context;
        public CategoryService(INiazRoozDBContext context)
        {
            _context = context;
        }

        public ResultDto CreateNewCategory(CategoriesDto dto)
        {
            throw new NotImplementedException();
        }

        public ResultDto<List<CategoriesDto>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public ResultDto<CategoriesDto> GetCategoryById(long CatId)
        {
            throw new NotImplementedException();
        }
    }
}
