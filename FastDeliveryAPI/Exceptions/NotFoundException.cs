namespace FastDeliveryAPI.Exceptions;

public class NotFoundException : ApplicationException
{
    public NotFoundException(string numero) : base ($"{numero} no es valido debe contener solamente numeros enteros")
    {

    }
}