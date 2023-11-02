using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool control = true;
            Student student1 = new Student(52, "Alican", "Dağıdır", 75, 95, 80, "Dgdr University");

            Console.WriteLine("Enter the given number between 1-4 to get the given information please");
            
            

            while (control)
            {
                ShowProcedures();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        student1.ShowStudentInfo();
                        break;
                    case "2":
                        double StudentAvg = student1.ShowStudentAvg();
                        Console.WriteLine("Student's avg is : " + StudentAvg);
                        break;
                    case "3":
                        student1.ShowSchoolName();
                        break;
                    case "4":
                        control = false;
                        break;
                }
            }
            
        }
        static void ShowProcedures()
        {
            Console.WriteLine("1 - Show Student Info");
            Console.WriteLine("2 - Show Students Average");
            Console.WriteLine("3 - Show Student's School");
            Console.WriteLine("4 - Log out from the system");
            Console.WriteLine("");
        }
    }
}
