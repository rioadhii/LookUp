FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["LookUp.WebAPI/LookUp.WebAPI.csproj", "LookUp.WebAPI/"]
RUN dotnet restore "LookUp.WebAPI/LookUp.WebAPI.csproj"
COPY . .
WORKDIR "/src/LookUp.WebAPI"
RUN dotnet build "LookUp.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LookUp.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LookUp.WebAPI.dll"]
