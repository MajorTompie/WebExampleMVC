using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebExampleMVC.Models
{
    public class WebExampleMVCContext : DbContext
    {
        public WebExampleMVCContext (DbContextOptions<WebExampleMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebExampleMVC.Models.Person> Person { get; set; }
    }
}
