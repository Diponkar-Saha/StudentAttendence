using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendence
{
    public class ClassTime
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int ToTalClass { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime endDateTime { get; set; }

    }
}
