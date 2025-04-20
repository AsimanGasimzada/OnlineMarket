namespace OnlineMarket_BB104.Exceptions;
public class AlreadyExistException(string message="Already exist!") : Exception(message)
{
}