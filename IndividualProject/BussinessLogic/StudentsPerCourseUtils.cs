using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.BussinessLogic;

namespace IndividualProject.Models
{
    class StudentsPerCourseUtils 
    {

        public List<StudentCourse> studentCourses1 = new List<StudentCourse>();

        public StudentsPerCourseUtils()
        {
            List<string> names = new List<string>();
            List<string> last = new List<string>();

            List<string> DoubleStudents= new List<string>();
            Console.WriteLine("Do you want to input a student?");
            string read = Console.ReadLine();
            while (read=="yes") 
            {   
                GetStudenDetails();
                Console.WriteLine("Do you want to input one more?");
                read= Console.ReadLine();
                names.Add(studentCourse.FirstName);
                last.Add(studentCourse.LastName);
                names.AddRange(last);

            }

            PrintStudentsPerCourse(studentCourses1);
            Console.WriteLine($"The number of students in the courses is {studentCourses1.Count}");

            Console.WriteLine("");

            
           


            var groups = names.GroupBy(f => f).Where(g => g.Count() > 1);
            foreach (var group in groups)
                Console.WriteLine($"Student {group.Key} belongs to more than one class");

        }

        void method()
        {
            
        }

        

        public StudentCourse studentCourse = new StudentCourse();
        
        public StudentCourse GetStudenDetails(List<string> courses = null)
        {
           
            studentCourse=new StudentCourse();
            if (courses == null) courses = new List<string>() { "C#", "Java", "Python"};
            studentCourse.Choosecourse=AskDetail("Choose between this courses", courses);

            studentCourse.FirstName     = AskDetail("Give me your first name");
            studentCourse.LastName      = AskDetail("Give me your last name");
            Console.Write("Give me the date of birth");
            studentCourse.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            studentCourse.Tutionfees    = AskDetail("This is the tution fees");

            studentCourses1.Add(studentCourse);
            
            return studentCourse;
        }


        public void PrintStudentsPerCourse(List<StudentCourse> studentCourses)
        {
            foreach (var item in studentCourses)
            {
                Console.WriteLine(item);
            }
        }




        public string AskDetail(string message, List<string> subjects = null)
        {
            string result = "";
            Console.Write(message + ": ");
            if (subjects != null)
            {
                // ASK FOR THE SUBJECT THE TRAINER TEACHES
                result = SelectFromListOfStrings(subjects);
            }
            else
            {
                result = Console.ReadLine();
            }

            return result;
        }
        public string SelectFromListOfStrings(List<string> elements)
        {
            string result = "";
            int counter = 1;
            Console.WriteLine();
            foreach (var item in elements)
            {
                Console.WriteLine($"{counter++}. {item}");
            }
            int choise = Convert.ToInt32(Console.ReadLine()); // kapoio while kati gia 1-5

            while (choise>elements.Count())
            {
                Console.WriteLine("Something went wrong. Type again!!!");
                choise = Convert.ToInt32(Console.ReadLine());
            }
            result = elements.ElementAt(choise - 1); //elements[choise-1];

            return result;
        }

    }
}
