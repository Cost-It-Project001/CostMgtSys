namespace CostItArchitecture.Domain.Models
{
    public class Estimate
    {
        public Guid Id { get; set; }
        public string? Paper { get; set; } 
        public int PaperQty { get; set; }
        public double PaperPrice { get; set; }
        public string? Plate { get; set; }
        public int PlateQty { get; set; }
        public double PlatePrice { get; set; }
        public string? Impression { get; set; } 
        public int ImpressionQty { get; set; }
        public double ImpressionPrice { get; set; }
        public string? Finishing { get; set; }
        public int FInishingQty { get; set; }
        public double FinishingPrice { get; set; }
        public string? Others { get; set; }
        public int OtherQty { get; set; }
        public double OtherPrice { get; set; }
        public DateTime DateCreated { get; set; }

        //One to Many Relationship
        public ICollection<User>? Users { get; set; }

        //One to Many Relationship
        public Guid CustomerId { get; set; }
        public Customer? Customers { get; set; }
    }
}