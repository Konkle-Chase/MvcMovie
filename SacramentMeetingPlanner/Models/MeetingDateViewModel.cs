using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SacramentMeetingPlanner.Models
{
    public class MeetingDateViewModel
    {
        public List<PlannedMeeting> plannedMeetings;
        public SelectList meetings;
        public string meetingDate { get; set; }
    }
}
