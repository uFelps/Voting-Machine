using Voting_Machine.Application.DTOs;
using Voting_Machine.Application.Exceptions;
using Voting_Machine.Application.Services.Interfaces;
using Voting_Machine.Domain.Entities;
using Voting_Machine.Domain.Interfaces;

namespace Voting_Machine.Application.Services.Implementations;

public class CandidateService : ICandidateService
{
    private readonly ICandidateRepository _repository;
    
    public CandidateService(ICandidateRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<CandidateDto> CreateCandidate(CandidateDto dto)
    {
        var candidate = new Candidate();
        candidate.Name = dto.Name;
        candidate.Number = dto.Number;
        candidate.Vice = dto.Vice;
        candidate.RegisteredIn = DateTime.Now;

        var newCandidate = await _repository.CreateCandidate(candidate);

        return new CandidateDto(newCandidate);
    }

    public async Task<CandidateDto> GetCandidateById(int id)
    {
        var user = await _repository.GetCandidateById(id);

        if (user == null)
        {
            throw new DataNotFoundException($"User not found. Id={id}");
        }

        return new CandidateDto(user);
    }
}