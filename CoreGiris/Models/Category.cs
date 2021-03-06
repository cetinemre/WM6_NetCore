﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoreGiris.Models
{
    [Table("Kategoriler")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(50),Column("KategoriAdi")]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }= new HashSet<Product>();
    }
}
