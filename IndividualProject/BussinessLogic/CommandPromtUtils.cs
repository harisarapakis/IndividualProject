using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
namespace IndividualProject.BussinessLogic
{
    class CommandPromtUtils

    {
        public Trainer GetTrainerDetails(List<string> subjects=null)

        {
            if (subjects == null) subjects=new List<string>() { "C#", "Jave", "Javescript", "Python", "PHP" };
        
            Trainer trainer = new Trainer();
            trainer.FirstName = AskDetail("Give me yout first name");
            trainer.LastName  = AskDetail("Give me yout last name");
            
            trainer.Subject   = AskDetail("Give me the subject you teach",subjects);

            return trainer;
            }

        public Course GetCourseDetails(List<string> subjects = null)
        {
            Course course = new Course();
            course._title     = AskDetail("Give me the title of your course");
            course._stream    = AskDetail("Whats your stream");
            course._type      = AskDetail("Whats is your type");
            course.Start_date = AskDetail("Tell me the start_date");
            course.End_date   = AskDetail("Tell me the end_date");

            return course;
        }

        public Student GetStudenDetails(List<string> subjects = null)
        {
            Student student = new Student();
            student.FirstName = AskDetail("Give me yout first name");
            student.LastName = AskDetail("Give me yout last name");
            student.DateOfBirth = AskDetail("Give me your Date of birth");
            student.Tutionfees = AskDetail("This is the tution fees");
            

            return student;
        }

        public Assignment GetAssigmentDetails(List<string> subjects = null)
        {
            Assignment assignment = new Assignment();
            assignment.Title = AskDetail("Give me the title of your assigment");
            assignment.Description = AskDetail("Give me the description");
            assignment.SubDateTime = AskDetail("Give me the Subdatetime");
            assignment.OralMark = AskDetail("Whats the oralMark");
            assignment.TotalMark = AskDetail("Whats the totalMark");



            return assignment;
        }


        private string AskDetail(string message, List<string> subjects = null)
        {
            //            subjects.Add("C#","Jave","Javescript","Python","PHP");
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

    
        private string SelectFromListOfStrings(List<string> elements)
        {
            string result = "";
            int counter = 1;
            Console.WriteLine();
            foreach (var item in elements)
            {
                Console.WriteLine($"{counter++}. {item}");
                
            }
            int p = 0;
            while(p<=5)
            {    
                int choise = Convert.ToInt32(Console.ReadLine()); // kapoio while kati gia 1-5
                result = elements.ElementAt(choise - 1); //elements[choise-1];
                p++;
                }

            return result;
        }
        
        public void PrintTrainersList(List<Trainer> trainers)
        {
            foreach (var item in trainers)

            {
                Console.WriteLine(item);
            }
        }

        public void PrintCourseList(List<Course> courses)
        {
            foreach (var item in courses)

            {
                Console.WriteLine(item);
            }
        }

        public void PrintStudentList(List<Student> students)
        {
            foreach (var item in students)

            {
                Console.WriteLine(item);
            }
        }
        public void PrintAssigmenttList(List<Assignment> assignments)
        {
            foreach (var item in assignments)

            {
                Console.WriteLine(item);
            }
        }

    }
}

