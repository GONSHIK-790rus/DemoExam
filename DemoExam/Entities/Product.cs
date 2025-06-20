using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoExam.Entities;

[Table("products")]
public partial class Product {
    [Column("Тип продукции")]
    [StringLength(100)]
    public string? ТипПродукции { get; set; }

    [Key]
    [Column("Наименование продукции")]
    [StringLength(100)]
    public string НаименованиеПродукции { get; set; } = null!;

    public int Артикул { get; set; }

    [Column("Минимальная стоимость для партнера")]
    public double? МинимальнаяСтоимостьДляПартнера { get; set; }

    [Column("Ширина рулона, м")]
    public double? ШиринаРулонаМ { get; set; }

    [InverseProperty("ПродукцияNavigation")]
    public virtual ICollection<ProductMaterial> ProductMaterials { get; set; } = new List<ProductMaterial>();

    [ForeignKey("ТипПродукции")]
    [InverseProperty("Products")]
    public virtual ProductType? ТипПродукцииNavigation { get; set; }
}
