using ModelLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.DataObjects
{
    public class ClosingCourse
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public University University { get; set; }
        public List<Course> Courses { get; set; }
        public DateTime DateTimeOrder { get; set; }

    }
}
