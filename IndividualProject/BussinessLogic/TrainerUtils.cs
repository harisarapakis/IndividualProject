using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.Models;

namespace IndividualProject.BussinessLogic
{

    class TrainerUtils:BaseUtils
    {
        private List<Trainer> _trainers;

        public List<Trainer> Trainers {
            get { return _trainers; }
            set { _trainers = value; }
        }
        public TrainerUtils()
        {
            Console.WriteLine("Do you want to input trainers?");
            string read = Console.ReadLine();
            if (read == "yes")
            {
                GetTrainerDetails();
            }
            else
            { this.start(); }
        }
        Trainer trainer = new Trainer();
        public Trainer GetTrainerDetails(List<string> subjects = null)

        {
             if (subjects == null) subjects = new List<string>() { "C#", "Java", "Javescript", "Python", "PHP" };
             trainer.FirstName = AskDetail("Give me yout first name");
             trainer.LastName = AskDetail("Give me yout last name");
             trainer.Subject = AskDetail("Give me the subject you teach", subjects);

            Console.WriteLine(trainer);
            return trainer;
        }

        public void start()
        {
            this._trainers = new List<Trainer>();
            Console.WriteLine("Pre Defined Trainer");
            this.PreDefinedCourses("First Name", "Haris", this._trainers);
            this.PreDefinedCourses("Last Name", "Arapakis", this._trainers);
            this.PreDefinedCourses("Subject", "C#", this._trainers);


        }
        public void PreDefinedCourses(string couseCategorie,
            string CourseProps, List<Trainer> trainers)
        {
            Console.Write($"{couseCategorie}:");
            Trainer c = new Trainer(CourseProps);
            trainers.Add(c);

        }



    }
}
