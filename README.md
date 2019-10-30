# WebApi-End-to-End
.Net Core 3.0 WebApi application

This project is used to introduce architecture and design patterns.  The applications is built using .Net Core 3.0.  

### Architecture & Design Patterns
- Onion Architecture
- Object Relational Mapping (ORM)
- SOLID
- Dependency Inversion
- Arrange Act Assert
- Factory

### Core Technologies:
- C#
- Entity Framework
- Asp.Net WebApi
- MSTest
- Autofac
- Moq

### Tools:
- Cmder
- Visual Studio 2019
- .Net Core 3.0
- Linqpad
- Resharper
- SQL Server Developer Edition
- SQL Server Management Studio

# Create Solution

### Create a Solution File
```
dotnet new sln -n HeroVillainTour
```

### Create Visual Studio Projects
```
dotnet new webapi -n HeroVillainTour.WebAPI --no-https --auth None --framework netcoreapp3.0
dotnet new classlib -n HeroVillainTour.Core --framework netcoreapp3.0
dotnet new classlib -n HeroVillainTour.BusinessLayer --framework netcoreapp3.0
dotnet new classlib -n HeroVillainTour.ApiModels --framework netcoreapp3.0
dotnet new classlib -n HeroVillainTour.DomainModels --framework netcoreapp3.0
dotnet new classlib -n HeroVillainTour.Data --framework netcoreapp3.0
dotnet new mstest -n HeroVillainTour.Tests --framework netcoreapp3.0
```

### Add Projcts to SLN File
```
dotnet sln HeroVillainTour.sln add "HeroVillainTour.WebAPI\HeroVillainTour.WebAPI.csproj"
dotnet sln HeroVillainTour.sln add "HeroVillainTour.Core\HeroVillainTour.Core.csproj"
dotnet sln HeroVillainTour.sln add "HeroVillainTour.BusinessLayer\HeroVillainTour.BusinessLayer.csproj"
dotnet sln HeroVillainTour.sln add "HeroVillainTour.ApiModels\HeroVillainTour.ApiModels.csproj"
dotnet sln HeroVillainTour.sln add "HeroVillainTour.DomainModels\HeroVillainTour.DomainModels.csproj"
dotnet sln HeroVillainTour.sln add "HeroVillainTour.Data\HeroVillainTour.Data.csproj"
dotnet sln HeroVillainTour.sln add "HeroVillainTour.Tests\HeroVillainTour.Tests.csproj"
```

### Setup Core Project References
```
dotnet add HeroVillainTour.Core\HeroVillainTour.Core.csproj reference HeroVillainTour.ApiModels\HeroVillainTour.ApiModels.csproj
dotnet add HeroVillainTour.Core\HeroVillainTour.Core.csproj reference HeroVillainTour.DomainModels\HeroVillainTour.DomainModels.csproj
```

### Setup WebAPI Project References
```
dotnet add HeroVillainTour.WebAPI\HeroVillainTour.WebAPI.csproj reference HeroVillainTour.Core\HeroVillainTour.Core.csproj
dotnet add HeroVillainTour.WebAPI\HeroVillainTour.WebAPI.csproj reference HeroVillainTour.BusinessLayer\HeroVillainTour.BusinessLayer.csproj
dotnet add HeroVillainTour.WebAPI\HeroVillainTour.WebAPI.csproj reference HeroVillainTour.ApiModels\HeroVillainTour.ApiModels.csproj
dotnet add HeroVillainTour.WebAPI\HeroVillainTour.WebAPI.csproj reference HeroVillainTour.Data\HeroVillainTour.Data.csproj
```

### Setup BusinessLayer Project References
```
dotnet add HeroVillainTour.BusinessLayer\HeroVillainTour.BusinessLayer.csproj reference HeroVillainTour.Core\HeroVillainTour.Core.csproj
dotnet add HeroVillainTour.BusinessLayer\HeroVillainTour.BusinessLayer.csproj reference HeroVillainTour.ApiModels\HeroVillainTour.ApiModels.csproj
dotnet add HeroVillainTour.BusinessLayer\HeroVillainTour.BusinessLayer.csproj reference HeroVillainTour.DomainModels\HeroVillainTour.DomainModels.csproj
dotnet add HeroVillainTour.BusinessLayer\HeroVillainTour.BusinessLayer.csproj reference HeroVillainTour.Data\HeroVillainTour.Data.csproj
```

### Setup Data Project References
```
dotnet add HeroVillainTour.Data\HeroVillainTour.Data.csproj reference HeroVillainTour.DomainModels\HeroVillainTour.DomainModels.csproj
dotnet add HeroVillainTour.Data\HeroVillainTour.Data.csproj reference HeroVillainTour.Core\HeroVillainTour.Core.csproj
```

### Setup Tests Project References
```
dotnet add HeroVillainTour.Tests\HeroVillainTour.Tests.csproj reference HeroVillainTour.Core\HeroVillainTour.Core.csproj
dotnet add HeroVillainTour.Tests\HeroVillainTour.Tests.csproj reference HeroVillainTour.BusinessLayer\HeroVillainTour.BusinessLayer.csproj
dotnet add HeroVillainTour.Tests\HeroVillainTour.Tests.csproj reference HeroVillainTour.ApiModels\HeroVillainTour.ApiModels.csproj
dotnet add HeroVillainTour.Tests\HeroVillainTour.Tests.csproj reference HeroVillainTour.DomainModels\HeroVillainTour.DomainModels.csproj
dotnet add HeroVillainTour.Tests\HeroVillainTour.Tests.csproj reference HeroVillainTour.Data\HeroVillainTour.Data.csproj
```

### Add Newtonsoft.Json Nuget Packages
```
dotnet add HeroVillainTour.WebAPI\HeroVillainTour.WebAPI.csproj package Newtonsoft.Json
dotnet add HeroVillainTour.BusinessLayer\HeroVillainTour.BusinessLayer.csproj package Newtonsoft.Json
```

### Add Microsoft.EntityFrameworkCore
```
dotnet add HeroVillainTour.Data\HeroVillainTour.Data.csproj package Microsoft.EntityFrameworkCore
```

### Add Microsoft.EntityFrameworkCore.SqlServer 
```
dotnet add HeroVillainTour.Data\HeroVillainTour.Data.csproj package Microsoft.EntityFrameworkCore.SqlServer
```

### Add Microsoft.EntityFrameworkCore.Design 
```
dotnet add HeroVillainTour.Data\HeroVillainTour.Data.csproj package Microsoft.EntityFrameworkCore.Design
dotnet add HeroVillainTour.WebAPI\HeroVillainTour.WebAPI.csproj package Microsoft.EntityFrameworkCore.Design
```

### Add Microsoft.EntityFrameworkCore.Tools 
```
dotnet add HeroVillainTour.Data\HeroVillainTour.Data.csproj package Microsoft.EntityFrameworkCore.Tools
dotnet add HeroVillainTour.WebAPI\HeroVillainTour.WebAPI.csproj package Microsoft.EntityFrameworkCore.Tools
```

### Add Autofac Nuget Package
```
dotnet add HeroVillainTour.WebAPI\HeroVillainTour.WebAPI.csproj package Autofac
dotnet add HeroVillainTour.Core\HeroVillainTour.Core.csproj package Autofac
dotnet add HeroVillainTour.BusinessLayer\HeroVillainTour.BusinessLayer.csproj package Autofac
dotnet add HeroVillainTour.ApiModels\HeroVillainTour.ApiModels.csproj package Autofac
dotnet add HeroVillainTour.DomainModels\HeroVillainTour.DomainModels.csproj package Autofac
dotnet add HeroVillainTour.Data\HeroVillainTour.Data.csproj package Autofac
dotnet add HeroVillainTour.Tests\HeroVillainTour.Tests.csproj package Autofac
```
 
### Autofac.Extensions.DependencyInjection
```
dotnet add HeroVillainTour.WebAPI\HeroVillainTour.WebAPI.csproj package Autofac.Extensions.DependencyInjection
dotnet add HeroVillainTour.Core\HeroVillainTour.Core.csproj package Autofac.Extensions.DependencyInjection
dotnet add HeroVillainTour.BusinessLayer\HeroVillainTour.BusinessLayer.csproj package Autofac.Extensions.DependencyInjection
dotnet add HeroVillainTour.ApiModels\HeroVillainTour.ApiModels.csproj package Autofac.Extensions.DependencyInjection
dotnet add HeroVillainTour.DomainModels\HeroVillainTour.DomainModels.csproj package Autofac.Extensions.DependencyInjection
dotnet add HeroVillainTour.Data\HeroVillainTour.Data.csproj package Autofac.Extensions.DependencyInjection
dotnet add HeroVillainTour.Tests\HeroVillainTour.Tests.csproj package Autofac.Extensions.DependencyInjection
```

### Moq
```
dotnet add HeroVillainTour.Tests\HeroVillainTour.Tests.csproj package Moq
```

