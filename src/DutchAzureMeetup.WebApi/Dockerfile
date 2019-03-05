FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY DutchAzureMeetup.WebApi/DutchAzureMeetup.WebApi.csproj DutchAzureMeetup.WebApi/
RUN dotnet restore DutchAzureMeetup.WebApi/DutchAzureMeetup.WebApi.csproj
COPY . .
WORKDIR /src/DutchAzureMeetup.WebApi
RUN dotnet build DutchAzureMeetup.WebApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish DutchAzureMeetup.WebApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DutchAzureMeetup.WebApi.dll"]
