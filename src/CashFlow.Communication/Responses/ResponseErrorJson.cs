namespace CashFlow.Communication.Responses;

public class ResponseErrorJson
{
    //public required string ErrorMessage { get; set; } = string.Empty;

    public List<string> ErrorMessages { get; set; }

    //construtor (digitar ct - ctor)
    public ResponseErrorJson(string errorMessage)
    {
        ErrorMessages = [errorMessage];
    }

    public ResponseErrorJson(List<string> errorMessage)
    {
        ErrorMessages = errorMessage;
    }
}
