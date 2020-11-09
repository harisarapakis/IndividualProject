using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;

namespace IndividualProject.BussinessLogic
{
    class AssigmentsPerCourseUtils:BaseUtils
    {
        public AssigmentsPerCourseUtils()
        {
            Console.WriteLine("Do you want to input an assigment?");
            string read = Console.ReadLine();
            while (read=="yes")
            {
                GetStudenDetails();
                Console.WriteLine("Do you want to input one more?");
                read= Console.ReadLine();

            }

            PrintAssigmentPerCourse(assigmentCoursesList);
            Console.WriteLine($"The number of assigments in the courses is {assigmentCoursesList.Count}");

            Console.WriteLine("");

           
        }
        List<AssigmentsCourse> assigmentCoursesList = new List<AssigmentsCourse>();

        AssigmentsCourse assigmentsCourse = new AssigmentsCourse();

        public AssigmentsCourse GetStudenDetails(List<string> courses = null)
        {

            assigmentsCourse=new AssigmentsCourse();
            if (courses == null) courses = new List<string>() { "C#", "Java", "Python" };

            assigmentsCourse.Title = AskDetail("Give me the title of your assigment");
            assigmentsCourse.Description = AskDetail("Give me the description");
            Console.Write("Give me the sub date time");
            assigmentsCourse.SubDateTime = Convert.ToDateTime(Console.ReadLine());
            assigmentsCourse.TotalMark = AskDetail("Whats the totalMark");
            assigmentsCourse.Choosecourse=AskDetail("Choose between this courses", courses);
            assigmentCoursesList.Add(assigmentsCourse);

            return assigmentsCourse;
        }

        public void PrintAssigmentPerCourse(List<AssigmentsCourse> assigmentsCourse)
        {
            foreach (var item in assigmentsCourse)
            {
                Console.WriteLine(item);
            }
        }
    }
}
