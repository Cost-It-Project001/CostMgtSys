using CostItArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostItArchitecture.Infrastructure.Context
{
    public interface ICostItDbcontext
    {
       // DbSet<Movie> Movies { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Estimate> Estimates { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Material> Materials { get; set; }



    }
}
