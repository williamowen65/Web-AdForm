# Use the official .NET runtime image as a base (runtime environment)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Use the official .NET SDK image for build (build environment)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy the solution file and project files to the container
COPY ["Web AdForm.sln", "./"]
COPY ["Web AdForm/Web AdForm.csproj", "Web AdForm/"]

# Restore dependencies
RUN dotnet restore "Web AdForm.sln"

# Copy the rest of the app files to the container
COPY . ./

# Build the app
RUN dotnet publish "Web AdForm/Web AdForm.csproj" -c Release -o /app/publish

# Final stage: Copy the build output to the runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "Web AdForm.dll"]
