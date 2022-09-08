# Registration

```cs
public static IServiceCollection AddLogging(this IServiceCollection services) =>
  services.AddSingleton(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));
```
