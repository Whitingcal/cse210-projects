using System;

namespace Develop05
{
    public class Eternal : Goal
    {
      int _timesCompleted;

        public Eternal(string name, string description, int points, int timesCompleted = 0): base(name, description, points) 
        {
            _timesCompleted = timesCompleted;
        }

        public override int CalculateScore() 
        {
            return _timesCompleted * _points;
        }

        public override void Complete() 
        {
            _timesCompleted++;
        }

        public override string GetInfo() 
        {
            return $"[ ] {_name}: {_description} -- Currently completed: {_timesCompleted} time{(_timesCompleted==1?"":"s")}";
        }

        public override string Serialize() 
        {
            return $"EternalGoal:|{_name}|{_description}|{_points}|{_timesCompleted}";
        }
    }
}