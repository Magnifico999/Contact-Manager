using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Contact.Api.Models
{
    public partial class BlzDbContactContext : IdentityDbContext<UserProfile>
    {
        public BlzDbContactContext()
        {
        }

        public BlzDbContactContext(DbContextOptions<BlzDbContactContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-HU8DLR9F;Initial Catalog=BlzDbContact;Integrated Security=True;Pooling=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Id = "abe24845-53a3-4a5c-9913-61f46aebc04b"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER",
                    Id = "279e089a-a166-4790-a033-0b1636334714"
                }
            );
            var hash = new PasswordHasher<UserProfile>();
            modelBuilder.Entity<UserProfile>().HasData(
                new UserProfile
                {
                    Id = "83134663-7788-4b21-8ce7-afe80772a9d2",
                    Email = "Admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    PasswordHash = hash.HashPassword(null,"admin@123Admin"),
                    UserName = "Admin@example.com",
                    NormalizedUserName = "ADMIN@EXAMPLE.COM",
                    FirstName = "Sodiq",
                    LastName = "Alabi",
                    ProfilePicture = "image1.png"
                },
                new UserProfile
                {
                    Id = "cc1ba891-6c2c-4718-a811-4e35d2e4d640",
                    Email = "user@example.com",
                    NormalizedEmail = "USER@EXAMPLE.COM",
                    PasswordHash = hash.HashPassword(null, "user@123user"),
                    UserName = "user@example.com",
                    NormalizedUserName = "USER@EXAMPLE.COM",
                    FirstName = "Ola",
                    LastName = "Tboss",
                    ProfilePicture = "noimage.png"
                }
            );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "83134663-7788-4b21-8ce7-afe80772a9d2",
                    RoleId = "abe24845-53a3-4a5c-9913-61f46aebc04b"
                },
                new IdentityUserRole<string>
                {
                    UserId = "cc1ba891-6c2c-4718-a811-4e35d2e4d640",
                    RoleId = "279e089a-a166-4790-a033-0b1636334714"

                }
            );
        }

        public DbSet<Contact> Contacts { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
