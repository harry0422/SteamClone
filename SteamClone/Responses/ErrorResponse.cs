using System;

namespace SteamClone.Responses
{
    public class ErrorResponse
    {
        public ErrorResponse(Exception exception)
        {
            Id = exception.GetType().Name;
            Description = exception.Message;
        }

        public string Id { get; private set; }
        public string Description { get; private set; }
    }
}