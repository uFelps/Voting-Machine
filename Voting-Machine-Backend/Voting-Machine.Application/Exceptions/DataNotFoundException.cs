namespace Voting_Machine.Application.Exceptions;

public class DataNotFoundException : Exception
{
    public DataNotFoundException(string message) : base(message){}
}