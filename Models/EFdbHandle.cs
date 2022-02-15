using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Models
{
    public class EFdbHandle : DbContext
    {
       
            public const string conn = "Server=DESKTOP-VLJFF77\\SQLEXPRESS; Database=CustomerDB1; Trusted_Connection=True;";
            protected override void OnConfiguring(DbContextOptionsBuilder optionsB)
            {
                optionsB.UseSqlServer(conn);
            }

            public DbSet<Customer> Customers { get; set; }
            
        }
    }



