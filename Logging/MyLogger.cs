using Serilog;

namespace Logging
{
    public class MyLogger
    {
        const string LOG_FILE = "log.txt";

        public static void LogAMessage(string message)
        {
            using (var log = new LoggerConfiguration()
                                    .WriteTo.File(LOG_FILE)
                                    .CreateLogger())
            {
                log.Information(message);
            }
        }
    }
}
