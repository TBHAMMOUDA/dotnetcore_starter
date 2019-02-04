using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GMAO.Entities;

namespace GMAO.Context
{
    public partial class GMAODbContext : DbContext
    {
        public GMAODbContext()
        {

        }
        public GMAODbContext(DbContextOptions<GMAODbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Role>(entity =>
            {

                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1B6B24EA82");
                entity.ToTable("Roles");
            });

            modelBuilder.Entity<Membership>(entity =>
            {

                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4D2BFE89A6");
                entity.ToTable("Membership");
            });

            modelBuilder.Entity<UsersInRoles>(entity =>
            {

                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4D2BFE89A6");
                entity.ToTable("UsersInRoles");
            });

            modelBuilder.Entity<User>(entity =>
            {

                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4D5FB337D6");
                entity.ToTable("Users");
            });

        }

        public virtual DbSet<User> User { get; set; }

        public virtual DbSet<Role> Role { get; set; }

        public virtual DbSet<Membership> Membership { get; set; }

        public virtual DbSet<UsersInRoles> UsersInRoles { get; set; }
    }
}
