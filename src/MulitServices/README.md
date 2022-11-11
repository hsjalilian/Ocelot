# Multi Services Template

This template uses a basic config for the ocelot project and routes requests to another dotnet core API project.

Gateway lunch on `localhost:8000`

## Projects 
* Gateway: this is the ocelot project and lunch in `http://localhost:8000` and gets incoming requests.
* ApiCustomers: sample dotnet core API project that presents customer's data
* ApiProducts: sample dotnet core API project that presents the product's data

## Get Start
From the Solution property, set startup configuration to `Multiple startup projects` and select these three project actions to `start`

After running the projects, open Below URL in Browser to see the result.
* http://localhost:8000/customers
* http://localhost:8000/customers/2
* http://localhost:8000/products