using HotChocolate.Types.Pagination;

namespace HotChocolate.IncrementalResultFormatAdapters.Bug.Types;

public static class Query
{
    [Query]
    [UsePaging(IncludeTotalCount = true)]
    public static Connection<Product> GetProducts()
    {
        var pageInfo = new ConnectionPageInfo(
            false,
            true,
            null,
            "cursor3"
        );
        
        var edges = new List<Edge<Product>>
        {
            new(new Product { Id = "1", ProductNumber = 1001 }, "cursor1"),
            new(new Product { Id = "2", ProductNumber = 1002 }, "cursor2"),
            new(new Product { Id = "3", ProductNumber = 1003 }, "cursor3")
        };

        return new Connection<Product>(edges, pageInfo, 200);
    }
}
