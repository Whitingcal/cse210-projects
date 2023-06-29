using System;

namespace Develop05
{
    public abstract class Goal
    {
        protected string _name;
        protected string _description;
        protected int _points;

        public Goal(string name, string description, int points) 
        {
            _name = name;
            _description = description;
            _points = points;
        }
        
        public abstract int CalculateScore();

        public abstract void Complete();

        public abstract string GetInfo();

        public abstract string Serialize();

    }
}