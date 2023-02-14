namespace CostItArchitecture.Domain.Models
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;

        //One to Many Relationship
        public ICollection<Estimate>? Estimates { get; set; }
    }
}