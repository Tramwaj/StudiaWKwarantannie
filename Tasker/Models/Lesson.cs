﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasker.Models
{
    public enum LessonType
    {
        Lecture = 0,
        Lab = 1
    }
    public enum LessonStatus
    {
        Planned = 0,
        InProgress = 1,
        Finished = 2
    }
    [Serializable]
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Lesson : Activity
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public TimeSpan Duration { get; set; }
        public LessonType Type { get; set; }

        public Lesson(Subject subject, DateTime time, TimeSpan duration, LessonType type) : base(subject, time)
        {
            Duration = duration;
            Type = type;
            PlaceOnDisk = new List<string>();
        }
        //TODO: tidy all constructors, 
        //and probably change Links to objects (same with Places??)
        public override Status Status
        {
            get => DateTime.Now < Time ? Status.Scheduled :
                DateTime.Now < Time + Duration ? Status.InProgress :
                Status.Finished;
            set =>Status = Status;
        }
        public bool Equals(Lesson other)
        {
            return Type == other.Type;
        }
        public override bool Equals(object obj)
        {
            if (obj is Lesson)
            {
            return base.Equals(obj)
                    && Equals(obj as Lesson);
            }
            return false;
        }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());
            return sb
                .Append(" (")
                .Append(Duration.Hours)
                .Append("h")
                .Append(Duration.Minutes)
                .Append(") - ")
                .Append(Type)
                .ToString();
        }
    }
}
