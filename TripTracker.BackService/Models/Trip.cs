﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset StartDateTIme { get; set; }
        public DateTimeOffset EndDateTime { get; set; }

    }
}
