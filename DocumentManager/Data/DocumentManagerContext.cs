using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DocumentManager.Models
{
    public class DocumentManagerContext : DbContext
    {
        public DocumentManagerContext (DbContextOptions<DocumentManagerContext> options)
            : base(options)
        {
        }

        public DbSet<DocumentManager.Models.DocumentType> DocumentType { get; set; }
    }
}
