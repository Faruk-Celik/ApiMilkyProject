namespace MilkyProject.WebUI.Dtos.ProductDtos
{
    public class UpdateProductDtos
    {
            public int productId { get; set; }
            public string productName { get; set; }
            public Decimal oldPrice { get; set; }
            public Decimal newPrice { get; set; }
            public string imageUrl { get; set; }
            public bool status { get; set; }
        

    }
}
