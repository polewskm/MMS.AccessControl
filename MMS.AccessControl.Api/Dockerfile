FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["MMS.AccessControl.Api/MMS.AccessControl.Api.csproj", "MMS.AccessControl.Api/"]
RUN dotnet restore "MMS.AccessControl.Api/MMS.AccessControl.Api.csproj"
COPY . .
WORKDIR "/src/MMS.AccessControl.Api"
RUN dotnet build "MMS.AccessControl.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MMS.AccessControl.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MMS.AccessControl.Api.dll"]
