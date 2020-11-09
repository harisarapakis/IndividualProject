using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.BussinessLogic;

namespace IndividualProject.Models
{
    class PrivateSchool
    {

        List<Student> students = new List<Student>();// --> ayti exei olous toys mathites
        List<Trainer> trainers = new List<Trainer>();
        List<Assignment> assigments = new List<Assignment>();
        List<Course> courses = new List<Course>();

        public PrivateSchool()
        {
            //CourseUtils courseutils = new CourseUtils();
            //TrainerUtils trainerUtils = new TrainerUtils();
            //StudentsUtils studentsUtils = new StudentsUtils();
            //AssigmentsUtils assigmentsUtils = new AssigmentsUtils();
            //StudentsPerCourseUtils studentsToCourses =new StudentsPerCourseUtils();
            //TrainerPerCourseUtils trainerPerCourseUtils = new TrainerPerCourseUtils();
            //AssigmentsPerCourseUtils assigmentsPerCourseUtils = new AssigmentsPerCourseUtils();
            //StudentsCourseAssigments studentsCourseAssigments = new StudentsCourseAssigments();
            Menu m = new Menu(students, trainers, assigments, courses);

        }





    }

}
    
