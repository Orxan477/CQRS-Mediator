namespace Mediator.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public bool IsDeleted { get; set; }
    }
}
