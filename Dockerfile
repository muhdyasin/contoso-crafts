# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies first (cache layer)
COPY ["Contoso_Crafts/Contoso_Crafts.csproj", "Contoso_Crafts/"]
RUN dotnet restore "Contoso_Crafts/Contoso_Crafts.csproj"

# Copy everything else and publish
COPY . .
RUN dotnet publish "Contoso_Crafts/Contoso_Crafts.csproj" -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "Contoso_Crafts.dll"]
