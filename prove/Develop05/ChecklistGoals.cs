using System;

namespace Develop05
{
    public class Checklist : Goal
    {
        int _timesCompleted;
        int _timesToComplete;
        public Checklist(string goalName, string description, int points, int timesToComplete, int timesCompleted = 0): base(goalName, description, points)
        {
            _timesCompleted = timesCompleted;
            _timesToComplete = timesToComplete;
        }

        public override int CalculateScore()
        {
            int score = _timesCompleted * _points;
            return score;
        }

        public override void Complete()
        {
            _timesCompleted++;
        }

        public override string GetInfo()
        {
            return $"[{(_timesCompleted >= _timesToComplete?"X": " ")}] {_name}: {_description} -- Currently completed: {_timesCompleted}/{_timesToComplete} time{(_timesToComplete==1?"":"s")}";
        }

        public override string Serialize()
        {
            return $"ChecklistGoal:|{_name}|{_description}|{_points}|{_timesToComplete}|{_timesCompleted}";
        }
    }
}