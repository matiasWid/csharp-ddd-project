#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
ARG START_ARGUMENTS=""
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["apps/Backoffice/Backend/Backend.csproj", "apps/Backoffice/Backend/"]
COPY ["apps/Backoffice/Frontend/Frontend.csproj", "apps/Backoffice/Frontend/"]
COPY ["apps/Mooc/Backend/Backend.csproj", "apps/Mooc/Backend/"]
COPY ["src/Backoffice/Backoffice.csproj", "src/Backoffice/"]
COPY ["src/Mooc/Mooc.csproj", "src/Mooc/"]
COPY ["src/Shared/Shared.csproj", "src/Shared/"]
RUN dotnet restore "apps/Mooc/Backend/Backend.csproj"
COPY . .
WORKDIR "/src/apps/Mooc/Backend"
RUN dotnet build "Backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Backend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CodelyTv.Apps.Mooc.Backend.dll", START_ARGUMENTS]
