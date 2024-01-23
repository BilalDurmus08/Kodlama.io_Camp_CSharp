using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_ClassIntro
{
    internal class ClassIntro
    {
        static void Main(string[] args)
        {
            string name = "Bilal";
            int age = 23;
            Course course1 = new Course();
            course1.CourseName = "Java";
            course1.Teacher = name;
            course1.NumberofWathing = 43;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Teacher = name;
            course2.NumberofWathing = 43;

            Course course3 = new Course();
            course3.CourseName = "Java";
            course3.Teacher = name;
            course3.NumberofWathing = 43;

            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (Course course in courses) { 
                Console.WriteLine(course.CourseName);   
            }

        }

        class Course {
            public string CourseName { get; set; }
            public string Teacher { get; set; }
            public int NumberofWathing { get; set; }
        }
    }

}
