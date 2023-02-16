#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/web/Blog.Server.Web/Blog.Server.Web.csproj", "src/web/Blog.Server.Web/"]
COPY ["src/web/Blog.Component/Blog.Component.csproj", "src/web/Blog.Component/"]
COPY ["src/server/Blog.Application.Contract/Blog.Application.Contract.csproj", "src/server/Blog.Application.Contract/"]
COPY ["src/server/Blog.Domain.Shared/Blog.Domain.Shared.csproj", "src/server/Blog.Domain.Shared/"]
COPY ["src/web/Blog.Shared/Blog.Shared.csproj", "src/web/Blog.Shared/"]
COPY ["src/web/Blog.HttpApi.Client/Blog.HttpApi.Client.csproj", "src/web/Blog.HttpApi.Client/"]
RUN dotnet restore "src/web/Blog.Server.Web/Blog.Server.Web.csproj"
COPY . .
WORKDIR "/src/src/web/Blog.Server.Web"
RUN dotnet build "Blog.Server.Web.csproj" -c Release --os linux -o /app/build

FROM build AS publish
RUN dotnet publish "Blog.Server.Web.csproj" -c Release --os linux -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Blog.Server.Web.dll"]