# AspNetCore.RouteAnalyzer
View all route information for ASP.NET Core project.

## Screenshot
![screenshot](https://raw.githubusercontent.com/kobake/AspNetCore.RouteAnalyzer/master/screenshots/screenshot.png)

## Usage on your ASP.NET Core project
### Install NuGet package
- [NuGet Gallery | AspNetCore.RouteAnalyzer](https://www.nuget.org/packages/AspNetCore.RouteAnalyzer)

```
PM> Install-Package AspNetCore.RouteAnalyzer
```

### Edit Startup.cs
Insert codes ```services.AddRouteAnalyzer();``` and ```routes.MapRouteAnalyzer("/routes");``` into Startup.cs as follows.

```cs
....

public class Startup
{
    ....

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
        services.AddRouteAnalyzer(); // Add
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        ....

        app.UseMvc(routes =>
        {
            routes.MapRouteAnalyzer("/routes"); // Add
            routes.MapRoute(
                name: "default",
                template: "{controller}/{action=Index}/{id?}");
        });
    }

    ....
}
```

### Browse
Access url of ```http://..../routes``` to view all route informations. (This url ```/routes``` can be customized by ```MapRouteAnalyzer()```.)
