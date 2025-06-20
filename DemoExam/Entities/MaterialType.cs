using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoExam.Entities;

[Table("material_types")]
public partial class MaterialType
{
    [Key]
    [Column("Тип материала")]
    [StringLength(100)]
    public string ТипМатериала { get; set; } = null!;

    [Column("Процент брака материала ")]
    public double? ПроцентБракаМатериала { get; set; }

    [InverseProperty("ТипМатериалаNavigation")]
    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
