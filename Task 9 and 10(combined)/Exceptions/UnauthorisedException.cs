namespace Task10.Exceptions;

public class UnauthorisedException : Exception
{
    public UnauthorisedException() : base("You are unauthorised")
    {
        
    }
}