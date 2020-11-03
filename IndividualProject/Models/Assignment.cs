using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Assignment
    {
        private string _title; //"Individual Project Part A"
        private string _description; //"A private school that has Course , Trainer, Assigment, Student"
        private string _subDateTime;// 10/01/1900
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

        public string SubDateTime
        {
            get { return (this._subDateTime); }
            set { this._subDateTime = value.ToUpper(); }
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

        public override string ToString()
        {
            return ($"Title: {_title}\tDescription: {_description}\tSubDateTime: {_subDateTime}\tOralMark{_oralMark}\tTotalMark{_totalMark}");
        }
    }
}
