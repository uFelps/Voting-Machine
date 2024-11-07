using Microsoft.AspNetCore.Mvc;
using Voting_Machine.Application.DTOs;
using Voting_Machine.Application.Exceptions;
using Voting_Machine.Application.Services.Interfaces;

namespace Voting_Machine.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CandidateController : ControllerBase
{
    private readonly ICandidateService _service;
    
    public CandidateController(ICandidateService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<ActionResult<CandidateDto>> CreateCandidate([FromBody] CandidateDto dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new {message = ModelState});
        }

        var candidateDto = await _service.CreateCandidate(dto);

        return CreatedAtAction(nameof(GetCandidateById), new { id = candidateDto.Id }, candidateDto);

    }
    
    [HttpGet("/{id:int}")]
    public async Task<ActionResult<CandidateDto>> GetCandidateById(int id)
    {
        try
        {
            var user = await _service.GetCandidateById(id);
            return Ok(user);
        }
        catch (DataNotFoundException e)
        {
            return BadRequest($"Data not found exception: {e.Message}");
        }
    }
}