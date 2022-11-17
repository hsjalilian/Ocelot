# Authentication and Authorization Template

This template shows how manage authentication and authorization on api requests.

Gateway launch on `localhost:8000`

## Projects 
* Gateway: this is the ocelot project launched in `http://localhost:8000` and gets incoming requests.
* ApiCustomers: sample dotnet core API project that presents Customer's data

## Get Start
From the Solution property, set startup configuration to `Multiple startup projects` and select these three project actions to `start`

Jwt token configuraion set in `appsettings.json`.

After running the projects, for send auth token in header, you can use [Postman](https://www.postman.com/) application.

### Postman Request
create a new postman request same as the below picture and test the API gateway with that.
![](images/auth_postman.png)

### JWT Token
To generate test jwt token manually, you can use [this](http://jwtbuilder.jamiekurtz.com/) site.
![](images/auth.png)

* http://localhost:8000/customer
* http://localhost:8000/customer/1