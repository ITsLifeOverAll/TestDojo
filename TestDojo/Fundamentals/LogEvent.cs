using Microsoft.Extensions.Logging;

namespace TestDojo.Fundamentals
{
    public class LogEvent
    {
        private ILogger _logger;

        public event EventHandler<Guid>? ErrorLogged;

        public LogEvent(ILogger logger)
        {
            _logger = logger;
        }
        
        public void LogError(string error)
        {
            if (string.IsNullOrEmpty(error))
            {
                throw new ArgumentNullException(nameof(error));
            }

            _logger.LogError("{Error}", error);

            ErrorLogged?.Invoke(this, Guid.NewGuid());
        }
    }
}
