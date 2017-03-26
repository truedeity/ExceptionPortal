
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CoreFamework.Security
{
	public partial class UserDbContext : IdentityDbContext<User, IdentityRole<int>, int>
	{
		public virtual DbSet<User> User { get; set; }
		public virtual DbSet<UserCd> UserCd { get; set; }
		public virtual DbSet<UserLogin> UserLogin { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ExceptionPortalDB;Integrated Security=True");
		}
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>(entity =>
			{
				entity.HasKey(e => e.Id);

				entity.Property(e => e.CreatedDt).HasColumnType("datetime");

				entity.Property(e => e.Email).HasMaxLength(256);

				entity.Property(e => e.EntityGuid).HasDefaultValueSql("newid()");

				entity.Property(e => e.IsSuppressed).HasDefaultValueSql("0");

				entity.Property(e => e.LastUpdateGuid).HasDefaultValueSql("newid()");

				entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

				entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

				entity.Property(e => e.UpdatedDt).HasColumnType("datetime");

				entity.Property(e => e.UserName).HasMaxLength(256);
			});

			modelBuilder.Entity<UserCd>(entity =>
			{
				entity.Property(e => e.UserCdId).ValueGeneratedNever();

				entity.Property(e => e.CreatedDt).HasColumnType("datetime");

				entity.Property(e => e.EntityGuid).HasDefaultValueSql("newid()");

				entity.Property(e => e.IsSuppressed).HasDefaultValueSql("0");

				entity.Property(e => e.LastUpdateGuid).HasDefaultValueSql("newid()");

				entity.Property(e => e.UpdatedDt).HasColumnType("datetime");

				entity.Property(e => e.UserCdName)
						.IsRequired()
						.HasMaxLength(50);
			});

			modelBuilder.Entity<UserLogin>(entity =>
			{
				entity.HasKey(e => e.UserLoginId);

				entity.Property(e => e.CreatedDt).HasColumnType("datetime");

				entity.Property(e => e.EntityGuid).HasDefaultValueSql("newid()");

				entity.Property(e => e.IsSuppressed).HasDefaultValueSql("0");

				entity.Property(e => e.LastUpdateGuid).HasDefaultValueSql("newid()");

				entity.Property(e => e.UpdatedDt).HasColumnType("datetime");

				entity.HasOne(d => d.User)
						.WithMany(p => p.UserLogin)
						.HasForeignKey(d => d.UserId)
						.HasConstraintName("FK_UserLogins_UserId");
			});
		}
	}
}
