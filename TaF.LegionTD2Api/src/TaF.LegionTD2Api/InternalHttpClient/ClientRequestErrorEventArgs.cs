using System;

namespace TaF.LegionTD2Api.InternalHttpClient
{
    public class ClientRequestErrorEventArgs : EventArgs
    {
        public ClientRequestErrorEventArgs(int statusCode, string message)
        {
            Message = message;
        }

        public int StatusCode { get; }
        public string Message { get; }
    }
}