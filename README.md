# NetCoreApiDockerHelloWorld
This is a hello world net core api which runs inside a docker container


## Build And Run In Docker
To build and run in docker use:

```console
docker build -t netcoreapidockerhelloworld .
docker run -it --rm -p 8000:80 netcoreapidockerhelloworld
```
