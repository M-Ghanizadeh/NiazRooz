using Application.Interface.Context;
using Domain.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class NiazRoozDBContext : DbContext, INiazRoozDBContext
    {
        public NiazRoozDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

    }
}
