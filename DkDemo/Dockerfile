#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 8082
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["DkDemo/DkDemo.csproj", "DkDemo/"]
RUN dotnet restore "DkDemo/DkDemo.csproj"
COPY . .
WORKDIR "/src/DkDemo"
RUN dotnet build "DkDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DkDemo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DkDemo.dll"]

ENV ASPNETCORE_URLS http://+:82