using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSYFinalAttempt
{
     public class Meeting
    {
        public string Location { get; set; }
        public DateTime DateTime { get; set; }
        public string[] MeetingTopics { get; set; }

        // Constructors
        public Meeting(string location, DateTime dateTime, string[] meetingTopics)
        {
            Location = location;
            DateTime = dateTime;
            MeetingTopics = meetingTopics;
        }
    }
}
