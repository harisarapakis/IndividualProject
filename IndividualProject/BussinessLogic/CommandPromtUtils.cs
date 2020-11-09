//using IndividualProject.Models;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Runtime.Remoting.Messaging;
//using System.Text;
//using System.Threading.Tasks;
//namespace IndividualProject.BussinessLogic
//{
//    class CommandPromtUtils 

//    {

//        public Trainer GetTrainerDetails(int counter,List<string> subjects = null)

//        {
//            for (int i = 0; i < counter; i++)
            

            
//            {
//                if (subjects == null) subjects = new List<string>() { "C#", "Java", "Javescript", "Python", "PHP" };
//                Trainer trainer1 = new Trainer();
//                trainer1.FirstName = AskDetail("Give me yout first name");
//                trainer1.LastName = AskDetail("Give me yout last name");
//                trainer1.Subject = AskDetail("Give me the subject you teach", subjects);


//                return trainer1;
//            }
//            if (subjects == null) subjects = new List<string>() { "C#", "Java", "Javescript", "Python", "PHP" };
//            Trainer trainer = new Trainer();
//            trainer.FirstName = AskDetail("Give me yout first name");
//            trainer.LastName = AskDetail("Give me yout last name");
//            trainer.Subject = AskDetail("Give me the subject you teach", subjects);


//            return trainer;

//        }
      
//        private string AskDetail(string message, List<string> subjects = null)
//        {
//            string result = "";
//            Console.Write(message + ": ");
//            if (subjects != null)
//            {
//                // ASK FOR THE SUBJECT THE TRAINER TEACHES
//                result = SelectFromListOfStrings(subjects);
//            }
//            else
//            {
//                result = Console.ReadLine();
//            }

//            return result;
//        }

//        private string SelectFromListOfStrings(List<string> elements)
//        {
//            string result = "";
//            int counter = 1;
//            Console.WriteLine();
//            foreach (var item in elements)
//            {
//                Console.WriteLine($"{counter++}. {item}");
//            }
//            int choise = Convert.ToInt32(Console.ReadLine()); // kapoio while kati gia 1-5
            
//            while (choise>elements.Count())
//            {
//                Console.WriteLine("Something went wrong. Type again!!!");
//                choise = Convert.ToInt32(Console.ReadLine());
//            }
//            result = elements.ElementAt(choise - 1); //elements[choise-1];

//            return result;
//        }



//        public Course GetCourseDetails(List<string> titles = null, List<string> stream = null, List<string> type = null)
//        {

//            if (titles == null) titles = new List<string>() { "CB8", "CB7" };
//            if (stream == null) stream = new List<string>() { "Java", "C#" };
//            if (type == null) type = new List<string>() { "Full Time", "Part Time" };

//            Course course = new Course();
//            course._title     = AskDetail("Give me the title of your course", titles);
//            course._stream    = AskDetail("Whats your stream", stream);
//            course._type      = AskDetail("Whats is your type", type);
//            course.Start_date = AskDetail("Tell me the start_date");
//            course.End_date   = AskDetail("Tell me the end_date");

//            return course;
//        }

//        public Student GetStudenDetails(List<string> subjects = null)
//        {
//            Student student = new Student();
//            student.FirstName = AskDetail("Give me yout first name");
//            student.LastName = AskDetail("Give me yout last name");
//            student.DateOfBirth = AskDetail("Give me your Date of birth");
//            student.Tutionfees = AskDetail("This is the tution fees");


//            return student;
//        }

//        public Assignment GetAssigmentDetails(List<string> subjects = null)
//        {
//            Assignment assignment = new Assignment();
//            assignment.Title = AskDetail("Give me the title of your assigment");
//            assignment.Description = AskDetail("Give me the description");
//            assignment.SubDateTime = AskDetail("Give me the Subdatetime");
//            assignment.OralMark = AskDetail("Whats the oralMark");
//            assignment.TotalMark = AskDetail("Whats the totalMark");



//            return assignment;
//        }

//        public void PrintTrainersList(List<Trainer> trainers)
//        {
//            foreach (var item in trainers)

//            {
//                Console.WriteLine(item);
//            }
//        }

//        public void PrintCourseList(List<Course> courses)
//        {
//            foreach (var item in courses)

//            {
//                Console.WriteLine(item);
//            }
//        }

//        public void PrintStudentList(List<Student> students)
//        {
//            foreach (var item in students)

//            {
//                Console.WriteLine(item);
//            }
//        }
//        public void PrintAssigmenttList(List<Assignment> assignments)
//        {
//            foreach (var item in assignments)

//            {
//                Console.WriteLine(item);
//            }
//        }

//    }
//}

