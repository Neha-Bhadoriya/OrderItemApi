using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MenuItem(string name)
        {
            Name = name;

        }

        public MenuItem() : this("Laptop") { }
        public bool FreeDelivery { get; set; }
        public double Price { get; set; }
        public DateTime DateOfLaunch { get; set; }
        public bool Active { get; set; }
    }
}
