namespace Core.Entities
{
    public record Product : BaseEntity
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public decimal Price { get; init; }
        public string PictureUrl { get; init; }
        public ProductType ProductType { get; init; }
        public int ProductTypeId { get; init; }
        public ProductBrand ProductBrand { get; init; }
        public int ProductBrandId { get; init; }
    }
}