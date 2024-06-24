namespace Store.Domain.DTO.Product;

public class ReadProductDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public Guid BarCode { get; set; }
    public DateTime ExpireDate { get; set; }
    public string Brand { get; set; }

    public string Category { get; set; }
}