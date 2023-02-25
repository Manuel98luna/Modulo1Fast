namespace FastDeliveryAPI.Exceptions;

public class NotFoundException : ApplicationException
{
    public NotFoundException(string numero) : base ($"{name} with id {key} was not found")
    {

    }
}