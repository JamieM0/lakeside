using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lakeside.Models
{
    public class Extra
    {
        public int ExtraID { get; set; }
        public string ExtraName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Extra(int extraID, string extraName, string description, double price)
        {
            ExtraID = extraID;
            ExtraName = extraName;
            Description = description;
            Price = price;
        }

        public Extra()
        {
            ExtraID = 0;
            ExtraName = "";
            Description = "";
            Price = 0;
        }
    }
}
