Put simply, `RnCore.Logging` is a simple wrapper for the `ILogger<T>` interface found in [Microsoft.Extensions.Logging.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions) which makes testing logging a lot simpler.

## Registration

```cs
public static IServiceCollection AddLogging(this IServiceCollection services) =>
  services.AddSingleton(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));
```

## Sample Usage

```cs
class MyClass {
  private readonly ILoggerAdapter<MyClass> _logger;

  public MyClass(ILoggerAdapter<MyClass> logger) {
    _logger = logger;
  }

  public void Foo() {
    _logger.LogInformation("Hello World!");
  }
}
```

## Configuration

Nothing special, just use the default logging configuration as this is just a wrapping class.
