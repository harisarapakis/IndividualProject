using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;

namespace IndividualProject.BussinessLogic
{
    class TrainerPerCourseUtils:BaseUtils
    {
        public TrainerPerCourseUtils()
        {
            Console.WriteLine("Do you want to input a teacher?");
            string read = Console.ReadLine();
            while (read=="yes")
            {
                GetStudenDetails();
                Console.WriteLine("Do you want to input one more?");
                read= Console.ReadLine();

            }


            PrintTrainersPerCourse(trainerCoursesList);
            Console.WriteLine($"The number of students in the courses is {trainerCoursesList.Count}");

            Console.WriteLine("");


        }
        List<TrainerCourse> trainerCoursesList = new List<TrainerCourse>();

        TrainerCourse trainerCourse = new TrainerCourse();

        public TrainerCourse GetStudenDetails(List<string> subjects = null)
        {

            trainerCourse=new TrainerCourse();
            if (subjects == null) subjects = new List<string>() { "C#", "Java", "Javescript", "Python", "PHP" };

            trainerCourse.FirstName     = AskDetail("Give me yout first name");
            trainerCourse.LastName      = AskDetail("Give me yout last name");
            trainerCourse.Subject = AskDetail("Give me the subject you teach", subjects);

            trainerCoursesList.Add(trainerCourse);

            return trainerCourse;
        }

        public void PrintTrainersPerCourse(List<TrainerCourse> trainerCourses)
        {
            foreach (var item in trainerCourses)
            {
                Console.WriteLine(item);
            }
        }
    }
}
