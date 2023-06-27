using System;

namespace TaF.LegionTD2Api.InternalHttpClient
{
    public class ClientRequestEventArgs : EventArgs
    {
        public string Url { get; set; }
        public string RequestContent { get; set; }
        public string ResponseContent { get; set; }
    }
}