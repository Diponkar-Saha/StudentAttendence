﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendence
{
    public class CCCC
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int CourseFees { get; set; }
        public List<Teacher> teacher { get; set; }
        public List<Student> student { get; set; }
        public List<ClassTime> classTimes { get; set; }
        public Guid CCCCId { get; set; }
    }
}
