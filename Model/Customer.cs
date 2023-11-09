using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }

        public bool IsAdmin { get; set; }

        public string? Company { get; set; }

        public List<Location> Locations { get; set; }

        public List<Comments> Comments { get; set; }
    }
}
