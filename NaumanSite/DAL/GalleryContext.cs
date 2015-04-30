using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NaumanSite.Models;

namespace NaumanSite.DAL
{
    public class GalleryContext : DbContext
{
    public GalleryContext()
        : base("DefaultConnection")
    {
        Database.SetInitializer<GalleryContext>
            (new DropCreateDatabaseIfModelChanges<GalleryContext>());
    }

    public DbSet<Photo> Photos { get; set; }
}
}