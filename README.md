# effective-guacamole
[Andre Lopes] Building a multi layer .NET Core 3.0 API from zero

Grab the article at [https://medium.com/swlh/building-a-nice-multi-layer-net-core-3-api-c68a9ef16368](https://medium.com/swlh/building-a-nice-multi-layer-net-core-3-api-c68a9ef16368)

## Tips/Run

* Running the project - at [https://localhost:5001](https://localhost:5001) - through [Swagger](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) ('Swashbuckle.AspNetCore', version 5.0.0-rc3) ("dotnet run -p MyMusic.Api/MyMusic.Api.csproj");

## Errors Experienced

* My powershell terminal in VSCode installed dotnet-ef but wouldn't run it even after uninstalling ("dotnet tool uninstall --global dotnet-ef") and targeting a specific latest build ("dotnet tool install --global dotnet-ef --version 3.*"), it was evidently running successfully outside of VSCode and in a normal PS terminal;
* I ended up having to install 'Microsoft.EntityFrameworkCore.Design' into the Api project also ("dotnet add MyMusic.Api/MyMusic.Api.csproj package Microso;ft.EntityFrameworkCore.Design")

## Notes:

* EntityFramework Core is no longer consumed from with "dotnet cli", a global installation to my environment was applied for use within the project via "dotnet tool install --global dotnet-ef";
* The dependency injected here was marked as Scoped. There are 3 types of dependency injection:
    * Transient — "Objects are different. One new instance is provided to every controller and every service"
    * Scoped — "Objects are same through the request"
    * Singleton — "Objects are the same for every request during the application lifetime"

## What's it all about?

* Let's build together a multi layer .NET Core API with the latest framework version and most used patterns

## Thanks

Thanks goes out to Andre Lopes for the FREE stuff!

* [Andre Lopes's Medium profile](https://medium.com/@andrevitorlopes) ...Full-stack developer and casual gamer...
