FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000
ENV ASPNETCORE_ENVIRONMENT=Development
ENV ConnectionStrings__DefaultConnection="Server=db;Database=SoccerDb;Username=root;Password=2510203121;"
# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["Soccer.Api/Soccer.Api.csproj", "Soccer.Api/"]
RUN dotnet restore "Soccer.Api/Soccer.Api.csproj"
COPY . .
WORKDIR "/src/Soccer.Api"
RUN dotnet build "Soccer.Api.csproj" -o /app/build

FROM build AS publish
RUN dotnet publish "Soccer.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false


FROM build AS final
WORKDIR /src
COPY --from=build /src .
WORKDIR /src/Soccer.Api
ENTRYPOINT ["dotnet", "run" ,"watch"]
