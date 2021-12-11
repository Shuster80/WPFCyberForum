using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Models
{
    [Table]
    public class CategoryCourse
    {
        [PrimaryKey, NotNull] public int CategoryId { get; set; }
        [PrimaryKey, NotNull] public long CourseId { get; set; }

        [Association(ThisKey = nameof(CategoryId), OtherKey = nameof(ModelLib.Models.Category.Id))]
        public Category Category { get; set; }

        [Association(ThisKey = nameof(CourseId), OtherKey = nameof(ModelLib.Models.Course.Id))]
        public Course Course { get; set; }
    }
}
