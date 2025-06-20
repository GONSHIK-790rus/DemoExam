using DemoExam.Entities;

namespace DemoExam.ProductCard;

public class ProductCard {
    public static Panel GetProductCard(Product product) {
        return new ProductCard().CreateProductCard(product);
    }

    private ProductCard() { }

    private Panel CreateProductCard(Product product) {
        var card = CreatePanel();

        var titleLabel = CreateTitleLabel(product.ТипПродукции ?? " ", product.НаименованиеПродукции);
        var articleLabel = CreateArticleLabel(product.Артикул);
        var minPriceForPartner = CreateMinPriceForPartnerLabel(product.МинимальнаяСтоимостьДляПартнера ?? 0.00);
        var widthLabel = CreateWidthLabel(product.ШиринаРулонаМ ?? 0.00);
        var priceLabel = CreatePriceLabel(product.CommonPrice);

        card.Controls.Add(titleLabel);
        card.Controls.Add(articleLabel);
        card.Controls.Add(minPriceForPartner);
        card.Controls.Add(widthLabel);
        card.Controls.Add(priceLabel);

        card.MouseEnter += Control_MouseEnter;
        card.MouseLeave += Control_MouseLeave;

        return card;
    }

    private Panel CreatePanel() {
        return new Panel {
            BorderStyle = BorderStyle.FixedSingle,
            Size = new Size(880, 130),
            Margin = new Padding(15),
            BackColor = Color.FromArgb(187, 217, 178)
        };
    }

    private Label CreateTitleLabel(string type, string productName) {
        return new Label {
            Name = "TitleLabel",
            Text = $"{type} | {productName}",
            Font = new Font("Gabriola", 14),
            Location = new Point(10, 10),
            AutoSize = true
        };
    }

    private Label CreateArticleLabel(int article) {
        return new Label {
            Name = "ArticleLabel",
            Text = $"Артикул - {article}",
            Font = new Font("Gabriola", 13),
            Location = new Point(10, 40),
            AutoSize = true
        };
    }

    private Label CreateMinPriceForPartnerLabel(double price) {
        return new Label {
            Name = "MinPriceForPartnerLabel",
            Text = $"Минимальная цена для партнера - {Math.Round(price, 2)} руб.",
            Font = new Font("Gabriola", 13),
            Location = new Point(10, 60),
            AutoSize = true
        };
    }

    private Label CreateWidthLabel(double width) {
        return new Label {
            Name = "WidthLabel",
            Text = $"Ширина - {Math.Round(width, 2)} м.",
            Font = new Font("Gabriola", 13),
            Location = new Point(10, 80),
            AutoSize = true
        };
    }

    private Label CreatePriceLabel(double price) {
        return new Label {
            Name = "PriceLabel",
            Text = $"Стоимость {Math.Round(price, 2)} руб.",
            Font = new Font("Gabriola", 18),
            ForeColor = Color.Black,
            Location = new Point(650, 10),
            AutoSize = true
        };
    }

    private void Control_MouseEnter(object? sender, EventArgs e) {
        if (sender is Panel card)
            card.Cursor = Cursors.Hand;
    }

    private void Control_MouseLeave(object? sender, EventArgs e) {
        if (sender is Panel card)
            card.Cursor = Cursors.Default;
    }
}
