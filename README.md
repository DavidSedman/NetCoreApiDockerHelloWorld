# NetCoreApiDockerHelloWorld
This is a hello world net core api which runs inside a docker container


## Build And Run In Docker
To build and run in docker use:

```console
docker build -t netcoreapidockerhelloworld .
docker run -it --rm -p 8000:80 netcoreapidockerhelloworld
```
## Alittle help from friends
*[medium.com](https://medium.com/trafi-tech-beat/running-net-core-on-docker-c438889eb5a)
*[dotnet-docker-samples](https://github.com/dotnet/dotnet-docker-samples/tree/master/aspnetapp)
*[docker docs - dotnetcore introduction](https://docs.docker.com/engine/examples/dotnetcore/#introduction)
*[README-Template.md](https://gist.github.com/PurpleBooth/109311bb0361f32d87a2)