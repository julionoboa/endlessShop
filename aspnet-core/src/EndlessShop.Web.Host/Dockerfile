FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/EndlessShop.Web.Host/EndlessShop.Web.Host.csproj", "src/EndlessShop.Web.Host/"]
COPY ["src/EndlessShop.Web.Core/EndlessShop.Web.Core.csproj", "src/EndlessShop.Web.Core/"]
COPY ["src/EndlessShop.Application/EndlessShop.Application.csproj", "src/EndlessShop.Application/"]
COPY ["src/EndlessShop.Core/EndlessShop.Core.csproj", "src/EndlessShop.Core/"]
COPY ["src/EndlessShop.EntityFrameworkCore/EndlessShop.EntityFrameworkCore.csproj", "src/EndlessShop.EntityFrameworkCore/"]
WORKDIR "/src/src/EndlessShop.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/EndlessShop.Web.Host", "src/EndlessShop.Web.Host"]
COPY ["src/EndlessShop.Web.Core", "src/EndlessShop.Web.Core"]
COPY ["src/EndlessShop.Application", "src/EndlessShop.Application"]
COPY ["src/EndlessShop.Core", "src/EndlessShop.Core"]
COPY ["src/EndlessShop.EntityFrameworkCore", "src/EndlessShop.EntityFrameworkCore"]
WORKDIR "/src/src/EndlessShop.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "EndlessShop.Web.Host.dll"]
