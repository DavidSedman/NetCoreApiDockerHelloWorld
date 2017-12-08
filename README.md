# NetCoreApiDockerHelloWorld
This is a hello world net core api which runs inside a docker container

## How to Start Your Net Core api

First you will need to install the .Net SDK from [here](https://www.microsoft.com/net/learn/get-started/macos#macosx).

To use the net core webapi template to create a net core webapi application, do the following in terminal:
```console
mkdir netcoreapidockerhelloworld
cd netcoreapidockerhelloworld
dotnet new webapi -au None -f netcoreapp2.0
```
Here are more details on using the [.NET Core command line interface documents](https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x).

## Build And Run Your New Api
To build the application use the following command:
```console
dotnet build
```

To run the application do the following:
```console
dotnet run
```
To test that this works go to the http://localhost:5000/api/values url.


## Build And Run In Docker
To build and run in docker use:

```console
docker build -t netcoreapidockerhelloworld .
docker run -it --rm -p 8000:80 netcoreapidockerhelloworld
```
## A little help from some friends
* [medium.com](https://medium.com/trafi-tech-beat/running-net-core-on-docker-c438889eb5a)
* [.NET SDK](https://www.microsoft.com/net/learn/get-started/macos#macosx)
* [.NET Core command line interface documents](https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x)
* [dotnet-docker-samples](https://github.com/dotnet/dotnet-docker-samples/tree/master/aspnetapp)
* [docker docs - dotnetcore introduction](https://docs.docker.com/engine/examples/dotnetcore/#introduction)
* [README-Template.md](https://gist.github.com/PurpleBooth/109311bb0361f32d87a2)