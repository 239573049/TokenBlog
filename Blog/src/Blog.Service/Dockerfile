#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Directory.Build.props", "."]
COPY ["src/Blog.Service/Blog.Service.csproj", "src/Blog.Service/"]
COPY ["src/Blog.Contracts/Blog.Contracts.csproj", "src/Blog.Contracts/"]
RUN dotnet restore "src/Blog.Service/Blog.Service.csproj"
COPY . .
WORKDIR "/src/src/Blog.Service"
RUN dotnet build "Blog.Service.csproj" -c Release --os linux -o /app/build

FROM build AS publish
RUN dotnet publish "Blog.Service.csproj" -c Release --os linux -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blog.Service.dll"]