#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["NuGet.Config", "."]
COPY ["src/Blog.HttpApi.Host/Blog.HttpApi.Host.csproj", "src/Blog.HttpApi.Host/"]
COPY ["src/Blog.Application/Blog.Application.csproj", "src/Blog.Application/"]
COPY ["src/Blog.Domain/Blog.Domain.csproj", "src/Blog.Domain/"]
COPY ["src/Blog.Domain.Shared/Blog.Domain.Shared.csproj", "src/Blog.Domain.Shared/"]
COPY ["src/Blog.Application.Contracts/Blog.Application.Contracts.csproj", "src/Blog.Application.Contracts/"]
COPY ["src/Blog.EntityFrameworkCore/Blog.EntityFrameworkCore.csproj", "src/Blog.EntityFrameworkCore/"]
COPY ["src/Blog.HttpApi/Blog.HttpApi.csproj", "src/Blog.HttpApi/"]
RUN dotnet restore "src/Blog.HttpApi.Host/Blog.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/Blog.HttpApi.Host"
RUN dotnet build "Blog.HttpApi.Host.csproj" -c Release --os linux -o /app/build

FROM build AS publish
RUN dotnet publish "Blog.HttpApi.Host.csproj" -c Release --os linux -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blog.HttpApi.Host.dll"]