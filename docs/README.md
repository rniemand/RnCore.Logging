# RnCore.Logging

Put simply, `RnCore.Logging` is a simple wrapper for the `ILogger<T>` interface found in **[Microsoft.Extensions.Logging.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions)** which makes testing logging a lot simpler.

> Current version: **6.0.0.103**

## Source Code
You can view the source code **[on GitHub](https://github.com/rniemand/RnCore.Logging)**, or by clicking the link in the top right corner.

## NuGet
You can install `RnCore.Logging` via **[NuGet](https://www.nuget.org/packages/RnCore.Logging/)** by running:

```powershell
Install-Package RnCore.Logging
```

## Getting Started
Follow the steps below to get started with `RnCore.Logging`:

- [Install](./installation.md) `RnCore.Logging` via NuGet.
- [Configure](./configuration.md) logging as per normal.
- [Register](./registration.md) `ILoggerAdapter` with your DI container.
- [Start Logging](./usage.md) your messages!
