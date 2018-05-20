# Create the build environment image
FROM microsoft/dotnet:2.0.0-sdk as build-env
WORKDIR /app

# Copy the project file and restore the dependencies
COPY ./TariffCompare/*.csproj ./
RUN dotnet restore

# Copy the remaining source files and build the application
COPY ./TariffCompare/ ./
RUN dotnet publish -c Release -o out

# Build the runtime image
FROM microsoft/dotnet:2.0.0-runtime
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT dotnet TariffCompare.dll $CONSUMPTION