using Microsoft.Extensions.Logging;
using System.Diagnostics.CodeAnalysis;

namespace RnCore.Logging;

[ExcludeFromCodeCoverage]
public class LoggerAdapter : ILoggerAdapter
{
  private readonly ILogger _logger;

  public LoggerAdapter(ILogger logger)
  {
    _logger = logger;
  }

  public void LogTrace(string? message, params object?[] args)
  {
    if (!_logger.IsEnabled(LogLevel.Trace))
      return;

    _logger.LogTrace(message, args);
  }

  public void LogTrace(Exception? exception, string? message, params object?[] args)
  {
    if (!_logger.IsEnabled(LogLevel.Trace))
      return;

    _logger.LogTrace(exception, message, args);
  }

  public void LogDebug(string? message, params object?[] args)
  {
    if (!_logger.IsEnabled(LogLevel.Debug))
      return;

    _logger.LogDebug(message, args);
  }

  public void LogDebug(Exception? exception, string? message, params object?[] args)
  {
    if (!_logger.IsEnabled(LogLevel.Debug))
      return;

    _logger.LogDebug(exception, message, args);
  }

  public void LogInformation(string? message, params object?[] args)
  {
    if (!_logger.IsEnabled(LogLevel.Information))
      return;

    _logger.LogInformation(message, args);
  }

  public void LogInformation(Exception? exception, string? message, params object?[] args)
  {
    if (!_logger.IsEnabled(LogLevel.Information))
      return;

    _logger.LogInformation(exception, message, args);
  }

  public void LogWarning(string? message, params object?[] args)
  {
    if (!_logger.IsEnabled(LogLevel.Warning))
      return;

    _logger.LogWarning(message, args);
  }

  public void LogWarning(Exception? exception, string? message, params object?[] args)
  {
    if (!_logger.IsEnabled(LogLevel.Warning))
      return;

    _logger.LogWarning(exception, message, args);
  }

  public void LogError(string? message, params object?[] args)
  {
    if (!_logger.IsEnabled(LogLevel.Error))
      return;

    _logger.LogError(message, args);
  }

  public void LogError(Exception? exception, string? message, params object?[] args)
  {
    if (!_logger.IsEnabled(LogLevel.Error))
      return;

    _logger.LogError(exception, message, args);
  }
  
  public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter) =>
    _logger.Log(logLevel, eventId, state, exception, formatter);

  public bool IsEnabled(LogLevel logLevel) =>
    _logger.IsEnabled(logLevel);

  public IDisposable BeginScope<TState>(TState state) =>
    _logger.BeginScope(state);
}

[ExcludeFromCodeCoverage]
public class LoggerAdapter<T> : LoggerAdapter, ILoggerAdapter<T>
{
  public LoggerAdapter(ILogger<T> logger)
    : base(logger)
  { }
}
