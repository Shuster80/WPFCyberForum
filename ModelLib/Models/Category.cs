using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Models
{
    [Table]
    public class Category
    {
        [PrimaryKey, Identity] public int Id { get; set; }
        [Column, NotNull] public string Name { get; set; }

        [Association(ThisKey = nameof(Id), OtherKey = nameof(CategoryCourse.CategoryId))]
        public IList<CategoryCourse> CategoryCourses { get; set; }
    }
}
