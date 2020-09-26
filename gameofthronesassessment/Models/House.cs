using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameofthronesassessment.Models
{
    public class House
    {
        public string url { get; set; }
        public List<string> SwornMembers { get; set; }
        public gotcharacter[] characters;
    }
}
