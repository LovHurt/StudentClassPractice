using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace StudentClassPractice
{
    public class Student
    {
        private int StudentNumber;
        private string StudentName;
        private string StudentSurname;
        private int midterm1;
        private int midterm2;
        private int final;
        private string SchoolName;


        public Student(int _studentNumber, string _studentName, string _studentSurname, int _midterm1, int _midterm2, int _final, string _schoolName)
        {
                StudentNumber = _studentNumber;
                StudentName = _studentName;
                StudentSurname = _studentSurname;
                midterm1 = _midterm1;
                midterm2 = _midterm2;
                final = _final;
                SchoolName = _schoolName;
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine("Student name is : "+StudentName);
            Console.WriteLine("Student surname is : " + StudentSurname);
            Console.WriteLine("Student number is : " +StudentNumber);
        }

        public double ShowStudentAvg()
        {
            double ortalama = midterm1 * 0.2 + midterm2 * 0.2 + final * 0.6;

            return ortalama;
        }

        public void ShowSchoolName()
        {
            Console.WriteLine("Student's Schoolname is : "+SchoolName);
        }
    }
}
