#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 44390

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Mediator/Mediator.csproj", "Mediator/"]
COPY ["Business/Business.csproj", "Business/"]
COPY ["Data/Data.csproj", "Data/"]
COPY ["Core/Core.csproj", "Core/"]
RUN dotnet restore "Mediator/Mediator.csproj"
COPY . .
WORKDIR "/src/Mediator"
RUN dotnet build "Mediator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mediator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mediator.dll"]