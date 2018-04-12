using System;

namespace SendCloudApi.Net.Exceptions
{
    public class SendCloudException : Exception
    {
        public SendCloudException(string message) : base(message) {}
    }
}
