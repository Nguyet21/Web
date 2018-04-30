namespace web.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Yumdbcontext : DbContext
    {
        public Yumdbcontext()
            : base("name=Yumdbcontext")
        {
        }

        public virtual DbSet<DANGNHAP> DANGNHAPs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.DANGNHAP1)
                .IsUnicode(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);
        }
    }
}
