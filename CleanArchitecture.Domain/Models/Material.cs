using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostItArchitecture.Domain.Models
{
    public class Material
    {
        public Guid MaterialId { get; set; }
        public string MaterialName { get; set; } = string.Empty;
        public int MaterialPrice { get; set; }
    }
}
