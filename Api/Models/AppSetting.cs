namespace Api.Models;

public record AppSetting
{
    public string AllowedHosts { get; set; } = string.Empty;
    public ConnectionStrings ConnectionStrings { get; set; } = new();
    public Logging Logging { get; set; } = new();
}

public record ConnectionStrings
{
    public string LocalConnection { get; set; } = string.Empty;
}

public class Logging 
{
    public LogLevel LogLevel { get; set; } = new();
}

public class LogLevel 
{
    public string Default { get; set; } = string.Empty;
    public string MicrosoftAspNetCore { get; set; } = string.Empty;
}