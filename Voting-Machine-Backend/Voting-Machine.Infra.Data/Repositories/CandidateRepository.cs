using Microsoft.EntityFrameworkCore;
using Voting_Machine.Domain.Entities;
using Voting_Machine.Domain.Interfaces;
using Voting_Machine.Infra.Data.Context;

namespace Voting_Machine.Infra.Data.Repositories;

public class CandidateRepository : ICandidateRepository
{
    private readonly DataContext _context;
    
    public CandidateRepository(DataContext context)
    {
        _context = context;
    }
    
    public async Task<Candidate> CreateCandidate(Candidate candidate)
    {
        _context.Candidates.Add(candidate);
        await _context.SaveChangesAsync();
        return candidate;
    }

    public async Task<Candidate?> GetCandidateById(int id)
    {
        return await _context.Candidates
            .FirstOrDefaultAsync(x => x.Id == id);
    }
}