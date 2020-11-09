using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class TrainerCourse
    {
        private string _firstname; //{ get; set;}
        private string _lastname;
        private string _subject;

        public string FirstName
        {
            get { return (this._firstname); }
            set { this._firstname = value.ToUpper(); }
        }

        public string LastName
        {
            get { return (this._lastname); }
            set { this._lastname = value.ToUpper(); }
        }

        public string Subject
        {
            get { return (this._subject); }
            set { this._subject = value.ToUpper(); }
        }
        

        public override string ToString()
        {
            return ($"First Name: {_firstname}\tLast Name: {_lastname}\tSubject: {_subject}");
        }
    }
}
