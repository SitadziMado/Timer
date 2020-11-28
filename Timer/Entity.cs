﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    [Serializable]
    public class Entity
    {
        public DateTime startDate { get; set; }
        public DateTime stopDate { get; set; }
        public TimeSpan timeSpan { get; set; }
        
        public Entity()
        {

        }

        public Entity(DateTime start, DateTime stop, TimeSpan span)
        {
            startDate = start;
            stopDate = stop;
            timeSpan = span;
        }
    }
}
