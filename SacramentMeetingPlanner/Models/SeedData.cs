using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SacramentMeetingPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentMeetingContext(
                serviceProvider.GetRequiredService<DbContextOptions<SacramentMeetingContext>>()))
            {
                // Look for any movies.
                if (context.PlannedMeeting.Any())
                {
                    return;   // DB has been seeded
                }

                context.PlannedMeeting.AddRange(
                     new PlannedMeeting
                     {                        
                         Meeting = DateTime.Parse("2017-12-3"),
                         Conductor = "Bishop",
                         OpeningSong = "27",
                         StartPrayer = "Chase Konkle",
                         SacramentSong = "173",
                         Sacrament = "Sacrament",
                         SpeakerOne = "Tiny Tim",
                         SpeakerTwo = "Sister Tim",
                         OptionalSong = "",
                         SpeakerThree = "Brother Tim",
                         ClosingSong = "165",
                         EndPrayer = "Christine Konkle"
                     },

                     new PlannedMeeting
                     {
                         Meeting = DateTime.Parse("2017-12-10"),
                         Conductor = "First Counselor",
                         OpeningSong = "7",
                         StartPrayer = "Ammon DeCrescenzo",
                         SacramentSong = "169",
                         Sacrament = "Sacrament",
                         SpeakerOne = "Paula Prince",
                         SpeakerTwo = "Sister Smith",
                         OptionalSong = "106",
                         SpeakerThree = "Brother Smith",
                         ClosingSong = "156",
                         EndPrayer = "Gina Russell"
                     },

                     new PlannedMeeting
                     {
                         Meeting = DateTime.Parse("2017-12-17"),
                         Conductor = "Second Counselor",
                         OpeningSong = "30",
                         StartPrayer = "John Prince",
                         SacramentSong = "184",
                         Sacrament = "Sacrament",
                         SpeakerOne = "Sarah Walker",
                         SpeakerTwo = "Sister Hatch",
                         OptionalSong = "",
                         SpeakerThree = "Brother Hatch",
                         ClosingSong = "193",
                         EndPrayer = "Devin Kelm"
                     }                  
                );
                context.SaveChanges();
            }
        }
    }
}
