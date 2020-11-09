using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;
namespace IndividualProject.BussinessLogic
{
    class AssigmentsUtils : StudentsPerCourseUtils
    {
        private List<Assignment> _assignments;

        public List<Assignment> Assignments {
            get { return _assignments; }
            set { _assignments = value; }
        }
        public AssigmentsUtils()
        {
            Console.WriteLine("Do you want to input assigment?");
            string read = Console.ReadLine();
            if (read == "yes")
            {
                GetAssigmentDetails();
            }
            else
            { this.start(); }
        }


        List<Assignment> assigmentsList = new List<Assignment>();

        Assignment assigments = new Assignment();
        public Assignment GetAssigmentDetails(List<string> subjects = null)
        {
            Assignment assignment = new Assignment();
            assignment.Title = AskDetail("Give me the title of your assigment");
            assignment.Description = AskDetail("Give me the description");
            Console.Write("Give me the sub date time");
            assignment.SubDateTime = Convert.ToDateTime(Console.ReadLine()); 
            assignment.OralMark = AskDetail("Whats the oralMark");
            assignment.TotalMark = AskDetail("Whats the totalMark");

            assigmentsList.Add(assigments);

            
            return assignment;
        }
        public void PrintAssigments(List<Assignment> assigments)
        {
            foreach (var item in assigments)
            {
                Console.WriteLine(item);
            }
        }

        public AssigmentsUtils(string name)
        {
            Console.WriteLine("Do you want to input an assigment for this student?");
            string read = Console.ReadLine();
            while (read=="yes")
            {

                GetAssigmentDetails();
                Console.WriteLine("Do you want to input one more?");
                read= Console.ReadLine();
            }

            PrintAssigments(assigmentsList);

            Console.WriteLine($"The number of assigments for studnet {studentCourse.FirstName} " +
                $"{studentCourse.LastName}" +
                $" in this courses is {assigmentsList.Count}");

            Console.WriteLine("");

        }
    
        public void start()
        {
            this._assignments = new List<Assignment>();
            Console.WriteLine("Pre Defined Assigments");
            this.PreDefinedCourses("Title", "Individual Program", this._assignments);
            this.PreDefinedCourses("Description", "Write a program for a private school", this._assignments);
            this.PreDefinedCourses("Sub Date Time", "10/11/2020", this._assignments);
            this.PreDefinedCourses("Oral Mark", "17", this._assignments);
            this.PreDefinedCourses("Total Mark", "95", this._assignments);


        }
        public void PreDefinedCourses(string Categorie,
            string Props, List<Assignment> assignments)
        {
            Console.Write($"{Categorie}:");
            Assignment c = new Assignment(Props);
            assignments.Add(c);

        }
    }
}
