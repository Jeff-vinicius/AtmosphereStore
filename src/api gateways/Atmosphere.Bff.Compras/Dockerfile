#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/api gateways/Atmosphere.Bff.Compras/Atmosphere.Bff.Compras.csproj", "src/api gateways/Atmosphere.Bff.Compras/"]
RUN dotnet restore "src/api gateways/Atmosphere.Bff.Compras/Atmosphere.Bff.Compras.csproj"
COPY . .
WORKDIR "/src/src/api gateways/Atmosphere.Bff.Compras"
RUN dotnet build "Atmosphere.Bff.Compras.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Atmosphere.Bff.Compras.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Atmosphere.Bff.Compras.dll"]