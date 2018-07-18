FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY ProductAPI/*.csproj ./ProductAPI/
RUN dotnet restore

# copy everything else and build app
COPY ProductAPI/. ./ProductAPI/
WORKDIR /app/ProductAPI
RUN dotnet publish -c Release -o out


FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/ProductAPI/out ./
ENTRYPOINT ["dotnet", "ProductAPI.dll"]