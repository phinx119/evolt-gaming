﻿using System;
using System.Collections.Generic;

namespace EvoltingStore.Entity
{
    public partial class Cart
    {
        public Cart()
        {
            CartItems = new HashSet<CartItem>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
