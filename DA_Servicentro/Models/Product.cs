﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DA_Servicentro.EntityTypes
{
[Table("products")]
    public partial class Product
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        [Column("product_id")]
        public int ProductId { get; set; }
        [Required]
        [Column("product_name")]
        [StringLength(200)]
        public string ProductName { get; set; }
        [Column("model_year")]
        public short ModelYear { get; set; }
        [Column("price", TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}