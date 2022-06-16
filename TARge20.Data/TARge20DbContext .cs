
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Access> Access { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<BranchOffice> BranchOffice { get; set; }
        public DbSet<Check> Check { get; set; }
        public DbSet<Children> Children { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<HealthCheckup> HealthCheckup { get; set; }
        public DbSet<Hints> Hints { get; set; }
        public DbSet<ItemLending> ItemLending { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<MailBox> MailBox { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderRow> OrderRow { get; set; }
        public DbSet<PriceDynamics> PriceDynamics { get; set; }
        public DbSet<PurchaseContract> PurchaseContract { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Requests> Request { get; set; }
        public DbSet<SalesContract> SalesContract { get; set; }
        public DbSet<SickLeave> SickLeave { get; set; }
        public DbSet<Vacation> Vacation { get; set; }

    }
}