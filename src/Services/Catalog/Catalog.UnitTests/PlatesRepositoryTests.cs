using System;
using System.Linq;
using Catalog.API.Data;
using Catalog.API.Repositories.Implementation;
using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Catalog.UnitTests
{
    public class PlatesRepositoryTests
    {
        private readonly ApplicationDbContext _dbContext;
        public PlatesRepositoryTests()
        {
            _dbContext = contextGenerator.Generate();
        }
        [Fact]
        public async void CanGetAllPlates()
        {
            _dbContext.Plates.AddRange(
                 new Plate
                 {
                     Id = Guid.NewGuid(),
                     Registration = "P777PER",
                     PurchasePrice = 1494.00M,
                     SalePrice = 4995.00M,
                     Numbers = 777,
                     Letters = "PYP"
                 },
                 new Plate {
                     Id = Guid.NewGuid(), 
                     Registration = "M66VEY", 
                     PurchasePrice = 469.00M, 
                     SalePrice = 5995.00M, 
                     Numbers = 66,
                     Letters = "VEY" });

            var repository = new PlatesRepository(_dbContext);

            var response = await repository.Get();

            Assert.NotNull(response);
            Assert.True(response.Count() == 2);
            Assert.Contains(response, x => x.Registration == "P777PER");
            Assert.Contains(response, x => x.Registration == "M66VEY");         
        }
    }
}