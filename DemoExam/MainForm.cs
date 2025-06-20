using DemoExam.DataBase;
using DemoExam.Repositories;

namespace DemoExam;

public partial class MainForm : Form {
    private readonly AppDbContext _AppDbContext;
    private readonly ProductRepository _ProductRepository;

    public MainForm() {
        InitializeComponent();
        _AppDbContext = new AppDbContext();
        _ProductRepository = new ProductRepository(_AppDbContext); 
        GetProducts();
    }

    private async void GetProducts() {
        Panel? productCard;
        var productList = await _ProductRepository.GetAllProductsAsync();

        foreach (var product in productList) {
            double price = 0.00;

            foreach (var prodMat in product.ProductMaterials) {
                price += GetCommonProductPrice(prodMat.НеобходимоеКоличествоМатериала ?? 0.00, prodMat.НаименованиеМатериалаNavigation.ЦенаЕдиницыМатериала ?? 0.00);
            }

            product.CommonPrice = Math.Round(price, 2);
            productCard = ProductCard.ProductCard.GetProductCard(product);
            productCard.Click += ProductCard_Click;
            flowLayoutPanel_ForCards.Controls.Add(productCard);
            productCard = null;
        }
    }

    private double GetCommonProductPrice(double firstMultiplier, double secondMultiplier) {
        return firstMultiplier * secondMultiplier;
    }

    private void ProductCard_Click(object? sender, EventArgs e) {

    }
}
