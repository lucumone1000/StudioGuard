using StudioGuard.Logging;

namespace StudioGuard;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        string logFolder = Path.Combine(
            AppContext.BaseDirectory,
            "Logs");

        Directory.CreateDirectory(logFolder);

        string logFilePath = Path.Combine(
            logFolder,
            "studioguard.log");

        FileLogger logger = new FileLogger(logFilePath);

        logger.Log(new LogEntry
        {
            Timestamp = DateTime.Now,
            Level = "INFO",
            Message = "StudioGuard avviato."
        });

        Application.Run(new MainForm());
    }
}