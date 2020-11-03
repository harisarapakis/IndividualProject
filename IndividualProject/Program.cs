using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.BussinessLogic;

namespace IndividualProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPromtUtils cpUtils = new CommandPromtUtils();
            //Trainer trainer = cpUtils.GetTrainerDetails();
            //Trainer trainer2 = cpUtils.GetTrainerDetails();

            //Console.WriteLine(trainer); Console.WriteLine(trainer2);

            List<Trainer> trainers = new List<Trainer>();
            trainers.Add(cpUtils.GetTrainerDetails());
            cpUtils.PrintTrainersList(trainers);

            List<Course> courses = new List<Course>();
            courses.Add(cpUtils.GetCourseDetails());
            cpUtils.PrintCourseList(courses);

            List<Student> students = new List<Student>();
            students.Add(cpUtils.GetStudenDetails());
            cpUtils.PrintStudentList(students);

            List<Assignment> assignments = new List<Assignment>();
            assignments.Add(cpUtils.GetAssigmentDetails());
            cpUtils.PrintAssigmenttList(assignments);
        }
    }
}

// creat appropriate methods in order to ask from the user data four main classes