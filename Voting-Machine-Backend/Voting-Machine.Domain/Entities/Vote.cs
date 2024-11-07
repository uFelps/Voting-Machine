using System.ComponentModel.DataAnnotations;

namespace Voting_Machine.Domain.Entities;

public class Vote
{
    [Key]
    public long Id { get; set; }
    public DateTime DateVote { get; set; }
    public int CandidateId { get; set; }
    public Candidate? Candidate { get; set; }
}