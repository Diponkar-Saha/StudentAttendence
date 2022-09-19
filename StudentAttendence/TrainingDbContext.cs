using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace StudentAttendence
{
    public class TrainingDbContext: DbContext
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;

        public TrainingDbContext()
        {
            _connectionString = "Server=DESKTOP-8OIA8DB\\SQLEXPRESS;Database=inspectionapidb;User Id = sa; Password=1234;Encrypt=True;TrustServerCertificate=True; ";

            _assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseTeacher>().ToTable("CourseTeachers");
            modelBuilder.Entity<CourseTeacher>().HasKey(cs => new { cs.CSSSID, cs.TTTTTId });



            modelBuilder.Entity<CourseStudent>().ToTable("CourseStudent");
            modelBuilder.Entity<CourseStudent>().HasKey(cs => new { cs.CSSSID, cs.SSSId });

            modelBuilder.Entity<CourseStu>().ToTable("CourseStu");
            modelBuilder.Entity<CourseStu>().HasKey(cs => new { cs.CSSSID, cs.SSSId });

            modelBuilder.Entity<CourseStudd>().ToTable("CourseStudd");
            modelBuilder.Entity<CourseStudd>().HasKey(cs => new { cs.CSSSID, cs.SSSId });

            modelBuilder.Entity<StuCourse>().ToTable("StuCourses");
            modelBuilder.Entity<StuCourse>().HasKey(cs => new { cs.CSSSID, cs.SSSId });



            base.OnModelCreating(modelBuilder);
        }



        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<SSS> ssss { get; set; }

        public DbSet<TTTTT>tttt{ get; set; }

        public DbSet<VVVVV> vvvvv { get; set; }

        public DbSet<ClassTime> classTimes { get; set; }

        public DbSet<Course> courses { get; set; }

        public DbSet<CCCC> cccc { get; set; }

        public DbSet<CSSS> csss { get; set; }

        public DbSet<CourseTeacher> courseTeachers { get; set; }

        public DbSet<CourseStudent> courseStudents { get; set; }

        public DbSet<CourseStu> courseStus { get; set; }

        public DbSet<CourseStudd> courseStusdd { get; set; }

        public DbSet<StuCourse> stuCourses{ get; set; }

        public DbSet<ClassSchedule> classSchedules { get; set; }




    }
}
