using Voting_Machine.Application.DTOs;

namespace Voting_Machine.Application.Services.Interfaces;

public interface ICandidateService
{
    public Task<CandidateDto> CreateCandidate(CandidateDto dto);
    public Task<CandidateDto> GetCandidateById(int id);
    public Task<bool> DeleteCandidate(int id);
}