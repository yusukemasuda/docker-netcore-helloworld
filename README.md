# docker-netcore-helloworld
My first docker container with .NET Core - This is an example .NET Core app running on Docker container.

To build and run container, enter commands below.
Tested it on PowerShell with Docker Desktop for Windows.

It would build netcore apps with .NET Core SDK container, and run it on .NET Core Runtime container.

## Build
``` PowerShell
docker build --pull -t myfirstdocker .
```

## Run
``` PowerShell
docker run --rm myfirstdocker
```
