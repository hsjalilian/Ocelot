# Request Aggregation Template

This template shows how one API response can aggregate from different microservice APIs.

Gateway launch on `localhost:8000`

## Projects 
* Gateway: this is the ocelot project launched in `http://localhost:8000` and gets incoming requests.
* ApiUsers: sample dotnet core API project that presents User's data
* ApiRoles: sample dotnet core API project that presents the Role's data

## Get Start
From the Solution property, set startup configuration to `Multiple startup projects` and select these three project actions to `start`

After running the projects, open Below URL in Browser to see the result.
* http://localhost:8000/UserAndRoles/1
* http://localhost:8000/UserAndRoles/2