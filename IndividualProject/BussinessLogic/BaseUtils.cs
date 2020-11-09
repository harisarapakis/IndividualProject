using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BussinessLogic
{
    class BaseUtils
    {
        private string _name;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public string AskDetail(string message, List<string> subjects = null)
        {
            string result = "";
            Console.Write(message + ": ");
            if (subjects != null)
            {
                // ASK FOR THE SUBJECT THE TRAINER TEACHES
                result = SelectFromListOfStrings(subjects);
            }
            else
            {
                result = Console.ReadLine();
            }

            return result;
        }
        public string SelectFromListOfStrings(List<string> elements)
        {
            string result = "";
            int counter = 1;
            Console.WriteLine();
            foreach (var item in elements)
            {
                Console.WriteLine($"{counter++}. {item}");
            }
            int choise = Convert.ToInt32(Console.ReadLine()); // kapoio while kati gia 1-5

            while (choise>elements.Count())
            {
                Console.WriteLine("Something went wrong. Type again!!!");
                choise = Convert.ToInt32(Console.ReadLine());
            }
            result = elements.ElementAt(choise - 1); //elements[choise-1];

            return result;
        }
    }
}
