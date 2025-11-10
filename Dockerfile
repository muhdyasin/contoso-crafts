# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy everything
COPY . .

# Restore and publish using the correct project path
RUN dotnet restore "Contoso_Crafts/ContosoCrafts.WebSite.csproj"
RUN dotnet publish "Contoso_Crafts/ContosoCrafts.WebSite.csproj" -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "ContosoCrafts.WebSite.dll"]
