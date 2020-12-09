FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5003
#ENV ASPNETCORE_URLS=http://*:5003

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TMmvc.csproj", "./"]
RUN dotnet restore "TMmvc.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "TMmvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TMmvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TMmvc.dll"]
