namespace ServiceAvtoProkat
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Db : DbContext
    {
        public Db()
            : base("name=Db")
        {
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Zakaz> Zakaz { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .Property(e => e.Mark)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Colour)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.Nomer)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.CarVinKuzov)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Car>()
                .HasMany(e => e.Zakaz)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientPassport)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientNumDrive)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientTel)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Zakaz)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmplName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmplTel)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Zakaz)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.Post1)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .HasMany(e => e.Employee)
                .WithRequired(e => e.Post)
                .WillCascadeOnDelete(false);
        }
    }
}
