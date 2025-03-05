using System;
using Catalog.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Catalog.UnitTests
{
    public static class contextGenerator
    {
        public static ApplicationDbContext Generate()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                     .UseInMemoryDatabase(Guid.NewGuid().ToString());

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
