# Basic Template

This template uses a basic config for the ocelot project and routes requests to another dotnet core API project.

Gateway launch on `localhost:8000`

## Projects 
* Gateway: this is the ocelot project launched in `http://localhost:8000` and gets incoming requests.
* ApiService: sample dotnet core API project with two controls for `Customers` and `Products`

## Get Start
From the Solution property, set startup configuration to `Multiple startup projects` and select these two project actions to `start`

After running the projects, open Below URL in Browser to see the result.
* http://localhost:8000/customers
* http://localhost:8000/customers/2
* http://localhost:8000/products