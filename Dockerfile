
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app


EXPOSE 80
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT Development


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src


COPY ["ApiCarus/ApiCarus.csproj", "ApiCarus/"]



RUN dotnet restore "ApiCarus/ApiCarus.csproj"


COPY . .


FROM build AS publish
RUN dotnet publish "ApiCarus/ApiCarus.csproj" -c Release -o /app/publish /p:UseAppHost=false


FROM base AS final
WORKDIR /app


COPY --from=publish /app/publish .


ENTRYPOINT ["dotnet", "ApiCarus.dll"]