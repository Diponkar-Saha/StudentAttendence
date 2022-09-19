using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendence
{
    public class ClassSchedule
    {
        public int Id { get; set; }
        public int CSSSID { get; set; }
        public CSSS cSSS { get; set; }
        public int ToTalClass { get; set; }
        public string Weekday { get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }
    }
}
