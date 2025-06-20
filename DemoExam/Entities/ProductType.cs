using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoExam.Entities;

[Table("product_types")]
public partial class ProductType
{
    [Key]
    [Column("Тип продукции")]
    [StringLength(100)]
    public string ТипПродукции { get; set; } = null!;

    [Column("Коэффициент типа продукции")]
    public double? КоэффициентТипаПродукции { get; set; }

    [InverseProperty("ТипПродукцииNavigation")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
