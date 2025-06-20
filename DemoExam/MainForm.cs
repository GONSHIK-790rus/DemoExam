using DemoExam.DataBase;

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
            productCard = ProductCard.ProductCard.GetProductCard(product);
            productCard.Click += ProductCard_Click;
            flowLayoutPanel_ForCards.Controls.Add(productCard);
            productCard = null;
        }
    }

    private void ProductCard_Click(object? sender, EventArgs e) {

    }
}
