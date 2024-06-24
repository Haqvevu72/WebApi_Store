namespace Store.Domain.DTO.Product;

public class WriteProductDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public DateTime ExpireDate { get; set; }
    public string Brand { get; set; }
    
    // Foreign Key 
    public int CategoryId { get; set; }
}