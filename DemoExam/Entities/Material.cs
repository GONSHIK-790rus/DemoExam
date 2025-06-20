using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DemoExam.Entities;

[Table("materials")]
public partial class Material
{
    [Key]
    [Column("Наименование материала")]
    [StringLength(100)]
    public string НаименованиеМатериала { get; set; } = null!;

    [Column("Тип материала")]
    [StringLength(100)]
    public string? ТипМатериала { get; set; }

    [Column("Цена единицы материала")]
    public double? ЦенаЕдиницыМатериала { get; set; }

    [Column("Количество на складе")]
    public double? КоличествоНаСкладе { get; set; }

    [Column("Минимальное количество")]
    public double? МинимальноеКоличество { get; set; }

    [Column("Количество в упаковке")]
    public double? КоличествоВУпаковке { get; set; }

    [Column("Единица измерения")]
    [StringLength(100)]
    public string? ЕдиницаИзмерения { get; set; }

    [InverseProperty("НаименованиеМатериалаNavigation")]
    public virtual ICollection<ProductMaterial> ProductMaterials { get; set; } = new List<ProductMaterial>();

    [ForeignKey("ТипМатериала")]
    [InverseProperty("Materials")]
    public virtual MaterialType? ТипМатериалаNavigation { get; set; }
}
