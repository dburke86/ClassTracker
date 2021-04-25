using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTracker_CS
{
    class NonCreditCourse : Course
    {
        /*public override float CalculateAverage(float[] arrGrades)
        {
            {
                float avg = 0;
                float sum = 0;
                int numGrades = arrGrades.Count();
                foreach (float grade in arrGrades)
                {
                    sum = sum + grade;
                }
                avg = sum / numGrades;
                return avg;
            }
        }*/
        public char CalculateGrade(float grade)
        {
            char letterGrade;
            
            if (grade >= 90)
            {
                letterGrade = 'A';
            }
            else if (grade >= 80 && grade <= 89)
            {
                letterGrade = 'B';
            }
            else if (grade >= 70 && grade <= 79)
            {
                letterGrade = 'C';
            }
            else if (grade >= 60 && grade <= 69)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            /*switch (letterGrade)
            {
                case 'A':
                    gradePoints = 4.0F;
                    break;

                case 'B':
                    gradePoints = 3.0F;
                    break;

                case 'C':
                    gradePoints = 2.0F;
                    break;

                case 'D':
                    gradePoints = 1.0F;
                    break;
            }*/
            return letterGrade;
        }
    }
}
