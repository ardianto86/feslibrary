using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FesLibrary.Models
{
    public class CatalogueContext : DbContext
    {
        public DbSet<CatalogueItem> CatalogueItems { get; set; }

        public CatalogueContext() : base("name=CatalogueContext")
        {

        }

    }
}