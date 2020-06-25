using BootcampIntern.Data;
using BootcampIntern.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit;

namespace BootcampIntern.Test.RepositoryTest
{
    public class BaseRepositoryTest
    {
        private static DbContextOptions<BootcampLegendDbContext> CreateNewContextOptions(string currentMethod)
        {
            // Create a fresh service provider, and therefore a fresh 
            // InMemory database instance.
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            // Create a new options instance telling the context to use an
            // InMemory database and the new service provider.
            var builder = new DbContextOptionsBuilder<BootcampLegendDbContext>();
            builder.UseInMemoryDatabase(currentMethod)
                   .UseInternalServiceProvider(serviceProvider);

            return builder.Options;
        }

        [Fact]
        public void Should_Success_Get_Empty_Data_From_Fresh_DB()
        {
            using (var dbContext = new BootcampLegendDbContext(CreateNewContextOptions(MethodBase.GetCurrentMethod().ReflectedType.FullName + MethodBase.GetCurrentMethod().Name)))
            {
                var repository = new BaseRepository<Character>(dbContext);
                var result = repository.Get();
                Assert.Empty(result);
            }
        }
    }
}
