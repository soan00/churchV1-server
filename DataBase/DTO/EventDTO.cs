using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DTO
{
    public class EventDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Discription { get; set; }
        public bool Active { get; set; }
        public DateTime Date { get; set; }
    }
}
