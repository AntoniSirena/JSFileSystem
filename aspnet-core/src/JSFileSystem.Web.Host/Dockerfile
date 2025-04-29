FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/JSFileSystem.Web.Host/JSFileSystem.Web.Host.csproj", "src/JSFileSystem.Web.Host/"]
COPY ["src/JSFileSystem.Web.Core/JSFileSystem.Web.Core.csproj", "src/JSFileSystem.Web.Core/"]
COPY ["src/JSFileSystem.Application/JSFileSystem.Application.csproj", "src/JSFileSystem.Application/"]
COPY ["src/JSFileSystem.Core/JSFileSystem.Core.csproj", "src/JSFileSystem.Core/"]
COPY ["src/JSFileSystem.EntityFrameworkCore/JSFileSystem.EntityFrameworkCore.csproj", "src/JSFileSystem.EntityFrameworkCore/"]
WORKDIR "/src/src/JSFileSystem.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/JSFileSystem.Web.Host", "src/JSFileSystem.Web.Host"]
COPY ["src/JSFileSystem.Web.Core", "src/JSFileSystem.Web.Core"]
COPY ["src/JSFileSystem.Application", "src/JSFileSystem.Application"]
COPY ["src/JSFileSystem.Core", "src/JSFileSystem.Core"]
COPY ["src/JSFileSystem.EntityFrameworkCore", "src/JSFileSystem.EntityFrameworkCore"]
WORKDIR "/src/src/JSFileSystem.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "JSFileSystem.Web.Host.dll"]
