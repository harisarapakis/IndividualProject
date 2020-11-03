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
            Trainer trainer = cpUtils.GetTrainerDetails();
            Trainer trainer2 = cpUtils.GetTrainerDetails();

            Console.WriteLine(trainer); Console.WriteLine(trainer2);

        }
    }
}

// creat appropriate methods in order to ask from the user data four main classes