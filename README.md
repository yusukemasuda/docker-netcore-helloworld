# docker-netcore-helloworld
My first docker container with .NET Core - This is an example .NET Core app running on Docker container.

To build and run container, enter commands below.
Tested it on PowerShell with Docker Desktop for Windows.

It would build netcore apps with .NET Core SDK container, and run it on .NET Core Runtime container.

## Build
``` PowerShell
cd ./src
docker build --pull -t <docker-hub-username>/netcore_helloworld .
```

## Run
``` PowerShell
docker run --rm <docker-hub-username>/netcore_helloworld
```

## Push to container registry
``` PowerShell
docker push <docker-hub-username>/netcore_helloworld:latest
```

## Pull and Run
``` PowerShell
docker pull <docker-hub-username>/netcore_helloworld:latest
docker run --rm <docker-hub-username>/netcore_helloworld
```

See also: https://hub.docker.com/repository/docker/yusukemasuda/netcore_helloworld
 - This is a container image built from those source code and pushed with above commands to my repository on dockerhub.
