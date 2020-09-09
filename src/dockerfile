FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /source

# copy and publish app and libraries
COPY . .
RUN dotnet publish "./HelloWorld.sln" -c Release -o "/app"

# final stage/image
FROM mcr.microsoft.com/dotnet/core/runtime:3.1
WORKDIR /opt/HelloWorld

COPY --from=build /app .
RUN ls -al
ENTRYPOINT ["/opt/HelloWorld/HelloWorld.Console"]
