namespace Task10.Exceptions;

public class InvalidRequestException : Exception
{
    public InvalidRequestException(string message) : base(message)
    {
        
    }
}