namespace OnlineMarket_BB104.Exceptions;

public class NotFoundException(string message = "Not found!") : Exception(message)
{
}
