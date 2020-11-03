using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Course
    {
        public string _title;                                                   // CB12 Full Time C#
        public string _stream;                                                  //C# // Java,Javascript,Python
        public string _type;                                                    //"Full Time // Part Time,Online,
        public string _start_date;                                              //01/01/1900
        public string _end_date;                                                //31/3/1900

        public string Title
        {
            get { return (this._title); }
            set { this._title = value.ToUpper(); }
        }
        public string Stream
        {
            get { return (this._stream); }
            set { this._stream = value.ToUpper(); }
        }
        public string Type
        {
            get { return (this._type); }
            set { this._type = value.ToUpper(); }
        }
        public string Start_date
        {
            get { return (this._start_date); }
            set { this._start_date = value.ToUpper(); }
        }
        public string End_date
        {
            get { return (this._end_date); }
            set { this._end_date = value.ToUpper(); }
        }

        public override string ToString()
        {
            return ($"Title: {_title}\tStream: {_stream}\tType: {_type}\tStar_date: {_start_date}\tEnd_date: {_end_date}");
        }

    }
}
