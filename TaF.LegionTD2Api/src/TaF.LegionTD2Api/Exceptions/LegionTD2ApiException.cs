using System;

namespace SkyeNet.ValorantAPI.Exceptions
{
    public class LegionTD2ApiException : Exception
    {
        public LegionTD2ApiException()
        {
        }

        public LegionTD2ApiException(string message) : base(message)
        {
        }

        public LegionTD2ApiException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}