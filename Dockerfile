FROM mcr.microsoft.com/dotnet/aspnet:6.0 as base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
COPY . /src
WORKDIR /src
RUN rm -r dbscripts
RUN dotnet build "campus-crawl-web-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "campus-crawl-web-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

EXPOSE 80
EXPOSE 8080
EXPOSE 443

ENV PORT=8080
ENV ASPNETCORE_URLS=http://*:${PORT}

ENTRYPOINT ["dotnet", "campus-crawl-web-api.dll"]
