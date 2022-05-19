using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BARISTA.Model;

namespace BARISTA.Infrastructure
{
    internal class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("ApplicationContext")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<AppointmentPosition> appointmentPositions { get; set; }
        public DbSet<Catalog> catalog { get; set; }
        public DbSet<Check> checks { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Manufacturer> manufacturers { get; set; }
        public DbSet<Menu> menus { get; set; }
        public DbSet<Position> positions { get; set; }
        public DbSet<PrescriptionProduct> prescriptionProducts { get; set; }
        public DbSet<Sale> sales { get; set; }
        public DbSet<Supply> supplies { get; set; }
        public DbSet<SupplyAccounting> supplyAccountings { get; set; }
        public DbSet<SupplyOfGoods> SupplyOfGoods { get; set; }
        public DbSet<Vendor> vendors { get; set; }
        public DbSet<Warehouse> warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
