using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;

namespace IndividualProject.BussinessLogic
{
    class CourseUtils : BaseUtils
    {
        private List<Course> _courses;

        public List<Course> Courses {
            get { return _courses; }
            set { _courses = value; }
        }


        public CourseUtils()
        {
            Console.WriteLine("Do you want to input courses?");
            string read = Console.ReadLine();
            if (read == "yes")
            {
                GetCourseDetails();
            }
            else
            { this.start(); }
        }
        public CourseUtils(List<TrainerUtils> trainerUtils)
        {

        }
        Course course = new Course();
        public Course GetCourseDetails(List<string> titles = null, List<string> stream = null, List<string> type = null)
        {

            if (titles == null) titles = new List<string>() { "CB8", "CB7" };
            if (stream == null) stream = new List<string>() { "Java", "C#" };
            if (type == null) type = new List<string>() { "Full Time", "Part Time" };

            course._title     = AskDetail("Give me the title of your course", titles);
            course._stream    = AskDetail("Whats your stream", stream);
            course._type      = AskDetail("Whats is your type", type);
            Console.Write("Give me the start date");
            course.Start_date = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Give me the end date");
            course.End_date   = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(course);
            
            return course;

        }
        
        



        public void start()
        {
            this._courses = new List<Course>();
            Console.WriteLine("Pre Defined Courses");
            this.PreDefinedCourses("Title", "CB8", this._courses);
            this.PreDefinedCourses("Stream", "Java", this._courses);
            this.PreDefinedCourses("Type", "Full Time", this._courses);
            this.PreDefinedCourses("Start date", "11/1/2020", this._courses);
            this.PreDefinedCourses("End date", "11/3/2020", this._courses);


        }
        public void PreDefinedCourses(string couseCategorie,
            string CourseProps, List<Course> courses)
        {
            Console.Write($"{couseCategorie}:");
            Course c = new Course(CourseProps);
            courses.Add(c);





        }

    }

}
