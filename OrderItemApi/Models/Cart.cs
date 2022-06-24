﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderItem.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int MenuItemId { get; set; }
        public int UserId { get; set; }

        public string MenuItemName { get; set; }
        public Cart(string menuitemname)
        {
            MenuItemName = menuitemname;
            
        }

        public Cart() : this("Phone") { }
    }
}