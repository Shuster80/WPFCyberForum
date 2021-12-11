using ModelLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.DataObjects
{
    public class CreateCourse
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public List<University> Universities { get; set; }
        public Course Course { get; set; }
        public DateTime DateTimeOrder { get; set; }
    }
}
