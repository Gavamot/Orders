using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrdersWeb.Model;

namespace OrdersWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        // Справочники
       
        public DbSet<Customer> Customers { get; set; }
        public DbSet<WorkerPost> WorkerPosts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Nomenclature> Nomenclatures { get; set; }
        public DbSet<NomenclatureCategory> NomenclatureCategorys { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<CommentTheme> CommentThemes { get; set; }
        public DbSet<OrderRowStatus> OrderRowStatus { get; set; }

        // Документы
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderRow> OrderRows { get; set; }
        public DbSet<OrderRowHistory> OrderRowHistorys { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
