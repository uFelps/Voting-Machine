using Microsoft.EntityFrameworkCore;
using Voting_Machine.Domain.Entities;

namespace Voting_Machine.Infra.Data.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options){}
    
    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<Vote> Votes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vote>()
            .HasOne(vote => vote.Candidate)
            .WithMany(candidate => candidate.Votes)
            .HasForeignKey(vote => vote.CandidateId);
    }
}