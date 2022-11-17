# Caching Template

This template use CacheManager for caching output response.

Gateway launch on `localhost:8000`

## Projects 
* Gateway: this is the ocelot project launched in `http://localhost:8000` and gets incoming requests.
* ApiCustomers: sample dotnet core API project that presents Customer's data

## Get Start
From the Solution property, set startup configuration to `Multiple startup projects` and select these two project actions to `start`

After running the projects, open Below URL in Browser to see the result. attend to datetime in response!
* http://localhost:8000/cutomers
* http://localhost:8000/cutomers/0