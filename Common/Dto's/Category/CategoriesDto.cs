using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto_s.Category
{
    public class CategoriesDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public long? ParentCategoryId { get; set; }
        public ParentCategoryDto Parent { get; set; }

    }

    public class ParentCategoryDto
    {
        public long Id { get; set; }
        public string name { get; set; }
    }
}
