FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DotNet/src/DylanRidenSite.Web.Client/DylanRidenSite.Web.Client.csproj", "DotNet/src/DylanRidenSite.Web.Client/"]
RUN dotnet restore "DotNet/src/DylanRidenSite.Web.Client/DylanRidenSite.Web.Client.csproj"
COPY . .
WORKDIR "/src/DotNet/src/DylanRidenSite.Web.Client"
RUN dotnet build "DylanRidenSite.Web.Client.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "DylanRidenSite.Web.Client.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DylanRidenSite.Web.Client.dll"]
