namespace TurboKanban.Data
{
    public class Parts
    {
        public int id { get; set; }
        public string? Title { get; set; }
        public bool IsAccquired { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
    }
}
