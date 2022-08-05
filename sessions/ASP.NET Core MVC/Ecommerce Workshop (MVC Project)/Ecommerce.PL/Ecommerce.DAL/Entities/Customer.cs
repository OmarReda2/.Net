﻿namespace Ecommerce.DAL.Entities
{
    public class Customer: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Order Order { get; set; }
    }
}