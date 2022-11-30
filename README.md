<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/hsjalilian/Ocelot">
    <img src="/images/ocelot_logo.png" alt="Ocelot Logo" width="80" height="80">
  </a>

  <h3 align="center">Ocelot API Gateway</h3>

  <p align="center">   
    <br />
    <a href="https://github.com/hsjalilian/Ocelot/tree/master/docs"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/hsjalilian/Ocelot/issues">Report Bug</a>
    ·
    <a href="https://github.com/hsjalilian/Ocelot/issues">Request Feature</a>
  </p>
</div>


<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#ocelot-api-gateway">Ocelot API Gateway</a></li>  
    <li><a href="#what-is-an-api-gateway?">What Is an API Gateway?</a></li>
    <li><a href="#what-is-ocelot">What Is Ocelot</a></li>
    <li><a href="#features">Features</a></li>
    <li><a href="#how-to-install">How to install</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li>
      <a href="#sample-projects">Sample Projects</a>
      <ul>
        <li><a href="#basic">Basic</a></li>
        <li><a href="#multi-services">Multi Services</a></li>
        <li><a href="#request-aggregation">Request Aggregation</a></li>
        <li><a href="#logging">Logging</a></li>
        <li><a href="#authentication-and-authorization">Authentication and Authorization</a></li>
        <li><a href="#ratelimit">RateLimit</a></li>
        <li><a href="#caching">Caching</a></li>
        <li><a href="#load-balance">Load Balance</a></li>
        <li><a href="#swagger">Swagger</a></li>
        <li><a href="#qos">QoS</a></li>
      </ul>
    </li>
  </ol>
</details>

# Ocelot API Gateway
This repository contains some samples that show ocelot features in different projects from basic to advance config.  


##  What Is an API Gateway?
An API gateway is an API management tool that sits between a client and a collection of backend services.

An API gateway acts as a reverse proxy to accept all application programming interface (API) calls, aggregate the various services required to fulfill them, and return the appropriate result.

Benefits of API gateways

* Security
* API authentication
* Input validation
* Filtering
* Faster response times
* load balancing
* Rate limiting
* Expose only one endpoint
* Billing for microservices
* caching
* Monitoring and tracking
* Extending legacy apps


## What Is Ocelot
Ocelot is a .NET API Gateway. This project is aimed at people using .NET running a micro services/service-oriented architecture 
that needs a unified point of entry into their system. However, it will work with anything that speaks HTTP and run on any platform that ASP.NET Core supports.

## Features

For a quick list of Ocelot's capabilities for more information see the [documentation](https://ocelot.readthedocs.io/en/latest/).

* Routing
* Request Aggregation
* Service Discovery with Consul & Eureka
* Service Fabric
* Kubernetes 
* WebSockets
* Authentication
* Authorization
* Rate Limiting
* Caching
* Retry policies / QoS
* Load Balancing
* Logging / Tracing / Correlation
* Headers / Method / Query String / Claims Transformation
* Custom Middleware / Delegating Handlers
* Configuration / Administration REST API
* Platform / Cloud Agnostic


## How to install

Ocelot is designed to work with ASP.NET and it targets `net6.0`.

Install Ocelot and it's dependencies using NuGet.

`Install-Package Ocelot`

Or via the .NET Core CLI:

`dotnet add package ocelot`

All versions can be found [here](https://www.nuget.org/packages/Ocelot/)

# Sample Projects

## Basic 

The simplest sample that introduces how to use Ocelot here.

Link here : [Basic](https://github.com/hsjalilian/Ocelot/tree/master/src/Basic)

## Multi Services 

Same as the Basic template but routes requests to multi services.

Link here : [Mulit Services](https://github.com/hsjalilian/Ocelot/tree/master/src/MulitServices)

## Request Aggregation 

In this project, receive request and collect response from two different services.

Link here : [Request Aggregation](https://github.com/hsjalilian/Ocelot/tree/master/src/RequestAggregation)

## Logging

In this project, use Serilog for log all request in file.

Link here : [Logging](https://github.com/hsjalilian/Ocelot/tree/master/src/Logging)

## Authentication And Authorization

In this project, handle authentication and authorization with JWT Token.

Link here : [Authentication And Authorization](https://github.com/hsjalilian/Ocelot/tree/master/src/Auth)

## RateLimit

In this project, handle client request limitation in custom periodic time per endpoint.

Link here : [RateLimit](https://github.com/hsjalilian/Ocelot/tree/master/src/RateLimit)

## Caching

In this project, use CacheManager for caching output response.

Link here : [Caching](https://github.com/hsjalilian/Ocelot/tree/master/src/Caching)

## Load Balance

In this project, Balance request to multi same service.

Link here : [Load Balance](https://github.com/hsjalilian/Ocelot/tree/master/src/LoadBalance)

## Swagger

In this project, Enable Swagger for APIs.

Link here : [Swagger](https://github.com/hsjalilian/Ocelot/tree/master/src/Swagger)

## Qos

In this project, Enable circuit breaker.

Link here : [QoS](https://github.com/hsjalilian/Ocelot/tree/master/src/QoS)