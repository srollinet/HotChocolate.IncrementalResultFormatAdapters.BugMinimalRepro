namespace HotChocolate.IncrementalResultFormatAdapters.Bug.Types;

public class Product
{
    public required string Id { get; set; }
    public int ProductNumber { get; set; }
    // public ProductDescription? Description { get; set; }
}

public class ProductDescription
{
    public required string Description { get; set; }
}