using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApi.Models
{
    public partial class UserModel : DbContext
    {
        public UserModel()
            : base("name=UserModel")
        {
        }

        public virtual DbSet<USERS> USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USERS>()
                .Property(e => e.ADI)
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.SOYADI)
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.KULLANICI_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.SIFRE)
                .IsUnicode(false);
        }
    }
}
