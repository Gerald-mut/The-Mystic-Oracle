# Stage 1: Build the app
# We use the .NET 8 SDK (Software Development Kit) image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
# This is done first to speed up future builds (caching)
COPY MysticOracle.csproj .
RUN dotnet restore

# Copy the rest of the source code and publish
COPY . .
RUN dotnet publish MysticOracle.csproj -c Release -o /app/publish

# Stage 2: Create the final, small runtime image
# We use the much smaller ASP.NET runtime-only image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# The .NET 8 base image automatically listens on port 8080.
# Railway will detect this.
ENTRYPOINT ["dotnet", "MysticOracle.dll"]