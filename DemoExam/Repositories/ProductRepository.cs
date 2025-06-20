using Microsoft.EntityFrameworkCore;
using DemoExam.Entities;
using DemoExam.DataBase;

namespace DemoExam.Repositories;

internal class ProductRepository {
    private readonly AppDbContext _AppDbContext;
    public ProductRepository(AppDbContext appDbContext) {
        _AppDbContext = appDbContext;
    }

    public async Task<List<Product>> GetAllProductsAsync() {
        return await _AppDbContext.Products
            .Include(product => product.ProductMaterials)
                .ThenInclude(productMaterial => productMaterial.НаименованиеМатериалаNavigation)
            .ToListAsync();
    }
}
