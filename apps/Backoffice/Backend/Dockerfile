#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY "CsharpDDDSkeleton.sln" "CsharpDDDSkeleton.sln"

COPY ["apps/Backoffice/Backend/Backend.csproj", "apps/Backoffice/Backend/Backend.csproj"]
COPY ["apps/Backoffice/Frontend/Frontend.csproj", "apps/Backoffice/Frontend/Frontend.csproj"]
COPY ["apps/Mooc/Backend/Backend.csproj", "apps/Mooc/Backend/Backend.csproj"]
COPY ["src/Backoffice/Backoffice.csproj", "src/Backoffice/Backoffice.csproj"]
COPY ["src/Shared/Shared.csproj", "src/Shared/Shared.csproj"]

#RUN dotnet restore "CsharpDDDSkeleton.sln"

COPY . .
WORKDIR "/src/apps/Backoffice/Backend"
RUN dotnet build "Backend.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "Backend.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodelyTv.Apps.Backoffice.Backend.dll"]
