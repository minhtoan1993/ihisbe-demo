#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["IHIS-BE-V1/IHIS-BE-V1.csproj", "IHIS-BE-V1/"]
RUN dotnet restore "IHIS-BE-V1/IHIS-BE-V1.csproj"
COPY . .
WORKDIR "/src/IHIS-BE-V1"
RUN dotnet build "IHIS-BE-V1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IHIS-BE-V1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IHIS-BE-V1.dll"]