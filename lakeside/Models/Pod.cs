using System;
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
        public string Price { get; set; }
        public string Capacity { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public int PodID { get; set; }

        public Pod()
        {
            FriendlyName = "";
            Description = "";
            Price = "";
            Capacity = "";
            Type = "";
            Location = "";
            PodID = 0;
        }

        public Pod(string friendlyName, string description, string price, string capacity, string type, string location, int podID)
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
