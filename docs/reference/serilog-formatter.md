---
mapped_pages:
  - https://www.elastic.co/guide/en/ecs-logging/dotnet/current/serilog-formatter.html
---

# Serilog formatter [serilog-formatter]

This `ITextFormatter` implementation formats a Serilog event into a JSON representation that adheres to the Elastic Common Schema specification.

## Installation [_installation_2]

Add a reference to the [Elastic.CommonSchema.Serilog](http://nuget.org/packages/Elastic.CommonSchema.Serilog) package:

```xml
<PackageReference Include="Elastic.CommonSchema.Serilog" Version="8.6.0" />
```


## Usage [_usage_2]

```csharp
var logger = new LoggerConfiguration()
    .WriteTo.Console(new EcsTextFormatter())
    .CreateLogger();
```

In the code snippet above `new EcsTextFormatter()` enables the text formatter and instructs Serilog to format the event as JSON. The sample above uses the Console sink, but you are free to use any sink of your choice, perhaps consider using a filesystem sink and [Elastic Filebeat](https://www.elastic.co/downloads/beats/filebeat) for durable and reliable ingestion.

In ASP.NET (core) applications

```csharp
.UseSerilog((ctx, config) =>
{
	// Ensure HttpContextAccessor is accessible
	var httpAccessor = ctx.Configuration.Get<HttpContextAccessor>();

	config
		.ReadFrom.Configuration(ctx.Configuration)
		.Enrich.WithEcsHttpContext(httpAccessor)
		.WriteTo.Async(a => a.Console(new EcsTextFormatter()));
})
```

The `WithEcsHttpContext` ensures logs will be enriched with `HttpContext` data.

An example of the output is given below:

```json
{
  "@timestamp": "2019-11-22T14:59:02.5903135+11:00",
  "log.level": "Information",
  "message": "Log message",
  "ecs": {
    "version": "1.4.0"
  },
  "event": {
    "severity": 0,
    "timezone": "AUS Eastern Standard Time",
    "created": "2019-11-22T14:59:02.5903135+11:00"
  },
  "log": {
    "logger": "Elastic.CommonSchema.Serilog"
  },
  "process": {
    "thread": {
      "id": 1
    },
    "executable": "System.Threading.ExecutionContext"
  }
}
```


## Configuration [_configuration]

| Option | Description |
| --- | --- |
| `MapCurrentThead` | `true` map `ecs.process` by looking up the `Process` from the current thread |
| `MapHttpAdapter` | `null` a way to map `HttpContextAccessor` to ECS fields. |
| `LogEventPropertiesToFilter` | A `Set<string>` of properties that should not be emitted as `labels.*` or `metadata.*` |
| `MapCustom` | A Func that allows you to mutate the EcsDocument before its fully converted. |


## ECS aware message templates [_ecs_aware_message_templates_2]

This formatter also allows you to set ECS fields directly from the message template using properties that adhere to the [https://messagetemplates.org/](https://messagetemplates.org/) format.

The available ECS message template properties are listed under `LogTemplateProperties.*` e.g `LogTemplateProperties.TraceId`

```csharp
Log.Information("The time is {TraceId}", "my-trace-id");
```

Will override `trace.id` on the resulting ECS json document.


