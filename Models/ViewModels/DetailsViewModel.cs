using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Models.ViewModels
{
    public class DetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Starts at")]
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; } = string.Empty;

        public List<string> AttendingMemberEmails { get; set; } = new List<string>();

    }
}
