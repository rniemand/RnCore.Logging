# Usage

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
