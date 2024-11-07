using Voting_Machine.Domain.Entities;

namespace Voting_Machine.Domain.Interfaces;

public interface ICandidateRepository
{
    Task<Candidate> CreateCandidate(Candidate candidate);
    Task<Candidate?> GetCandidateById(int id);
}