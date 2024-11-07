using System.ComponentModel.DataAnnotations;
using Voting_Machine.Domain.Entities;

namespace Voting_Machine.Application.DTOs;

public class CandidateDto
{
    public CandidateDto()
    {
    }

    public CandidateDto(int id, string name, int number, string vice, DateTime registeredIn)
    {
        Id = id;
        Name = name;
        Number = number;
        Vice = vice;
        RegisteredIn = registeredIn;
    }

    public CandidateDto(Candidate newCandidate)
    {
        Id = newCandidate.Id;
        Name = newCandidate.Name;
        Number = newCandidate.Number;
        Vice = newCandidate.Vice;
        RegisteredIn = newCandidate.RegisteredIn;
    }


    public int Id { get; set; }
    
    [Required(ErrorMessage = "This field is required")]
    [StringLength(60, ErrorMessage = "length must be between 6 and 60.", MinimumLength = 6)]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "This field is required")]
    [Range(10, 99, ErrorMessage = "Value for number must be between 10 and 99.")]
    public int Number { get; set; }
    
    [Required(ErrorMessage = "This field is required")]
    [StringLength(60, ErrorMessage = "length must be between 6 and 60.", MinimumLength = 6)]
    public string Vice { get; set; }
    
    public DateTime RegisteredIn { get; set; }
}