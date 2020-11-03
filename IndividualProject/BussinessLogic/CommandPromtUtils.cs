using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BussinessLogic
{
    class CommandPromtUtils
    {
        public Trainer GetTrainerDetails()
        {
            Trainer trainer = new Trainer();
            trainer.FirstName = AskDetail("Give me yout first name");
            trainer.LastName  = AskDetail("Give me yout last name");
            trainer.Subject   = AskDetail("Give me the subject you teach");

            return trainer;
            }

        private string AskDetail(string message)
        {
            string result = "";
            Console.Write(message+": ");
            result = Console.ReadLine();
            return result;
        }
        





        }
}

