﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ApiTienTe.Entities
{
    public partial class TienTeDataContext : DbContext
    {
        public TienTeDataContext()
        {
        }

        public TienTeDataContext(DbContextOptions<TienTeDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TienTe> TienTes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = LAPTOP - 3E89SLDR\\SQLEXPRESS; Initial Catalog = TienTeData; Integrated Security = True; Persist Security Info = False; Pooling = False; Multiple Active Result Sets = False; Connect Timeout = 60; Encrypt = False; Trust Server Certificate = False; Command Timeout = 0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TienTe>(entity =>
            {
                entity.ToTable("TienTe");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TienTeDich).HasMaxLength(50);

                entity.Property(e => e.TienTeNguon).HasMaxLength(50);

                entity.Property(e => e.TyGia).HasColumnType("decimal(18, 5)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
