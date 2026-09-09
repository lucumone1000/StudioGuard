namespace StudioGuard.Configuration;

internal class AppSettings
{
    public string OneDriveFolder { get; set; } = string.Empty;

    public string TargetPath { get; set; } = string.Empty;

    public string LogFolder { get; set; } = string.Empty;

    public string BackupPath { get; set; } = string.Empty;

    public int MonitoringIntervalSeconds { get; set; } = 60;
}