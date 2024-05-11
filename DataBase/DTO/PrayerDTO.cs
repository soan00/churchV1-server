using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DTO
{
    public class PrayerDTO
    {
        
        public string? Name { get; set; }
        public string? Request { get; set; }
        public string? Email { get; set; }
        public double PhoneNo { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
