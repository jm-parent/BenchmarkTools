namespace BenchmarkTools.Core.Models;

public enum AppTheme
{
    System,
    Light,
    Dark
}

public class AppSettings
{
    public AppTheme Theme { get; set; } = AppTheme.System;
    public int TotalSessions { get; set; }
}
