using System;

namespace FinalProgect
{
    public abstract class Event
    {
        private DateTime _date;
        private string _name;

        public Event (DateTime date, string name){
            _date = date;
            _name = name;
        }

        public DateTime GetDate(){
            return _date;
        }

        public string GetName(){
            return _name;
        }

        public override string ToString()
        {
            return $"{_date}|{_name}";
        }

    }
}