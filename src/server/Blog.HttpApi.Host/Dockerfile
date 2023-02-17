#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/server/Blog.HttpApi.Host/Blog.HttpApi.Host.csproj", "src/server/Blog.HttpApi.Host/"]
COPY ["src/server/Blog.Application/Blog.Application.csproj", "src/server/Blog.Application/"]
COPY ["src/server/Blog.Domain/Blog.Domain.csproj", "src/server/Blog.Domain/"]
COPY ["src/server/Blog.Domain.Shared/Blog.Domain.Shared.csproj", "src/server/Blog.Domain.Shared/"]
COPY ["src/server/Blog.Application.Contracts/Blog.Application.Contracts.csproj", "src/server/Blog.Application.Contracts/"]
COPY ["src/server/Blog.EntityFrameworkCore/Blog.EntityFrameworkCore.csproj", "src/server/Blog.EntityFrameworkCore/"]
RUN dotnet restore "src/server/Blog.HttpApi.Host/Blog.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/server/Blog.HttpApi.Host"
RUN dotnet build "Blog.HttpApi.Host.csproj" --os linux -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Blog.HttpApi.Host.csproj" --os linux -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blog.HttpApi.Host.dll"]