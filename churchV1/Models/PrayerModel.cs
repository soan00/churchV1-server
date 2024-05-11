namespace churchV1.Models
{
    public class PrayerModel
    {
        public string? Name { get; set; }
        public string? Request { get; set; }
        public string? Email { get; set; }
        public double PhoneNo { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
