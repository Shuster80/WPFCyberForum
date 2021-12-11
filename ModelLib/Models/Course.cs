using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Models
{
    [Table]
    public class Course
    {
        [PrimaryKey, Identity] public long Id { get; set; }
        [Column, NotNull] public string Name { get; set; }

        [Association(ThisKey = nameof(Id), OtherKey = nameof(CategoryCourse.CourseId))]
        public IList<CategoryCourse> CategoryCourses { get; set; }

        [Association(ThisKey = nameof(Id), OtherKey = nameof(TagCourse.CourseId))]
        public IList<TagCourse> TagCourses { get; set; }

    }
}
