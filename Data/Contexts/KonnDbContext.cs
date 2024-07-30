using KonnClient.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KonnClient.Data.Contexts;

public class KonnDbContext : DbContext
{
    public KonnDbContext(DbContextOptions<KonnDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users => Set<User>();

    public DbSet<Address> Addresses => Set<Address>();

    public DbSet<Category> Categories => Set<Category>();

    public DbSet<Contact> Contacts => Set<Contact>();

    public DbSet<ContactCategory> ContactCategories => Set<ContactCategory>();

    public DbSet<Workspace> Workspaces => Set<Workspace>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Contact>()
          .HasMany(c => c.Addresses)
          .WithOne(a => a.Contact)
          .HasForeignKey(a => a.ContactId)
          .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Contact>()
          .HasMany(c => c.ContactCategories)
          .WithOne(cc => cc.Contact)
          .HasForeignKey(cc => cc.ContactId)
          .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Category>()
          .HasMany(c => c.ContactCategories)
          .WithOne(cc => cc.Category)
          .HasForeignKey(cc => cc.CategoryId)
          .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<User>()
          .HasMany(w => w.Workspaces)
          .WithOne(a => a.User)
          .HasForeignKey(a => a.UserId)
          .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Workspace>()
          .HasMany(w => w.Categories)
          .WithOne(a => a.Workspace)
          .HasForeignKey(a => a.WorkspaceId)
          .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Workspace>()
          .HasMany(w => w.Contacts)
          .WithOne(a => a.Workspace)
          .HasForeignKey(a => a.WorkspaceId)
          .OnDelete(DeleteBehavior.Cascade);
    }
}
