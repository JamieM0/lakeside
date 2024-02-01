﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lakeside.Models
{
    public class Pod
    {
        public string FriendlyName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public int PodID { get; set; }

        public Pod()
        {
            FriendlyName = "";
            Description = "";
            Price = 0.0;
            Capacity = 0;
            Type = "";
            Location = "";
            PodID = 0;
        }

        public Pod(string friendlyName, string description, double price, int capacity, string type, string location, int podID)
        {
            FriendlyName = friendlyName;
            Description = description;
            Price = price;
            Capacity = capacity;
            Type = type;
            Location = location;
            PodID = podID;
        }
    }
}
