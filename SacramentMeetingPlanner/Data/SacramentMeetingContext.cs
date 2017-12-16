using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentMeetingContext : DbContext
    {
        public SacramentMeetingContext (DbContextOptions<SacramentMeetingContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentMeetingPlanner.Models.PlannedMeeting> PlannedMeeting { get; set; }
    }
}
