using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Voting_Machine.Infra.Data.Context;

namespace Voting_Machine.Infra.Ioc;

public static class DependencyInjection
{
    public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("Database"));
        
        
    }
}