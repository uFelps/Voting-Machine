using System.ComponentModel.DataAnnotations;

namespace Voting_Machine.Domain.Entities;

public class Candidate
{
    public Candidate()
    {
    }

    public Candidate(int id, string name, int number, string vice, DateTime registeredIn)
    {
        Id = id;
        Name = name;
        Number = number;
        Vice = vice;
        RegisteredIn = registeredIn;
    }

    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
    public string Vice { get; set; }
    public DateTime RegisteredIn { get; set; }
    public List<Vote> Votes { get; set; }
}