using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data
{
    public class personContext : DbContext
    {
        public personContext(DbContextOptions opt) : base(opt)
        {

        }
        public DbSet<person> contacts { get; set; }
    
    }
}
