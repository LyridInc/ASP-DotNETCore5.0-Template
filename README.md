# Lyrid .NET Core 5.0 ASP.NET Template

## Run locally with:
```
dotnet restore .\dotnet5_asp.template\
dotnet run --project dotnet5_asp.template
```

Open http://localhost:3000

## Edit the names (optional):
Open .lyrid-definition and change the App and Module name, because this will override another applications with the same name in the platform.

## Then submit to Lyrid Platform:

```
lc code submit
```
Wait until the cloud platform to finish with the build and the default deployment.

## Start hacking:

Edit the route url, settings, and views at Startup/Startup.cs file at dotnet5_asp.template project with your custom APIs. 

Add more middlewares or your business logic in there.
