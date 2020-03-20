namespace FurnitureStore.Infrastructure.Table
{
    public class Image
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public byte? Data { get; set; }
    }
}
