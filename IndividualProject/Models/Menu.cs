using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.BussinessLogic;

namespace IndividualProject.Models
{
    class Menu
    {
        List<Student> students = new List<Student>();// --> ayti exei olous toys mathites
        List<Trainer> trainers = new List<Trainer>();
        List<Assignment> assigments = new List<Assignment>();
        List<Course> courses = new List<Course>();
        public Menu(List<Student> students, List<Trainer> trainers,
            List<Assignment> assigments, List<Course> courses)
        {
            StudentsPerCourseUtils studentsToCourses = new StudentsPerCourseUtils();
            //foreach (var item in studentsToCourses.studentCourses1)
            //{
            //    Console.WriteLine(item.C);
            //    students.Add(item)
            //}
        }
    }
}
