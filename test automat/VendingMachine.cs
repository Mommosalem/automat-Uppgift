﻿namespace Automat
{
    abstract class VendingMachine
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int ID { get; set; }
    }
}
