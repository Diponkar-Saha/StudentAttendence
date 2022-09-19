
// See https://aka.ms/new-console-template for more information
using StudentAttendence;

Console.WriteLine("Hello, World!");
// * dotnet ef migrations add AddStuCourseTable --context TrainingDbContext --project StudentAttendence
//*dotnet ef database update --context TrainingDbContext --project StudentAttendence
TrainingDbContext trainingDbConttext = new TrainingDbContext();
/*
User user = new User();
user.UserName = "teacher";
user.Password = "password";
user.role =1;
*/

/*

VVVVV teacher    = new VVVVV();
teacher.Name = "Tttt";
teacher.user  = new List<User>();

teacher.user.Add(new User()
{
    UserName="dddd",
    Password="123456",
    role=3

});
trainingDbConttext.vvvvv.Add(teacher);
trainingDbConttext.SaveChanges();
Console.WriteLine("added");

*/

/*
CSSS course = new CSSS();
course.CCCCId = Guid.NewGuid();
course.CourseName = "bangla";
course.CourseFees = 5000;
trainingDbConttext.csss.Add(course);
trainingDbConttext.SaveChanges();
Console.WriteLine("added");

var course = trainingDbConttext.csss.Where(x => x.CourseName == "bangla").FirstOrDefault();

Console.WriteLine(course.Id+" " + course.CourseFees);
course.teacher = new List<TTTTT>();

course.teacher.Add(new TTTTT()
{
    Name = "Tttt"
});
trainingDbConttext.SaveChanges();
Console.WriteLine("added");
*/
var course = trainingDbConttext.csss.Where(x => x.CourseName == "bangla").FirstOrDefault();

/*
var teacher = trainingDbConttext.tttt.Where(x => x.Name == "Tttt").FirstOrDefault();

CourseTeacher courseTeacher = new CourseTeacher();
courseTeacher.cSSS = course;
courseTeacher.tTTTT = teacher;
trainingDbConttext.courseTeachers.Add(courseTeacher);
trainingDbConttext.SaveChanges();
Console.WriteLine("added");

var student = trainingDbConttext.vvvvv.Where(x => x.Name == "Tttt").FirstOrDefault();

StuCourse courseStudent = new StuCourse();
courseStudent.cSSS = course;
courseStudent.sSSS = student;
trainingDbConttext.stuCourses.Add(courseStudent);
trainingDbConttext.SaveChanges();
Console.WriteLine("added");

*/

ClassSchedule classSchedule = new ClassSchedule();
classSchedule.startTime = TimeSpan.Parse("14:47:13.8902232");
classSchedule.endTime = TimeSpan.Parse("14:47:13.8902232");
classSchedule.Weekday = "Mon";
classSchedule.cSSS = course;
classSchedule.ToTalClass = 20;
trainingDbConttext.classSchedules.Add(classSchedule);
trainingDbConttext.SaveChanges();
Console.WriteLine("added");

DateTime aDate = DateTime.Now;

Console.WriteLine(aDate.ToString("ddd"));
TimeSpan CurrentTime = DateTime.Now.TimeOfDay;
Console.WriteLine(CurrentTime);
TimeSpan start = TimeSpan.Parse("14:47:13.8902232"); // 10 PM
TimeSpan end = TimeSpan.Parse("14:50:13.8902232");   // 2 AM
TimeSpan now = DateTime.Now.TimeOfDay;
Console.WriteLine(now);

if (start <= end)
{
    // start and stop times are in the same day
    if (now >= start && now <= end)
    {
        // current time is between start and stop
        Console.WriteLine("between start and stop");
    }
    else
    {
        // start and stop times are in different days
        Console.WriteLine("beppp");
    }

}
else
{
    // start and stop times are in different days
    Console.WriteLine("between start and88 stop");
}

Console.ReadKey();