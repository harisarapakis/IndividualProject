using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class AssigmentsCourse
    {
        private string _title; //"Individual Project Part A"
        private string _description; //"A private school that has Course , Trainer, Assigment, Student"
        private DateTime _subDateTime;// 10/01/1900
        private string _oralMark; // 20
        private string _totalMark; // 80

        public string Title
        {
            get { return (this._title); }
            set { this._title = value.ToUpper(); }
        }

        public string Description
        {
            get { return (this._description); }
            set { this._description = value.ToUpper(); }
        }

        public DateTime SubDateTime
        {
            get { return (this._subDateTime); }
            set { this._subDateTime = value; }
        }
        public string OralMark
        {
            get { return (this._oralMark); }
            set { this._oralMark = value.ToUpper(); }
        }
        public string TotalMark
        {
            get { return (this._totalMark); }
            set { this._totalMark = value.ToUpper(); }
        }
        private string _choosecourse;

        public string Choosecourse
        {
            get { return _choosecourse; }
            set { _choosecourse = value; }
        }
        public override string ToString()
        {
            return ($"Title: {_title}\tDescription: {_description}" +
                $"\tSubDateTime: {_subDateTime}\tOralMark:{_oralMark}\tTotalMark:{_totalMark}\tCourse:{_choosecourse}");
        }
    }
}
