using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitalhub.Core;

namespace Vitalhub.Store.MySqlStore
{
    public class CategoryContext : DbContext
    {

        public CategoryContext(DbContextOptions<CategoryContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
