using System;

namespace AstroBit.Ephemeris
{
    public struct TimeInterval
    {
        public TimeInterval(DateTime startTime, DateTime endTime, int intervalSize, IntervalUnit intervalUnit)
        {
            StartTime = startTime;
            EndTime = endTime;
            IntervalSize = intervalSize;
            IntervalUnit = intervalUnit;
        }

        public DateTime StartTime { get; }

        public DateTime EndTime { get; }

        public int IntervalSize { get; }

        public IntervalUnit IntervalUnit { get; }
    }
}
