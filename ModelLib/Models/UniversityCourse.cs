using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Models
{
    [Table]
    public class UniversityCourse
    {
        [PrimaryKey, Identity] public long Id { get; set; }
        [Column, NotNull] public long CourseId { get; set; }
        [Column, NotNull] public int UniversityId { get; set; }
        [Column, NotNull] public int State { get; set; }
        [Column, NotNull] public DateTime TS { get; set; }

        [Association(ThisKey = nameof(UniversityId), OtherKey = nameof(ModelLib.Models.University.Id))]
        public University University { get; set; }

        [Association(ThisKey = nameof(CourseId), OtherKey = nameof(ModelLib.Models.Course.Id))]
        public Course Course { get; set; }
    }
}
