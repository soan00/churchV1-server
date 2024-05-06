using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DTO
{
    public class ContentDTO
    {
        public int Id { get; set; }
        public string? Link { get; set; }
        public string? Discription { get; set; }
        public string? Title { get; set; }
        public bool Active { get; set; }
    }
}
