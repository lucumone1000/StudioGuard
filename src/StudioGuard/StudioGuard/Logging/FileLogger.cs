namespace StudioGuard.Logging;

internal class FileLogger
{
    private readonly string _logFilePath;

    public FileLogger(string logFilePath)
    {
        _logFilePath = logFilePath;
    }

    public void Log(LogEntry entry)
    {
        string line =
            $"{entry.Timestamp:yyyy-MM-dd HH:mm:ss} [{entry.Level}] {entry.Message}";

        File.AppendAllText(
            _logFilePath,
            line + Environment.NewLine);
    }
}