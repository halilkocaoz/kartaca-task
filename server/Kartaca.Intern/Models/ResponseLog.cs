
using System;

namespace Kartaca.Intern.Models
{
    public class ResponseLog
    {
        public ResponseLog(string method, long elapsedTime)
        {
            Method = method;
            ElapsedTime = elapsedTime;
            Message = $"{Method} {ElapsedTime} {DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}";
        }
        
        public ResponseLog(string method, long elapsedTime, long timestamp)
        {
            Method = method;
            ElapsedTime = elapsedTime;
            Timestamp = timestamp;
        }

        public string Method { get; set; }
        public long ElapsedTime { get; set; }
        public string Message { get; set; }
        public long Timestamp { get; set; }
    }
}