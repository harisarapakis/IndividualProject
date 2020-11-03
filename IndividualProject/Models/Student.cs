using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Student
    {
        private string _firstname; //{ get; set;}
        private string _lastname;
        private string _dateofbirth;
        private string _tutionfees;

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

        public string DateOfBirth
        {
            get { return (this._dateofbirth); }
            set { this._dateofbirth = value.ToUpper(); }
        }
        public string Tutionfees
        {
            get { return (this._tutionfees); }
            set { this._tutionfees = value.ToUpper(); }
        }

        public override string ToString()
        {
            return ($"First Name: {_firstname}\tLast Name: {_lastname}\tDate of birth: {_dateofbirth}\tTution fees{_tutionfees}");
        }
    }
}
