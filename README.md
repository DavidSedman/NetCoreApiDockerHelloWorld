# NetCoreApiDockerHelloWorld
This is a hello world net core api which runs inside a docker container


## Build And Run In Docker
To build and run in docker use:

```console
docker build -t netcoreapidockerhelloworld .
docker run -it --rm -p 8000:80 netcoreapidockerhelloworld
```
## Alittle help from friends
https://medium.com/trafi-tech-beat/running-net-core-on-docker-c438889eb5a
https://github.com/dotnet/dotnet-docker-samples/tree/master/aspnetapp
https://docs.docker.com/engine/examples/dotnetcore/#introduction
