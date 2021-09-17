namespace API.Dtos
{
    public record ProductToReturnDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public decimal Price { get; init; }
        public string PictureUrl { get; init; }
        public string ProductType { get; init; }
        public string ProductBrand { get; init; }
    }
}