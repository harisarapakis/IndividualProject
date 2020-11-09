using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;

namespace IndividualProject.BussinessLogic
{
    class StudentsUtils:BaseUtils
    {

        private List<Student> _students;

        public List<Student> Students {
            get { return _students; }
            set { _students = value; }
        }
        public StudentsUtils()
        {
            Console.WriteLine("Do you want to input student?");
            string read = Console.ReadLine();
            if (read == "yes")
            {
                GetStudenDetails();
            }
            else
            { this.start(); }
        }
        Student student = new Student();
        public Student GetStudenDetails(List<string> subjects = null)
        {
            student.FirstName = AskDetail("Give me yout first name");
            student.LastName = AskDetail("Give me yout last name");
            Console.Write("Give me the date of birth");
            student.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            student.Tutionfees = AskDetail("This is the tution fees");

            Console.WriteLine(student);
            return student;
        }

        public void start()
        {
            this._students = new List<Student>();
            Console.WriteLine("Pre Defined Student");
            this.PreDefinedCourses("First Name", "Haris", this._students);
            this.PreDefinedCourses("Last Name", "Arapakis", this._students);
            this.PreDefinedCourses("Date Of Birth", "17/10/1996", this._students);
            this.PreDefinedCourses("Tutionfees", "2500", this._students);



        }
        public void PreDefinedCourses(string Categorie,
            string Props, List<Student> students)
        {
            Console.Write($"{Categorie}:");
            Student c = new Student(Props);
            students.Add(c);

        }

        
    }
}
