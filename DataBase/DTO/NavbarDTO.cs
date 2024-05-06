using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.DTO
{
    public class NavbarDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Access { get; set; }
        public bool Active { get; set; }
        public string? RoutLink { get; set; }
    }
}
