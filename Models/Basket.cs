﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_zm275.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        public void AddItem (Books book, int qty)
        {
            BasketLineItem line = Items
                .Where(p => p.Books.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Books = book,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity = line.Quantity + qty;
            }
        }
        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Books.Price);

            return sum;
        }
    }
   
    public class BasketLineItem
    {
        [Key]
        public int LineID { get; set; }
        public Books Books { get; set; }
        public int Quantity { get; set; }

    }
}
