namespace ComponentDemosScenarios.Models.NorthwindAPIv2;

public class ProductDto
{
    public int ProductId { get; set; }
    public int? SupplierId { get; set; }
    public int? CategoryId { get; set; }
    public string QuantityPerUnit { get; set; }
    public double? UnitPrice { get; set; }
    public int? UnitsInStock { get; set; }
    public int? UnitsOnOrder { get; set; }
    public int? ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
}
