using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Models
{
    [Table]
    public class University
    {
        [PrimaryKey, Identity] public int Id { get; set; }
        [Column, NotNull] public string Name { get; set; }

        [Association(ThisKey = nameof(Id), OtherKey = nameof(UniversityCourse.UniversityId))]
        public IList<UniversityCourse> UniversityCouses { get; set; }
    }
}
