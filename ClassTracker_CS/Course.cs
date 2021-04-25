using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTracker_CS
{
    class Course
    {
        //private variables
        private string courseTitle;
        private int creditHours;
        private string program;

        //public variables
        public string _courseTitle
        {
            get { return courseTitle; }
            set { courseTitle = value; }
        }

        public int _creditHours
        {
            get { return creditHours; }
            set { creditHours = value; }
        }

        public string _program
        {
            get { return program; }
            set { program = value; }
        }
        //public methods
        public void EnrollStudent(string studentName)
        {

        }

        public virtual float CalculateAverage(float[] arrGrades)
        {
            float avg = 0;
            return avg;
        }
    }
}
