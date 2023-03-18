# Use the official .NET 6 SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Set the working directory to /app
WORKDIR /app

# Copy the project file and restore dependencies
COPY *.csproj .
RUN dotnet restore

# Copy the rest of the code and build the app
COPY . .
RUN dotnet publish -c Release -o out

# Use the official .NET 6 runtime image as the base image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime

# Set the working directory to /app
WORKDIR /app

# Copy the built app from the previous stage to the runtime image
COPY --from=build /app/out .

# Expose port 80 for the app to listen on
EXPOSE 80

# Set the command to start the app
CMD ["dotnet", "campus-crawler-web-api.dll"]

