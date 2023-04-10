using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_App.Data
{
    public class InitDb
    {
        public static void Initialize(Context context)
        {
          
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var TaiLieu = new TaiLieu[]
            {
            };

            context.Students.AddRange();
            context.SaveChanges();

            var NguoiDung = new NguoiDung[]
            {
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID102=1,CourseID102=1050,Grade=Grade.A},
                new Enrollment{StudentID102=1,CourseID102=4022,Grade=Grade.C},
                new Enrollment{StudentID102=1,CourseID102=4041,Grade=Grade.B},
                new Enrollment{StudentID102=2,CourseID102=1045,Grade=Grade.B},
                new Enrollment{StudentID102=2,CourseID102=3141,Grade=Grade.F},
                new Enrollment{StudentID102=2,CourseID102=2021,Grade=Grade.F},
                new Enrollment{StudentID102=3,CourseID102=1050},
                new Enrollment{StudentID102=4,CourseID102=1050},
                new Enrollment{StudentID102 = 4, CourseID102 = 4022,Grade=Grade.F},
                new Enrollment{StudentID102 = 5, CourseID102 = 4041,Grade=Grade.C},
                new Enrollment{StudentID102 = 6, CourseID102 = 1045},
                new Enrollment{StudentID102 = 7, CourseID102 = 3141,Grade=Grade.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
