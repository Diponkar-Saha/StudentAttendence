using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendence
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
        public Guid TeacherId { get; set; }
    }
}
