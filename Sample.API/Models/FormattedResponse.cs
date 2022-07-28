namespace Sample.API.Models
{
    public class FormattedResponse<T>
    {
        public string Message { get; set; }
        public string Status { get; set; }
        public T? Body { get; set; }

        public FormattedResponse(T? body, string message, string status)
        {
            Message = message;
            Status = status;
            if (body != null) 
                Body = body;
        }
    }

    static class Statuses
    {
        public const string Success = "success";
        public const string NotFound = "not found";
        public const string BadRequest = "bad request";
    }
}
