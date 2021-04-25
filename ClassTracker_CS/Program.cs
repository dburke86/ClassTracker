using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTracker_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCourse credCourse = new CreditCourse();

            credCourse._courseTitle = "CS101";
            credCourse._creditHours = 6;
            credCourse._program = "Computer Science";
            credCourse.EnrollStudent("Danny Burke");
            float GPA = credCourse.CalculateGPA(98.5F);
            Console.WriteLine("Danny Burke has a GPA of {0} in course {1}.", GPA, credCourse._courseTitle);

            NonCreditCourse nonCredCrse = new NonCreditCourse();
            nonCredCrse._courseTitle = "Introduction to Excel";
            
            char grade = nonCredCrse.CalculateGrade(87.0F);

            Console.WriteLine("Danny also received a {0} in {1}.", grade, nonCredCrse._courseTitle);

            CreditCourse newCredCourse = new CreditCourse();
            Console.WriteLine(newCredCourse._courseTitle);

            CreditCourse newCredCourseTwo = new CreditCourse("CS102", 6, "Computer Science");
            Console.WriteLine(newCredCourseTwo._courseTitle);
        }
    }
}
