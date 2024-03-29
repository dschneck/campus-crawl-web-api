FROM mcr.microsoft.com/dotnet/aspnet:6.0 as base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
COPY . app/
WORKDIR /app
RUN dotnet build "campus-crawl-web-api.sln" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "campus-crawl-web-api.sln" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY ./campus-crawler-web-api-9b22192eb631.json .

EXPOSE 8080
EXPOSE 443

ENV PORT=8080
ENV ASPNETCORE_URLS=http://*:${PORT}
ENV GOOGLE_APPLICATION_CREDENTIALS='./campus-crawler-web-api-9b22192eb631.json'

ENTRYPOINT ["dotnet", "Api.dll"]
