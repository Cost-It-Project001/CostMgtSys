using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostItArchitecture.Domain.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int Phone { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public Guid EstimateId { get; set; }
        public Estimate? Estimate { get; set; }
    }
}
