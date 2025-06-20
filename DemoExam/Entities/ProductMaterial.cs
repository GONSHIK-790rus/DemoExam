using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoExam.Entities;

[PrimaryKey("Продукция", "НаименованиеМатериала")]
[Table("product_materials")]
public partial class ProductMaterial
{
    [Key]
    [StringLength(100)]
    public string Продукция { get; set; } = null!;

    [Key]
    [Column("Наименование материала")]
    [StringLength(100)]
    public string НаименованиеМатериала { get; set; } = null!;

    [Column("Необходимое количество материала")]
    public double? НеобходимоеКоличествоМатериала { get; set; }

    [ForeignKey("НаименованиеМатериала")]
    [InverseProperty("ProductMaterials")]
    public virtual Material НаименованиеМатериалаNavigation { get; set; } = null!;

    [ForeignKey("Продукция")]
    [InverseProperty("ProductMaterials")]
    public virtual Product ПродукцияNavigation { get; set; } = null!;
}
