FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY DutchAzureMeetup.WebApp/DutchAzureMeetup.WebApp.csproj DutchAzureMeetup.WebApp/
RUN dotnet restore DutchAzureMeetup.WebApp/DutchAzureMeetup.WebApp.csproj
COPY . .
WORKDIR /src/DutchAzureMeetup.WebApp
RUN dotnet build DutchAzureMeetup.WebApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish DutchAzureMeetup.WebApp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DutchAzureMeetup.WebApp.dll"]
