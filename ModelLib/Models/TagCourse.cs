using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Models
{
    [Table]
    public class TagCourse
    {
        [PrimaryKey, NotNull] public int TagId { get; set; }
        [PrimaryKey, NotNull] public long CourseId { get; set; }

        [Association(ThisKey = nameof(TagId), OtherKey = nameof(ModelLib.Models.Tag.Id))]
        public Tag Tag { get; set; }

        [Association(ThisKey = nameof(CourseId), OtherKey = nameof(ModelLib.Models.Course.Id))]
        public Course Course { get; set; }
    }
}
