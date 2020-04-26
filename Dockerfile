FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY *sln .
COPY condominio-core-api/*.csproj condominio-core-api/
RUN dotnet restore
COPY . .

FROM build AS publish
WORKDIR /src/condominio-core-api
RUN dotnet publish -c Release -o /src/publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime
WORKDIR /app
COPY --from=publish /src/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet condominio-core-api.dll

