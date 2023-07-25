namespace BookApp.midleware
{
    public class Custom
    {
       public Custom(int statusCode, string message, string details = null)
    {
        StatusCode = statusCode;
        Message = message;
        Details = details;
    }

    public int StatusCode { get; set; }
    public string Message { get; set; }
    public string Details { get; set; }
}  
    }
