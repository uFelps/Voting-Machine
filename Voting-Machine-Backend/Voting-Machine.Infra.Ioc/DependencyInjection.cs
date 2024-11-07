using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Voting_Machine.Application.Services.Implementations;
using Voting_Machine.Application.Services.Interfaces;
using Voting_Machine.Domain.Interfaces;
using Voting_Machine.Infra.Data.Context;
using Voting_Machine.Infra.Data.Repositories;

namespace Voting_Machine.Infra.Ioc;

public static class DependencyInjection
{
    public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("Database"));

        //services
        services.AddScoped<ICandidateService, CandidateService>();
        
        //repositories
        services.AddScoped<ICandidateRepository, CandidateRepository>();
    }
}