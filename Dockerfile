#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["condominio-core-api.csproj", "condominio-core-api/"]
RUN dotnet restore "condominio-core-api/condominio-core-api.csproj"
WORKDIR "/src/condominio-core-api"
COPY . .
RUN dotnet build "condominio-core-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "condominio-core-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet condominio.core.api.dll